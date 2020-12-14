
using System.Collections.ObjectModel;
using bidcardcoin_WPF_B2.DAL;

namespace bidcardcoin_WPF_B2.DAO
{
    public class AcheteurDAO
    {
        public int idAcheteurDAO;
        public float soldeAcheteurDAO;
        public string isSolvableAcheteurDAO;
        public string identiteAcheteurDAO;
        public string moyenPaiementAcheteurDAO;
        public int idPersonneAcheteurDAO;
        public int idPersonneDAO;
        public string nomAcheteurDAO;
        public string prenomAcheteurDAO;
        public string mailAcheteurDAO;
        public string numeroTelAcheteurDAO;
        public string motDePasseAcheteurDAO;
        public string adresseAcheteurDAO;
        public int codePostalAcheteurDAO;
        public int ageAcheteurDAO;
        
        public AcheteurDAO(int idAcheteurDao, float soldeAcheteurDao, string isSolvableAcheteurDao, string identiteAcheteurDao, string moyenPaiementAcheteurDao, int idPersonneAcheteurDao, int idPersonneDao, string nomAcheteurDao, string prenomAcheteurDao, string mailAcheteurDao, string numeroTelAcheteurDao, string motDePasseAcheteurDao, string adresseAcheteurDao, int codePostalAcheteurDao, int ageAcheteurDao)
        {
            this.idAcheteurDAO = idAcheteurDao;
            this.soldeAcheteurDAO = soldeAcheteurDao;
            this.isSolvableAcheteurDAO = isSolvableAcheteurDao;
            this.identiteAcheteurDAO = identiteAcheteurDao;
            this.moyenPaiementAcheteurDAO = moyenPaiementAcheteurDao;
            this.idPersonneAcheteurDAO = idPersonneAcheteurDao;
            this.idPersonneDAO = idPersonneDao;
            this.nomAcheteurDAO = nomAcheteurDao;
            this.prenomAcheteurDAO = prenomAcheteurDao;
            this.mailAcheteurDAO = mailAcheteurDao;
            this.numeroTelAcheteurDAO = numeroTelAcheteurDao;
            this.motDePasseAcheteurDAO = motDePasseAcheteurDao;
            this.adresseAcheteurDAO = adresseAcheteurDao;
            this.codePostalAcheteurDAO = codePostalAcheteurDao;
            this.ageAcheteurDAO = ageAcheteurDao;
        }
        public AcheteurDAO(int idAcheteurDao, float soldeAcheteurDao, string isSolvableAcheteurDao, string identiteAcheteurDao, string moyenPaiementAcheteurDao, int idPersonneAcheteurDao)
        {
            this.idAcheteurDAO = idAcheteurDao;
            this.soldeAcheteurDAO = soldeAcheteurDao;
            this.isSolvableAcheteurDAO = isSolvableAcheteurDao;
            this.identiteAcheteurDAO = identiteAcheteurDao;
            this.moyenPaiementAcheteurDAO = moyenPaiementAcheteurDao;
            this.idPersonneAcheteurDAO = idPersonneAcheteurDao;
        }
        
        

        public static ObservableCollection<AcheteurDAO> listeAcheteur()
        {
            ObservableCollection<AcheteurDAO> l = AcheteurDAL.selectAcheteur();
            return l;
        }

        public static AcheteurDAO getAcheteur(int id)
        {
            AcheteurDAO p = AcheteurDAL.getAcheteur(id);
            return p;
        }
        public static void updateAcheteur(AcheteurDAO p)
        {
            AcheteurDAL.updateAcheteur(p);
        }

        public static void supprimerAcheteur(int id)
        {
            AcheteurDAL.supprimerAcheteur(id);
        }

        public static void insertAcheteur(AcheteurDAO p)
        {
            AcheteurDAL.insertAcheteur(p);
        }
    }
}

