using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Input;
using VisitorLog.ViewModels.Commands;

namespace VisitorLog.ViewModels
{
    class CurrentContentVM : BaseViewModel
    {

        public CurrentContentVM()
        {
            CurrentContent = new SecurityOfficerLoginViewModel();

            ContentChanger.ContentChanged += ChangeVM;

            RaiseContentChangerCommand changer = new RaiseContentChangerCommand();
            ChangeVMCommand = new RelayCommand(changer.ExecuteEventRaising);
        }

        private BaseViewModel сurrentContent;
        public BaseViewModel CurrentContent
        {
            get { return сurrentContent; }
            set
            {
                сurrentContent = value;
                OnPropertyChanged("CurrentContent");
            }
        }


        public ICommand ChangeVMCommand { get; private set; }

        private void ChangeVM(BaseViewModel vm)
        {
            CurrentContent = vm;
        }

        //public void ChangeControl(object parameter)
        //{
        //    //BaseViewModel vm = parameter as BaseViewModel;
        //    CurrentContent = parameter as BaseViewModel;
        //    //changer.OnContentChanged(new EnterExitSelectionViewModel(changer));
        //}
    }
}
