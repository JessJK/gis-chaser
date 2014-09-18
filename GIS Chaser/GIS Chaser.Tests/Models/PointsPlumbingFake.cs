using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GIS_Chaser.Plumbing;
using GIS_Chaser.Plumbing.TableInterfaces;

namespace GIS_Chaser.Tests.Models
{
    class PointsPlumbingFake : IExtendUserTableStorage
    {
        public void Persist(ExtendUserTable user)
        {
            throw new NotImplementedException();
        }

        public Plumbing.ExtendUserTable Retrieve(string id)
        {
            return new ExtendUserTable() { AspNetUsersId = "user", TotalPoints = 5 };
        }

        public void Delete(ExtendUserTable user)
        {
            throw new NotImplementedException();
        }

        public List<ExtendUserTable> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(int id, int quantity)
        {
            throw new NotImplementedException();
        }
    }
}
