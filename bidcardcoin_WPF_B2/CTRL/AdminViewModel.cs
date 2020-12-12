using System;
using System.ComponentModel;
using bidcardcoin_WPF_B2.ORM;

namespace bidcardcoin_WPF_B2.CTRL
{
    public class AdminViewModel : INotifyPropertyChanged
    {
        private int idAdmin;
        private string nomAdmin;
        private string prenomAdmin;
        private string mailAdmin;
        private string numeroTelAdmin;
        private string motDePasseAdmin;
        private int ageAdmin;
        private int idLieuAdmin;
        
        
        
        private string concat = "Ajouter ";
        public AdminViewModel() { }

        public AdminViewModel(int idAdmin, string nomAdmin, string prenomAdmin, string mailAdmin, string numeroTelAdmin ,string  motDePasseAdmin, int ageAdmin, int idLieuAdmin)
        {
            this.idAdmin = idAdmin;
            this.nomAdmin = nomAdmin;
            this.prenomAdmin = prenomAdmin;
            this.mailAdmin = mailAdmin;
            this.numeroTelAdmin = numeroTelAdmin;
            this.motDePasseAdmin = motDePasseAdmin;
            this.ageAdmin = ageAdmin;
            this.idLieuAdmin = idLieuAdmin;

        }

        public int idAdminProperty
        {
            get { return idAdmin; }
            set
            {
                idAdmin = value;
            }
        }

        public String nomAdminProperty
        {
            get { return nomAdmin; }
            set
            {
                nomAdmin = value;

                OnPropertyChanged("nomAdminProperty");
            }
        }

        public String prenomAdminProperty
            {
                get { return prenomAdmin; }
                set
                {
                    prenomAdmin = value;
                
                    OnPropertyChanged("prenomAdminProperty");
                }
        }
        public String mailAdminProperty
        {
            get { return mailAdmin; }
            set
            {
                mailAdmin = value;
                
                OnPropertyChanged("mailAdminProperty");
            }
        }
        public String numeroTelAdminProperty
        {
            get { return numeroTelAdmin; }
            set
            {
                numeroTelAdmin = value;
                
                OnPropertyChanged("numeroTelAdminProperty");
            }
        }
        public String motDePasseAdminProperty
        {
            get { return motDePasseAdmin; }
            set
            {
                motDePasseAdmin = value;
                
                OnPropertyChanged("motDePasseAdminProperty");
            }
        }
        public int ageAdminProperty
        {
            get { return ageAdmin; }
            set
            {
                ageAdmin = value;
                
                OnPropertyChanged("ageAdminProperty");
            }
        }
        public int idLieuAdminProperty
        {
            get { return idLieuAdmin; }
            set
            {
                idLieuAdmin = value;
                
                OnPropertyChanged("idLieuAdminProperty");
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
                AdminORM.updateAdmin(this);
            }
        }
    }
}
