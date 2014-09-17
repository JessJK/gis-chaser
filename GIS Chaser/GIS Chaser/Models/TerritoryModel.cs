using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GIS_Chaser.ScheduledTasks.Interfaces;

namespace GIS_Chaser.Models
{
    public class TerritoryModel
    {
        public ITerritorySchedulePoints _territorySchedulePoints { get; set; }

        public TerritoryModel (ITerritorySchedulePoints territorySchedulePoints)
        {
            _territorySchedulePoints = territorySchedulePoints;
        }
    }
}