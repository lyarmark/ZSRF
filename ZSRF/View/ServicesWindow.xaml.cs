using MahApps.Metro.Controls;
using ZSRF.ViewModel;

namespace ZSRF.View
{
    /// <summary>
    /// Interaction logic for Services.xaml
    /// </summary>
    public partial class ServicesWindow : MetroWindow
    {
        public ServicesWindow()
        {
            InitializeComponent();
        }
        public ServicesWindow(ServicesVM vm) : this()
        {
            this.DataContext = vm;
        }
    }
}
