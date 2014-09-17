using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GIS_Chaser.Services.Interfaces;

namespace GIS_Chaser.Models
{
    public class UserModel
    {
        private IExtendUserTableStorage _pointsStorage { get; set; }

        public UserModel(IExtendUserTableStorage pointsStoragestorage)
        {
            _pointsStorage = pointsStoragestorage;
        }

        public int GetPoints(string id)
        {
            var tempPoints = _pointsStorage.Retrieve(id);
            return tempPoints.TotalPoints;
        }
    }
}