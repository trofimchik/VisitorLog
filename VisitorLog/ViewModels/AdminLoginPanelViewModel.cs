using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;
using VisitorLog.ViewModels.Commands;

namespace VisitorLog.ViewModels
{
    class AdminLoginPanelViewModel : BaseViewModel
    {
        public AdminLoginPanelViewModel()
        {
            RaiseContentChangerCommand changer = new RaiseContentChangerCommand();
            
            ChangeVMCommand = new RelayCommand(changer.ExecuteEventRaising);
        }
        public ICommand ChangeVMCommand { get; set; }
    }
}
