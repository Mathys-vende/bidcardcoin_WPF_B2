using System;
using System.ComponentModel;
using bidcardcoin_WPF_B2.ORM;

namespace bidcardcoin_WPF_B2.CTRL
{
    public class EnchereViewModel : INotifyPropertyChanged
    {
        private int idEnchere;
        private string nomEnchere;
        private string heureEnchere;
        private string dateVenteEnchere;
        private int idLieuEnchere;
        /*private int idAdminEnchere;*/
        
        private string concat = "Ajouter ";
        public EnchereViewModel() { }

        public EnchereViewModel(int id, string nomEnchere, string heureEnchere, string dateVenteEnchere, int idLieuEnchere /*, int idAdminEnchere*/ )
        {
            this.idEnchere = id;
            this.nomEnchereProperty = nomEnchere;
            this.heureEnchereProperty = heureEnchere;
            this.dateVenteEnchereProperty = dateVenteEnchere;
            this.idLieuEnchereProperty = idLieuEnchere;
            /*this.idAdminEnchereProperty = idAdminEnchere;*/

        }

        public int idEnchereProperty
        {
            get { return idEnchere; }
            set
            {
                idEnchere = value;
            }
        }

        public String nomEnchereProperty
        {
            get { return nomEnchere; }
            set
            {
                nomEnchere = value;

                OnPropertyChanged("nomEnchereProperty");
            }
        }

        public String heureEnchereProperty
            {
                get { return heureEnchere; }
                set
                {
                    heureEnchere = value;
                
                    OnPropertyChanged("heureEnchereProperty");
                }
        }
        public String dateVenteEnchereProperty
        {
            get { return dateVenteEnchere; }
            set
            {
                dateVenteEnchere = value;
                
                OnPropertyChanged("dateVenteEnchereProperty");
            }
        }
        public int idLieuEnchereProperty
        {
            get { return idLieuEnchere; }
            set
            {
                idLieuEnchere = value;
                
                OnPropertyChanged("idLieuEnchereProperty");
            }
        }
        /*public int idAdminEnchereProperty
        {
            get { return idAdminEnchere; }
            set
            {
                idAdminEnchere = value;
                
                OnPropertyChanged("idAdminEnchereProperty");
            }
        }*/
        
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string info)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(info));
                this.PropertyChanged(this, new PropertyChangedEventArgs(info));
                EnchereORM.updateEnchere(this);
            }
        }
    }
}
