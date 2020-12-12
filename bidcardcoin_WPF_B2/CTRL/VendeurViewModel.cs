using System;
using System.ComponentModel;
using bidcardcoin_WPF_B2.ORM;

namespace bidcardcoin_WPF_B2.CTRL
{
    public class VendeurViewModel
    {
        private int idVendeur;
        private int idPersonne;
        
        private string concat = "Ajouter ";
        public VendeurViewModel() { }

        public VendeurViewModel(int id, int idPersonne)
        {
            this.idVendeur = id;
            this.idPersonneProperty = idPersonne;
        }
        
        

        public int idVendeurProperty
        {
            get { return idVendeur; }
            set
            {
                idVendeur = value;
            }
        }
        public int idPersonneProperty
        {
            get { return idPersonne; }
            set
            {
                idPersonne = value;
                
                OnPropertyChanged("nomVendeurProperty");
               
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
                VendeurORM.updateVendeur(this);
            }
        }
    }
}