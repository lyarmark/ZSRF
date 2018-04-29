using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ZSRF.Helpers
{
    public class CommandWithParam : ICommand
    {
        private Action<object> method;
        public event EventHandler CanExecuteChanged;
        public CommandWithParam(Action<object> method)
        {
            this.method = method;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            this.method(parameter);
        }
    }
}