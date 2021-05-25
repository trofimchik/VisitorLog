using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using VisitorLog.ViewModels.Commands;
using System.ComponentModel.DataAnnotations;

namespace VisitorLog.ViewModels
{
    class EntryViewModel : BaseViewModel
    {
        private string surname;
        public EntryViewModel()
        {
            RaiseContentChangerCommand changer = new RaiseContentChangerCommand();
            ChangeVMCommand = new RelayCommand(changer.ExecuteEventRaising);
        }

        [Required(ErrorMessage = "Поле не должно быть пустым.")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Должно быть как минимум два символа.")]
        public string Surname
        {
            get { return surname; }
            set
            {
                surname = value;
                ValidateProperty(value, "Surname");
                OnPropertyChanged("Surname");
            }
        }

        private void ValidateProperty<T>(T value, string name)
        {
            Validator.ValidateProperty(value, new ValidationContext(this, null, null)
            {
                MemberName = name
            });
        }
        
        public ICommand ChangeVMCommand { get; set; }
    }
}
