using System.Collections.ObjectModel;
using bidcardcoin_WPF_B2.CTRL;
using bidcardcoin_WPF_B2.DAO;
using bidcardcoin_WPF_B2.Vue;

namespace bidcardcoin_WPF_B2.ORM
{
    public class OrdreachatORM
    {
        public static ObservableCollection<OrdreachatViewModel> getOrdreachat(int idAcheteur)
        {
            ObservableCollection<OrdreachatDAO> lDAO = OrdreachatDAO.getOrdreachat(idAcheteur);
            ObservableCollection<OrdreachatViewModel> liste = new ObservableCollection<OrdreachatViewModel>();
            foreach (OrdreachatDAO element in lDAO)
            {
                OrdreachatViewModel l = new OrdreachatViewModel(element.IDProduitDAO, element.nomProduitDAO, element.IDEnchereDAO, element.nomEnchereDAO, element.MontantMaxDAO, element.AdresseDepotDAO);
                liste.Add(l);
            }
            return liste;
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

        public static void supprimerOrdreachat(int idAcheteur, int idEnchere, int idProduit)
        {
            OrdreachatDAO.supprimerOrdreachat(idAcheteur,idEnchere, idProduit);
        }

        public static void insertOrdreachat(OrdreachatViewModel p)
        {
            OrdreachatDAO.insertOrdreachat(new OrdreachatDAO(p.idProduitProperty, p.idAcheteurProperty,p.idEnchereProperty, p.montantMaxProperty, p.adresseDepotProperty));
        }

    }
}