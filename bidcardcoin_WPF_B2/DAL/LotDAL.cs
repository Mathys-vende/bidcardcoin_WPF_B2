using System;
using System.Collections.ObjectModel;
using System.Data;
using System.Windows;
using bidcardcoin_WPF_B2.DAO;
using MySql.Data.MySqlClient;

namespace bidcardcoin_WPF_B2.DAL
{
    public class LotDAL
    {
        public static ObservableCollection<LotDAO> selectLot()
        {    
            ObservableCollection<LotDAO> l = new ObservableCollection<LotDAO>();
            string query = "SELECT * FROM lot;";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.OpenConnection());
            MySqlDataReader reader = null;
            try
            {
                cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    LotDAO p = new LotDAO(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3));
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
        public static LotDAO getLot(int id)
        {
            string query = "SELECT * FROM lot WHERE id=" + id + ";";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.OpenConnection());
            cmd.ExecuteNonQuery();
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            LotDAO cat = new LotDAO(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3));
            reader.Close();
            return cat;
        }
        public static void updateLot(LotDAO p)
        {
            string query = "UPDATE lot set nom=\"" + p.nomLotDAO + "\", description=\"" + p.descriptionLotDAO + "\", idEnchere=\"" + p.idEnchereLotDAO + "\" where id=" + p.idLotDAO + ";";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.OpenConnection());
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
        }
        public static void insertLot(LotDAO p)
        {
            int id = getMaxIdLot() + 1;
            string query = "INSERT INTO lot VALUES (\"" + id + "\",\"" + p.nomLotDAO + "\",\"" + p.descriptionLotDAO + "\",\"" + p.idEnchereLotDAO + "\");";
            MySqlCommand cmd2 = new MySqlCommand(query, DALConnection.OpenConnection());
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd2);
            cmd2.ExecuteNonQuery();
        }
        public static void supprimerLot(int id)
        {
            string query = "DELETE FROM lot WHERE id = \"" + id + "\";";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.OpenConnection());
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
        }
        public static int getMaxIdLot()
        {
            int maxIdCategorie = 0;
            string query = "SELECT MAX(id) FROM Lot;";
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
