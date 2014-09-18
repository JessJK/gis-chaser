using System;
using System.Collections.Generic;
using System.Linq;
using GIS_Chaser.Models;
using GIS_Chaser.Plumbing;
using GIS_Chaser.Plumbing.TableInterfaces;

namespace GIS_Chaser.Tests.FakePlumbing

{
    public class GemsPlumbingFake : IGemStorage
    {

        public Gems TempGem { get; set; }

        public void Persist(Gems gem)
        {
            TempGem = gem;
        }

        public Gems Retrieve(string id)
        {
            return TempGem;
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