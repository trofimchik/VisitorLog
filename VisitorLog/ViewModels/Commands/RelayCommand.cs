using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace VisitorLog.ViewModels.Commands
{
    public class RelayCommand : ICommand
    {
        private readonly Func<bool> _canExecute;
        private readonly Action<object> _onExecute;

        /// <summary>Событие извещающее об измении состояния команды</summary>
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        /// <summary>Конструктор команды</summary>
        /// <param name="execute">Выполняемый метод команды</param>
        /// <param name="canExecute">Метод разрешающий выполнение команды</param>
        public RelayCommand(Action<object> execute, Func<bool> canExecute = null)
        {
            _onExecute = execute;
            _canExecute = canExecute;
        }

        /// <summary>Вызов разрешающего метода команды</summary>
        /// <param name="parameter">Параметр команды</param>
        /// <returns>True - если выполнение команды разрешено</returns>
        public bool CanExecute(object parameter) => _canExecute == null ? true : _canExecute.Invoke();

        /// <summary>Вызов выполняющего метода команды</summary>
        /// <param name="parameter">Параметр команды</param>
        public void Execute(object parameter) => _onExecute?.Invoke(parameter);

        //readonly Action<object> _execute;
        //readonly Predicate<object> _canExecute;

        //public event EventHandler CanExecuteChanged
        //{
        //    add { CommandManager.RequerySuggested += value; }
        //    remove { CommandManager.RequerySuggested -= value; }
        //}

        //public RelayCommand(Action<object> execute)
        //: this(execute, null)
        //{
        //}

        //public RelayCommand(Action<object> execute, Predicate<object> canExecute)
        //{
        //    if (execute == null)
        //        throw new ArgumentNullException("execute");

        //    _execute = execute;
        //    _canExecute = canExecute;
        //}

        //public bool CanExecute(object parameter)
        //{
        //    return _canExecute == null ? true : _canExecute(parameter);
        //}

        //public void Execute(object parameter)
        //{
        //    _execute(parameter);
        //}
    }
}
