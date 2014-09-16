using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GIS_Chaser.Plumbing;
using GIS_Chaser.Models;

namespace GIS_Chaser.Services.Interfaces
{
    public interface IExtendUserTableStorage
    {
        void Persist(ExtendUserTable user);

        ExtendUserTable Retrieve(string id);

        void Delete(ExtendUserTable user);

        List<ExtendUserTable> GetAll();

        void Update(int id, int quantity);
    }
}
