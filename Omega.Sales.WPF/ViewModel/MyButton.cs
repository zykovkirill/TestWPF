using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace Omega.Sales.WPF.ViewModel
{
    public class MyButton
    {
        public ICommand MyCommand { get; set; }

        public MyButton()
        {
            MyCommand = new TestCommand(ExecuteMethod, canExecuteMethod);
        }
        private bool canExecuteMethod(object parameter)
        {
            return true;
        }

        private void ExecuteMethod( object parameter)
        {
            MessageBox.Show("Тест");
        }
    }
}
