using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiApiModels.Classes;

public class KiUserOwnedApplications :KiApplications
{
    public int? UserID { get; set; }

    public int? ApplicationID { get; set; }

    public bool Owned { get; set; }

    public DateTime? PurchaseDate { get; set; }

    public bool? Active { get; set; }

    /// <summary>
    /// Costruttore vuoto (necessario affinche avvengano letture da DB)
    /// </summary>
    public KiUserOwnedApplications()
    {
        
    }

    /// <summary>
    /// Costruttore per un dato applicazioni con applicazione posseduta dall'utente
    /// </summary>
    /// <param name="applicationData"></param>
    /// <param name="ownedApplications"></param>
    public KiUserOwnedApplications(KiApplications applicationData, KiUserOwnedApplications ownedApplications)
    {
        this.ID = applicationData.ID;
        this.Name = applicationData.Name;
        this.ShortDescription = applicationData.ShortDescription;
        this.LongDescription = applicationData.LongDescription;
        this.ReleaseDate = applicationData.ReleaseDate;
        this.Windows = applicationData.Windows;
        this.Mac = applicationData.Mac;
        this.Web = applicationData.Web;
        this.Android = applicationData.Android;
        this.IOS = applicationData.IOS;

        this.UserID = ownedApplications.UserID;
        this.ApplicationID = ownedApplications.ApplicationID;
        this.Owned = true;
        this.PurchaseDate = ownedApplications.PurchaseDate;
        this.Active = ownedApplications.Active;
    }


    /// <summary>
    /// Costruttore per un dato applicazioni con applicazione non posseduta dall'utente
    /// </summary>
    /// <param name="applicationData"></param>
    /// <param name="ownedApplications"></param>
    public KiUserOwnedApplications(KiApplications applicationData)
    {
        this.ID = applicationData.ID;
        this.Name = applicationData.Name;
        this.ShortDescription = applicationData.ShortDescription;
        this.LongDescription = applicationData.LongDescription;
        this.ReleaseDate = applicationData.ReleaseDate;
        this.Windows = applicationData.Windows;
        this.Mac = applicationData.Mac;
        this.Web = applicationData.Web;
        this.Android = applicationData.Android;
        this.IOS = applicationData.IOS;

        this.UserID = null;
        this.ApplicationID = applicationData.ID;
        this.Owned = false;
        this.PurchaseDate = null;
        this.Active = null;
    }

}
