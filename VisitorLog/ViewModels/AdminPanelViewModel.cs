using Models.VisitorLog;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;
using VisitorLog.ViewModels.Commands;
using Syncfusion.UI.Xaml.Grid;

namespace VisitorLog.ViewModels
{
    class AdminPanelViewModel : BaseViewModel
    {
        private RaiseContentChangerCommand changer = new RaiseContentChangerCommand();
        
        public AdminPanelViewModel()
        {
            CollectionChanged += UpdateData;
            MainCloseButtonCommand = new RelayCommand(PerformMainCloseButtonCommand, ChangeVM_CanExecute);
            ChangeVMCommand = new RelayCommand(changer.ExecuteEventRaising, ChangeVM_CanExecute);
            DeleteCommand = new RelayCommand(DeleteOfficer);
            SaveChangesCommand = new RelayCommand(SaveData);

            using (VisitorLogContext db = new VisitorLogContext())
            {
                SecurityOfficers = new ObservableCollection<SecurityOfficer>(db.SecurityOfficers);
            }
        }

        public ObservableCollection<SecurityOfficer> SecurityOfficers { get; set; }
        public ICommand ChangeVMCommand { get; private set; }
        public ICommand SaveChangesCommand { get; set; }
        public ICommand MainCloseButtonCommand { get; set; }
        public ICommand DeleteCommand { get; set; }


        private void SaveData(object obj)
        {
            using (VisitorLogContext db = new VisitorLogContext())
            {
                foreach (SecurityOfficer officer in SecurityOfficers)
                {
                    if (SecurityOfficers.Where(off => off.Login == officer.Login).ToList().Count > 1)
                    {
                        MessageBox.Show("Повторяющиеся логины " + officer.Login);
                        CurrentContentVM.isValid = false;
                        break;
                    }
                    else
                    {
                        CurrentContentVM.isValid = true;
                        if (db.SecurityOfficers.Any(off => off.Id == officer.Id))
                        {
                            if (officer.Login != null || officer.Password != null)
                            {
                                var off = db.SecurityOfficers.Where(off => off.Id == officer.Id).First();
                                off.Login = officer.Login;
                                off.Password = officer.Password;
                                db.SecurityOfficers.Update(off);
                            }
                        }
                        else
                        {
                            if (officer.Login != null || officer.Password != null)
                                db.SecurityOfficers.Add(officer);
                        }
                    }
                }

                db.SaveChanges();
            }
        }

        //TODO: Исправить костыль isValid, заменить на событие?
        private bool ChangeVM_CanExecute()
        {
            return CurrentContentVM.isValid;
        }
        private void PerformMainCloseButtonCommand(object Parameter)
        {
            if (MessageBox.Show("Вы уверены?", "Требуется подтверждение", MessageBoxButton.OKCancel) == MessageBoxResult.OK)
            {
                Window objWindow = Parameter as Window;
                objWindow.Close();
            }
        }
        private void DeleteOfficer(object obj)
        {
            SecurityOfficer officer = obj as SecurityOfficer;
            if (officer.Id > 0)
                if (SecurityOfficers.Any(off => off.Id == officer.Id))
                    if (MessageBox.Show("Вы уверены?", "Требуется подтверждение", MessageBoxButton.OKCancel) == MessageBoxResult.OK)
                    {
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
        private void UpdateData()
        {
            using (VisitorLogContext db = new VisitorLogContext())
            {
                SecurityOfficers = new ObservableCollection<SecurityOfficer>(db.SecurityOfficers);
            }
        }

        public static event ExecuteChangeCollection CollectionChanged;
        public delegate void ExecuteChangeCollection();
        public static void OnContentChanged()
        {
            CollectionChanged?.Invoke();
        }
    }
}
