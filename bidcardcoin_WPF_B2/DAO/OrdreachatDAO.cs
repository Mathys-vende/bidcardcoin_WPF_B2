using System.Collections.ObjectModel;
using bidcardcoin_WPF_B2.DAL;

namespace bidcardcoin_WPF_B2.DAO
{
    
        public class OrdreachatDAO
        {
            public int idProduitDAO;
            public int idAcheteurDAO;
            public int idEnchereDAO;
            public float montantMaxDAO;
            public string adresseDepotDAO;
        
            public OrdreachatDAO(int idProduitDAO, int idAcheteurDAO, int idEnchereDAO, float montantMaxDAO, string adresseDepotDAO)
            {
                this.idProduitDAO = idProduitDAO;
                this.idAcheteurDAO = idAcheteurDAO;
                this.idEnchereDAO = idEnchereDAO;
                this.montantMaxDAO = montantMaxDAO;
                this.adresseDepotDAO = adresseDepotDAO;
                
            }

            public static ObservableCollection<OrdreachatDAO> listeOrdreachat()
            {
                ObservableCollection<OrdreachatDAO> l = OrdreachatDAL.selectOrdreachat();
                return l;
            }

            public static OrdreachatDAO getOrdreachat(int id)
            {
                OrdreachatDAO p = OrdreachatDAL.getOrdreachat(id);
                return p;
            }
            public static void updateOrdreachat(OrdreachatDAO p)
            {
                OrdreachatDAL.updateOrdreachat(p);
            }

            public static void supprimerOrdreachat(int id)
            {
                OrdreachatDAL.supprimerOrdreachat(id);
            }

            public static void insertOrdreachat(OrdreachatDAO p)
            {
                OrdreachatDAL.insertOrdreachat(p);
            } 
        }
    }
