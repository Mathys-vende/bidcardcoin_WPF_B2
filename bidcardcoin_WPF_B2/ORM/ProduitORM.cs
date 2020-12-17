using bidcardcoin_WPF_B2.CTRL;
using bidcardcoin_WPF_B2.DAO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bidcardcoin_WPF_B2.ORM
{
    class ProduitORM
    {
        public static ProduitViewModel getProduit(int idProduit)
        {
            
            ProduitDAO pDAO = ProduitDAO.getProduit(idProduit);
            ProduitViewModel p = new ProduitViewModel(pDAO.idProduitDAO, pDAO.estimationProduitDAO, pDAO.prixVenteProduitDAO, pDAO.nomProduitDAO, pDAO.descriptionProduitDAO,
            pDAO.artisteProduitDAO, pDAO.styleProduitDAO, pDAO.idLotProduitDAO, pDAO.idPhotoProduitDAO, pDAO.idAcheteurProduitDAO, pDAO.idVendeurProduitDAO);
            return p;
        }

        public static ObservableCollection<ProduitViewModel> listeProduit()
        {
            ObservableCollection<ProduitDAO> lDAO = ProduitDAO.listeProduit();
            ObservableCollection<ProduitViewModel> l = new ObservableCollection<ProduitViewModel>();
            foreach (ProduitDAO element in lDAO)
            {

                ProduitViewModel p = new ProduitViewModel(element.idProduitDAO, element.estimationProduitDAO, element.prixVenteProduitDAO, element.nomProduitDAO, element.descriptionProduitDAO,
                element.artisteProduitDAO, element.styleProduitDAO, element.idLotProduitDAO, element.idPhotoProduitDAO, element.idAcheteurProduitDAO, element.idVendeurProduitDAO);
                l.Add(p);
            }
            return l;
        }


        public static void updateProduit(ProduitViewModel p)
        {
            ProduitDAO.updateProduit(new ProduitDAO(p.idProduitProperty, p.estimationProduitProperty, p.prixVenteProduitProperty, p.nomProduitProperty, p.descriptionProduitProperty,
                p.artisteProduitProperty, p.styleProduitProperty, p.idLotProduitProperty, p.idPhotoProduitProperty, p.idAcheteurProduitProperty, p.idVendeurProduitProperty));
        }

        public static void supprimerProduit(int id)
        {
            ProduitDAO.supprimerProduit(id);
        }

        public static void insertProduit(ProduitViewModel p)
        {
            ProduitDAO.insertProduit(new ProduitDAO(p.idProduitProperty, p.estimationProduitProperty, p.prixVenteProduitProperty, p.nomProduitProperty, p.descriptionProduitProperty,
                p.artisteProduitProperty, p.styleProduitProperty, p.idLotProduitProperty, p.idPhotoProduitProperty, p.idAcheteurProduitProperty, p.idVendeurProduitProperty));
        }

    }
}
