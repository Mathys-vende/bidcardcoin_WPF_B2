using System;
using System.Collections.ObjectModel;
using bidcardcoin_WPF_B2.DAL;

namespace bidcardcoin_WPF_B2.DAO
{
    public class EstimationDAO
    {
        public float estimationDAO;
        public string dateEstimationDAO;
        public int idProduitDAO;
        public int idAdminDAO;
        
        
        public EstimationDAO(float estimationDAO, string dateEstimationDAO, int idProduitDAO, int idAdminDAO)
        {
            this.estimationDAO = estimationDAO;
            this.dateEstimationDAO = dateEstimationDAO;
            this.idProduitDAO = idProduitDAO;
            this.idAdminDAO = idAdminDAO;

                
        }

        public static ObservableCollection<EstimationDAO> listeEstimation()
        {
            ObservableCollection<EstimationDAO> l = EstimationDAL.selectEstimation();
            return l;
        }

        public static EstimationDAO getEstimation(int id)
        {
            EstimationDAO p = EstimationDAL.getEstimation(id);
            return p;
        }
        public static void updateEstimation(EstimationDAO p)
        {
            EstimationDAL.updateEstimation(p);
        }

        public static void supprimerEstimation(int id)
        {
            EstimationDAL.supprimerEstimation(id);
        }

        public static void insertEstimation(EstimationDAO p)
        {
            EstimationDAL.insertEstimation(p);
        } 
    }
    }
