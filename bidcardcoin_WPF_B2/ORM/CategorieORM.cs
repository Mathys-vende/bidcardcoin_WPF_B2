using System.Collections.ObjectModel;
using bidcardcoin_WPF_B2.CTRL;
using bidcardcoin_WPF_B2.DAO;


namespace bidcardcoin_WPF_B2.ORM
{
    public class CategorieORM
    {
        public static CategorieViewModel getCategorie(int idCategorie)
        {
            CategorieDAO pDAO=CategorieDAO.getCategorie(idCategorie);
            CategorieViewModel p = new CategorieViewModel(pDAO.idCategorieDAO, pDAO.nomCategorieDAO);
            return p;
        }

        public static ObservableCollection<CategorieViewModel> listeCategorie()
        {
            ObservableCollection<CategorieDAO> lDAO = CategorieDAO.listeCategorie();
            ObservableCollection<CategorieViewModel> l = new ObservableCollection<CategorieViewModel>();
            foreach (CategorieDAO element in lDAO)
            {

                CategorieViewModel p = new CategorieViewModel(element.idCategorieDAO, element.nomCategorieDAO);
                l.Add(p);
            }
            return l;
        }


        public static void updateCategorie(CategorieViewModel p)
        {
            CategorieDAO.updateCategorie(new CategorieDAO(p.idCategorieProperty, p.nomCategorieProperty));
        }

        public static void supprimerCategorie(int id)
        {
            CategorieDAO.supprimerCategorie(id);
        }

        public static void insertCategorie(CategorieViewModel p)
        {
            CategorieDAO.insertCategorie(new CategorieDAO(p.idCategorieProperty, p.nomCategorieProperty));
        }
        
    }
}
