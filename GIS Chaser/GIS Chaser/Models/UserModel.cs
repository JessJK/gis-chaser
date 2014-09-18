using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GIS_Chaser.Plumbing.TableInterfaces;

namespace GIS_Chaser.Models
{
    public class UserModel
    {
        private IExtendUserTableStorage _userStorage { get; set; }

        public UserModel(IExtendUserTableStorage userStorage)
        {
            _userStorage = userStorage;
        }

        public int GetPoints(string id)
        {
            var tempPoints = _userStorage.Retrieve(id);
            return tempPoints.TotalPoints;
        }
    }
}