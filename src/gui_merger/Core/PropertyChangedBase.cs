using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace gui_merger.Core
{

    public abstract class PropertyChangedBase : INotifyPropertyChanged, INotifyPropertyChanging
    {
        protected bool SetPropertyValue<T>(ref T field, T value, [CallerMemberName]string name = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            OnPropertyChanging(name);
            field = value;
            OnPropertyChanged(name);
            return true;
        }
        protected void OnPropertyChanging([CallerMemberName]string name = null)
        {
#if DEBUG
            //Debug.WriteLine($"changing: {GetType().Name}.{name}");
#endif
            PropertyChanging?.Invoke(this, new PropertyChangingEventArgs(name));
        }
        protected void OnPropertyChanged([CallerMemberName]string name = null)
        {
#if DEBUG
            Debug.WriteLine($"changed: {GetType().Name}.{name}");
#endif
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public event PropertyChangingEventHandler PropertyChanging;
    }
}
