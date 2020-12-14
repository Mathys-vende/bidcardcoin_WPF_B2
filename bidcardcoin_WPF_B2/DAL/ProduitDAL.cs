using bidcardcoin_WPF_B2.DAO;
using MySql.Data.MySqlClient;

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
            ProduitDAO p = new ProduitDAO();
            string query = "SELECT * FROM produit;";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.OpenConnection());
            MySqlDataReader reader = cmd.ExecuteReader();
            //cmd.ExecuteNonQuery();
            //reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                float prixVente;
                if (Convert.IsDBNull(reader[2]))
                {
                    prixVente = 0;
                }
                else
                {
                    prixVente = reader.GetFloat(2);
                }


                int idLot; // = ( int ) reader["idLot"];
                if (Convert.IsDBNull(reader[7]))
                {
                    idLot = 0;
                }
                else
                {
                    idLot = reader.GetInt32(7);
                }
                int idPhoto;
                if (Convert.IsDBNull(reader[8]))
                {
                    idPhoto = 0;
                }
                else
                {
                    idPhoto = reader.GetInt32(8);
                }
                //= (int)reader["idPhoto"];
                int idAcheteur;
                if (Convert.IsDBNull(reader[9]))
                {
                    idAcheteur = 0;
                }
                else
                {
                    idAcheteur = reader.GetInt32(9);
                }
                //= (int)reader["idAcheteur"];
                int idVendeur;
                if (Convert.IsDBNull(reader[10]))
                {
                    idVendeur = 0;
                }
                else
                {
                    idVendeur = reader.GetInt32(10);
                }
                //= (int)reader["idvendeur"];

                /*                if (Convert.IsDBNull(prixVente))
                                {
                                    prixVente = 0;
                                }*/
                //var str = reader.IsDBNull(2) ? string.Empty : reader.GetString(2);

                new ProduitDAO(reader.GetInt32(0), reader.GetFloat(1), prixVente, reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), idLot, idPhoto, idAcheteur, idVendeur);
                    
                l.Add(p);
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
            
                float prixVente;
                if (Convert.IsDBNull(reader[2]))
                {
                    prixVente = 0;
                }
                else
                {
                    prixVente = reader.GetFloat(2);
                }


                int idLot; // = ( int ) reader["idLot"];
                if (Convert.IsDBNull(reader[7]))
                {
                    idLot = 0;
                }
                else
                {
                    idLot = reader.GetInt32(7);
                }

                int idPhoto;
                if (Convert.IsDBNull(reader[8]))
                {
                    idPhoto = 0;
                }
                else
                {
                    idPhoto = reader.GetInt32(8);
                }

                //= (int)reader["idPhoto"];
                int idAcheteur;
                if (Convert.IsDBNull(reader[9]))
                {
                    idAcheteur = 0;
                }
                else
                {
                    idAcheteur = reader.GetInt32(9);
                }

                //= (int)reader["idAcheteur"];
                int idVendeur;
                if (Convert.IsDBNull(reader[10]))
                {
                    idVendeur = 0;
                }
                else
                {
                    idVendeur = reader.GetInt32(10);
                }
                //= (int)reader["idvendeur"];

                /*                if (Convert.IsDBNull(prixVente))
                                {
                                    prixVente = 0;
                                }*/
                //var str = reader.IsDBNull(2) ? string.Empty : reader.GetString(2);

                ProduitDAO dao = new ProduitDAO(reader.GetInt32(0), reader.GetFloat(1), prixVente, reader.GetString(3),
                    reader.GetString(4), reader.GetString(5), reader.GetString(6), idLot, idPhoto, idAcheteur,
                    idVendeur);
            

            reader.Close();
            return dao;
        }
        public static void updateProduit(ProduitDAO p)
        {
            string query = "UPDATE produit set estimationActuelle=\"" + p.estimationProduitDAO + "\", prixVente=\"" + p.prixVenteProduitDAO + "\", nom=\"" + p.nomProduitDAO
                + "\", description=\"" + p.descriptionProduitDAO + "\", artiste=\"" + p.artisteProduitDAO + "\", style=\"" + p.styleProduitDAO + "\", idLot=\"" + p.idLotProduitDAO
                + "\", idPhoto=\"" + p.idPhotoProduitDAO + "\", idAcheteur=\"" + p.idAcheteurProduitDAO + "\", idVendeur=\"" + p.idVendeurProduitDAO + "\" where id=" + p.idProduitDAO + ";";
            MySqlCommand cmd = new MySqlCommand(query, DALConnection.OpenConnection());
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
        }
        public static void insertProduit(ProduitDAO p)
        {
            int id = getMaxIdProduit() + 1;
            string query = "INSERT INTO produit VALUES (\"" + id + "\",\"" + p.estimationProduitDAO + "\"),\"" + p.prixVenteProduitDAO + "\"),\"" + p.nomProduitDAO + "\")" +
                ",\"" + p.descriptionProduitDAO + "\"),\"" + p.artisteProduitDAO + "\"),\"" + p.styleProduitDAO + "\"),\"" + p.idLotProduitDAO + "\"),\"" + p.idPhotoProduitDAO + "\")" +
                ",\"" + p.idAcheteurProduitDAO + "\"),\"" + p.idVendeurProduitDAO + "\");";
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
