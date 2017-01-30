using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TelerikListViewPoc.Components
{
    public class Bindable : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            var handler = this.PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs (propertyName));
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.NotifyPropertyChanged(propertyName);
        }

        protected virtual bool SetValue<T>(ref T reference, T value, [CallerMemberName] string propertyName = null)
        {
            if (ReferenceEquals (reference, value) || Equals (reference, value))
                return false;

            reference = value;
            this.OnPropertyChanged(propertyName);
            return true;
        }
    }
}