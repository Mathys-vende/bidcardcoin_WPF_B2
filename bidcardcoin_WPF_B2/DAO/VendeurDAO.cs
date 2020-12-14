using System.Collections.ObjectModel;
using bidcardcoin_WPF_B2.DAL;

namespace bidcardcoin_WPF_B2.DAO
{
    public class VendeurDAO
    {
        public int idVendeurDAO;
        public int idPersonneDAO;
        public int iDPeronneDAO;
        public string nomVendeurDAO;
        public string prenomVendeurDAO;
        public string mailVendeurDAO;
        public string numeroTelVendeurDAO;
        public string motDePasseVendeurDAO;
        public string adresseVendeurDAO;
        public int codePostalVendeurDAO;
        public int ageVendeurDAO;
        
        public VendeurDAO(int idDAO, int idPersonneDAO, int iDPeronneDAO, string nomVendeurDAO, string prenomVendeurDAO, string mailVendeurDAO, string numeroTelVendeurDAO, string motDePasseVendeurDAO, string adresseVendeurDAO, int codePostalVendeurDAO, int ageVendeurDAO)
        {
            this.idVendeurDAO = idDAO;
            this.idPersonneDAO = idPersonneDAO;
            this.iDPeronneDAO = iDPeronneDAO;
            this.nomVendeurDAO = nomVendeurDAO;
            this.prenomVendeurDAO = prenomVendeurDAO;
            this.mailVendeurDAO = mailVendeurDAO;
            this.numeroTelVendeurDAO = numeroTelVendeurDAO;
            this.motDePasseVendeurDAO = motDePasseVendeurDAO;
            this.adresseVendeurDAO = adresseVendeurDAO;
            this.codePostalVendeurDAO = codePostalVendeurDAO;
            this.ageVendeurDAO = ageVendeurDAO;
        }
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