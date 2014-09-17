using System.Diagnostics;
using GIS_Chaser.ScheduledTasks.Interfaces;
using Quartz;

namespace GIS_Chaser.ScheduledTasks
{
    public class TerritorySchedulePoints : ITerritorySchedulePoints, IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            Debug.Write("Territory points are awarded");
        }
    }
}