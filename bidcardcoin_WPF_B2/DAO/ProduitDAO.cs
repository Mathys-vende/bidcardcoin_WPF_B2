using bidcardcoin_WPF_B2.DAL;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bidcardcoin_WPF_B2.DAO
{
    class ProduitDAO
    {
        public int idProduitDAO;
        public float estimationProduitDAO;
        public float prixVenteProduitDAO;

        public string nomProduitDAO;
        public string descriptionProduitDAO;
        public string artisteProduitDAO;
        public string styleProduitDAO;


        public int idPhotoProduitDAO;
        //public int idCategorieProduitDAO;
        public int idLotProduitDAO;
        public int idAcheteurProduitDAO;
        public int idVendeurProduitDAO;

        public ProduitDAO() { }
        
        

        public ProduitDAO(int idDAO, float estimationProduitDAO, float prixVenteProduitDAO, string nomProduitDAO, string descriptionProduitDAO,
            string artisteProduitDAO, string styleProduitDAO, int idLotProduitDAO, int idPhotoProduitDAO, int idAcheteurProduitDAO, int idVendeurProduitDAO)
        {
            this.idProduitDAO = idDAO;
            this.estimationProduitDAO = estimationProduitDAO;
            this.prixVenteProduitDAO = prixVenteProduitDAO;
            this.nomProduitDAO = nomProduitDAO;
            this.descriptionProduitDAO = descriptionProduitDAO;
            this.styleProduitDAO = styleProduitDAO;
            this.artisteProduitDAO = artisteProduitDAO;
            //this.idCategorieProduitDAO = idCategorieProduitDAO;
            this.idLotProduitDAO = idLotProduitDAO;
            this.idPhotoProduitDAO = idPhotoProduitDAO;
            this.idAcheteurProduitDAO = idAcheteurProduitDAO;
            this.idVendeurProduitDAO = idVendeurProduitDAO;
        }

        public static ObservableCollection<ProduitDAO> listeProduit()
        {
            ObservableCollection<ProduitDAO> l = ProduitDAL.selectProduit();
            return l;
        }

        public static ProduitDAO getProduit(int id)
        {
            ProduitDAO p = ProduitDAL.getProduit(id);
            return p;
        }
        public static void updateProduit(ProduitDAO p)
        {
            ProduitDAL.updateProduit(p);
        }

        public static void supprimerProduit(int id)
        {
            ProduitDAL.supprimerProduit(id);
        }

        public static void insertProduit(ProduitDAO p)
        {
            ProduitDAL.insertProduit(p);
        }
    }
}

