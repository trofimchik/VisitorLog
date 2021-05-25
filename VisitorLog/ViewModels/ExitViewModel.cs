using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using VisitorLog.ViewModels.Commands;

namespace VisitorLog.ViewModels
{
    class ExitViewModel : BaseViewModel
    {
        public ExitViewModel()
        {
            RaiseContentChangerCommand changer = new RaiseContentChangerCommand();

            ChangeVMCommand = new RelayCommand(changer.ExecuteEventRaising);
        }
        public ICommand ChangeVMCommand { get; set; }
    }
}
