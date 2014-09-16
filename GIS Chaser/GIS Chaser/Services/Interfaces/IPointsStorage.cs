using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GIS_Chaser.Plumbing;
using GIS_Chaser.Models;

namespace GIS_Chaser.Services.Interfaces
{
    public interface IPointsStorage
    {
        void Persist(Points points);

        Points Retrieve(string id);

        void Delete(Points item);

        List<Points> GetAll();

        void Update(int id, int quantity);
    }
}
