using System;
using System.ComponentModel;
using bidcardcoin_WPF_B2.ORM;

namespace bidcardcoin_WPF_B2.CTRL
{
    public class VendeurViewModel : INotifyPropertyChanged
    {
        private int idVendeur;
        private int idPersonne;
        public int iDPeronne;
        public string nomVendeur;
        public string prenomVendeur;
        public string mailVendeur;
        public string numeroTelVendeur;
        public string motDePasseVendeur;
        public string adresseVendeur;
        public int codePostalVendeur;
        public int ageVendeur;
        
        private string concat = "Ajouter ";
        public VendeurViewModel() { }

        public VendeurViewModel(int id, int idPersonne,int iDPeronneDAO,string nomVendeurDAO, string prenomVendeurDAO,string mailVendeurDAO, string numeroTelVendeurDAO,string motDePasseVendeurDAO, string adresseVendeurDAO,int codePostalVendeurDAO, int ageVendeurDAO )
        {
            this.idVendeurProperty = id;
            this.idPersonneProperty = idPersonne;
            this.idPeronneProperty = iDPeronneDAO;
            this.nomVendeurProperty = nomVendeurDAO;
            this.prenomVendeurProperty = prenomVendeurDAO;
            this.mailVendeurProperty = mailVendeurDAO;
            this.numeroTelVendeurProperty = numeroTelVendeurDAO;
            this.motDePasseVendeurProperty = motDePasseVendeurDAO;
            this.adresseVendeurProperty = adresseVendeurDAO;
            this.codePostalVendeurProperty = codePostalVendeurDAO;
            this.ageVendeurProperty = ageVendeurDAO;
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
                
                OnPropertyChanged("idPersonneProperty");
               
            }
        }
        public int idPeronneProperty
        {
            get { return iDPeronne; }
            set
            {
                iDPeronne = value;
                OnPropertyChanged("idPeronneProperty");
            }
        }
        public String nomVendeurProperty
        {
            get { return nomVendeur; }
            set
            {
                nomVendeur = value;
                OnPropertyChanged("nomVendeurProperty");
            }
        }
        public String  prenomVendeurProperty
        {
            get { return prenomVendeur; }
            set
            {
                prenomVendeur = value;
                OnPropertyChanged("prenomVendeurProperty");
            }
        }
        public String  mailVendeurProperty
        {
            get { return mailVendeur; }
            set
            {
                mailVendeur = value;
                OnPropertyChanged("mailVendeurProperty");
            }
        }
        public String  numeroTelVendeurProperty
        {
            get { return numeroTelVendeur; }
            set
            {
                numeroTelVendeur = value;
                OnPropertyChanged("numeroTelVendeurProperty");
            }
        }
        public String  motDePasseVendeurProperty
        {
            get { return motDePasseVendeur; }
            set
            {
                motDePasseVendeur = value;
                OnPropertyChanged("motDePasseVendeurProperty");
            }
        }
        public String  adresseVendeurProperty
        {
            get { return adresseVendeur; }
            set
            {
                adresseVendeur = value;
                OnPropertyChanged("adresseVendeurProperty");
            }
        }
        public int  codePostalVendeurProperty
        {
            get { return codePostalVendeur; }
            set
            {
                codePostalVendeur = value;
                OnPropertyChanged("codePostalVendeurProperty");
            }
        }
        public int  ageVendeurProperty
        {
            get { return ageVendeur; }
            set
            {
                ageVendeur = value;
                OnPropertyChanged("ageVendeurProperty");
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