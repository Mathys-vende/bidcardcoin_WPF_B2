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
                    int idOAProduit = element.idProduitOADAO;
                    ProduitViewModel p = ProduitORM.getProduit(idOAProduit);
                    int idOAAcheteur = element.idAcheteurOADAO;
                    AcheteurViewModel a = AcheteurORM.getAcheteur(idOAAcheteur);
                    int idOAEnchere = element.idAcheteurOADAO;
                    EnchereViewModel e = EnchereORM.getEnchere(idOAEnchere);
                    
                    
                    
                OrdreachatViewModel l = new OrdreachatViewModel(p, a,e, element.montantMaxOADAO, element.adresseDepotOADAO);
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
                int idOAProduit = element.idProduitOADAO;
                ProduitViewModel prod = ProduitORM.getProduit(idOAProduit);
                int idOAAcheteur = element.idAcheteurOADAO;
                AcheteurViewModel a = AcheteurORM.getAcheteur(idOAAcheteur);
                int idOAEnchere = element.idAcheteurOADAO;
                EnchereViewModel e = EnchereORM.getEnchere(idOAEnchere);

                OrdreachatViewModel p = new OrdreachatViewModel(prod, a,e, element.montantMaxOADAO, element.adresseDepotOADAO);
                l.Add(p);
            }

            return l;
        }


        public static void updateOrdreachat(OrdreachatViewModel p)
        {
            OrdreachatDAO.updateOrdreachat(new OrdreachatDAO(p.idProduitOAProperty.idProduitProperty, p.idAcheteurOAProperty.idAcheteurProperty,p.idEnchereOAProperty.idEnchereProperty, p.montantMaxOAProperty, p.adresseDepotOAProperty ));
        }

        public static void supprimerOrdreachat(int idAcheteur, int idEnchere, int idProduit)
        {
            OrdreachatDAO.supprimerOrdreachat(idAcheteur,idEnchere, idProduit);
        }

        public static void insertOrdreachat(OrdreachatViewModel p)
        {
            OrdreachatDAO.insertOrdreachat(new OrdreachatDAO(p.idProduitOAProperty.idProduitProperty, p.idAcheteurOAProperty.idAcheteurProperty,p.idEnchereOAProperty.idEnchereProperty, p.montantMaxOAProperty, p.adresseDepotOAProperty));
        }

    }
}