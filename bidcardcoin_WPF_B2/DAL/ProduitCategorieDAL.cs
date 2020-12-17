using System;
using System.Collections.ObjectModel;
using System.Data;
using System.Windows;
using bidcardcoin_WPF_B2.DAO;
using MySql.Data.MySqlClient;

namespace bidcardcoin_WPF_B2.DAL
{
    public class ProduitCategorieDAL
    {
         public static ObservableCollection<ProduitCategorieDAO> selectProduitCategorie()
        {    
            ObservableCollection<ProduitCategorieDAO> l = new ObservableCollection<ProduitCategorieDAO>();
            string query = "SELECT * FROM produitcategorie;";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.OpenConnection());
            MySqlDataReader reader = null;
            try
            {
                cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ProduitCategorieDAO p = new ProduitCategorieDAO(reader.GetInt32(0), reader.GetInt32(1));
                    l.Add(p);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Il y a un problème dans la table produitcategorie : {0}",e.StackTrace);
            }
            reader.Close();
            return l;
        }
        public static ObservableCollection<ProduitCategorieDAO> getProduitCategorie(int id)
        {
            ObservableCollection<ProduitCategorieDAO> liste = new ObservableCollection<ProduitCategorieDAO>();
            string query = "SELECT DISTINCT categorie.nom, categorie.id FROM categorie JOIN produitcategorie ON categorie.id = produitcategorie.idCategorie JOIN produit on produitcategorie.idProduit = produit.id WHERE produit.id =" + id + ";";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.OpenConnection());
            MySqlDataReader reader = null;
            try
            {
                cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();
                
                while (reader.Read())
                {
                    ProduitCategorieDAO cat = new ProduitCategorieDAO(reader.GetString(0), reader.GetInt32(1));
                    liste.Add(cat);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Il y a un problème dans la table produitcategorie : {0}",e.StackTrace);
            }

            reader.Close();
            return liste;
        }
        public static void updateProduitCategorie(ProduitCategorieDAO p)
        {
/*            string query = "UPDATE produitcategorie set idProduit=\"" + p.idProduitDAO + "\" idCategorie=\"" + p.idCategorieDAO + "\" where id=" + p.idProduitDAO + ";";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.OpenConnection());
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();*/

            /*int id = getMaxIdproduitcategorie() + 1;*/
            string query = "INSERT INTO produitcategorie VALUES (\"" + p.idProduitDAO + "\",\"" + p.idCategorieDAO + "\");";
            MySqlCommand cmd2 = new MySqlCommand(query, DALConnection.OpenConnection());
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd2);
            cmd2.ExecuteNonQuery();
        }
        public static void insertProduitCategorie(ProduitCategorieDAO p)
        {
            /*int id = getMaxIdproduitcategorie() + 1;*/
            string query = "INSERT INTO produitcategorie VALUES (\"" + p.idProduitDAO + "\",\"" + p.idCategorieDAO + "\");";
            MySqlCommand cmd2 = new MySqlCommand(query, DALConnection.OpenConnection());
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd2);
            cmd2.ExecuteNonQuery();
        }
        public static void supprimerProduitCategorie(int idProduit, int idCategorie)
        {
            string query = "DELETE FROM produitcategorie WHERE idProduit = \"" + idProduit + "\" and idCategorie=" + idCategorie + ";";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.OpenConnection());
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
        }
        public static int getMaxIdproduitcategorie()
        {
            int maxIdproduitcategorie = 0;
            string query = "SELECT MAX(id) FROM produitcategorie;";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.OpenConnection());

            int cnt = cmd.ExecuteNonQuery();
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable schemaTable = reader.GetSchemaTable();

            if (reader.HasRows)
            {
                reader.Read();
                if (!reader.IsDBNull(0))
                {
                    maxIdproduitcategorie = reader.GetInt32(0);
                }
                else
                {
                    maxIdproduitcategorie = 0;
                }
            }
            reader.Close();
            return maxIdproduitcategorie;
        }
    }
}