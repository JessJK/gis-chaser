using System.Collections.Generic;
using GIS_Chaser;

namespace GIS_Chaser.Plumbing.TableInterfaces
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
