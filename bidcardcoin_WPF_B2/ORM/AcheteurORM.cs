using System.Collections.ObjectModel;
using bidcardcoin_WPF_B2.CTRL;
using bidcardcoin_WPF_B2.DAO;

namespace bidcardcoin_WPF_B2.ORM
{
    public class AcheteurORM
    {
        public static AcheteurViewModel getAcheteur(int idAcheteur)
        {
            AcheteurDAO pDAO=AcheteurDAO.getAcheteur(idAcheteur);
            AcheteurViewModel p = new AcheteurViewModel(pDAO.idAcheteurDAO, pDAO.soldeAcheteurDAO, pDAO.isSolvableAcheteurDAO, pDAO.identiteAcheteurDAO, pDAO.moyenPaiementAcheteurDAO,pDAO.idPersonneAcheteurDAO, pDAO.idPersonneDAO, pDAO.nomAcheteurDAO,pDAO.prenomAcheteurDAO,pDAO.mailAcheteurDAO, pDAO.numeroTelAcheteurDAO, pDAO.motDePasseAcheteurDAO, pDAO.adresseAcheteurDAO, pDAO.codePostalAcheteurDAO, pDAO.ageAcheteurDAO);
            return p;
        }

        public static ObservableCollection<AcheteurViewModel> listeAcheteur()
        {
            ObservableCollection<AcheteurDAO> lDAO = AcheteurDAO.listeAcheteur();
            ObservableCollection<AcheteurViewModel> l = new ObservableCollection<AcheteurViewModel>();
            foreach (AcheteurDAO element in lDAO)
            {

                AcheteurViewModel p = new AcheteurViewModel(element.idAcheteurDAO, element.soldeAcheteurDAO, element.isSolvableAcheteurDAO, element.identiteAcheteurDAO, element.moyenPaiementAcheteurDAO,element.idPersonneAcheteurDAO, element.idPersonneDAO, element.nomAcheteurDAO,element.prenomAcheteurDAO,element.mailAcheteurDAO, element.numeroTelAcheteurDAO, element.motDePasseAcheteurDAO, element.adresseAcheteurDAO, element.codePostalAcheteurDAO, element.ageAcheteurDAO);
                l.Add(p);
            }
            return l;
        }


        public static void updateAcheteur(AcheteurViewModel p)
        {
            AcheteurDAO.updateAcheteur(new AcheteurDAO(p.idAcheteurProperty, p.soldeAcheteurProperty, p.isSolvableAcheteurProperty, p.identiteAcheteurProperty, p.moyenPaiementAcheteurProperty,p.idPersonneAcheteurProperty, p.idPersonneProperty, p.nomAcheteurProperty,p.prenomAcheteurProperty,p.mailAcheteurProperty, p.numeroTelAcheteurProperty, p.motDePasseAcheteurProperty, p.adresseAcheteurProperty, p.codePostalAcheteurProperty, p.ageAcheteurProperty));
        }

        public static void supprimerAcheteur(int id)
        {
            AcheteurDAO.supprimerAcheteur(id);
        }

        public static void insertAcheteur(AcheteurViewModel p)
        {
            AcheteurDAO.insertAcheteur(new AcheteurDAO(p.idAcheteurProperty, p.soldeAcheteurProperty,p.isSolvableAcheteurProperty,p.identiteAcheteurProperty,p.moyenPaiementAcheteurProperty,p.idPersonneAcheteurProperty));
        }

    }
}