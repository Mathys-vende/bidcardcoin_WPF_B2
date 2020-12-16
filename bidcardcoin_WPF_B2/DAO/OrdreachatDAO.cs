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

            public int IDProduitDAO;
            public string nomProduitDAO;
            public int IDEnchereDAO;
            public string nomEnchereDAO;
            public int MontantMaxDAO;
            public string AdresseDepotDAO;

            public OrdreachatDAO(int IDProduitDAO, string nomProduitDAO, int IDEnchereDAO, string nomEnchereDAO,
                int MontantMaxDAO, string AdresseDepotDAO)
            {
                this.IDProduitDAO = IDProduitDAO;
                this.nomProduitDAO = nomProduitDAO;
                this.IDEnchereDAO = IDEnchereDAO;
                this.nomEnchereDAO = nomEnchereDAO;
                this.MontantMaxDAO = MontantMaxDAO;
                this.AdresseDepotDAO = AdresseDepotDAO;
            }
        
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

            public static ObservableCollection<OrdreachatDAO> getOrdreachat(int id)
            {
                ObservableCollection<OrdreachatDAO> p = OrdreachatDAL.getOrdreachat(id);
                return p;
            }
            public static void updateOrdreachat(OrdreachatDAO p)
            {
                OrdreachatDAL.updateOrdreachat(p);
            }

            public static void supprimerOrdreachat(int idAcheteur, int  idEnchere, int idProduit)
            {
                OrdreachatDAL.supprimerOrdreachat(idAcheteur, idEnchere,idProduit);
            }

            public static void insertOrdreachat(OrdreachatDAO p)
            {
                OrdreachatDAL.insertOrdreachat(p);
            } 
        }
    }
