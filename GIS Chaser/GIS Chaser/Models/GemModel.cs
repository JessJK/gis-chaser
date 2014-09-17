using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GIS_Chaser.Models.Interfaces;
using GIS_Chaser.Services.Interfaces;

namespace GIS_Chaser.Models
{
    public class GemModel : IGemModel
    {
        private IGemStorage _pointsStorage { get; set; }

        public GemModel(IGemStorage pointsStoragestorage)
        {
            _pointsStorage = pointsStoragestorage;
        }

        public int GetGems(string id)
        {
            var tempPoints = _pointsStorage.GetAll();
            return tempPoints.Count;
        }
    }
}