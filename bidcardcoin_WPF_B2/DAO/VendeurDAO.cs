using System.Collections.ObjectModel;
using bidcardcoin_WPF_B2.DAL;

namespace bidcardcoin_WPF_B2.DAO
{
    public class VendeurDAO
    {
        public int idVendeurDAO;
        public int idPersonneDAO;
        
        public VendeurDAO(int idDAO, int idPersonneDAO)
        {
            this.idVendeurDAO = idDAO;
            this.idPersonneDAO = idPersonneDAO;
        }

        public static ObservableCollection<VendeurDAO> listeVendeur()
        {
            ObservableCollection<VendeurDAO> l = VendeurDAL.selectVendeur();
            return l;
        }

        public static VendeurDAO getVendeur(int id)
        {
            VendeurDAO p = VendeurDAL.getVendeur(id);
            return p;
        }
        public static void updateVendeur(VendeurDAO p)
        {
            VendeurDAL.updateVendeur(p);
        }

        public static void supprimerVendeur(int id)
        {
            VendeurDAL.supprimerVendeur(id);
        }

        public static void insertVendeur(VendeurDAO p)
        {
            VendeurDAL.insertVendeur(p);
        }
    }
}