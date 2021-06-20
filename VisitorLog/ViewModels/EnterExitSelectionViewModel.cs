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
        public EnterExitSelectionViewModel()
        {
            RaiseContentChangerCommand changer = new RaiseContentChangerCommand();
            ChangeVMCommand = new RelayCommand(changer.ExecuteEventRaising);
        }
        
        public ICommand ChangeVMCommand { get; private set; }
    }
}
