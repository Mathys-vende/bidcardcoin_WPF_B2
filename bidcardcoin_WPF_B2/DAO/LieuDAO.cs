using System.Collections.ObjectModel;
using bidcardcoin_WPF_B2.DAL;

namespace bidcardcoin_WPF_B2.DAO
{
    public class LieuDAO
    {
        public int idLieuDAO;
        public string villeLieuDAO;
        public string adresseLieuDAO;
        public int codePostalLieuDAO;
        public string departementLieuDAO;
        
        public LieuDAO(int idDAO, string villeLieuDAO, string adresseLieuDAO, int codePostalDAO, string departementDAO)
        {
            this.idLieuDAO = idDAO;
            this.villeLieuDAO = villeLieuDAO;
            this.adresseLieuDAO = adresseLieuDAO;
            this.codePostalLieuDAO = codePostalDAO;
            this.departementLieuDAO = departementDAO;
        }

        public static ObservableCollection<LieuDAO> listeLieu()
        {
            ObservableCollection<LieuDAO> l = LieuDAL.selectLieu();
            return l;
        }

        public static LieuDAO getLieu(int id)
        {
            LieuDAO p = LieuDAL.getLieu(id);
            return p;
        }
        public static void updateLieu(LieuDAO p)
        {
            LieuDAL.updateLieu(p);
        }

        public static void supprimerLieu(int id)
        {
            LieuDAL.supprimerLieu(id);
        }

        public static void insertLieu(LieuDAO p)
        {
            LieuDAL.insertLieu(p);
        }
    }
}
