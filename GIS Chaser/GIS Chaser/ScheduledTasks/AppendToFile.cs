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
            string infoLine = "The date and time is now " + DateTime.Now + Environment.NewLine;

            GetValue(newFileName, infoLine);
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