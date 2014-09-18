using System;

using Mindscape.LightSpeed;
using Mindscape.LightSpeed.Validation;
using Mindscape.LightSpeed.Linq;

namespace GIS_Chaser.Models
{
  [Serializable]
  [System.CodeDom.Compiler.GeneratedCode("LightSpeedModelGenerator", "1.0.0.0")]
  [System.ComponentModel.DataObject]
  [Table("AspNetUsers")]
  public partial class AspNetUser : Entity<string>
  {
    #region Fields
  
    [ValidateEmailAddress]
    [ValidateLength(0, 256)]
    private string _email;
    private bool _emailConfirmed;
    private string _passwordHash;
    private string _securityStamp;
    private string _phoneNumber;
    private bool _phoneNumberConfirmed;
    private bool _twoFactorEnabled;
    private System.Nullable<System.DateTime> _lockoutEndDateUtc;
    private bool _lockoutEnabled;
    private int _accessFailedCount;
    [ValidatePresence]
    [ValidateLength(0, 256)]
    private string _userName;

    #endregion
    
    #region Field attribute and view names
    
    /// <summary>Identifies the Email entity attribute.</summary>
    public const string EmailField = "Email";
    /// <summary>Identifies the EmailConfirmed entity attribute.</summary>
    public const string EmailConfirmedField = "EmailConfirmed";
    /// <summary>Identifies the PasswordHash entity attribute.</summary>
    public const string PasswordHashField = "PasswordHash";
    /// <summary>Identifies the SecurityStamp entity attribute.</summary>
    public const string SecurityStampField = "SecurityStamp";
    /// <summary>Identifies the PhoneNumber entity attribute.</summary>
    public const string PhoneNumberField = "PhoneNumber";
    /// <summary>Identifies the PhoneNumberConfirmed entity attribute.</summary>
    public const string PhoneNumberConfirmedField = "PhoneNumberConfirmed";
    /// <summary>Identifies the TwoFactorEnabled entity attribute.</summary>
    public const string TwoFactorEnabledField = "TwoFactorEnabled";
    /// <summary>Identifies the LockoutEndDateUtc entity attribute.</summary>
    public const string LockoutEndDateUtcField = "LockoutEndDateUtc";
    /// <summary>Identifies the LockoutEnabled entity attribute.</summary>
    public const string LockoutEnabledField = "LockoutEnabled";
    /// <summary>Identifies the AccessFailedCount entity attribute.</summary>
    public const string AccessFailedCountField = "AccessFailedCount";
    /// <summary>Identifies the UserName entity attribute.</summary>
    public const string UserNameField = "UserName";


    #endregion
    
    #region Relationships

    [ReverseAssociation("AspNetUsers")]
    private readonly EntityCollection<Gems> _gems = new EntityCollection<Gems>();
    [ReverseAssociation("AspNetUsers")]
    private readonly EntityCollection<ExtendUserTable> _extendUserTables = new EntityCollection<ExtendUserTable>();


    #endregion
    
    #region Properties

