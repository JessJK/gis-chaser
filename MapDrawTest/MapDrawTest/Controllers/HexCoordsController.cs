using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MapDrawTest.Models;
using Mindscape.LightSpeed;
using Mindscape.LightSpeed.Linq;

namespace MapDrawTest.Controllers
{
    public class HexCoordsController : ApiController
    {
        // GET: api/HexCoords
        public IEnumerable<HexCoord> Get()
        {
            return null;
        }

        // GET: api/HexCoords/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/HexCoords
        public void Post([FromBody]IEnumerable<HexCoord> coords)
        {
            Console.WriteLine(coords);
            using (var uow = DataAccessHelper.GetUnitOfWork())
            {
                //uow.Add();
            }
        }

        // PUT: api/HexCoords/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/HexCoords/5
        public void Delete(int id)
        {
        }
    }

  
}
