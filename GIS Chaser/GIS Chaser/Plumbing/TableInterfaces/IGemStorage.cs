﻿using System.Collections.Generic;
using GIS_Chaser.Models;

namespace GIS_Chaser.Plumbing.TableInterfaces
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
