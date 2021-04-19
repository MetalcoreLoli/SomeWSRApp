#nullable enable

using System;
using System.Windows.Input;

namespace SomeWSRApp.WPF.Layer.Models
{
    public class RelayCommand : ICommand
    {
        #region Private Members

        private readonly Action<object> _execute;
        private readonly Func<object, bool> _canExecute;

        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null!)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        #endregion Private Members

        public bool CanExecute(object? parameter)
        {
            return parameter == null || _canExecute(parameter);
        }

        public void Execute(object? parameter)
        {
            _execute(parameter);
        }

        public event EventHandler? CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }
    }
}