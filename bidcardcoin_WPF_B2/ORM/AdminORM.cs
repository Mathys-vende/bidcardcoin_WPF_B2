using System.Collections.ObjectModel;
using bidcardcoin_WPF_B2.CTRL;
using bidcardcoin_WPF_B2.DAO;

namespace bidcardcoin_WPF_B2.ORM
{
    public class AdminORM
    {
        public static AdminViewModel getAdmin(int idAdmin)
        {
            AdminDAO pDAO=AdminDAO.getAdmin(idAdmin);
            AdminViewModel p = new AdminViewModel(pDAO.idAdminDAO, pDAO.nomAdminDAO, pDAO.prenomAdminDAO, pDAO.mailAdminDAO, pDAO.numeroTelAdminDAO, pDAO.motDePasseAdminDAO, pDAO.ageAdminDAO, pDAO.idLieuAdminDAO);
            return p;
        }

        public static ObservableCollection<AdminViewModel> listeAdmin()
        {
            ObservableCollection<AdminDAO> lDAO = AdminDAO.listeAdmin();
            ObservableCollection<AdminViewModel> l = new ObservableCollection<AdminViewModel>();
            foreach (AdminDAO element in lDAO)
            {

                AdminViewModel p = new AdminViewModel(element.idAdminDAO, element.nomAdminDAO, element.prenomAdminDAO, element.mailAdminDAO, element.numeroTelAdminDAO, element.motDePasseAdminDAO, element.ageAdminDAO, element.idLieuAdminDAO);
                l.Add(p);
            }
            return l;
        }
        public static int getAuth(string email, string mdp)
        {
            int x = AdminDAO.getAuth(email, mdp);
            return x;
        }

        public static void updateAdmin(AdminViewModel p)
        {
            AdminDAO.updateAdmin(new AdminDAO(p.idAdminProperty, p.nomAdminProperty, p.prenomAdminProperty, p.mailAdminProperty, p.numeroTelAdminProperty, p.motDePasseAdminProperty,p.ageAdminProperty, p.idLieuAdminProperty));
        }

        public static void supprimerAdmin(int id)
        {
            AdminDAO.supprimerAdmin(id);
        }

        public static void insertAdmin(AdminViewModel p)
        {
            AdminDAO.insertAdmin(new AdminDAO(p.idAdminProperty, p.nomAdminProperty, p.prenomAdminProperty, p.mailAdminProperty, p.numeroTelAdminProperty, p.motDePasseAdminProperty,p.ageAdminProperty, p.idLieuAdminProperty));
        }
    }
}