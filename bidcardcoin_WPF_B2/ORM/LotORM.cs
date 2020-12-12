using System.Collections.ObjectModel;
using bidcardcoin_WPF_B2.CTRL;
using bidcardcoin_WPF_B2.DAO;

namespace bidcardcoin_WPF_B2.ORM
{
    public class LotORM
    {
        public static LotViewModel getLot(int idLot)
        {
            LotDAO pDAO=LotDAO.getLot(idLot);
            LotViewModel p = new LotViewModel(pDAO.idLotDAO, pDAO.nomLotDAO , pDAO.descriptionLotDAO, pDAO.idEnchereLotDAO);
            return p;
        }

        public static ObservableCollection<LotViewModel> listeLot()
        {
            ObservableCollection<LotDAO> lDAO = LotDAO.listeLot();
            ObservableCollection<LotViewModel> l = new ObservableCollection<LotViewModel>();
            foreach (LotDAO element in lDAO)
            {

                LotViewModel p = new LotViewModel(element.idLotDAO, element.nomLotDAO, element.descriptionLotDAO, element.idEnchereLotDAO);
                l.Add(p);
            }
            return l;
        }


        public static void updateLot(LotViewModel p)
        {
            LotDAO.updateLot(new LotDAO(p.idLotProperty, p.nomLotProperty, p.descriptionLotProperty,p.idEnchereLotProperty));
        }

        public static void supprimerLot(int id)
        {
            LotDAO.supprimerLot(id);
        }

        public static void insertLot(LotViewModel p)
        {
            LotDAO.insertLot(new LotDAO(p.idLotProperty, p.nomLotProperty, p.descriptionLotProperty,p.idEnchereLotProperty));
        }

    }
}