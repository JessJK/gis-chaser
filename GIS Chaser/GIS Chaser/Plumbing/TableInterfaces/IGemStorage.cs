using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using GIS_Chaser.Plumbing;

namespace GIS_Chaser.Services.Interfaces
{
    public interface IGemStorage
    {
        void Persist(Gems gem);

        Gems Retrieve(string id);

        void Delete(Gems gem);

        List<Gems> GetAll();

        void Update(int id, int quantity);
    }
}
