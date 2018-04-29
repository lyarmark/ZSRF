using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ZSRF.Helpers
{
    public class Command : ICommand
    {
        private Action method;
        public event EventHandler CanExecuteChanged;
        public Command(Action method)
        {
            this.method = method;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }
        public void Execute(object parameter)
        {
            this.method();
        }
    }
}