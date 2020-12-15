using System.Collections.ObjectModel;
using bidcardcoin_WPF_B2.CTRL;
using bidcardcoin_WPF_B2.DAO;

namespace bidcardcoin_WPF_B2.ORM
{
    public class ProduitCategorieORM
    {
        public static ProduitCategorieViewModel getProduitCategorie(int idProduitCategorie)
        {
            ProduitCategorieDAO pDAO = ProduitCategorieDAO.getProduitCategorie(idProduitCategorie);
            ProduitCategorieViewModel p = new ProduitCategorieViewModel(pDAO.idProduitDAO, pDAO.idCategorieDAO);
            return p;
        }

        public static ObservableCollection<ProduitCategorieViewModel> listeProduitCategorie()
        {
            ObservableCollection<ProduitCategorieDAO> lDAO = ProduitCategorieDAO.listeProduitCategorie();
            ObservableCollection<ProduitCategorieViewModel> l = new ObservableCollection<ProduitCategorieViewModel>();
            foreach (ProduitCategorieDAO element in lDAO)
            {

                ProduitCategorieViewModel p = new ProduitCategorieViewModel(element.idProduitDAO, element.idCategorieDAO);
                l.Add(p);
            }

            return l;
        }


        public static void updateProduitCategorie(ProduitCategorieViewModel p)
        {
            ProduitCategorieDAO.updateProduitCategorie(new ProduitCategorieDAO(p.idProduitProperty, p.idCategorieProperty));
        }

        public static void supprimerProduitCategorie(int id)
        {
            ProduitCategorieDAO.supprimerProduitCategorie(id);
        }

        public static void insertProduitCategorie(ProduitCategorieViewModel p)
        {
            ProduitCategorieDAO.insertProduitCategorie(new ProduitCategorieDAO(p.idProduitProperty, p.idCategorieProperty));
        }

    }
}