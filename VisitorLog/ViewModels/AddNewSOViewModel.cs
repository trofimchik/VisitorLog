using Models.VisitorLog;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using VisitorLog.ViewModels.Commands;

namespace VisitorLog.ViewModels
{
    class AddNewSOViewModel : BaseViewModel
    {
        RaiseContentChangerCommand changer = new RaiseContentChangerCommand();
        private string login;
        private string password;

        public AddNewSOViewModel()
        {
            ChangeVMCommand = new RelayCommand(changer.ExecuteEventRaising);
            SaveAndChangeVMCommand = new RelayCommand(SaveAndChangeVM, SaveAndChangeVM_CanExecute);
        }

        [Required(ErrorMessage = "Поле не должно быть пустым.")]
        [StringLength(100, MinimumLength = 4, ErrorMessage = "Не меньше 4 и не больше 100 символов.")]
        public string Login
        {
            get { return login; }
            set
            {
                login = value;
                ValidateProperty(value);
                OnPropertyChanged();
            }
        }

        [Required(ErrorMessage = "Поле не должно быть пустым.")]
        [StringLength(100, MinimumLength = 4, ErrorMessage = "Не меньше 4 и не больше 100 символов.")]
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                ValidateProperty(value);
                OnPropertyChanged();
            }
        }

        public ICommand SaveAndChangeVMCommand { get; set; }
        public ICommand ChangeVMCommand { get; set; }
        private void SaveAndChangeVM(object parameter)
        {
            SaveData();
            changer.ExecuteEventRaising(parameter);
        }

        private void SaveData()
        {
            using (VisitorLogContext db = new VisitorLogContext())
            {
                db.SecurityOfficers.Add(new SecurityOfficer()
                {
                    Login = Login,
                    Password = Password,
                });
                db.SaveChanges();
            }
            AdminPanelViewModel.OnContentChanged();
        }

        private bool SaveAndChangeVM_CanExecute()
        {
            bool sOExists;
            using (VisitorLogContext db = new VisitorLogContext())
            {
                sOExists = db.SecurityOfficers.Any(x => x.Login == Login);
            }
            if (sOExists)
                return false;
            if (Login != null && Password != null)
                if(Login.Length >= 4 && Password.Length >= 4)
                    return true;
                else return false;
            else return false;
        }


    }
}
