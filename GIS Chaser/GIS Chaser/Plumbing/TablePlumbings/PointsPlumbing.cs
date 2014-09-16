using System;
using System.Collections.Generic;
using System.Linq;
using GIS_Chaser.Services.Interfaces;

namespace GIS_Chaser.Plumbing.TablePlumbings
{
    public class PointsPlumbing : IPointsStorage
    {
        public void Persist(Points item)
        {
            using (Repository<Points> dataAccessHelper = new Repository<Points>(new Configuration()))
            {
                dataAccessHelper.Add(item);
                dataAccessHelper.SaveChanges();
            }
        }

        public Points Retrieve(string id)
        {
            using (Repository<Points> dataAccessHelper = new Repository<Points>(new Configuration()))
            {
                return dataAccessHelper.GetAll().First(w => w.AspNetUsersId == id);
            }
        }

        public void Delete(Points item)
        {
            using (Repository<Points> dataAccessHelper = new Repository<Points>(new Configuration()))
            {
                dataAccessHelper.Delete(item);
            }
        }


        public List<Points> GetAll()
        {
            using (Repository<Points> dataAccessHelper = new Repository<Points>(new Configuration()))
            {
                return dataAccessHelper.GetAll().ToList();
            }
        }


        public void Update(int id, int quantity)
        {
            using (Repository<Points> dataAccessHelper = new Repository<Points>(new Configuration()))
            {
                var tempo = Convert.ToInt32(dataAccessHelper.FindById(id).Quantity) - quantity;
                dataAccessHelper.FindById(id).Quantity = tempo;
                dataAccessHelper.SaveChanges();
            }
        }
    }
}
