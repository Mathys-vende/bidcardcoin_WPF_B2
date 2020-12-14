using bidcardcoin_WPF_B2.DAO;
using MySql.Data.MySqlClient;
using Solution;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace bidcardcoin_WPF_B2.DAL
{
    class ProduitDAL
    {
        public ProduitDAL()
        {
        }

        public static ObservableCollection<ProduitDAO> selectProduit()
        {
            ObservableCollection<ProduitDAO> l = new ObservableCollection<ProduitDAO>();
            string query = "SELECT * FROM produit;";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.OpenConnection());
            MySqlDataReader reader = null;
            try
            {
                cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ProduitDAO p = new ProduitDAO(reader.GetInt32(0), reader.GetInt32(0), reader.GetInt32(0), reader.GetString(1), reader.GetString(1), reader.GetString(1), reader.GetString(1), reader.GetInt32(0), reader.GetInt32(0), reader.GetInt32(0), reader.GetInt32(0), reader.GetInt32(0));
                    l.Add(p);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Il y a un problème dans la table Categorie : {0}", e.StackTrace);
            }
            reader.Close();
            return l;
        }
        public static ProduitDAO getProduit(int id)
        {
            string query = "SELECT * FROM produit WHERE id=" + id + ";";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.OpenConnection());
            cmd.ExecuteNonQuery();
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            ProduitDAO cat = new ProduitDAO(reader.GetInt32(0), reader.GetInt32(0), reader.GetInt32(0), reader.GetString(1), reader.GetString(1), reader.GetString(1), reader.GetString(1), reader.GetInt32(0), reader.GetInt32(0), reader.GetInt32(0), reader.GetInt32(0), reader.GetInt32(0));
            reader.Close();
            return cat;
        }
        public static void updateProduit(ProduitDAO p)
        {
            string query = "UPDATE produit set estimationActuelle=\"" + p.estimationProduitDAO + "\", prixVente=\"" + p.prixVenteProduitDAO + "\", nom=\"" + p.nomProduitDAO
                + "\", description=\"" + p.descriptionProduitDAO + "\", artiste=\"" + p.artisteProduitDAO + "\", style=\"" + p.styleProduitDAO + "\", isVendu=\"" + p.idPhotoProduitDAO
                + "\", idCategorie=\"" + p.idCategorieProduitDAO + "\", idLot=\"" + p.idLotProduitDAO + "\", idAcheteur=\"" + p.idAcheteurProduitDAO + "\", idVendeurProduit=\"" + p.idVendeurProduitDAO + "\" where id=" + p.idProduitDAO + ";";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.OpenConnection());
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
        }
        public static void insertProduit(ProduitDAO p)
        {
            int id = getMaxIdProduit() + 1;
            string query = "INSERT INTO produit VALUES (\"" + id + "\",\"" + p.estimationProduitDAO + "\"),\"" + p.prixVenteProduitDAO + "\"),\"" + p.nomProduitDAO + "\")" +
                ",\"" + p.descriptionProduitDAO + "\"),\"" + p.artisteProduitDAO + "\"),\"" + p.styleProduitDAO + "\"),\"" + p.idPhotoProduitDAO + "\"),\"" + p.idCategorieProduitDAO + "\")" +
                ",\"" + p.idLotProduitDAO + "\"),\"" + p.idAcheteurProduitDAO + "\"),\"" + p.idVendeurProduitDAO + "\"),\"" + p.idProduitDAO + "\");";
            MySqlCommand cmd2 = new MySqlCommand(query, DALConnection.OpenConnection());
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd2);
            cmd2.ExecuteNonQuery();
        }
        public static void supprimerProduit(int id)
        {
            string query = "DELETE FROM produit WHERE id = \"" + id + "\";";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.OpenConnection());
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
        }
        public static int getMaxIdProduit()
        {
            int maxIdProduit = 0;
            string query = "SELECT MAX(id) FROM produit;";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.OpenConnection());

            int cnt = cmd.ExecuteNonQuery();
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable schemaTable = reader.GetSchemaTable();

            if (reader.HasRows)
            {
                reader.Read();
                if (!reader.IsDBNull(0))
                {
                    maxIdProduit = reader.GetInt32(0);
                }
                else
                {
                    maxIdProduit = 0;
                }
            }
            reader.Close();
            return maxIdProduit;
        }
    }
}
