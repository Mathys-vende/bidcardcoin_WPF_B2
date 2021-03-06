using System.Collections.ObjectModel;
using bidcardcoin_WPF_B2.DAL;


namespace bidcardcoin_WPF_B2.DAO
{
    public class CategorieDAO
    {
            public int idCategorieDAO;
            public string nomCategorieDAO;
        
            public CategorieDAO(int idDAO, string nomCategorieDAO)
            {
                this.idCategorieDAO = idDAO;
                this.nomCategorieDAO = nomCategorieDAO;
            }

            public static ObservableCollection<CategorieDAO> listeCategorie()
            {
                ObservableCollection<CategorieDAO> l = CategorieDAL.selectCategorie();
                return l;
            }

            public static CategorieDAO getCategorie(int id)
            {
                CategorieDAO p = CategorieDAL.getCategorie(id);
                return p;
            }
            public static void updateCategorie(CategorieDAO p)
            {
                CategorieDAL.updateCategorie(p);
            }

            public static void supprimerCategorie(int id)
            {
                CategorieDAL.supprimerCategorie(id);
            }

            public static void insertCategorie(CategorieDAO p)
            {
                CategorieDAL.insertCategorie(p);
            }
        }
    }   
    