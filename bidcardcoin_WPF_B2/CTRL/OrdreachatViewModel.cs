using System;
using System.ComponentModel;
using bidcardcoin_WPF_B2.ORM;

namespace bidcardcoin_WPF_B2.CTRL
{
    public class OrdreachatViewModel : INotifyPropertyChanged

    {
    private int idProduit;
    private int idAcheteur;
    private int idEnchere;
    private float montantMax;
    private string adresseDepot;

    
    public int IDProduit;
    public string NomProduit;
    public int IDEnchere;
    public string NomEnchere;
    public int MontantMax;
    public string AdresseDepot;
    
    private string concat = "Ajouter ";

    public OrdreachatViewModel()
    {
        
        
    }

    public OrdreachatViewModel(int idProduit, int idAcheteur,int idEnchere, float montantMax,string adresseDepot )
    {
        this.idProduit = idProduit;
        this.idAcheteur = idAcheteur;
        this.idEnchere = idEnchere;
        this.montantMax = montantMax;
        this.adresseDepot = adresseDepot;
    }

    public OrdreachatViewModel(int IdProduit, string NomProduit, int IDEnchere, string NomEnchere, int MontantMax, string AdresseDepot)
    {
        this.IDProduit = IdProduit;
        this.NomProduit = NomProduit;
        this.IDEnchere = IDEnchere;
        this.NomEnchere = NomEnchere;
        this.MontantMax = MontantMax;
        this.AdresseDepot = AdresseDepot;

    }

    public int idProduitProperty
    {
        get { return idProduit; }
        set
        {
            idProduit = value;
            OnPropertyChanged("idProduitProperty");
        }

    }

    public int idAcheteurProperty
    {
        get { return idAcheteur; }
        set
        {
            idAcheteur = value;

            OnPropertyChanged("idCategorieProperty");
        }
    }

    public int idEnchereProperty
    {
        get { return idEnchere; }
        set
        {
            idEnchere = value;

            OnPropertyChanged("idCategorieProperty");
        }
    }
    public float montantMaxProperty
    {
        get { return montantMax; }
        set
        {
            montantMax = value;

            OnPropertyChanged("idCategorieProperty");
        }
    }
    public String adresseDepotProperty
    {
        get { return adresseDepot; }
        set
        {
            adresseDepot = value;

            OnPropertyChanged("idCategorieProperty");
        }
    }
    
    
    public int IDProduitProperty
    {
        get { return IDProduit; }
        set
        {
            IDProduit = value;
            OnPropertyChanged("IDProduitProperty");
        }

    }
    public String NomProduitProperty
    {
        get { return NomProduit; }
        set
        {
            NomProduit = value;
            OnPropertyChanged("NomProduitProperty");
        }

    }
    public int IDEnchereProperty
    {
        get { return IDEnchere; }
        set
        {
            IDEnchere = value;
            OnPropertyChanged("IDEnchereProperty");
        }

    }
    public String NomEnchereProperty
    {
        get { return NomEnchere; }
        set
        {
            NomEnchere = value;
            OnPropertyChanged("NomEnchereProperty");
        }

    }
    public int MontantMaxProperty
    {
        get { return MontantMax; }
        set
        {
            MontantMax = value;
            OnPropertyChanged("MontantMaxProperty");
        }

    }
    public string AdresseDepotProperty
    {
        get { return AdresseDepot; }
        set
        {
            AdresseDepot = value;
            OnPropertyChanged("AdresseDepotProperty");
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