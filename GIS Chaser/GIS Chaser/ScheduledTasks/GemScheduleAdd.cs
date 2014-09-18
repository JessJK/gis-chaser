using System;
using System.Diagnostics;
using System.IO;
using GIS_Chaser.ScheduledTasks.Interfaces;
using Quartz;

namespace GIS_Chaser.ScheduledTasks
{
    public class GemScheduleAdd : IGemScheduleAdd, IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            Debug.Write("A gem is created");
        }
    }
}
