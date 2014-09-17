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
            IJobDetail job = JobBuilder.Create<AppendToFile>().Build();
            IJobDetail job2 = JobBuilder.Create<GemScheduleAdd>().Build();
            IJobDetail job3 = JobBuilder.Create<TerritorySchedulePoints>().Build();

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

            ITrigger trigger2 = TriggerBuilder.Create()
                .StartNow()
                .WithSimpleSchedule(x => x
                .WithIntervalInSeconds(10)
                .RepeatForever())
                .Build();

            ITrigger trigger3 = TriggerBuilder.Create()
                .StartNow()
                .WithSimpleSchedule(x => x
                .WithIntervalInSeconds(10)
                .RepeatForever())
                .Build();

            IScheduler scheduler = StdSchedulerFactory.GetDefaultScheduler();
            scheduler.Start();

            scheduler.ScheduleJob(job, trigger);
            scheduler.ScheduleJob(job2, trigger2);
            scheduler.ScheduleJob(job3, trigger3);
        }
    }
}