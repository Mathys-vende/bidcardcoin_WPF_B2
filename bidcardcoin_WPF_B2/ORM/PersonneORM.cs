using System.Collections.ObjectModel;
using bidcardcoin_WPF_B2.CTRL;
using bidcardcoin_WPF_B2.DAO;

namespace bidcardcoin_WPF_B2.ORM
{
    public class PersonneORM
    {
        public static PersonneViewModel getPersonne(int idPersonne)
        {
            PersonneDAO pDAO=PersonneDAO.getPersonne(idPersonne);
            PersonneViewModel p = new PersonneViewModel(pDAO.idPersonneDAO, pDAO.nomPersonneDAO, pDAO.prenomPersonneDAO, pDAO.mailPersonneDAO, pDAO.numeroTelPersonneDAO, pDAO.motDePassePersonneDAO, pDAO.adressePersonneDAO, pDAO.codePostalPersonneDAO, pDAO.agePersonneDAO);
            return p;
        }
        public static int getAuth(string email, string mdp)
        {
           int x = PersonneDAO.getAuth(email, mdp);
           return x;
        }

        public static ObservableCollection<PersonneViewModel> listePersonne()
        {
            ObservableCollection<PersonneDAO> lDAO = PersonneDAO.listePersonne();
            ObservableCollection<PersonneViewModel> l = new ObservableCollection<PersonneViewModel>();
            foreach (PersonneDAO element in lDAO)
            {

                PersonneViewModel p = new PersonneViewModel(element.idPersonneDAO, element.nomPersonneDAO, element.prenomPersonneDAO, element.mailPersonneDAO, element.numeroTelPersonneDAO, element.motDePassePersonneDAO, element.adressePersonneDAO, element.codePostalPersonneDAO, element.agePersonneDAO);
                l.Add(p);
            }
            return l;
        }


        public static void updatePersonne(PersonneViewModel p)
        {
            PersonneDAO.updatePersonne(new PersonneDAO(p.idPersonneProperty, p.nomPersonneProperty, p.prenomPersonneProperty, p.mailPersonneProperty, p.numeroTelPersonneProperty, p.motDePassePersonneProperty, p.adressePersonneProperty, p.codePostalPersonneProperty, p.agePersonneProperty));
        }

        public static void supprimerPersonne(int id)
        {
            PersonneDAO.supprimerPersonne(id);
        }

        public static void insertPersonne(PersonneViewModel p)
        {
            PersonneDAO.insertPersonne(new PersonneDAO(p.idPersonneProperty, p.nomPersonneProperty, p.prenomPersonneProperty, p.mailPersonneProperty, p.numeroTelPersonneProperty, p.motDePassePersonneProperty, p.adressePersonneProperty, p.codePostalPersonneProperty, p.agePersonneProperty));
        }  
    }
}