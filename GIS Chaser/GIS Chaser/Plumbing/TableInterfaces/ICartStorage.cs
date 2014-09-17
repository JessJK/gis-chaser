using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GIS_Chaser.Models;
using GIS_Chaser.Plumbing;

namespace GIS_Chaser.Services.Interfaces
{
    public interface ICartStorage
    {
        void Persist(Cart item);

        Cart Retrieve(int id);

        void Delete(Cart item);

        IEnumerable<Cart> GetAll();
    }
}