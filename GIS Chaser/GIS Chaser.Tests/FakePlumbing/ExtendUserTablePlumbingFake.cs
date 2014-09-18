using System;
using System.Collections.Generic;
using GIS_Chaser.Plumbing;
using GIS_Chaser.Plumbing.TableInterfaces;

namespace GIS_Chaser.Tests.FakePlumbing
{
    class ExtendUserTablePlumbingFake : IExtendUserTableStorage
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
