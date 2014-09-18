using System;
using System.Collections.Generic;
using System.Linq;
using GIS_Chaser.Plumbing.TableInterfaces;
using GIS_Chaser;

namespace GIS_Chaser.Plumbing.TablePlumbings
{
    public class ExtendUserTablePlumbing : IExtendUserTableStorage
    {
        public void Persist(ExtendUserTable user)
        {
            using (Repository<ExtendUserTable> dataAccessHelper = new Repository<ExtendUserTable>(new Configuration()))
            {
                dataAccessHelper.Add(user);
                dataAccessHelper.SaveChanges();
            }
        }

        public ExtendUserTable Retrieve(string id)
        {
            using (Repository<ExtendUserTable> dataAccessHelper = new Repository<ExtendUserTable>(new Configuration()))
            {
                return dataAccessHelper.GetAll().First(w => w.AspNetUsersId == id);
            }
        }

        public void Delete(ExtendUserTable user)
        {
            using (Repository<ExtendUserTable> dataAccessHelper = new Repository<ExtendUserTable>(new Configuration()))
            {
                dataAccessHelper.Delete(user);
            }
        }


        public List<ExtendUserTable> GetAll()
        {
            using (Repository<ExtendUserTable> dataAccessHelper = new Repository<ExtendUserTable>(new Configuration()))
            {
                return dataAccessHelper.GetAll().ToList();
            }
        }


        public void Update(int id, int quantity)
        {
            using (Repository<ExtendUserTable> dataAccessHelper = new Repository<ExtendUserTable>(new Configuration()))
            {
                var tempo = Convert.ToInt32(dataAccessHelper.FindById(id).TotalPoints) - quantity;
                dataAccessHelper.FindById(id).TotalPoints = tempo;
                dataAccessHelper.SaveChanges();
            }
        }

      
    }
}
