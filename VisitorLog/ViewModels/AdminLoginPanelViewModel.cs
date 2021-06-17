using Models.VisitorLog;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using VisitorLog.ViewModels.Commands;
using System.Linq;

namespace VisitorLog.ViewModels
{
    class AdminLoginPanelViewModel : BaseViewModel
    {
        private RaiseContentChangerCommand changer = new RaiseContentChangerCommand();
        public AdminLoginPanelViewModel()
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
                if(db.Admins.Any(admin => admin.Login == Login))
                {
                    if(db.Admins.First(admin => admin.Login == Login).Password == pwBox.Password)
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
