using System;

using Mindscape.LightSpeed;
using Mindscape.LightSpeed.Validation;
using Mindscape.LightSpeed.Linq;

namespace MapDrawTest.Models
{
  [Serializable]
  [System.CodeDom.Compiler.GeneratedCode("LightSpeedModelGenerator", "1.0.0.0")]
  [System.ComponentModel.DataObject]
  [Table("CoordinateData")]
  public partial class CoordinateDatum : Entity<string>
  {
    #region Fields
  
    [ValueField]
    private Microsoft.SqlServer.Types.SqlGeography _lat;
    [ValueField]
    private Microsoft.SqlServer.Types.SqlGeography _long;

    #endregion
    
    #region Field attribute and view names
    
    /// <summary>Identifies the Lat entity attribute.</summary>
    public const string LatField = "Lat";
    /// <summary>Identifies the Long entity attribute.</summary>
    public const string LongField = "Long";


    #endregion
    
    #region Properties



    [System.Diagnostics.DebuggerNonUserCode]
    public Microsoft.SqlServer.Types.SqlGeography Lat
    {
      get { return Get(ref _lat, "Lat"); }
      set { Set(ref _lat, value, "Lat"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public Microsoft.SqlServer.Types.SqlGeography Long
    {
      get { return Get(ref _long, "Long"); }
      set { Set(ref _long, value, "Long"); }
    }

    #endregion
  }




  /// <summary>
  /// Provides a strong-typed unit of work for working with the GisChaser model.
  /// </summary>
  [System.CodeDom.Compiler.GeneratedCode("LightSpeedModelGenerator", "1.0.0.0")]
  public partial class GisChaserUnitOfWork : Mindscape.LightSpeed.UnitOfWork
  {

    public System.Linq.IQueryable<CoordinateDatum> CoordinateData
    {
      get { return this.Query<CoordinateDatum>(); }
    }
    
  }

}
