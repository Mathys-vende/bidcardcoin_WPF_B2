using System.Collections.ObjectModel;
using bidcardcoin_WPF_B2.CTRL;
using bidcardcoin_WPF_B2.DAO;

namespace bidcardcoin_WPF_B2.ORM
{
    public class EnchereORM
    {
        public static EnchereViewModel getEnchere(int idEnchere)
        {
            EnchereDAO pDAO=EnchereDAO.getEnchere(idEnchere);
            EnchereViewModel p = new EnchereViewModel(pDAO.idEnchereDAO, pDAO.nomEnchereDAO, pDAO.heureEnchereDAO, pDAO.dateVenteEnchereDAO, pDAO.idLieuEnchereDAO, pDAO.idAdminEnchereDAO);
            return p;
        }

        public static ObservableCollection<EnchereViewModel> listeEnchere()
        {
            ObservableCollection<EnchereDAO> lDAO = EnchereDAO.listeEnchere();
            ObservableCollection<EnchereViewModel> l = new ObservableCollection<EnchereViewModel>();
            foreach (EnchereDAO element in lDAO)
            {

                EnchereViewModel p = new EnchereViewModel(element.idEnchereDAO, element.nomEnchereDAO, element.heureEnchereDAO, element.dateVenteEnchereDAO, element.idLieuEnchereDAO, element.idAdminEnchereDAO);
                l.Add(p);
            }
            return l;
        }


        public static void updateEnchere(EnchereViewModel p)
        {
            EnchereDAO.updateEnchere(new EnchereDAO(p.idEnchereProperty, p.nomEnchereProperty, p.heureEnchereProperty, p.dateVenteEnchereProperty, p.idLieuEnchereProperty, p.idAdminEnchereProperty));
        }

        public static void supprimerEnchere(int id)
        {
            EnchereDAO.supprimerEnchere(id);
        }

        public static void insertEnchere(EnchereViewModel p)
        {
            EnchereDAO.insertEnchere(new EnchereDAO(p.idEnchereProperty, p.nomEnchereProperty, p.heureEnchereProperty, p.dateVenteEnchereProperty, p.idLieuEnchereProperty, p.idAdminEnchereProperty));
        }
        
    }
}
