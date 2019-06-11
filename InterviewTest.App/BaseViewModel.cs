using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace InterviewTest.App
{
    /// <summary>
    /// All the ViewModel will extend this class in order to have the INotifyPropertyChanged already implemented
    /// </summary>
    public class BaseViewModel : INotifyPropertyChanged
    {
        protected virtual void SetProperty<T>(ref T member, T val, [CallerMemberName] string propertyName = null)
        {
            if (object.Equals(member, val)) return;

            member = val;
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler PropertyChanged = delegate { };
    }
}
