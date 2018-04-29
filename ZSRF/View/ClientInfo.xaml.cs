using MahApps.Metro.Controls;
using ZSRF.ViewModel;

namespace ZSRF.View
{
    /// <summary>
    /// Interaction logic for ClientInfo.xaml
    /// </summary>
    public partial class ClientInfo : MetroWindow
    {
        public ClientInfo()
        {
            InitializeComponent();
        }
        public ClientInfo(ClientInfoVM vm) : this()
        {
            this.DataContext = vm;
        }
    }
}
