using System.Collections.ObjectModel;
using bidcardcoin_WPF_B2.DAL;

namespace bidcardcoin_WPF_B2.DAO
{
    public class ProduitCategorieDAO
    {
        public int idProduitDAO;
        public int idCategorieDAO;
        
        public ProduitCategorieDAO(int idDAO, int idCategorieDAO)
        {
            this.idProduitDAO = idDAO;
            this.idCategorieDAO = idCategorieDAO;
        }

        public static ObservableCollection<ProduitCategorieDAO> listeProduitCategorie()
        {
            ObservableCollection<ProduitCategorieDAO> l = ProduitCategorieDAL.selectProduitCategorie();
            return l;
        }

        public static ProduitCategorieDAO getProduitCategorie(int id)
        {
            ProduitCategorieDAO p = ProduitCategorieDAL.getProduitCategorie(id);
            return p;
        }
        public static void updateProduitCategorie(ProduitCategorieDAO p)
        {
            ProduitCategorieDAL.updateProduitCategorie(p);
        }

        public static void supprimerProduitCategorie(int id)
        {
            ProduitCategorieDAL.supprimerProduitCategorie(id);
        }

        public static void insertProduitCategorie(ProduitCategorieDAO p)
        {
            ProduitCategorieDAL.insertProduitCategorie(p);
        } 
    }
}