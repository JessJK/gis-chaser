﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GIS_Chaser.Models;
using GIS_Chaser.Plumbing.TableInterfaces;

namespace GIS_Chaser.Plumbing.TablePlumbings

{
    public class GemsPlumbing : IGemStorage
    {
        public void Persist(Gems gem)
        {
            using (Repository<Gems> dataAccessHelper = new Repository<Gems>(new Configuration()))
            {
                dataAccessHelper.Add(gem);
                dataAccessHelper.SaveChanges();
            }
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