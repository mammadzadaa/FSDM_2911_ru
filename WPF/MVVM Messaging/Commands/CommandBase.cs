using System;
using System.Windows.Input;

namespace MVVM_Messaging.Commands
{
    public class CommandBase<T> : Command, ICommand
    {
        private Action<T> action;

        public CommandBase(Action<T> action, Func<bool> canExecute = null) : base(canExecute)
        {
            this.action = action;
        }

        public void Execute(object parameter)
        {
            action?.Invoke((T)parameter);
        }
    }
}