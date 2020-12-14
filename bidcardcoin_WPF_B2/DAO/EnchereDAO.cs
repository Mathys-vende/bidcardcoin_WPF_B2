using System.Collections.ObjectModel;
using bidcardcoin_WPF_B2.DAL;

namespace bidcardcoin_WPF_B2.DAO
{
    public class EnchereDAO
    {
        public int idEnchereDAO;
        public string nomEnchereDAO;
        public string heureEnchereDAO;
        public string dateVenteEnchereDAO;
        public int idLieuEnchereDAO;
        public int idAdminEnchereDAO;
        
        public EnchereDAO(int idDAO, string nomEnchere, string heureEnchere, string dateVenteDAO, int idLieuEnchere, int idAdminEnchere)
        {
            this.idEnchereDAO = idDAO;
            this.nomEnchereDAO = nomEnchere;
            this.heureEnchereDAO = heureEnchere;
            this.dateVenteEnchereDAO = dateVenteDAO;
            this.idLieuEnchereDAO = idLieuEnchere;
            this.idAdminEnchereDAO = idAdminEnchere;
        }

        public static ObservableCollection<EnchereDAO> listeEnchere()
        {
            ObservableCollection<EnchereDAO> l = EnchereDAL.selectEnchere();
            return l;
        }

        public static EnchereDAO getEnchere(int id)
        {
            EnchereDAO p = EnchereDAL.getEnchere(id);
            return p;
        }
        public static void updateEnchere(EnchereDAO p)
        {
            EnchereDAL.updateEnchere(p);
        }
        public static void supprimerEnchere(int id)
        {
            EnchereDAL.supprimerEnchere(id);
        }

        public static void insertEnchere(EnchereDAO p)
        {
            EnchereDAL.insertEnchere(p);
        }
    }
}
