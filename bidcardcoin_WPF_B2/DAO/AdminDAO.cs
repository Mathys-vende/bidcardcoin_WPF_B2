using System.Collections.ObjectModel;
using bidcardcoin_WPF_B2.DAL;

namespace bidcardcoin_WPF_B2.DAO
{
    public class AdminDAO
    {
        public int idAdminDAO;
        public string nomAdminDAO;
        public string prenomAdminDAO;
        public string mailAdminDAO;
        public string numeroTelAdminDAO;
        public string motDePasseAdminDAO;
        public int ageAdminDAO;
        public int idLieuAdminDAO;
        
        
        public AdminDAO(int idAdminDAO, string nomAdminDAO,string prenomAdminDAO, string mailAdminDAO, string numeroTelAdminDAO,string motDePasseAdminDAO, int ageAdminDAO, int idLieuAdminDAO)
        {
            this.idAdminDAO = idAdminDAO;
            this.nomAdminDAO = nomAdminDAO;
            this.prenomAdminDAO = prenomAdminDAO;
            this.mailAdminDAO = mailAdminDAO;
            this.numeroTelAdminDAO = numeroTelAdminDAO;
            this.motDePasseAdminDAO = motDePasseAdminDAO;
            this.ageAdminDAO = ageAdminDAO;
            this.idLieuAdminDAO = idLieuAdminDAO;
        }

        public static int getAuth(string email, string mdp)
        {
            int x = AdminDAL.getAuth(email, mdp);

            return x;
        }

        public static ObservableCollection<AdminDAO> listeAdmin()
        {
            ObservableCollection<AdminDAO> l = AdminDAL.selectAdmin();
            return l;
        }

        public static AdminDAO getAdmin(int id)
        {
            AdminDAO p = AdminDAL.getAdmin(id);
            return p;
        }
        public static void updateAdmin(AdminDAO p)
        {
            AdminDAL.updateAdmin(p);
        }

        public static void supprimerAdmin(int id)
        {
            AdminDAL.supprimerAdmin(id);
        }

        public static void insertAdmin(AdminDAO p)
        {
            AdminDAL.insertAdmin(p);
        }
    }
}
