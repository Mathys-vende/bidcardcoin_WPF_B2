using System.Collections.ObjectModel;
using bidcardcoin_WPF_B2.CTRL;
using bidcardcoin_WPF_B2.DAO;
using bidcardcoin_WPF_B2.Vue;

namespace bidcardcoin_WPF_B2.ORM
{
    public class ProduitCategorieORM
    {
        public static ObservableCollection<ProduitCategorieViewModel> getProduitCategorie(int idProduitCategorie)
        {
            ObservableCollection<ProduitCategorieDAO> pDAO = ProduitCategorieDAO.getProduitCategorie(idProduitCategorie);
            ObservableCollection<ProduitCategorieViewModel> liste = new ObservableCollection<ProduitCategorieViewModel>();
            foreach (ProduitCategorieDAO element in pDAO)
            {

                ProduitCategorieViewModel p = new ProduitCategorieViewModel(element.nomCategorieDAO, element.IDCategorieDAO);
                liste.Add(p);
            }
            return liste;
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

        public static void supprimerProduitCategorie(int idProduit, int idCategorie)
        {
            ProduitCategorieDAO.supprimerProduitCategorie(idProduit, idCategorie);
        }

        public static void insertProduitCategorie(ProduitCategorieViewModel p)
        {
            ProduitCategorieDAO.insertProduitCategorie(new ProduitCategorieDAO(p.idProduitProperty, p.idCategorieProperty));
        }

    }
}