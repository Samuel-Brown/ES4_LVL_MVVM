﻿using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ES4_LVL_MVVM.MVVM.ViewModels
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        public virtual Task OnNavigatingTo(object parameter)
            => Task.CompletedTask;

        public virtual Task OnNavigatedFrom(bool isForwardNavigation)
            => Task.CompletedTask;

        public virtual Task OnNavigatedTo()
            => Task.CompletedTask;
        public virtual void RaisePropertyChanged([CallerMemberName] string property = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
