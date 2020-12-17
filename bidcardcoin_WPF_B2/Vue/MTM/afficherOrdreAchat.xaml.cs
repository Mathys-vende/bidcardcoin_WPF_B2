using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using bidcardcoin_WPF_B2.CTRL;
using bidcardcoin_WPF_B2.DAL;
using bidcardcoin_WPF_B2.ORM;

namespace bidcardcoin_WPF_B2.Vue.MTM
{
    public partial class afficherOrdreAchat : UserControl
    {

        private int selectedEnchereId;
        private int selectedProduitId;

        private OrdreachatViewModel myDataObjectOrdreachat;
        public ObservableCollection<OrdreachatViewModel> Ordreachat;

        private AcheteurViewModel myDataObjectAcheteur;
        public ObservableCollection<AcheteurViewModel> Acheteur;




        public afficherOrdreAchat()
        {
            InitializeComponent();

            DALConnection.OpenConnection();

            loadOrdreAchat();

            loadAcheteur();
        }

        void loadAcheteur()
        {
            Acheteur = AcheteurORM.listeAcheteur();
            myDataObjectAcheteur = new AcheteurViewModel();
            //LIEN AVEC la VIEW
            AcheteurCombobox.ItemsSource = Acheteur; // bind de la liste avec la source, permettant le binding.#2#*/

        }
        private void listeOrdreAchat_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if ((listeOrdreAchat.SelectedIndex < Ordreachat.Count) && (listeOrdreAchat.SelectedIndex >= 0))
            {
                selectedEnchereId = (Ordreachat.ElementAt<OrdreachatViewModel>(listeOrdreAchat.SelectedIndex).idEnchereOAProperty.idEnchereProperty);
                selectedProduitId = (Ordreachat.ElementAt<OrdreachatViewModel>(listeOrdreAchat.SelectedIndex).idProduitOAProperty.idProduitProperty);
            }
            
        }
        void loadOrdreAchat()
        {
            Ordreachat = OrdreachatORM.listeOrdreachat();
            myDataObjectOrdreachat = new OrdreachatViewModel();
            //LIEN AVEC la VIEW
            listeOrdreAchat.ItemsSource = Ordreachat; // bind de la liste avec la source, permettant le binding.#2#*/

        }

        private void ProduitCategorieButton_Click(object sender, RoutedEventArgs e)
        {

            Ordreachat = OrdreachatORM.getOrdreachat(Convert.ToInt32(AcheteurCombobox.SelectedValue.ToString()));
            myDataObjectOrdreachat = new OrdreachatViewModel();
            listeOrdreAchat.DataContext = myDataObjectOrdreachat;
            listeOrdreAchat.ItemsSource = Ordreachat;
            listeOrdreAchat.Items.Refresh();


        }

        private void SupprButton(object sender, RoutedEventArgs routedEventArgs)
        {
            if (listeOrdreAchat.SelectedItem is OrdreachatViewModel)
            {
                OrdreachatViewModel toRemove = (OrdreachatViewModel) listeOrdreAchat.SelectedItem;
                Ordreachat.Remove(toRemove);
                listeOrdreAchat.Items.Refresh();
                OrdreachatORM.supprimerOrdreachat(Convert.ToInt32(AcheteurCombobox.SelectedValue.ToString()),
                    selectedEnchereId, selectedProduitId);

            }
        }
    }
}
