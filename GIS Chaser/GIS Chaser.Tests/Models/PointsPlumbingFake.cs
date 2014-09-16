using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GIS_Chaser.Plumbing;
using GIS_Chaser.Services.Interfaces;

namespace GIS_Chaser.Tests.Models
{
    class PointsPlumbingFake : IPointsStorage
    {

        public void Persist(Plumbing.Points points)
        {
            throw new NotImplementedException();
        }

        public Plumbing.Points Retrieve(string id)
        {
            return new Points(){AspNetUsersId = "user",Quantity = 5};
        }

        public void Delete(Plumbing.Points item)
        {
            throw new NotImplementedException();
        }

        public List<Plumbing.Points> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(int id, int quantity)
        {
            throw new NotImplementedException();
        }
    }
}
