using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Windows.Input;
using VisitorLog.ViewModels.Commands;
using System.ComponentModel.DataAnnotations;
using Models.VisitorLog;
using System.Windows;

namespace VisitorLog.ViewModels
{
    class EntryViewModel : BaseViewModel
    {
        private string surname;
        private string name;
        private string patronymic;
        private string documentNumber;
        private List<string> purposesOfVisit;
        private string selectedPurpose;

        private List<Employee> employees;
        private List<string> organizations;
        private string selectedOrganization;
        private Employee selectedEmployee;

        RaiseContentChangerCommand changer = new RaiseContentChangerCommand();
        public EntryViewModel()
        {
            SaveAndChangeVMCommand = new RelayCommand(SaveAndChangeVM, SaveAndChangeVM_CanExecute);
            using (VisitorLogContext db = new VisitorLogContext())
            {
                PurposesOfVisit = (from purpose in db.PurposesOfVisits select purpose.Name).ToList();
                Organizations = (from organization in db.Organizations select organization.Name).ToList();
            }
        }

        [Required(ErrorMessage = "Поле не должно быть пустым.")]
        [StringLength(100, ErrorMessage = "Не больше 100 символов.")]
        public string Surname
        {
            get { return surname; }
            set
            {
                surname = value;
                ValidateProperty(value);
                OnPropertyChanged();
            }
        }
        [Required(ErrorMessage = "Поле не должно быть пустым.")]
        [StringLength(100, ErrorMessage = "Не больше 100 символов.")]
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                ValidateProperty(value);
                OnPropertyChanged();
            }
        }
        [StringLength(100, ErrorMessage = "Не больше 100 символов.")]
        public string Patronymic
        {
            get { return patronymic; }
            set
            {
                patronymic = value;
                ValidateProperty(value);
                OnPropertyChanged();
            }
        }

        [Required(ErrorMessage = "Поле не должно быть пустым.")]
        [StringLength(50, ErrorMessage = "Не больше 20 символов.")]
        public string DocumentNumber
        {
            get { return documentNumber; }
            set
            {
                bool visitExists;

                using (VisitorLogContext db = new VisitorLogContext())
                    visitExists = db.Visits.Any(x => x.DocumentNumber == value && x.DatetimeOfEntry.Date == DateTime.Now.Date);
                
                if (visitExists)
                {
                    documentNumber = null;
                    MessageBox.Show("В списке присутствующих на территории уже есть человек с такими-же паспортными данными.");
                }
                else documentNumber = value;

                ValidateProperty(value);
                OnPropertyChanged();
            }
        }



        public List<string> PurposesOfVisit
        {
            get { return purposesOfVisit; }
            set { purposesOfVisit = value; }
        }

        public string SelectedPurpose
        {
            get { return selectedPurpose; }
            set 
            { 
                selectedPurpose = value;
                OnPropertyChanged();
            }
        }


        public List<Employee> Employees
        {
            get { return employees; }
            set { employees = value; }
        }

        public Employee SelectedEmployee
        {
            get { return selectedEmployee; }
            set 
            { 
                selectedEmployee = value;
                OnPropertyChanged();
            }
        }


        public List<string> Organizations
        {
            get { return organizations; }
            set { organizations = value; }
        }
        public string SelectedOrganization
        {
            get
            {
                return selectedOrganization;
            }
            set
            {
                selectedOrganization = value;

                using (VisitorLogContext db = new VisitorLogContext())
                {
                    Employees = (from employee in db.Employees
                                 join organization in db.Organizations
                                 on employee.IdOrganization equals organization.Id
                                 where organization.Name == SelectedOrganization
                                 select employee).ToList();
                }

                OnPropertyChanged();
                OnPropertyChanged("Employees");
            }
        }


        private void SaveAndChangeVM(object parameter)
        {
            SaveData();
            changer.ExecuteEventRaising(parameter);
        }

        private void SaveData()
        {
            using (VisitorLogContext db = new VisitorLogContext())
            {
                db.Visits.Add(new Visit()
                {
                    Surname = Surname,
                    Name = Name,
                    Patronymic = Patronymic,
                    DocumentNumber = DocumentNumber,
                    IdEmployees = db.Employees.First
                        (emp => emp.Surname == SelectedEmployee.Surname && 
                        emp.Name == SelectedEmployee.Name && 
                        emp.Patronymic == SelectedEmployee.Patronymic).Id,
                    IdPurpose = db.PurposesOfVisits.First(purpose => purpose.Name == SelectedPurpose).Id,
                    DatetimeOfEntry = DateTime.Now
                });
                db.SaveChanges();
            }
        }
        private bool SaveAndChangeVM_CanExecute()
        {
            bool visitExists;
            using (VisitorLogContext db = new VisitorLogContext())
            {
                visitExists = db.Visits.Any(x => x.DocumentNumber == DocumentNumber && x.DatetimeOfEntry.Date == DateTime.Now.Date);
            }
            if (visitExists)
                return false;
            if (SelectedEmployee != null && Surname != null && Name != null)
                if (Name.Length > 0 && Surname.Length > 0)
                    return true;
                else return false;
            else return false;
        }

        public ICommand SaveAndChangeVMCommand { get; set; }
    }
}
