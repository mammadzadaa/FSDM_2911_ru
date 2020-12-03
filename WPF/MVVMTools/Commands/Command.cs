using System;

namespace MVVMTools.Commands
{
    public abstract class Command
    {
        protected Func<bool> canExecute;

        public event EventHandler CanExecuteChanged;
        public Command(Func<bool> canExecute)
        {
            this.canExecute = canExecute;
        }

        public bool CanExecute(object parameter) => canExecute?.Invoke() ?? true;

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
