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
            //todo finir l'ORM pour produit
            ProduitDAO pDAO = ProduitDAO.getProduit(idProduit);
            ProduitViewModel p = new ProduitViewModel(pDAO.idProduitDAO, pDAO.nomProduitDAO);
            return p;
        }

        public static ObservableCollection<ProduitViewModel> listeProduit()
        {
            ObservableCollection<ProduitDAO> lDAO = ProduitDAO.listeProduit();
            ObservableCollection<ProduitViewModel> l = new ObservableCollection<ProduitViewModel>();
            foreach (ProduitDAO element in lDAO)
            {

                ProduitViewModel p = new ProduitViewModel(element.idProduitDAO, element.nomProduitDAO);
                l.Add(p);
            }
            return l;
        }


        public static void updateProduit(ProduitViewModel p)
        {
            ProduitDAO.updateProduit(new ProduitDAO(p.idProduitProperty, p.nomProduitProperty));
        }

        public static void supprimerProduit(int id)
        {
            ProduitDAO.supprimerProduit(id);
        }

        public static void insertProduit(ProduitViewModel p)
        {
            ProduitDAO.insertProduit(new ProduitDAO(p.idProduitProperty, p.nomProduitProperty));
        }

    }
}
