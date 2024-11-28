using Demo08MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Demo08MVVM.Commands
{
    public class AddProductCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public readonly MainViewModel _mainViewModel;

        // Constructeur
        public AddProductCommand(MainViewModel mainViewModel)
        {
            _mainViewModel = mainViewModel;
            _mainViewModel.PropertyChanged += OnViewModelPropertyChanged;
        }

        public bool CanExecute(object? parameter)
        {
            return !(string.IsNullOrEmpty(_mainViewModel.Name) &&
                _mainViewModel.Price >= 0);
        }

        public void Execute(object? parameter)
        {
            MessageBox.Show(_mainViewModel.Name);
        }

        protected void OnCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }

        private void OnViewModelPropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            if(e.PropertyName == nameof(_mainViewModel.Name)) 
            {
                OnCanExecuteChanged();
            }
        }
    }
}
