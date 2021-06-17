using Models.VisitorLog;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;
using VisitorLog.Models.SubModels;
using VisitorLog.ViewModels.Commands;

namespace VisitorLog.ViewModels
{
    class SecurityOfficerWorkingPanelViewModel : BaseViewModel
    {
        private RaiseContentChangerCommand changer = new RaiseContentChangerCommand();
        public SecurityOfficerWorkingPanelViewModel()
        {
            ExitCommand = new RelayCommand(SetVisitorExit);
            ChangeVMCommand = new RelayCommand(changer.ExecuteEventRaising);
            BeginningOfPeriodRemaining = DateTime.Now.Date;
            EndingOfPeriodRemaining = DateTime.Now.Date;
            DateEnd = DateTime.Now.Date;
            SetVisitsList();
        }


        private ObservableCollection<CurrentVisitor> currentVisits;
        public ObservableCollection<CurrentVisitor> CurrentVisits
        {
            get
            {
                return currentVisits;
            }
            set
            {
                currentVisits = value;
            }
        }
        private ObservableCollection<RemainingVisitor> remainingVisits;
        public ObservableCollection<RemainingVisitor> RemainingVisits
        {
            get
            {
                return remainingVisits;
            }
            set
            {
                remainingVisits = value;
            }
        }

        private void SetVisitsList()
        {
            using (VisitorLogContext db = new VisitorLogContext())
            {
                CurrentVisits = new ObservableCollection<CurrentVisitor>(
                    (from vis in db.Visits
                     join emp in db.Employees on vis.IdEmployees equals emp.Id
                     join org in db.Organizations on emp.IdOrganization equals org.Id
                     join purp in db.PurposesOfVisits on vis.IdPurpose equals purp.Id
                     where vis.DatetimeOfExit == null & vis.DatetimeOfEntry.Date == DateTime.Today
                     select new CurrentVisitor
                     {
                         Surname = vis.Surname,
                         Name = vis.Name,
                         Patronymic = vis.Patronymic,
                         DocumentNumber = vis.DocumentNumber,
                         EmpSurname = emp.Surname,
                         EmpName = emp.Name,
                         EmpPatronymic = emp.Patronymic,
                         OrgName = org.Name,
                         Purpose = purp.Name,
                         DateTimeOfEntry = vis.DatetimeOfEntry,
                         Note = vis.Note
                     }));
                RemainingVisits = new ObservableCollection<RemainingVisitor>(
                    (from vis in db.Visits
                     join emp in db.Employees on vis.IdEmployees equals emp.Id
                     join org in db.Organizations on emp.IdOrganization equals org.Id
                     join purp in db.PurposesOfVisits on vis.IdPurpose equals purp.Id
                     where vis.DatetimeOfEntry >= BeginningOfPeriodRemaining
                     && vis.DatetimeOfEntry <= EndingOfPeriodRemaining
                     select new RemainingVisitor
                     {
                         Surname = vis.Surname,
                         Name = vis.Name,
                         Patronymic = vis.Patronymic,
                         DocumentNumber = vis.DocumentNumber,
                         EmpSurname = emp.Surname,
                         EmpName = emp.Name,
                         EmpPatronymic = emp.Patronymic,
                         OrgName = org.Name,
                         Purpose = purp.Name,
                         DateTimeOfEntry = vis.DatetimeOfEntry
                     }));
            }

            OnPropertyChanged("CurrentVisits");
            OnPropertyChanged("RemainingVisits");
        }
        private DateTime beginningOfPeriodRemaining;
        public DateTime BeginningOfPeriodRemaining
        {
            get { return beginningOfPeriodRemaining; }
            set
            {
                beginningOfPeriodRemaining = value;
                if (beginningOfPeriodRemaining <= EndingOfPeriodRemaining)
                    SetBetweenTwoDatesRemaining();
                OnPropertyChanged("RemainingVisits");
                OnPropertyChanged("CurrentVisits");
                OnPropertyChanged("EndingOfPeriodRemaining");
                OnPropertyChanged();
            }
        }
       
        private DateTime endingOfPeriodRemaining;
        public DateTime EndingOfPeriodRemaining
        {
            get { return endingOfPeriodRemaining; }
            set 
            {
                endingOfPeriodRemaining = value;
                if (endingOfPeriodRemaining >= BeginningOfPeriodRemaining)
                    SetBetweenTwoDatesRemaining();
                OnPropertyChanged("RemainingVisits");
                OnPropertyChanged("CurrentVisits");
                OnPropertyChanged("BeginningOfPeriodRemaining");
                OnPropertyChanged();
            }
        }
        //ToDo: Исправить ошибку с фильтрацией по дате...
        private DateTime dateEnd;
        public DateTime DateEnd
        {
            get { return dateEnd; }
            set 
            { 
                dateEnd = value;
                OnPropertyChanged();
            }
        }
        private void SetBetweenTwoDatesRemaining()
        {
            using (VisitorLogContext db = new VisitorLogContext())
            {
                RemainingVisits = new ObservableCollection<RemainingVisitor>(
                           (from vis in db.Visits
                            join emp in db.Employees on vis.IdEmployees equals emp.Id
                            join org in db.Organizations on emp.IdOrganization equals org.Id
                            join purp in db.PurposesOfVisits on vis.IdPurpose equals purp.Id
                            where vis.DatetimeOfEntry >= BeginningOfPeriodRemaining.Date
                            && vis.DatetimeOfEntry <= EndingOfPeriodRemaining.Date.AddDays(1).AddSeconds(-1)
                            select new RemainingVisitor
                            {
                                Surname = vis.Surname,
                                Name = vis.Name,
                                Patronymic = vis.Patronymic,
                                DocumentNumber = vis.DocumentNumber,
                                EmpSurname = emp.Surname,
                                EmpName = emp.Name,
                                EmpPatronymic = emp.Patronymic,
                                OrgName = org.Name,
                                Purpose = purp.Name,
                                DateTimeOfEntry = vis.DatetimeOfEntry
                            }));
            }
        }
        private void SetVisitorExit(object obj)
        {

            if (MessageBox.Show("Вы уверены?", "Требуется подтверждение", MessageBoxButton.OKCancel) == MessageBoxResult.OK)
            {
                var row = obj as CurrentVisitor;
                using (VisitorLogContext db = new VisitorLogContext())
                {
                    db.Visits.Where(visit => visit.Name == row.Name
                    && visit.Surname == row.Surname
                    && visit.Patronymic == row.Patronymic
                    && visit.DocumentNumber == row.DocumentNumber
                    && visit.DatetimeOfEntry == row.DateTimeOfEntry && visit.DatetimeOfExit == null).First().DatetimeOfExit = DateTime.Now;
                    db.SaveChanges();
                }
                SetVisitsList();
                //MessageBox.Show(row.Name);
            }
        }
       
        public ICommand ChangeVMCommand { get; private set; }
        public ICommand ExitCommand { get; set; }
    }
}
