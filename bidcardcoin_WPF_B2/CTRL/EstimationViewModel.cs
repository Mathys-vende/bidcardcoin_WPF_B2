using System;
using System.ComponentModel;
using bidcardcoin_WPF_B2.ORM;

namespace bidcardcoin_WPF_B2.CTRL
{
    public class EstimationViewModel : INotifyPropertyChanged
    {

        private float estimation;
        private string dateEstimation;
        private int idProduit;
        private int idAdmin;


        private string concat = "Ajouter ";

        public EstimationViewModel()
        {
        }

        public EstimationViewModel(float estimation, string dateEstimation, int idProduit, int idAdmin)
        {
            this.estimation = estimation;
            this.dateEstimation = dateEstimation;
            this.idProduit = idProduit;
            this.idAdmin = idAdmin;
        }

        public float estimationProperty
        {
            get { return estimation; }
            set
            {
                estimation = value;
                OnPropertyChanged("idProduitProperty");
            }

        }

        public string dateEstimationProperty
        {
            get { return dateEstimation; }
            set
            {
                dateEstimation = value;

                OnPropertyChanged("idCategorieProperty");
            }
        }

        public int idProduitProperty
        {
            get { return idProduit; }
            set
            {
                idProduit = value;

                OnPropertyChanged("idCategorieProperty");
            }
        }

        public int idAdminProperty
        {
            get { return idAdmin; }
            set
            {
                idAdmin = value;

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
                EstimationORM.updateEstimation(this);
            }
        }
    }
}
