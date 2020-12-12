using System.Collections.ObjectModel;
using bidcardcoin_WPF_B2.DAL;

namespace bidcardcoin_WPF_B2.DAO
{
    public class LotDAO
    {
        public int idLotDAO;
        public string nomLotDAO;
        public string descriptionLotDAO;
        public int idEnchereLotDAO;

        public LotDAO(int idLotDAO, string nomLotDAO, string descriptionLotDAO, int idEnchereLotDAO)
        {
            this.idLotDAO = idLotDAO;
            this.nomLotDAO = nomLotDAO;
            this.descriptionLotDAO = descriptionLotDAO;
            this.idEnchereLotDAO = idEnchereLotDAO;

        }

        public static ObservableCollection<LotDAO> listeLot()
        {
            ObservableCollection<LotDAO> l = LotDAL.selectLot();
            return l;
        }

        public static LotDAO getLot(int id)
        {
            LotDAO p = LotDAL.getLot(id);
            return p;
        }
        public static void updateLot(LotDAO p)
        {
            LotDAL.updateLot(p);
        }

        public static void supprimerLot(int id)
        {
            LotDAL.supprimerLot(id);
        }

        public static void insertLot(LotDAO p)
        {
            LotDAL.insertLot(p);
        }
    }
}
