using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace InventoryManager.Utils
{
    public class DelegateCommand<T> : ICommand  
    {
        private readonly Predicate<T> _canExecute;
        private readonly Action<T> _execute;

        public DelegateCommand(Action<T> execute, Predicate<T> canExecute)
        {
            _canExecute = canExecute;
            _execute = execute;
        }

        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute((T)parameter);
        }

        public void Execute(object parameter)
        {
            _execute((T)parameter);
        }
    }
}
