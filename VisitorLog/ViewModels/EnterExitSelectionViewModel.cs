using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;
using VisitorLog.ViewModels.Commands;

namespace VisitorLog.ViewModels
{
    class EnterExitSelectionViewModel : BaseViewModel
    {
        //ContentChanger changer;
        public EnterExitSelectionViewModel()
        {
            RaiseContentChangerCommand changer = new RaiseContentChangerCommand();
            ChangeVMCommand = new RelayCommand(changer.ExecuteEventRaising);
            MainCloseButtonCommand = new RelayCommand(PerformMainCloseButtonCommand);
        }
        
        public ICommand ChangeVMCommand { get; private set; }


        public ICommand MainCloseButtonCommand { get; set; }
        private void PerformMainCloseButtonCommand(object Parameter)
        {
            Window objWindow = Parameter as Window;
            objWindow.Close();
        }
        //public void ChangeControl(object parameter)
        //{
        //    MessageBox.Show("метод команды");

        //    ContentChanger.OnContentChanged(parameter as BaseViewModel);

        //    //ContentChanger.OnContentChanged(new EntryViewModel());
        //}
    }
}
