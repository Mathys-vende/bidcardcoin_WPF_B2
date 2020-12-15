using System;
using System.Collections.ObjectModel;
using System.Data;
using System.Windows;
using bidcardcoin_WPF_B2.DAO;
using MySql.Data.MySqlClient;

namespace bidcardcoin_WPF_B2.DAL
{
    public class OrdreachatDAL
    {
      public static ObservableCollection<OrdreachatDAO> selectOrdreachat()
        {    
            ObservableCollection<OrdreachatDAO> l = new ObservableCollection<OrdreachatDAO>();
            string query = "SELECT * FROM ordreachat;";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.OpenConnection());
            MySqlDataReader reader = null;
            try
            {
                cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    OrdreachatDAO p = new OrdreachatDAO(reader.GetInt32(0), reader.GetInt32(1),reader.GetInt32(2),reader.GetFloat(3), reader.GetString(4));
                    l.Add(p);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Il y a un problème dans la table Ordreachat : {0}",e.StackTrace);
            }
            reader.Close();
            return l;
        }
        public static OrdreachatDAO getOrdreachat(int id)
        {
            string query = "SELECT * FROM ordreachat WHERE id=" + id + ";";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.OpenConnection());
            cmd.ExecuteNonQuery();
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            OrdreachatDAO cat = new OrdreachatDAO(reader.GetInt32(0), reader.GetInt32(1),reader.GetInt32(2),reader.GetFloat(3), reader.GetString(4));
            reader.Close();
            return cat;
        }
        public static void updateOrdreachat(OrdreachatDAO p)
        {
            /*string query = "UPDATE Ordreachat set idOrdreachat=\"" + p.idOrdreachatDAO + "\" id=\"" + p.idDAO + "\" where id=" + p.idOrdreachatDAO + ";";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.OpenConnection());
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();*/
        }
        public static void insertOrdreachat(OrdreachatDAO p)
        {
            /*int id = getMaxIdOrdreachat() + 1;*/
            string query = "INSERT INTO Ordreachat VALUES (\"" + p.idProduitDAO + "\",\"" + p.idAcheteurDAO + "\",\"" + p.idEnchereDAO + "\",\"" + p.montantMaxDAO + "\",\"" + p.adresseDepotDAO + "\");";
            MySqlCommand cmd2 = new MySqlCommand(query, DALConnection.OpenConnection());
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd2);
            cmd2.ExecuteNonQuery();
        }
        public static void supprimerOrdreachat(int id)
        {
            string query = "DELETE FROM Ordreachat WHERE id = \"" + id + "\";";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.OpenConnection());
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
        }
        public static int getMaxIdOrdreachat()
        {
            int maxIdOrdreachat = 0;
            string query = "SELECT MAX(id) FROM Ordreachat;";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.OpenConnection());

            int cnt = cmd.ExecuteNonQuery();
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable schemaTable = reader.GetSchemaTable();

            if (reader.HasRows)
            {
                reader.Read();
                if (!reader.IsDBNull(0))
                {
                    maxIdOrdreachat = reader.GetInt32(0);
                }
                else
                {
                    maxIdOrdreachat = 0;
                }
            }
            reader.Close();
            return maxIdOrdreachat;
        }
    }  
}
