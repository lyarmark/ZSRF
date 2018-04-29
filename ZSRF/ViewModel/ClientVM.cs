using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using ZSRF.Model;
using ZSRF.Helpers;
using ZSRF.View;

namespace ZSRF.ViewModel
{
    class ClientVM : BaseVM
    {
        #region data
        private Model.Model model;

        public ObservableCollection<Client> Clients
        {
            get { return model.Clients; }
            set { model.Clients = value; }
        }

        //private Client _selectedClient;
        //public Client SelectedClient
        //{
        //    get { return _selectedClient; }
        //    set
        //    {
        //        _selectedClient = value;
        //        ClientSelected(value);
        //    }
        //}

        private CommandWithParam _servicesCmd;
        private CommandWithParam _clientInfoCmd;
        public CommandWithParam ServicesCommand
        {
            get { return _servicesCmd; }
        }
        public CommandWithParam ClientInfoCommand
        {
            get { return _clientInfoCmd; }
        }
        #endregion data

        #region construct
        public ClientVM()
        {
            this.model = new Model.Model();

            //Mediator.Register("cancelAdd", cancelAdd);
            //Mediator.Register("endAddDelete", endAddDelete);
            //Mediator.Register("cancelEdit", x => cancelEdit(x));

            _servicesCmd = new CommandWithParam(x => openServices((Client)x));
            _clientInfoCmd = new CommandWithParam(x => openClientInfo((Client)x));
        }
        #endregion construct

        #region selected
        private void ClientSelected(Client client)
        {
            SelectionTrail.Client = client;

            using (ZSRFEntities context = new ZSRFEntities())
            {
                IEnumerable<Service> services =
                    from s in context.Services
                    where s.clientID == client.clientID
                    orderby s.serviceDate descending
                    select s;

                //ClientServices = new ObservableCollection<Service>(services);
                this.OnPropertyChanged("ClientServices");
            }
        }
        #endregion selected

        //private void cancelAdd()
        //{
        //    this.ClientServices.RemoveAt(0);
        //    ClientServices.Insert(0, new Service()
        //    {
        //        clientID = SelectionTrail.Client.clientID
        //    });

        //    this.OnPropertyChanged("ClientServices");
        //}
        //private void cancelEdit(Service service)
        //{
        //    Service service2 = this.ClientServices.Where(t => t.serviceID == service.serviceID).First();
        //    int index = this.ClientServices.IndexOf(service2);
        //    this.ClientServices[index] = service;
        //    this.OnPropertyChanged("ClientServies");
        //}
        //private void endAddDelete()
        //{
        //    updateServices();
        //}

        //private void updateServices()
        //{
        //    using (ZSRFEntities context = new ZSRFEntities())
        //    {
        //        IEnumerable<Service> services =
        //            from t in context.Services
        //            where t.clientID == SelectionTrail.Client.clientID
        //            select t;

        //        ClientServices = new ObservableCollection<Service>(services);

        //        ClientServices.Insert(0, new Service()
        //        {
        //            clientID = SelectionTrail.Client.clientID,
        //        });
        //        this.OnPropertyChanged("ClientServices");
        //    }
        //}

        private void openClientInfo(Client c)
        {

        }

        private void openServices(Client c)
        {
            ServicesVM vm = new ServicesVM(c);
            ServicesWindow servicesWindow = new ServicesWindow(vm);
            servicesWindow.Show();
        }
    }
}
