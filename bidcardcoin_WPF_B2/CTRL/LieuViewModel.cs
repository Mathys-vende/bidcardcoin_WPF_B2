using System;
using System.ComponentModel;
using bidcardcoin_WPF_B2.ORM;

namespace bidcardcoin_WPF_B2.CTRL
{
    public class LieuViewModel :INotifyPropertyChanged
    {
        private int idLieu;
        private string villeLieu;
        private string adresseLieu;
        private int codePostalLieu;
        private string departementLieu;
        
        
        
        private string concat = "Ajouter ";
        public LieuViewModel() { }

        public LieuViewModel(int id, string villeLieu, string adresseLieu, int codePostalLieu, string departementLieu  )
        {
            this.idLieu = id;
            this.villeLieuProperty = villeLieu;
            this.adresseLieuProperty = adresseLieu;
            this.codePostalLieuProperty = codePostalLieu;
            this.departementLieuProperty = departementLieu;

        }

        public int idLieuProperty
        {
            get { return idLieu; }
            set
            {
                idLieu = value;
            }
        }

        public String villeLieuProperty
        {
            get { return villeLieu; }
            set
            {
                villeLieu = value;

                OnPropertyChanged("villeLieuProperty");
            }
        }

        public String adresseLieuProperty
            {
                get { return adresseLieu; }
                set
                {
                    adresseLieu = value;
                
                    OnPropertyChanged("adresseLieuProperty");
                }
        }
        public int codePostalLieuProperty
        {
            get { return codePostalLieu; }
            set
            {
                codePostalLieu = value;
                
                OnPropertyChanged("codePostalLieuProperty");
            }
        }
        public String departementLieuProperty
        {
            get { return departementLieu; }
            set
            {
                departementLieu = value;
                
                OnPropertyChanged("departementLieuProperty");
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
                LieuORM.updateLieu(this);
            }
        }
    }
}
