

using System;
using System.Collections.ObjectModel;
using System.Data;
using System.Windows;
using bidcardcoin_WPF_B2.DAO;
using MySql.Data.MySqlClient;

namespace bidcardcoin_WPF_B2.DAL
{
    public class AcheteurDAL
    {
         public static ObservableCollection<AcheteurDAO> selectAcheteur()
        {    
            ObservableCollection<AcheteurDAO> l = new ObservableCollection<AcheteurDAO>();
             string query = "SELECT * FROM acheteur LEFT JOIN personne ON acheteur.idPersonne = personne.id;";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.OpenConnection());
            MySqlDataReader reader = null;
            try
            {
                cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    AcheteurDAO p = new AcheteurDAO(reader.GetInt32(0), reader.GetFloat(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetInt32(5), reader.GetInt32(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10) , reader.GetString(11), reader.GetString(12), reader.GetInt32(13), reader.GetInt32(14));
                    l.Add(p);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Il y a un problème dans la table Acheteur : {0}",e.StackTrace);
            }
            reader.Close();
            return l;
        }
        public static AcheteurDAO getAcheteur(int id)
        { 
            string query = "SELECT * FROM acheteur LEFT JOIN personne ON acheteur.idPersonne = personne.id WHERE Acheteur.idPersonne = " + id + ";";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.OpenConnection());
            cmd.ExecuteNonQuery();
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            AcheteurDAO cat = new AcheteurDAO(reader.GetInt32(0), reader.GetFloat(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetInt32(5), reader.GetInt32(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10) , reader.GetString(11), reader.GetString(12), reader.GetInt32(13), reader.GetInt32(14));
            reader.Close();
            return cat;
        }
        public static void updateAcheteur(AcheteurDAO p)
        {
            string query = "UPDATE acheteur LEFT JOIN personne ON acheteur.idPersonne = personne.id set solde=\"" + p.soldeAcheteurDAO + "\", isSolvable=\"" + p.isSolvableAcheteurDAO + "\", identite=\"" + p.identiteAcheteurDAO + "\",moyenPaiement=\"" + p.moyenPaiementAcheteurDAO + "\", idPersonne=\"" + p.idPersonneAcheteurDAO + "\", idPersonne=\"" + p.idPersonneDAO + "\", nom=\"" + p.nomAcheteurDAO + "\", prenom=\"" + p.prenomAcheteurDAO +  "\", mail=\"" + p.mailAcheteurDAO + "\", numeroTel=\"" + p.numeroTelAcheteurDAO +"\", motDePasse=\"" + p.motDePasseAcheteurDAO + "\", adresse=\"" + p.adresseAcheteurDAO + "\", codePostal=\"" + p.codePostalAcheteurDAO + "\", age=\"" + p.ageAcheteurDAO +  "\" where Acheteur.id=" + p.idAcheteurDAO + ";";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.OpenConnection());
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
        }
        public static void insertAcheteur(AcheteurDAO p)
        {
            int id = getMaxIdAcheteur() + 1;
            string query = "INSERT INTO acheteur VALUES (\"" + id + "\",\"" + p.soldeAcheteurDAO + "\",\"" + p.isSolvableAcheteurDAO + "\",\"" + p.identiteAcheteurDAO +"\",\"" + p.moyenPaiementAcheteurDAO +"\",\"" + p.idPersonneAcheteurDAO +  "\");";
            MySqlCommand cmd2 = new MySqlCommand(query, DALConnection.OpenConnection());
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd2);
            cmd2.ExecuteNonQuery();
        }
        public static void supprimerAcheteur(int id)
        {
            string query = "DELETE FROM acheteur WHERE id = \"" + id + "\";";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.OpenConnection());
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
        }
        public static int getMaxIdAcheteur()
        {
            int maxIdAcheteur = 0;
            string query = "SELECT MAX(id) FROM acheteur;";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.OpenConnection());

            int cnt = cmd.ExecuteNonQuery();
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable schemaTable = reader.GetSchemaTable();

            if (reader.HasRows)
            {
                reader.Read();
                if (!reader.IsDBNull(0))
                {
                    maxIdAcheteur = reader.GetInt32(0);
                }
                else
                {
                    maxIdAcheteur = 0;
                }
            }
            reader.Close();
            return maxIdAcheteur;
        }  
    }
}


