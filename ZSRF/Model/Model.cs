using System.Collections.ObjectModel;

namespace ZSRF.Model
{
    public class Model
    {
        private ZSRFEntities data;

        private ObservableCollection<Client> _clients;
        public ObservableCollection<Client> Clients
        {
            get { return _clients; }
            set { _clients = value; }
        }

        public Model()
        {
            data = new ZSRFEntities();

            data.Clients.Add(new Client());

            _clients = new ObservableCollection<Client>(data.Clients);

        }
    }
}
