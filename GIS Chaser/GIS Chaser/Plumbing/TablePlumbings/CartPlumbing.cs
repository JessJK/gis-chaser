using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GIS_Chaser.Services.Interfaces;

namespace GIS_Chaser.Plumbing.TablePlumbings
{
    public class CartPlumbing : ICartStorage
    {
        public void Persist(Cart item)
        {
            using (Repository<Cart> dataAccessHelper = new Repository<Cart>(new Configuration()))
            {
                dataAccessHelper.Add(item);
                dataAccessHelper.SaveChanges();
            }
        }


        public Cart Retrieve(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(Cart item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cart> GetAll()
        {
            using (var dataAccessHelper = new Repository<Cart>(new Configuration()))
            {
                return dataAccessHelper.GetAll();
            }
 
        }

        //public IEnumerable<Cart> GetCartbyId(string id)
        //{
        //    IEnumerable<Cart> temp;
        //    using (var dataAccessHelper = new Repository<Cart>(new Configuration()))
        //    {
        //        temp = dataAccessHelper.FindById(id);
        //    }
        //    return temp;
        //}
    }
}