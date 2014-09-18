using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Linq.Expressions;
using MapDrawTest.Models;
using Mindscape.LightSpeed;
using Mindscape.LightSpeed.Linq;
using Mindscape.LightSpeed.Logging;
using System.Configuration;



namespace Mindscape.LightSpeed
{
  static  public class DataAccessHelper
    {

      public static readonly LightSpeedContext<GisChaserUnitOfWork> context = new LightSpeedContext<GisChaserUnitOfWork>()
      {
          ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString,
          IdentityMethod = IdentityMethod.IdentityColumn,
          QuoteIdentifiers = true,
          Logger = new TraceLogger()
      };

      /// <summary>
      /// To use create a using statement following this pattern
      /// using (LightSpeedModel1UnitOfWork uow = DataAccessHelper.GetUnitOfWork())
      ///   {
      ///       something = uow.tablename;
      ///   }
      /// </summary>
      /// <returns>functionality to talk to the database</returns>
      public static GisChaserUnitOfWork GetUnitOfWork() { return context.CreateUnitOfWork(); }
    }
}