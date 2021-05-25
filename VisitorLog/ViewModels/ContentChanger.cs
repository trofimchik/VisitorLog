using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorLog.ViewModels
{
    public class ContentChanger
    {
        public static event ExecuteChangeContent ContentChanged;
        public delegate void ExecuteChangeContent (BaseViewModel vm);
        public static void OnContentChanged(BaseViewModel vm)
        {
            ContentChanged?.Invoke(vm);
        }
    }
}
