using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZSRF.ViewModel
{
    public class ClientInfoVM : BaseVM
    {
        Client client;
        public ClientInfoVM(Client c)
        {
            client = c;
        }
        public ClientInfoVM() { }
    }
}
