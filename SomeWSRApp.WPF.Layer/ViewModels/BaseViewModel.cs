#nullable enable

using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace SomeWSRApp.WPF.Layer.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        protected void SetProperty<T>([NotNull] ref T source, T value, [CallerMemberName] string prop = null!)
        {
            source = value;
            OnPropertyChanged(prop);
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null!)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}