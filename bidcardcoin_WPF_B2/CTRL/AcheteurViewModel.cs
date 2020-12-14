using System;
using System.ComponentModel;
using bidcardcoin_WPF_B2.ORM;

namespace bidcardcoin_WPF_B2.CTRL
{
    public class AcheteurViewModel : INotifyPropertyChanged
    {
        public int idAcheteur;
        public float soldeAcheteur;
        public string isSolvableAcheteur;
        public string identiteAcheteur;
        public string moyenPaiementAcheteur;
        public int idPersonneAcheteur;
        public int idPersonne;
        public string nomAcheteur;
        public string prenomAcheteur;
        public string mailAcheteur;
        public string numeroTelAcheteur;
        public string motDePasseAcheteur;
        public string adresseAcheteur;
        public int codePostalAcheteur;
        public int ageAcheteur;
        
        private string concat = "Ajouter ";
  
        public AcheteurViewModel() { }

        public AcheteurViewModel( int idAcheteur,float soldeAcheteur, string isSolvableAcheteur, string identiteAcheteur, string moyenPaiementAcheteur, int idPersonneAcheteur, int idPersonne, string nomAcheteur, string prenomAcheteur,string mailAcheteur,string numeroTelAcheteur, string motDePasseAcheteur, string adresseAcheteur, int codePostalAcheteur,int ageAcheteur)
        {
            this.idAcheteurProperty = idAcheteur;
            this.soldeAcheteurProperty = soldeAcheteur;
            this.isSolvableAcheteurProperty = isSolvableAcheteur;
            this.identiteAcheteurProperty = identiteAcheteur;
            this.moyenPaiementAcheteurProperty = moyenPaiementAcheteur;
            this.idPersonneAcheteurProperty = idPersonneAcheteur;
            this.idPersonneProperty = idPersonne;
            this.nomAcheteurProperty = nomAcheteur;
            this.prenomAcheteurProperty = prenomAcheteur;
            this.mailAcheteurProperty = mailAcheteur;
            this.numeroTelAcheteurProperty = numeroTelAcheteur;
            this.motDePasseAcheteurProperty = motDePasseAcheteur;
            this.adresseAcheteurProperty = adresseAcheteur;
            this.codePostalAcheteurProperty = codePostalAcheteur;
            this.ageAcheteurProperty = ageAcheteur;
        }

        public int idAcheteurProperty { 
            get { return idAcheteur; }
            set
            {
                idAcheteur = value;
                OnPropertyChanged("ageVendeurProperty");
            }
        }

        public float soldeAcheteurProperty
        {
            get { return soldeAcheteur; }
            set
            {
                soldeAcheteur = value;
                OnPropertyChanged("ageVendeurProperty");
            }
        }

        public String isSolvableAcheteurProperty
        {
            get { return isSolvableAcheteur; }
            set
            {
                isSolvableAcheteur = value;
                OnPropertyChanged("ageVendeurProperty");
            }
        }

        public string identiteAcheteurProperty
        {
            get { return identiteAcheteur; }
            set
            {
                identiteAcheteur = value;
                OnPropertyChanged("ageVendeurProperty");
            }
        }

        public string moyenPaiementAcheteurProperty
        {
            get { return moyenPaiementAcheteur; }
            set
            {
                moyenPaiementAcheteur = value;
                OnPropertyChanged("ageVendeurProperty");
            }
        }

        public int idPersonneAcheteurProperty
        {
            get { return  idPersonneAcheteur; }
            set
            {
                idPersonneAcheteur = value;
                OnPropertyChanged("ageVendeurProperty");
            }
        }

        public int idPersonneProperty
        {
            get { return idPersonne; }
            set
            {
                idPersonne = value;
                OnPropertyChanged("ageVendeurProperty");
            }
        }

        public string nomAcheteurProperty
        {
            get { return nomAcheteur; }
            set
            {
                nomAcheteur = value;
                OnPropertyChanged("ageVendeurProperty");
            }
        }

        public string prenomAcheteurProperty
        {
            get { return prenomAcheteur; }
            set
            {
                prenomAcheteur = value;
                OnPropertyChanged("ageVendeurProperty");
            }
        }

        public string mailAcheteurProperty
        {
            get { return mailAcheteur; }
            set
            {
                mailAcheteur = value;
                OnPropertyChanged("ageVendeurProperty");
            }
        }

        public string numeroTelAcheteurProperty
        {
            get { return numeroTelAcheteur; }
            set
            {
                numeroTelAcheteur = value;
                OnPropertyChanged("ageVendeurProperty");
            }
        }

        public string motDePasseAcheteurProperty
        {
            get { return motDePasseAcheteur; }
            set
            {
                motDePasseAcheteur = value;
                OnPropertyChanged("ageVendeurProperty");
            }
        }

        public string adresseAcheteurProperty
        {
            get { return adresseAcheteur; }
            set
            {
                adresseAcheteur = value;
                OnPropertyChanged("ageVendeurProperty");
            }
        }

        public int codePostalAcheteurProperty
        {
            get { return codePostalAcheteur; }
            set
            {
                codePostalAcheteur = value;
                OnPropertyChanged("ageVendeurProperty");
            }
        }
        public int ageAcheteurProperty
        {
            get { return ageAcheteur; }
            set
            {
                ageAcheteur = value;
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
                AcheteurORM.updateAcheteur(this);
            }
        }
    }
}