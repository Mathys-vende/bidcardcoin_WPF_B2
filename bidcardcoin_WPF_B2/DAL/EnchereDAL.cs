using System;
using System.Collections.ObjectModel;
using System.Data;
using System.Windows;
using bidcardcoin_WPF_B2.DAO;
using MySql.Data.MySqlClient;

namespace bidcardcoin_WPF_B2.DAL
{
    public class EnchereDAL
    {
         public static ObservableCollection<EnchereDAO> selectEnchere()
        {    
            ObservableCollection<EnchereDAO> l = new ObservableCollection<EnchereDAO>();
            string query = "SELECT * FROM enchere;";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.OpenConnection());
            MySqlDataReader reader = null;
            try
            {
                cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    EnchereDAO p = new EnchereDAO(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt32(4)/*, reader.GetInt32(5)*/);
                    l.Add(p);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Il y a un problème dans la table Michelle : {0}",e.StackTrace);
            }
            reader.Close();
            return l;
        }
        public static EnchereDAO getEnchere(int id)
        {
            string query = "SELECT * FROM enchere WHERE id=" + id + ";";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.OpenConnection());
            cmd.ExecuteNonQuery();
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            EnchereDAO cat = new EnchereDAO(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt32(4)/*, reader.GetInt32(5)*/);
            reader.Close();
            return cat;
        }
        public static void updateEnchere(EnchereDAO p)
        {
            string query = "UPDATE enchere set nom=\"" + p.nomEnchereDAO + "\", heure=\"" + p.heureEnchereDAO + "\", dateVente=\"" + p.dateVenteEnchereDAO + "\", idLieu=\"" + p.idLieuEnchereDAO /*+ "\", idAdmin=\"" + p.idAdminEnchereDAO*/ +"\" where id=" + p.idEnchereDAO + ";";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.OpenConnection());
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
        }
        public static void insertEnchere(EnchereDAO p)
        {
            int id = getMaxIdEnchere() + 1;
            string query = "INSERT INTO enchere VALUES (\"" + id + "\",\"" + p.nomEnchereDAO + "\",\"" + p.heureEnchereDAO + "\",\"" + p.dateVenteEnchereDAO + "\",\"" + p.idLieuEnchereDAO /*+ "\",\"" + p.idAdminEnchereDAO*/ + "\");";
            MySqlCommand cmd2 = new MySqlCommand(query, DALConnection.OpenConnection());
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd2);
            cmd2.ExecuteNonQuery();
        }
        public static void supprimerEnchere(int id)
        {
            string query = "DELETE FROM enchere WHERE id = \"" + id + "\";";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.OpenConnection());
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
        }
        public static int getMaxIdEnchere()
        {
            int maxIdEnchere= 0;
            string query = "SELECT MAX(id) FROM enchere;";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.OpenConnection());

            int cnt = cmd.ExecuteNonQuery();
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable schemaTable = reader.GetSchemaTable();

            if (reader.HasRows)
            {
                reader.Read();
                if (!reader.IsDBNull(0))
                {
                    maxIdEnchere = reader.GetInt32(0);
                }
                else
                {
                    maxIdEnchere = 0;
                }
            }
            reader.Close();
            return maxIdEnchere;
        }
    }
}