    [System.Diagnostics.DebuggerNonUserCode]
    public EntityCollection<Gems> Gems
    {
      get { return Get(_gems); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public EntityCollection<ExtendUserTable> ExtendUserTables
    {
      get { return Get(_extendUserTables); }
    }


    [System.Diagnostics.DebuggerNonUserCode]
    public string Email
    {
      get { return Get(ref _email, "Email"); }
      set { Set(ref _email, value, "Email"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public bool EmailConfirmed
    {
      get { return Get(ref _emailConfirmed, "EmailConfirmed"); }
      set { Set(ref _emailConfirmed, value, "EmailConfirmed"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public string PasswordHash
    {
      get { return Get(ref _passwordHash, "PasswordHash"); }
      set { Set(ref _passwordHash, value, "PasswordHash"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public string SecurityStamp
    {
      get { return Get(ref _securityStamp, "SecurityStamp"); }
      set { Set(ref _securityStamp, value, "SecurityStamp"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public string PhoneNumber
    {
      get { return Get(ref _phoneNumber, "PhoneNumber"); }
      set { Set(ref _phoneNumber, value, "PhoneNumber"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public bool PhoneNumberConfirmed
    {
      get { return Get(ref _phoneNumberConfirmed, "PhoneNumberConfirmed"); }
      set { Set(ref _phoneNumberConfirmed, value, "PhoneNumberConfirmed"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public bool TwoFactorEnabled
    {
      get { return Get(ref _twoFactorEnabled, "TwoFactorEnabled"); }
      set { Set(ref _twoFactorEnabled, value, "TwoFactorEnabled"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public System.Nullable<System.DateTime> LockoutEndDateUtc
    {
      get { return Get(ref _lockoutEndDateUtc, "LockoutEndDateUtc"); }
      set { Set(ref _lockoutEndDateUtc, value, "LockoutEndDateUtc"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public bool LockoutEnabled
    {
      get { return Get(ref _lockoutEnabled, "LockoutEnabled"); }
      set { Set(ref _lockoutEnabled, value, "LockoutEnabled"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public int AccessFailedCount
    {
      get { return Get(ref _accessFailedCount, "AccessFailedCount"); }
      set { Set(ref _accessFailedCount, value, "AccessFailedCount"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public string UserName
    {
      get { return Get(ref _userName, "UserName"); }
      set { Set(ref _userName, value, "UserName"); }
    }

    #endregion
  }


  [Serializable]
  [System.CodeDom.Compiler.GeneratedCode("LightSpeedModelGenerator", "1.0.0.0")]
  [System.ComponentModel.DataObject]
  public partial class Gems : Entity<int>
  {
    #region Fields
  
    private string _type;
    private string _pointsValue;
    private string _lat;
    private string _lng;
    [Column("AspNetUsers")]
    private string _aspNetUsersId;

    #endregion
    
    #region Field attribute and view names
    
    /// <summary>Identifies the Type entity attribute.</summary>
    public const string TypeField = "Type";
    /// <summary>Identifies the PointsValue entity attribute.</summary>
    public const string PointsValueField = "PointsValue";
    /// <summary>Identifies the lat entity attribute.</summary>
    public const string latField = "lat";
    /// <summary>Identifies the lng entity attribute.</summary>
    public const string lngField = "lng";
    /// <summary>Identifies the AspNetUsersId entity attribute.</summary>
    public const string AspNetUsersIdField = "AspNetUsersId";


    #endregion
    
    #region Relationships

    [ReverseAssociation("Gems")]
    private readonly EntityHolder<AspNetUser> _aspNetUsers = new EntityHolder<AspNetUser>();


    #endregion
    
    #region Properties

    [System.Diagnostics.DebuggerNonUserCode]
    public AspNetUser AspNetUsers
    {
      get { return Get(_aspNetUsers); }
      set { Set(_aspNetUsers, value); }
    }


    [System.Diagnostics.DebuggerNonUserCode]
    public string Type
    {
      get { return Get(ref _type, "Type"); }
      set { Set(ref _type, value, "Type"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public string PointsValue
    {
      get { return Get(ref _pointsValue, "PointsValue"); }
      set { Set(ref _pointsValue, value, "PointsValue"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public string lat
    {
      get { return Get(ref _lat, "lat"); }
      set { Set(ref _lat, value, "lat"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public string lng
    {
      get { return Get(ref _lng, "lng"); }
      set { Set(ref _lng, value, "lng"); }
    }

    /// <summary>Gets or sets the ID for the <see cref="AspNetUsers" /> property.</summary>
    [System.Diagnostics.DebuggerNonUserCode]
    public string AspNetUsersId
    {
      get { return Get(ref _aspNetUsersId, "AspNetUsersId"); }
      set { Set(ref _aspNetUsersId, value, "AspNetUsersId"); }
    }

    #endregion
  }


  [Serializable]
  [System.CodeDom.Compiler.GeneratedCode("LightSpeedModelGenerator", "1.0.0.0")]
  [System.ComponentModel.DataObject]
  public partial class ExtendUserTable : Entity<int>
  {
    #region Fields
  
    private int _totalPoints;
    [Column("AspNetUsers")]
    private string _aspNetUsersId;

    #endregion
    
    #region Field attribute and view names
    
    /// <summary>Identifies the TotalPoints entity attribute.</summary>
    public const string TotalPointsField = "TotalPoints";
    /// <summary>Identifies the AspNetUsersId entity attribute.</summary>
    public const string AspNetUsersIdField = "AspNetUsersId";


    #endregion
    
    #region Relationships

    [ReverseAssociation("ExtendUserTables")]
    private readonly EntityHolder<AspNetUser> _aspNetUsers = new EntityHolder<AspNetUser>();


    #endregion
    
    #region Properties

    [System.Diagnostics.DebuggerNonUserCode]
    public AspNetUser AspNetUsers
    {
      get { return Get(_aspNetUsers); }
      set { Set(_aspNetUsers, value); }
    }


    [System.Diagnostics.DebuggerNonUserCode]
    public int TotalPoints
    {
      get { return Get(ref _totalPoints, "TotalPoints"); }
      set { Set(ref _totalPoints, value, "TotalPoints"); }
    }

    /// <summary>Gets or sets the ID for the <see cref="AspNetUsers" /> property.</summary>
    [System.Diagnostics.DebuggerNonUserCode]
    public string AspNetUsersId
    {
      get { return Get(ref _aspNetUsersId, "AspNetUsersId"); }
      set { Set(ref _aspNetUsersId, value, "AspNetUsersId"); }
    }

    #endregion
  }




  /// <summary>
  /// Provides a strong-typed unit of work for working with the Points_LightSpeedModel model.
  /// </summary>
  [System.CodeDom.Compiler.GeneratedCode("LightSpeedModelGenerator", "1.0.0.0")]
  public partial class Points_LightSpeedModelUnitOfWork : Mindscape.LightSpeed.UnitOfWork
  {

    public System.Linq.IQueryable<AspNetUser> AspNetUsers
    {
      get { return this.Query<AspNetUser>(); }
    }
    
    public System.Linq.IQueryable<Gems> Gems
    {
      get { return this.Query<Gems>(); }
    }
    
    public System.Linq.IQueryable<ExtendUserTable> ExtendUserTables
    {
      get { return this.Query<ExtendUserTable>(); }
    }
    
  }

}
