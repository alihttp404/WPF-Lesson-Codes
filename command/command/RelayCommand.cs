using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace command
{
    internal class RelayCommand : ICommand
    {
        private readonly Predicate<object?> _canExecute;

        private readonly Action<object?> _execute;

        event EventHandler? ICommand.CanExecuteChanged
        {
            add
                => CommandManager.RequerySuggested += value;

            remove
                => CommandManager.RequerySuggested -= value;
        }

        public RelayCommand(Action<object?> execute, Predicate<object?> canExecute)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        bool ICommand.CanExecute(object? parameter)
        {
            if (_canExecute == null) return true;
            return _canExecute!.Invoke(parameter);
        }

        void ICommand.Execute(object? parameter)
        {
            _execute.Invoke(parameter);
        }
    }
}
