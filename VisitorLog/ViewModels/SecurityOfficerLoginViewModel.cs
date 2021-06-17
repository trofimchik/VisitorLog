using Models.VisitorLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using VisitorLog.ViewModels.Commands;

namespace VisitorLog.ViewModels
{
    class SecurityOfficerLoginViewModel : BaseViewModel
    {

        private RaiseContentChangerCommand changer = new RaiseContentChangerCommand();
        public SecurityOfficerLoginViewModel()
        {

            ChangeVMCommand = new RelayCommand(CheckAndChangeVM);
        }

        private string login;
        public string Login
        {
            get { return login; }
            set
            {
                login = value;
                OnPropertyChanged();
            }
        }

        private void CheckAndChangeVM(object obj)
        {
            object[] values = obj as object[];
            PasswordBox pwBox = values[0] as PasswordBox;

            using (VisitorLogContext db = new VisitorLogContext())
            {
                if (db.SecurityOfficers.Any(officer => officer.Login == Login))
                {
                    if (db.SecurityOfficers.First(officer => officer.Login == Login).Password == pwBox.Password)
                    {
                        changer.ExecuteEventRaising(values[1]);
                    }
                    else
                    {
                        MessageBox.Show("Неверный пароль.");
                    }
                }
                else
                {
                    MessageBox.Show("Данный логин не существует");
                }
            }
            Login = "";
        }

        public ICommand ChangeVMCommand { get; set; }
    }
}
