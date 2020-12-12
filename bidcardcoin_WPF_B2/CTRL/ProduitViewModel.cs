using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bidcardcoin_WPF_B2.CTRL
{
    class ProduitViewModel
    {
        private int idProduit;
        private int estimationProduit;
        private int prixVenteProduit;
        private string nomProduit;
        private string descriptionProduit;
        private string artisteProduit;
        private string styleProduit;
        private int isVenduProduit;
        private int idCategorieProduit;
        private int idLotProduit;
        private int idPhotoProduit;

        public ProduitViewModel(int idProduitDAO, int estimationProduitDAO, int prixVenteProduitDAO, string nomProduitDAO, string descriptionProduitDAO, string artisteProduitDAO, string styleProduitDAO, int isVenduProduitDAO, int idCategorieProduitDAO, int idLotProduitDAO, int idPhotoProduitDAO)
        {
            this.idProduit = idProduitDAO;
            this.estimationProduit = estimationProduitDAO;
            this.prixVenteProduit = prixVenteProduitDAO;
            this.nomProduit = nomProduitDAO;
            this.descriptionProduit = descriptionProduitDAO;
            this.artisteProduit = artisteProduitDAO;
            this.styleProduit = styleProduitDAO;
            this.isVenduProduit = isVenduProduitDAO;
            this.idCategorieProduit = idCategorieProduitDAO;
            this.idLotProduit = idLotProduitDAO;
            this.idPhotoProduit = idPhotoProduitDAO;
        }
    }
}
