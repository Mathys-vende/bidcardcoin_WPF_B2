using System.Collections.ObjectModel;
using bidcardcoin_WPF_B2.DAL;

namespace bidcardcoin_WPF_B2.DAO
{
    public class PersonneDAO
    {
        public int idPersonneDAO;
        public string nomPersonneDAO;
        public string prenomPersonneDAO;
        public string mailPersonneDAO;
        public string numeroTelPersonneDAO;
        public string motDePassePersonneDAO;
        public string adressePersonneDAO;
        public int codePostalPersonneDAO;
        public int agePersonneDAO;
        
        public PersonneDAO(int idPersonneDAO, string nomPersonneDAO, string prenomPersonneDAO, string mailPersonneDAO, string numeroTelPersonneDAO, string motDePassePersonneDAO,string adressePersonneDAO, int codePostalPersonneDAO,int agePersonneDAO )
        {
            this.idPersonneDAO = idPersonneDAO;
            this.nomPersonneDAO = nomPersonneDAO;
            this.prenomPersonneDAO = prenomPersonneDAO;
            this.mailPersonneDAO = mailPersonneDAO;
            this.numeroTelPersonneDAO = numeroTelPersonneDAO;
            this.motDePassePersonneDAO = motDePassePersonneDAO;
            this.adressePersonneDAO = adressePersonneDAO;
            this.codePostalPersonneDAO = codePostalPersonneDAO;
            this.agePersonneDAO = agePersonneDAO;
        }

        public static ObservableCollection<PersonneDAO> listePersonne()
        {
            ObservableCollection<PersonneDAO> l = PersonneDAL.selectPersonne();
            return l;
        }

        /*public static int getAuth(string email, string mdp)
        {
           int x = PersonneDAL.getAuth(email, mdp);

            return x;
        }*/

        public static PersonneDAO getPersonne(int id)
        {
            PersonneDAO p = PersonneDAL.getPersonne(id);
            return p;
        }
        public static void updatePersonne(PersonneDAO p)
        {
            PersonneDAL.updatePersonne(p);
        }
        public static void supprimerPersonne(int id)
        {
            PersonneDAL.supprimerPersonne(id);
        }

        public static void insertPersonne(PersonneDAO p)
        {
            PersonneDAL.insertPersonne(p);
        }
    }
}