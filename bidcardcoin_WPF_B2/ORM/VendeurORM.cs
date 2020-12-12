using System.Collections.ObjectModel;
using bidcardcoin_WPF_B2.CTRL;
using bidcardcoin_WPF_B2.DAO;

namespace bidcardcoin_WPF_B2.ORM
{
    public class VendeurORM
    {
        public static VendeurViewModel getVendeur(int idVendeur)
        {
            VendeurDAO pDAO=VendeurDAO.getVendeur(idVendeur);
            VendeurViewModel p = new VendeurViewModel(pDAO.idVendeurDAO, pDAO.idPersonneDAO);
            return p;
        }

        public static ObservableCollection<VendeurViewModel> listeVendeur()
        {
            ObservableCollection<VendeurDAO> lDAO = VendeurDAO.listeVendeur();
            ObservableCollection<VendeurViewModel> l = new ObservableCollection<VendeurViewModel>();
            foreach (VendeurDAO element in lDAO)
            {

                VendeurViewModel p = new VendeurViewModel(element.idVendeurDAO, element.idPersonneDAO);
                l.Add(p);
            }
            return l;
        }


        public static void updateVendeur(VendeurViewModel p)
        {
            VendeurDAO.updateVendeur(new VendeurDAO(p.idVendeurProperty, p.idPersonneProperty));
        }

        public static void supprimerVendeur(int id)
        {
            VendeurDAO.supprimerVendeur(id);
        }

        public static void insertVendeur(VendeurViewModel p)
        {
            VendeurDAO.insertVendeur(new VendeurDAO(p.idVendeurProperty, p.idPersonneProperty));
        }

    }
}