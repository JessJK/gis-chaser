using System.Diagnostics;
using GIS_Chaser.Models;
using GIS_Chaser.Plumbing.TableInterfaces;
using GIS_Chaser.Plumbing.TablePlumbings;
using Quartz;

namespace GIS_Chaser.ScheduledTasks
{
    public class GemScheduleAdd : IJob
    {

        public void Execute(IJobExecutionContext context)
        {
            GemModel gemModel = new GemModel(new GemsPlumbing());
            gemModel.AutoAddGem();
        }
    }
}
