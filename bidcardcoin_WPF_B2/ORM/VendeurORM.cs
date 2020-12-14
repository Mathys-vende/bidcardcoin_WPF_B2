using System;
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
            VendeurViewModel p = new VendeurViewModel(pDAO.idVendeurDAO, pDAO.idPersonneDAO, pDAO.iDPeronneDAO, pDAO.nomVendeurDAO, pDAO.prenomVendeurDAO,pDAO.mailVendeurDAO, pDAO.numeroTelVendeurDAO, pDAO.motDePasseVendeurDAO,pDAO.adresseVendeurDAO,pDAO.codePostalVendeurDAO, pDAO.ageVendeurDAO);
            return p;
        }

        public static ObservableCollection<VendeurViewModel> listeVendeur()
        {
            ObservableCollection<VendeurDAO> lDAO = VendeurDAO.listeVendeur();
            ObservableCollection<VendeurViewModel> l = new ObservableCollection<VendeurViewModel>();
            foreach (VendeurDAO element in lDAO)
            {

                VendeurViewModel p = new VendeurViewModel(element.idVendeurDAO, element.idPersonneDAO, element.iDPeronneDAO, element.nomVendeurDAO, element.prenomVendeurDAO, element.mailVendeurDAO, element.numeroTelVendeurDAO,element.motDePasseVendeurDAO,element.adresseVendeurDAO, element.codePostalVendeurDAO, element.ageVendeurDAO);
                l.Add(p);
            }
            return l;
        }


        public static void updateVendeur(VendeurViewModel p)
        {
            VendeurDAO.updateVendeur(new VendeurDAO(p.idVendeurProperty, p.idPersonneProperty, p.idPeronneProperty, p.nomVendeurProperty, p.prenomVendeurProperty, p.mailVendeurProperty, p.numeroTelVendeurProperty, p.motDePasseVendeurProperty, p.adresseVendeurProperty, p.codePostalVendeurProperty, p.ageVendeurProperty));
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