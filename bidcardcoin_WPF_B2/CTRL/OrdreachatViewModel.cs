using System;
using System.ComponentModel;
using bidcardcoin_WPF_B2.ORM;

namespace bidcardcoin_WPF_B2.CTRL
{
    public class OrdreachatViewModel : INotifyPropertyChanged

    {
    private ProduitViewModel idOAProduit;
    private AcheteurViewModel idOAAcheteur;
    private EnchereViewModel idOAEnchere;
    private float montantMax;
    private string adresseDepot;
    
    private string concat = "Ajouter ";

    public OrdreachatViewModel()
    {
        
        
    }

    public OrdreachatViewModel(ProduitViewModel idOAProduit, AcheteurViewModel idOAAcheteur,EnchereViewModel idOAEnchere, float montantMax,string adresseDepot )
    {
        this.idOAProduit = idOAProduit;
        this.idOAAcheteur = idOAAcheteur;
        this.idOAEnchere = idOAEnchere;
        this.montantMax = montantMax;
        this.adresseDepot = adresseDepot;
    }
    public ProduitViewModel idProduitOAProperty
    {
        get { return idOAProduit; }
        set
        {
            idOAProduit = value;
            OnPropertyChanged("idProduitProperty");
        }

    }

    public AcheteurViewModel idAcheteurOAProperty
    {
        get { return idOAAcheteur; }
        set
        {
            idOAAcheteur = value;

            OnPropertyChanged("idCategorieProperty");
        }
    }

    public EnchereViewModel idEnchereOAProperty
    {
        get { return idOAEnchere; }
        set
        {
            idOAEnchere = value;

            OnPropertyChanged("idCategorieProperty");
        }
    }
    public float montantMaxOAProperty
    {
        get { return montantMax; }
        set
        {
            montantMax = value;

            OnPropertyChanged("idCategorieProperty");
        }
    }
    public String adresseDepotOAProperty
    {
        get { return adresseDepot; }
        set
        {
            adresseDepot = value;

            OnPropertyChanged("idCategorieProperty");
        }
    }
    
    


    public event PropertyChangedEventHandler PropertyChanged;

    private void OnPropertyChanged(string info)
    {
        PropertyChangedEventHandler handler = PropertyChanged;
        if (handler != null)
        {
            handler(this, new PropertyChangedEventArgs(info));
            this.PropertyChanged(this, new PropertyChangedEventArgs(info));
            OrdreachatORM.updateOrdreachat(this);
        }
    }
    }
}