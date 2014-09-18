using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GIS_Chaser.Plumbing.TableInterfaces;
using GIS_Chaser.ScheduledTasks.Interfaces;

namespace GIS_Chaser.Models
{
    public class GemModel
    {
        private IGemStorage _gemStorage { get; set; }
        private IGemScheduleAdd _gemAdd { get; set; }

        public GemModel(IGemStorage gemStorage, IGemScheduleAdd gemAdd)
        {
            _gemStorage = gemStorage;
            _gemAdd = gemAdd;
        }

        public int GetGems(string id)
        {
            return _gemStorage.GetAll().Count;
        }


    }
}