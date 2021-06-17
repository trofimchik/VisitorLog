using Models.VisitorLog;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;
using VisitorLog.ViewModels.Commands;

namespace VisitorLog.ViewModels
{
    class AdminPanelViewModel : BaseViewModel
    {
        private RaiseContentChangerCommand changer = new RaiseContentChangerCommand();
        public AdminPanelViewModel()
        {
            MainCloseButtonCommand = new RelayCommand(PerformMainCloseButtonCommand);
            ChangeVMCommand = new RelayCommand(changer.ExecuteEventRaising);
            ChangeVMAndSaveDataCommand = new RelayCommand(ChangeVMAndSaveData);
            DeleteCommand = new RelayCommand(DeleteOfficer);
            using (VisitorLogContext db = new VisitorLogContext())
            {
                SecurityOfficers = new ObservableCollection<SecurityOfficer>(db.SecurityOfficers);
            }
        }

        public ObservableCollection<SecurityOfficer> SecurityOfficers { get; set; }
        public ICommand ChangeVMCommand { get; private set; }
        public ICommand ChangeVMAndSaveDataCommand { get; private set; }
        public ICommand MainCloseButtonCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        private void ChangeVMAndSaveData(object obj)
        {
            using (VisitorLogContext db = new VisitorLogContext())
            {
                foreach (SecurityOfficer officer in SecurityOfficers)
                {
                    if (db.SecurityOfficers.Any(off => off.Id == officer.Id))
                    {
                        var off = db.SecurityOfficers.Where(off => off.Id == officer.Id).First();
                        off.Login = officer.Login;
                        off.Password = officer.Password;
                        db.SecurityOfficers.Update(off);
                    }
                    else
                    {
                        db.SecurityOfficers.Add(officer);
                    }
                }
                db.SaveChanges();
            }
            changer.ExecuteEventRaising(obj);
        }
        private void PerformMainCloseButtonCommand(object Parameter)
        {
            if (MessageBox.Show("Вы уверены?", "Требуется подтверждение", MessageBoxButton.OKCancel) == MessageBoxResult.OK)
            {
                Window objWindow = Parameter as Window;
                objWindow.Close();
            }
        }
        //ToDo: Реализовать функцию добавления нового сотрудника. реализовать проверку валидации.
        private void DeleteOfficer(object obj)
        {
            if(MessageBox.Show("Вы уверены?","Требуется подтверждение", MessageBoxButton.OKCancel) == MessageBoxResult.OK)
            {
                SecurityOfficer officer = obj as SecurityOfficer;
                using (VisitorLogContext db = new VisitorLogContext())
                {
                    officer = db.SecurityOfficers.First(off => off.Id == officer.Id);
                    db.SecurityOfficers.Remove(officer);
                    db.SaveChanges();
                    SecurityOfficers = new ObservableCollection<SecurityOfficer>(db.SecurityOfficers);
                }
                OnPropertyChanged("SecurityOfficers");
            }
        }
    }
}
