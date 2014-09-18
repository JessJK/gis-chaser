using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GIS_Chaser.Plumbing;
using GIS_Chaser.Services.Interfaces;

namespace GIS_Chaser.Tests.Models
{
    class PointsPlumbingFake : IExtendUserTableStorage
    {

        public void Persist(Plumbing.ExtendUserTable user)
        {
            throw new NotImplementedException();
        }

        Plumbing.ExtendUserTable IExtendUserTableStorage.Retrieve(string id)
        {
            return new ExtendUserTable() { AspNetUsersId = "user", TotalPoints = 5 };
        }

        public void Delete(Plumbing.ExtendUserTable user)
        {
            throw new NotImplementedException();
        }

        List<Plumbing.ExtendUserTable> IExtendUserTableStorage.GetAll()
        {
            throw new NotImplementedException();
        }


        public void Update(int id, int quantity)
        {
            throw new NotImplementedException();
        }
    }
}
