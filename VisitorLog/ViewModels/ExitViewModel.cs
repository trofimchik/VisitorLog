using Microsoft.EntityFrameworkCore;
using Models.VisitorLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;
using VisitorLog.ViewModels.Commands;

namespace VisitorLog.ViewModels
{
    class ExitViewModel : BaseViewModel
    {
        RaiseContentChangerCommand changer = new RaiseContentChangerCommand();


        private Visit selectedVisitor;
        private List<Visit> visitors;

        public ExitViewModel()
        {
            using(VisitorLogContext db = new VisitorLogContext())
            {
                Visitors = db.Visits
                    .Where(visitor => visitor.DatetimeOfExit == null && visitor.DatetimeOfEntry.Date == DateTime.Today)
                    .Select(visitor => visitor).ToList();
            }
            ChangeVMCommand = new RelayCommand(SaveAndChangeVM, SaveAndChangeVM_CanExecute);
        }

        private string note;

        public string Note
        {
            get { return note; }
            set { note = value; }
        }

        public Visit SelectedVisitor
        {
            get { return selectedVisitor; }
            set 
            { 
                selectedVisitor = value;
                //OnPropertyChanged();
            }
        }

        public List<Visit> Visitors
        {
            get { return visitors; }
            set 
            { 
                visitors = value;
                //OnPropertyChanged();
            }
        }

        private void SaveAndChangeVM(object parameter)
        {
            changer.ExecuteEventRaising(parameter);
            SaveData();
        }
        private void SaveData()
        {
            using(VisitorLogContext db = new VisitorLogContext())
            {
                Visit visit = db.Visits.First((visitor => visitor.DatetimeOfEntry.Date == DateTime.Today
                    && visitor.Surname == SelectedVisitor.Surname
                    && visitor.Name == SelectedVisitor.Name
                    && visitor.Patronymic == SelectedVisitor.Patronymic
                    && visitor.DocumentNumber == SelectedVisitor.DocumentNumber));
                visit.DatetimeOfExit = DateTime.Now;
                visit.Note = Note;

                db.SaveChanges();
            }
        }
        private bool SaveAndChangeVM_CanExecute()
        {
            return SelectedVisitor != null ? true : false;
        }
        public ICommand ChangeVMCommand { get; set; }
    }
}
