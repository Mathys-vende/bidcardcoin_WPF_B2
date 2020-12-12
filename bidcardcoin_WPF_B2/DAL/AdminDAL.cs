using System;
using System.Collections.ObjectModel;
using System.Data;
using System.Windows;
using bidcardcoin_WPF_B2.DAO;
using MySql.Data.MySqlClient;

namespace bidcardcoin_WPF_B2.DAL
{
    public class AdminDAL
    {
        
        public static ObservableCollection<AdminDAO> selectAdmin()
        {    
            ObservableCollection<AdminDAO> l = new ObservableCollection<AdminDAO>();
            string query = "SELECT * FROM admin;";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.OpenConnection());
            MySqlDataReader reader = null;
            try
            {
                cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    AdminDAO p = new AdminDAO(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt32(4), reader.GetString(5) , reader.GetInt32(6), reader.GetInt32(7));
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
        public static AdminDAO getAdmin(int id)
        {
            string query = "SELECT * FROM admin WHERE id=" + id + ";";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.OpenConnection());
            cmd.ExecuteNonQuery();
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            AdminDAO cat = new AdminDAO(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt32(4), reader.GetString(5) , reader.GetInt32(6), reader.GetInt32(7));
            reader.Close();
            return cat;
        }
        public static void updateAdmin(AdminDAO p)
        {
            string query = "UPDATE admin set nom=\"" + p.nomAdminDAO + "\", prenom=\"" + p.prenomAdminDAO + "\", mail=\"" + p.mailAdminDAO + "\", numeroTel=\"" + p.numeroTelAdminDAO + "\", motDePasse=\"" + p.motDePasseAdminDAO + "\", age=\"" + p.ageAdminDAO + "\", idLieu=\"" + p.idLieuAdminDAO + "\" where id=" + p.idAdminDAO + ";";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.OpenConnection());
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
        }
        public static void insertAdmin(AdminDAO p)
        {
            int id = getMaxIdAdmin() + 1;
            string query = "INSERT INTO Admin VALUES (\"" + id + "\",\"" + p.nomAdminDAO + "\",\"" + p.prenomAdminDAO + "\",\"" + p.mailAdminDAO + "\",\"" + p.numeroTelAdminDAO + "\",\"" + p.motDePasseAdminDAO + "\",\"" + p.ageAdminDAO + "\",\"" + p.idLieuAdminDAO + "\");";
            MySqlCommand cmd2 = new MySqlCommand(query, DALConnection.OpenConnection());
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd2);
            cmd2.ExecuteNonQuery();
        }
        public static void supprimerAdmin(int id)
        {
            string query = "DELETE FROM admin WHERE id = \"" + id + "\";";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.OpenConnection());
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
        }
        public static int getMaxIdAdmin()
        {
            int maxIdCategorie = 0;
            string query = "SELECT MAX(id) FROM admin;";
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