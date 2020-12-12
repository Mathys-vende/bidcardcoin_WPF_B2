using System;
using System.ComponentModel;
using bidcardcoin_WPF_B2.ORM;

namespace bidcardcoin_WPF_B2.CTRL
{
    public class PersonneViewModel
    {
        private int idPersonne;
        private string nomPersonne;
        private string prenomPersonne;
        private string mailPersonne;
        private string numeroTelPersonne;
        private string motDePassePersonne;
        private string adressePersonne;
        private int codePostalPersonne;
        private int agePersonne;
        
        
        private string concat = "Ajouter ";
        public PersonneViewModel() { }

        public PersonneViewModel(int id, string nomPersonne, string prenomPersonne, string mailPersonne, string numeroTelPersonne , string motDePassePersonne, string adressePersonne, int codePostalPersonne, int agePersonne  )
        {
            this.idPersonne = id;
            this.nomPersonneProperty = nomPersonne;
            this.prenomPersonneProperty = prenomPersonne;
            this.mailPersonneProperty = mailPersonne;
            this.numeroTelPersonneProperty = numeroTelPersonne;
            this.motDePassePersonneProperty = motDePassePersonne;
            this.adressePersonneProperty = adressePersonne;
            this.codePostalPersonneProperty = codePostalPersonne;
            this.agePersonneProperty = agePersonne;

        }

        public int idPersonneProperty
        {
            get { return idPersonne; }
            set
            {
                idPersonne = value;
            }
        }

        public String nomPersonneProperty
        {
            get { return nomPersonne; }
            set
            {
                nomPersonne = value;

                OnPropertyChanged("nomPersonneProperty");
            }
        }

        public String prenomPersonneProperty
            {
                get { return prenomPersonne; }
                set
                {
                    prenomPersonne = value;
                
                    OnPropertyChanged("heurePersonneProperty");
                }
        }
        public String mailPersonneProperty
        {
            get { return mailPersonne; }
            set
            {
                mailPersonne = value;
                
                OnPropertyChanged("dateVentePersonneProperty");
            }
        }
        public String numeroTelPersonneProperty
        {
            get { return numeroTelPersonne; }
            set
            {
                numeroTelPersonne = value;
                
                OnPropertyChanged("idLieuPersonneProperty");
            }
        }
        public String motDePassePersonneProperty
        {
            get { return motDePassePersonne; }
            set
            {
                motDePassePersonne = value;
                
                OnPropertyChanged("idAdminPersonneProperty");
            }
        }
        public String adressePersonneProperty
        {
            get { return adressePersonne; }
            set
            {
                adressePersonne = value;
                
                OnPropertyChanged("idAdminPersonneProperty");
            }
        }
        public int codePostalPersonneProperty
        {
            get { return codePostalPersonne; }
            set
            {
                codePostalPersonne = value;
                
                OnPropertyChanged("idAdminPersonneProperty");
            }
        }
        public int agePersonneProperty
        {
            get { return agePersonne; }
            set
            {
                agePersonne = value;
                
                OnPropertyChanged("idAdminPersonneProperty");
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
                PersonneORM.updatePersonne(this);
            }
        }
    }
}