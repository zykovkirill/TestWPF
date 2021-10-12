using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Omega.Sales.WPF
{
    class TestCommand : ICommand
    {
        Action<object> executeMethod;
        Func<object, bool> canexecuteMethod;

        public TestCommand(Action<object> executeMethod, Func<object, bool> canexecuteMethod)
        {
            this.executeMethod = executeMethod;
            this.canexecuteMethod = canexecuteMethod;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            executeMethod(parameter);
        }

        public event EventHandler CanExecuteChanged;

    }
}
