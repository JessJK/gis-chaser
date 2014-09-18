using System;
using System.Configuration;
using GIS_Chaser.Plumbing.Interfaces;

namespace GIS_Chaser.Plumbing
{
    public class Configuration : IConfiguration
    {
        public string ConnectionString
        {
            get { return ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString; }
        }

        //public string GetBaseUrl(string hiddenUrl)
        //{
        //    return String.Concat(ConfigurationManager.AppSettings["FrontEndBaseUrl"], hiddenUrl);
        //}

        //public string GetSplashUrl()
        //{
        //    return ConfigurationManager.AppSettings["SplashPageUrl"];
        //}
    }
}