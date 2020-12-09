using System.Collections.ObjectModel;
using bidcardcoin_WPF_B2.CTRL;
using bidcardcoin_WPF_B2.DAO;

namespace bidcardcoin_WPF_B2.ORM
{
    public class LieuORM
    {
        public static LieuViewModel getLieu(int idLieu)
        {
            LieuDAO pDAO=LieuDAO.getLieu(idLieu);
            LieuViewModel p = new LieuViewModel(pDAO.idLieuDAO, pDAO.villeLieuDAO , pDAO.adresseLieuDAO, pDAO.codePostalLieuDAO, pDAO.departementLieuDAO);
            return p;
        }

        public static ObservableCollection<LieuViewModel> listeLieu()
        {
            ObservableCollection<LieuDAO> lDAO = LieuDAO.listeLieu();
            ObservableCollection<LieuViewModel> l = new ObservableCollection<LieuViewModel>();
            foreach (LieuDAO element in lDAO)
            {

                LieuViewModel p = new LieuViewModel(element.idLieuDAO, element.villeLieuDAO, element.adresseLieuDAO, element.codePostalLieuDAO, element.departementLieuDAO);
                l.Add(p);
            }
            return l;
        }


        public static void updateLieu(LieuViewModel p)
        {
            LieuDAO.updateLieu(new LieuDAO(p.idLieuProperty, p.villeLieuProperty, p.adresseLieuProperty,p.codePostalLieuProperty,p.departementLieuProperty));
        }

        public static void supprimerLieu(int id)
        {
            LieuDAO.supprimerLieu(id);
        }

        public static void insertLieu(LieuViewModel p)
        {
            LieuDAO.insertLieu(new LieuDAO(p.idLieuProperty, p.villeLieuProperty, p.adresseLieuProperty,p.codePostalLieuProperty,p.departementLieuProperty));
        }
        
    }  
}
    
