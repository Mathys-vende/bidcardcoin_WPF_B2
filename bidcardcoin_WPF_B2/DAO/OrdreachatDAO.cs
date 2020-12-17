using System.Collections.ObjectModel;
using bidcardcoin_WPF_B2.DAL;

namespace bidcardcoin_WPF_B2.DAO
{
    
        public class OrdreachatDAO
        {
            public int idProduitOADAO;
            public int idAcheteurOADAO;
            public int idEnchereOADAO;
            public float montantMaxOADAO;
            public string adresseDepotOADAO;
            
        
            public OrdreachatDAO(int idProduitOADAO, int idAcheteurOADAO, int idEnchereOADAO, float montantMaxOADAO, string adresseDepotOADAO)
            {
                this.idProduitOADAO = idProduitOADAO;
                this.idAcheteurOADAO = idAcheteurOADAO;
                this.idEnchereOADAO = idEnchereOADAO;
                this.montantMaxOADAO = montantMaxOADAO;
                this.adresseDepotOADAO = adresseDepotOADAO;
                
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
  