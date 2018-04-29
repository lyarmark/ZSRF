using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZSRF.ViewModel
{
    public class ServicesVM : BaseVM
    {

        private ObservableCollection<Service> _services;
        public ObservableCollection<Service> Services
        {
            get { return _services; }
            set { _services = value; }
        }

        public ServicesVM(Client client)
        {
            Services = new ObservableCollection<Service>(client.Services);
        }
        public ServicesVM() { }
    }
}
