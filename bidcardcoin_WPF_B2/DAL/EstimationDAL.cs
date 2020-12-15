using System;
using System.Collections.ObjectModel;
using System.Data;
using System.Windows;
using bidcardcoin_WPF_B2.DAO;
using MySql.Data.MySqlClient;

namespace bidcardcoin_WPF_B2.DAL
{
    public class EstimationDAL
    {
        public static ObservableCollection<EstimationDAO> selectEstimation()
        {    
            ObservableCollection<EstimationDAO> l = new ObservableCollection<EstimationDAO>();
            string query = "SELECT * FROM estimation;";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.OpenConnection());
            MySqlDataReader reader = null;
            try
            {
                cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    EstimationDAO p = new EstimationDAO(reader.GetFloat(0), reader.GetString(1),reader.GetInt32(2),reader.GetInt32(3));
                    l.Add(p);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Il y a un problème dans la table Estimation : {0}",e.StackTrace);
            }
            reader.Close();
            return l;
        }
        public static EstimationDAO getEstimation(int id)
        {
            string query = "SELECT * FROM estimation WHERE id=" + id + ";";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.OpenConnection());
            cmd.ExecuteNonQuery();
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            EstimationDAO cat = new EstimationDAO(reader.GetFloat(0), reader.GetString(1),reader.GetInt32(2),reader.GetInt32(3));
            reader.Close();
            return cat;
        }
        public static void updateEstimation(EstimationDAO p)
        {
            /*string query = "UPDATE Estimation set idEstimation=\"" + p.idEstimationDAO + "\" id=\"" + p.idDAO + "\" where id=" + p.idEstimationDAO + ";";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.OpenConnection());
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();*/
        }
        public static void insertEstimation(EstimationDAO p)
        {
            /*int id = getMaxIdEstimation() + 1;*/
            string query = "INSERT INTO Estimation VALUES (\"" + p.estimationDAO + "\",\"" + p.dateEstimationDAO + "\",\"" + p.idProduitDAO + "\",\"" + p.idAdminDAO + "\");";
            MySqlCommand cmd2 = new MySqlCommand(query, DALConnection.OpenConnection());
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd2);
            cmd2.ExecuteNonQuery();
        }
        public static void supprimerEstimation(int id)
        {
            string query = "DELETE FROM estimation WHERE id = \"" + id + "\";";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.OpenConnection());
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
        }
        public static int getMaxIdEstimation()
        {
            int maxIdEstimation = 0;
            string query = "SELECT MAX(id) FROM estimation;";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.OpenConnection());

            int cnt = cmd.ExecuteNonQuery();
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable schemaTable = reader.GetSchemaTable();

            if (reader.HasRows)
            {
                reader.Read();
                if (!reader.IsDBNull(0))
                {
                    maxIdEstimation = reader.GetInt32(0);
                }
                else
                {
                    maxIdEstimation = 0;
                }
            }
            reader.Close();
            return maxIdEstimation;
        }
    }
}