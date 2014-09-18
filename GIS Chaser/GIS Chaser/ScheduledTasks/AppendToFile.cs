using System;
using System.IO;
using Quartz;

namespace GIS_Chaser.ScheduledTasks
{
    public class AppendToFile : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            const string newFileName = "C:\\Windows/Temp/GIS_Chaser_Schedule_Test.csv";
            string infoLine = "Despair not, for the time until you graduate be-ith " + DifferenceInDays() + Environment.NewLine;
            GetValue(newFileName, infoLine);
        }

        private static double DifferenceInDays()
        {
            double differenceInDays = TimeSpan().TotalHours;
            return differenceInDays;
        }

        private static TimeSpan TimeSpan()
        {
            DateTime coarseEnd = new DateTime(2014, 10, 3, 12, 0, 0);
            DateTime now = DateTime.Now;
            TimeSpan time = coarseEnd - now;
            return time;
        }

        private static void GetValue(string newFileName, string infoLine)
        {
            if (!File.Exists(newFileName))
            {
                File.WriteAllText(newFileName, infoLine);
            }
            else
            {
                File.AppendAllText(newFileName, infoLine);
            }
        }
    }

}