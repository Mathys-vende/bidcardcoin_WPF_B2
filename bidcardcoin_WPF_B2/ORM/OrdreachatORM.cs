using System.Collections.ObjectModel;
using bidcardcoin_WPF_B2.CTRL;
using bidcardcoin_WPF_B2.DAO;

namespace bidcardcoin_WPF_B2.ORM
{
    public class OrdreachatORM
    {
        public static OrdreachatViewModel getOrdreachat(int idOrdreachat)
        {
            OrdreachatDAO pDAO = OrdreachatDAO.getOrdreachat(idOrdreachat);
            OrdreachatViewModel p = new OrdreachatViewModel(pDAO.idProduitDAO, pDAO.idAcheteurDAO, pDAO.idEnchereDAO, pDAO.montantMaxDAO, pDAO.adresseDepotDAO);
            return p;
        }

        public static ObservableCollection<OrdreachatViewModel> listeOrdreachat()
        {
            ObservableCollection<OrdreachatDAO> lDAO = OrdreachatDAO.listeOrdreachat();
            ObservableCollection<OrdreachatViewModel> l = new ObservableCollection<OrdreachatViewModel>();
            foreach (OrdreachatDAO element in lDAO)
            {

                OrdreachatViewModel p = new OrdreachatViewModel(element.idProduitDAO, element.idAcheteurDAO, element.idEnchereDAO, element.montantMaxDAO, element.adresseDepotDAO);
                l.Add(p);
            }

            return l;
        }


        public static void updateOrdreachat(OrdreachatViewModel p)
        {
            OrdreachatDAO.updateOrdreachat(new OrdreachatDAO(p.idProduitProperty, p.idAcheteurProperty,p.idEnchereProperty, p.montantMaxProperty, p.adresseDepotProperty ));
        }

        public static void supprimerOrdreachat(int id)
        {
            OrdreachatDAO.supprimerOrdreachat(id);
        }

        public static void insertOrdreachat(OrdreachatViewModel p)
        {
            OrdreachatDAO.insertOrdreachat(new OrdreachatDAO(p.idProduitProperty, p.idAcheteurProperty,p.idEnchereProperty, p.montantMaxProperty, p.adresseDepotProperty));
        }

    }
}