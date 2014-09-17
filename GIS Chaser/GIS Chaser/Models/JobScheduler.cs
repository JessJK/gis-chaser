using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GIS_Chaser.ScheduledTasks;
using Quartz;
using Quartz.Impl;

namespace GIS_Chaser.Models
{
    public class JobScheduler
    {
        public static void Start()
        {
            IScheduler scheduler = StdSchedulerFactory.GetDefaultScheduler();
            scheduler.Start();

            IJobDetail job = JobBuilder.Create<AppendToFile>().Build();

            ITrigger trigger = TriggerBuilder.Create()
                .StartNow()
                .WithSimpleSchedule(x => x
                .WithIntervalInSeconds(10)
                .RepeatForever())
                //.WithDailyTimeIntervalSchedule
                //  (s =>
                //     s.WithIntervalInSeconds(5)
                //    .OnEveryDay()
                //    .StartingDailyAt(TimeOfDay.HourAndMinuteOfDay(0, 0))
                //  )
                .Build();

            scheduler.ScheduleJob(job, trigger);
        }
    }
}