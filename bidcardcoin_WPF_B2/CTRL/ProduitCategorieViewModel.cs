using System;
using System.ComponentModel;
using bidcardcoin_WPF_B2.ORM;

namespace bidcardcoin_WPF_B2.CTRL
{

    public class ProduitCategorieViewModel : INotifyPropertyChanged
    {
        private int idProduit;
        private int idCategorie;
        private string nomCategorie;
        private int IDCategorie;

        private string concat = "Ajouter ";

        public ProduitCategorieViewModel()
        {
            
        }
        public ProduitCategorieViewModel(string nomCategorie, int IDCategorie)
        {
            this.nomCategorie = nomCategorie;
            this.IDCategorie = IDCategorie;
        }

        public ProduitCategorieViewModel(int idProduit, int idCategorie)
        {
            this.idProduit = idProduit;
            this.idCategorie = idCategorie;
            
        }

        public int idProduitProperty
        {
            get { return idProduit; }
            set
            {
                idProduit = value; 
                OnPropertyChanged("idProduitProperty");
            }
            
        }

        public int IDCategorieProperty
        {
            get { return IDCategorie; }
            set
            {
                IDCategorie = value;
                OnPropertyChanged("IDCategorieProperty");
            }
        }

        public int idCategorieProperty
        {
            get { return idCategorie; }
            set
            {
                idCategorie = value;

                OnPropertyChanged("idCategorieProperty");
            }
        }

        public string nomCategorieProperty
        {
            get { return nomCategorie; }
            set
            {
                nomCategorie = value;
                OnPropertyChanged("idCategorieProperty");
            }
        }
        
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string info)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(info));
                this.PropertyChanged(this, new PropertyChangedEventArgs(info));
                ProduitCategorieORM.updateProduitCategorie(this);
            }
        }
    }
}