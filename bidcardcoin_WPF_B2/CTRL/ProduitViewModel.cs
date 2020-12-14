using bidcardcoin_WPF_B2.ORM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bidcardcoin_WPF_B2.CTRL
{
    class ProduitViewModel
    {
        private int idProduit;
        private float estimationProduit;
        private float prixVenteProduit;
        private string nomProduit;
        private string descriptionProduit;
        private string artisteProduit;
        private string styleProduit;
        private int idPhotoProduit;
        //private int idCategorieProduit;
        private int idLotProduit;
        private int idAcheteurProduit;
        private int idVendeurProduit;

        public ProduitViewModel() { }
        public ProduitViewModel(int idProduitDAO, float estimationProduitDAO, float prixVenteProduitDAO, string nomProduitDAO, string descriptionProduitDAO, string artisteProduitDAO, string styleProduitDAO, int idLotProduitDAO, int idPhotoProduitDAO, int idAcheteurProduitDAO, int idVendeurProduitDAO)
        {
            this.idProduit = idProduitDAO;
            this.estimationProduit = estimationProduitDAO;
            this.prixVenteProduit = prixVenteProduitDAO;
            this.nomProduit = nomProduitDAO;
            this.descriptionProduit = descriptionProduitDAO;
            this.artisteProduit = artisteProduitDAO;
            this.styleProduit = styleProduitDAO;
            this.idPhotoProduit = idPhotoProduitDAO;
            //this.idCategorieProduit = idCategorieProduitDAO;
            this.idLotProduit = idLotProduitDAO;
            this.idAcheteurProduit = idAcheteurProduitDAO;
            this.idVendeurProduit = idVendeurProduitDAO;
        }
        public int idProduitProperty
        {
            get { return idProduit; }
            set
            {
                idProduit = value;
            }
        }
        public float estimationProduitProperty
        {
            get { return estimationProduit; }
            set
            {
                estimationProduit = value;

                OnPropertyChanged("estimationProduitProperty");

            }
        }
        public float prixVenteProduitProperty
        {
            get { return prixVenteProduit; }
            set
            {
                prixVenteProduit = value;

                OnPropertyChanged("prixVenteProperty");

            }
        }
        public string nomProduitProperty
        {
            get { return nomProduit; }
            set
            {
                nomProduit = value;

                OnPropertyChanged("nomProduitProperty");

            }
        }
        public string descriptionProduitProperty
        {
            get { return descriptionProduit; }
            set
            {
                descriptionProduit = value;

                OnPropertyChanged("descriptionProduitProperty");

            }
        }
        public string artisteProduitProperty
        {
            get { return artisteProduit; }
            set
            {
                artisteProduit = value;

                OnPropertyChanged("artisteProduitProperty");

            }
        }
        public string styleProduitProperty
        {
            get { return styleProduit; }
            set
            {
                styleProduit = value;

                OnPropertyChanged("styleProduitProperty");

            }
        }
        public int idLotProduitProperty
        {
            get { return idLotProduit; }
            set
            {
                idLotProduit = value;

                OnPropertyChanged("idLotProduitProperty");

            }
        }
        public int idPhotoProduitProperty
        {
            get { return idPhotoProduit; }
            set
            {
                idPhotoProduit = value;

                OnPropertyChanged("idPhotoProduitProperty");

            }
        }
       /* public int idCategorieProduitProperty
        {
            get { return idCategorieProduit; }
            set
            {
                idCategorieProduit = value;

                OnPropertyChanged("idCategoryProduitProperty");

            }
        }*/
        public int idAcheteurProduitProperty
        {
            get { return idAcheteurProduit; }
            set
            {
                idAcheteurProduit = value;

                OnPropertyChanged("idAcheteurProduitProperty");

            }
        }
        public int idVendeurProduitProperty
        {
            get { return idVendeurProduit; }
            set
            {
                idVendeurProduit = value;

                OnPropertyChanged("idVendeurProduitProperty");

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
                ProduitORM.updateProduit(this);
            }
        }
    }
}
