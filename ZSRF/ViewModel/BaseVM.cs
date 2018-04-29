using System;
using System.ComponentModel;

namespace ZSRF.ViewModel
{
    public class BaseVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(String name)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }
}
