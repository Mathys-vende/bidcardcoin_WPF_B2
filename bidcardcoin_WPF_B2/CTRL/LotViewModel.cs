using System;
using System.ComponentModel;
using bidcardcoin_WPF_B2.ORM;

namespace bidcardcoin_WPF_B2.CTRL
{
    public class LotViewModel
    {
        private int idLot;
        private string nomLot;
        private string descriptionLot;
        private int idEnchereLot;
        
        
        
        
        private string concat = "Ajouter ";
        public LotViewModel() { }

        public LotViewModel(int idLot, string nomLot, string descriptionLot, int idEnchereLot  )
        {
            this.idLotProperty = idLot;
            this.nomLotProperty = nomLot;
            this.descriptionLotProperty = descriptionLot;
            this.idEnchereLotProperty = idEnchereLot;

        }

        public int idLotProperty
        {
            get { return idLot; }
            set
            {
                idLot = value;
            }
        }

        public String nomLotProperty
        {
            get { return nomLot; }
            set
            {
                nomLot = value;

                OnPropertyChanged("nomLotProperty");
            }
        }

        public String descriptionLotProperty
            {
                get { return descriptionLot; }
                set
                {
                    descriptionLot = value;
                
                    OnPropertyChanged("descriptionLotProperty");
                }
        }
        public int idEnchereLotProperty
        {
            get { return idEnchereLot; }
            set
            {
                idEnchereLot = value;
                
                OnPropertyChanged("idEnchereLotProperty");
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
                LotORM.updateLot(this);
            }
        }
    }
}
