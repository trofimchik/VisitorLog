using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorLog.ViewModels.Commands
{
    class RaiseContentChangerCommand
    {
        public void ExecuteEventRaising(object parameter)
        {
            ContentChanger.OnContentChanged(parameter as BaseViewModel);
        }
    }
}
