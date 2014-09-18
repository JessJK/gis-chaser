using System.Diagnostics;
using Quartz;

namespace GIS_Chaser.ScheduledTasks
{
    public class TerritorySchedulePoints :  IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            Debug.Write("Territory points are awarded");
        }
    }
}