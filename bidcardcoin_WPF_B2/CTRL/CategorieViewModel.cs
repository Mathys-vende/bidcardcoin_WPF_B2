using System;
using System.ComponentModel;
using bidcardcoin_WPF_B2.ORM;

namespace bidcardcoin_WPF_B2.CTRL
{
    public class CategorieViewModel 
    {
        private int idCategorie;
        private string nomCategorie;
        
        public CategorieViewModel() { }

        public CategorieViewModel(int id, string nomCategorie)
        {
            this.idCategorie = id;
            this.nomCategorieProperty = nomCategorie;
        }

        public int idCategorieProperty
        {
            get { return idCategorie; }
            set
            {
                idCategorie = value;
            }
        }
        public String nomCategorieProperty
        {
            get { return nomCategorie; }
            set
            {
                nomCategorie = value;
               
            }
        }
        

        /*public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string info)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(info));
                this.PropertyChanged(this, new PropertyChangedEventArgs(info));
                if ((info != "AgeProperty")&&(MainWindow.onglet != "ajouter"))
                {
                    CategorieORM.updatePersonne(this);
                }
            }
        }*/
    }
}
