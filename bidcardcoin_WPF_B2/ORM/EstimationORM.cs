using System.Collections.ObjectModel;
using bidcardcoin_WPF_B2.CTRL;
using bidcardcoin_WPF_B2.DAO;

namespace bidcardcoin_WPF_B2.ORM
{
    public class EstimationORM
    {
        public static EstimationViewModel getEstimation(int idEstimation)
        {
            EstimationDAO pDAO = EstimationDAO.getEstimation(idEstimation);
            EstimationViewModel p = new EstimationViewModel(pDAO.estimationDAO, pDAO.dateEstimationDAO, pDAO.idProduitDAO, pDAO.idAdminDAO);
            return p;
        }

        public static ObservableCollection<EstimationViewModel> listeEstimation()
        {
            ObservableCollection<EstimationDAO> lDAO = EstimationDAO.listeEstimation();
            ObservableCollection<EstimationViewModel> l = new ObservableCollection<EstimationViewModel>();
            foreach (EstimationDAO element in lDAO)
            {

                EstimationViewModel p = new EstimationViewModel(element.estimationDAO, element.dateEstimationDAO, element.idProduitDAO, element.idAdminDAO);
                l.Add(p);
            }

            return l;
        }


        public static void updateEstimation(EstimationViewModel p)
        {
            EstimationDAO.updateEstimation(new EstimationDAO(p.estimationProperty, p.dateEstimationProperty,p.idProduitProperty, p.idAdminProperty));
        }

        public static void supprimerEstimation(int id)
        {
            EstimationDAO.supprimerEstimation(id);
        }

        public static void insertEstimation(EstimationViewModel p)
        {
            EstimationDAO.insertEstimation(new EstimationDAO(p.estimationProperty, p.dateEstimationProperty,p.idProduitProperty, p.idAdminProperty));
        }
    }
}