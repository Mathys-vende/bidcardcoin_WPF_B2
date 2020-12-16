using System;
using System.Collections.ObjectModel;
using System.Data;
using System.Windows;
using bidcardcoin_WPF_B2.DAO;
using MySql.Data.MySqlClient;

namespace bidcardcoin_WPF_B2.DAL
{
    public class PersonneDAL
    {
         public static ObservableCollection<PersonneDAO> selectPersonne()
        {    
            ObservableCollection<PersonneDAO> l = new ObservableCollection<PersonneDAO>();
            string query = "SELECT * FROM personne;";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.OpenConnection());
            MySqlDataReader reader = null;
            try
            {
                cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    PersonneDAO p = new PersonneDAO(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetInt32(7), reader.GetInt32(8));
                    l.Add(p);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Il y a un problème dans la table Categorie : {0}",e.StackTrace);
            }
            reader.Close();
            return l;
        }
        public static int getAuth(string mail, string mdp)
        {
            int counter = 0;
            string query = "SELECT * FROM personne WHERE mail='" + mail + "' AND motDePasse='" + mdp + "';";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.OpenConnection());
            cmd.ExecuteNonQuery();
            MySqlDataReader reader = cmd.ExecuteReader();
            //reader.Read();
            //string mdp = reader.GetString(0);
            if (reader.HasRows)
            {
                reader.Read();
                if (!reader.IsDBNull(0))
                {
                    counter = reader.GetInt32(0);
                }
                else
                {
                    counter = 0;
                }
            }
            reader.Close();
            return counter;
        }
        public static PersonneDAO getPersonne(int id)
        {
            string query = "SELECT * FROM personne WHERE id=" + id + ";";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.OpenConnection());
            cmd.ExecuteNonQuery();
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            PersonneDAO cat = new PersonneDAO(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetInt32(7), reader.GetInt32(8));
            reader.Close();
            return cat;
        }
        public static void updatePersonne(PersonneDAO p)
        {
            string query = "UPDATE personne set nom=\"" + p.nomPersonneDAO + "\", prenom=\"" + p.prenomPersonneDAO + "\", mail=\"" + p.mailPersonneDAO + "\", numeroTel=\"" + p.numeroTelPersonneDAO + "\" , motDePasse=\"" + p.motDePassePersonneDAO + "\" , adresse=\"" + p.adressePersonneDAO + "\" , codePostal=\"" + p.codePostalPersonneDAO + "\", age=\"" + p.agePersonneDAO + "\" where id=" + p.idPersonneDAO + ";";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.OpenConnection());
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
        }
        public static void insertPersonne(PersonneDAO p)
        {
            int id = getMaxIdPersonne() + 1;
            string query = "INSERT INTO Personne VALUES (\"" + id + "\",\"" + p.nomPersonneDAO + "\",\"" + p.prenomPersonneDAO + "\",\"" + p.mailPersonneDAO + "\",\"" + p.numeroTelPersonneDAO + "\",\"" + p.motDePassePersonneDAO + "\",\"" + p.adressePersonneDAO + "\",\"" + p.codePostalPersonneDAO + "\",\"" + p.agePersonneDAO + "\");";
            MySqlCommand cmd2 = new MySqlCommand(query, DALConnection.OpenConnection());
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd2);
            cmd2.ExecuteNonQuery();
        }
        public static void supprimerPersonne(int id)
        {
            string query = "DELETE FROM personne WHERE id = \"" + id + "\";";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.OpenConnection());
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
        }
        public static int getMaxIdPersonne() 
        {
            int maxIdCategorie = 0;
            string query = "SELECT MAX(id) FROM personne;";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.OpenConnection());

            int cnt = cmd.ExecuteNonQuery();
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable schemaTable = reader.GetSchemaTable();

            if (reader.HasRows)
            {
                reader.Read();
                if (!reader.IsDBNull(0))
                {
                    maxIdCategorie = reader.GetInt32(0);
                }
                else
                {
                    maxIdCategorie = 0;
                }
            }
            reader.Close();
            return maxIdCategorie;
        }
    }
}