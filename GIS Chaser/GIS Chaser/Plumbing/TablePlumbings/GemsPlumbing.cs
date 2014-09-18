using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GIS_Chaser.Services.Interfaces;

namespace GIS_Chaser.Plumbing.TablePlumbings
{
    public class GemsPlumbing : IGemStorage
    {
        public void Persist(Gems gem)
        {
            throw new NotImplementedException();
        }

        public Gems Retrieve(string id)
        {
            throw new NotImplementedException();
        }

        public void Delete(Gems gem)
        {
            throw new NotImplementedException();
        }

        public List<Gems> GetAll()
        {
            using (Repository<Gems> dataAccessHelper = new Repository<Gems>(new Configuration()))
            {
                return dataAccessHelper.GetAll().ToList();
            };
        }

        public void Update(int id, int quantity)
        {
            throw new NotImplementedException();
        }
    }
}