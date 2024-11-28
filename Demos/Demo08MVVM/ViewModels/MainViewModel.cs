using Demo08MVVM.Commands;
using Demo08MVVM.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Demo08MVVM.ViewModels
{
    public class MainViewModel : BaseViewModel, INotifyDataErrorInfo
    {

        // Une commande qui va être exécutée lorsque je souhaite ajouter un produit
        public ICommand AddProductCommand { get; }

        // Commande pour afficher le produit
        public ICommand ShowProductCommand { get; }
       
        // Dictionnaire qui va contenir les erreurs en liens avec nos propriétés
        private Dictionary<string, List<string>> _errors = new();


        private Produit _produit;

        // Le gestionnaire d'événement des erreurs qu'on va déclencher lorsque l'on détecte un changement sur les erreurs
        public event EventHandler<DataErrorsChangedEventArgs>? ErrorsChanged;

        public string Name
        {
            get { return _produit.Name; }
            set 
            {
                _produit.Name = value;
                OnPropertyChanged(nameof(Name));
                // Déclenchement de la validation du Nom lorsqu'il y a un changement
                ValidateProductName();
            }
        }

        public decimal Price
        {
            get { return _produit.Price; }
            set
            {
                _produit.Price = value;
                OnPropertyChanged(nameof(Price));
                ValidateProductPrice();
            }
        }

        public MainViewModel()
        {
            _produit = new Produit();
            AddProductCommand = new AddProductCommand(this);
            ShowProductCommand = new RelayCommand(ShowProduct);
        }


        private void ShowProduct()
        {
            MessageBox.Show($"Nom du produit: {Name} Prix: {Price}");
        }

        // Permet à la Vue d'avoir accès aux erreurs de notre dictionnaire
        public IEnumerable GetErrors(string? propertyName)
        {
            if(propertyName == null) return Enumerable.Empty<string>();

            if(!_errors.ContainsKey(propertyName)) return Enumerable.Empty<string>();

            return _errors[propertyName];
        }

        // Permet de vérifier la présence d'erreurs
        public bool HasErrors => _errors.Any();

        // Permet d'ajouter une erreur dans notre dictionnaire en lien avec notre propriété
        private void AddError(string propertyName, string error)
        {
            if (!_errors.ContainsKey(propertyName))
                _errors[propertyName] = new List<string>();

            _errors[propertyName].Add(error);
            OnErrorsChanged(propertyName);
        }

        // Permet de déclencher l'événement de modifications des erreurs
        public void OnErrorsChanged(string propertyName)
        {
            ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propertyName));
        }

        // Supprime toutes les erreurs en lien avec une propriété
        private void ClearErrors(string propertyName) 
        {
            if(_errors.ContainsKey(propertyName))
            {
                _errors[propertyName].Clear();
                OnErrorsChanged(propertyName);
            }
        }

        // Méthode de validation du nom du produit
        private void ValidateProductName()
        {

            ClearErrors(Name);

            // Vérifie que le nom du produit est correcte
            if(string.IsNullOrEmpty(Name))
            {
                AddError(nameof(Name), "Veuillez saisir un nom de produit");
            }
        }

        // Validation du prix du produit
        private void ValidateProductPrice()
        {
            ClearErrors(nameof(Price));

            if(Price <= 0)
            {
                AddError(nameof(Price), "Le prix du produit doit être supérieur à 0");
            }
        }
    }
}
