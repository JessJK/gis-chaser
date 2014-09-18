using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GIS_Chaser.Models;
using GIS_Chaser.Plumbing.TableInterfaces;

namespace GIS_Chaser.Controllers
{
    public class GemController : ApiController
    {
        private IGemStorage _gemStorage { get; set; }

        public GemController(IGemStorage gemStorage)
        {
            _gemStorage = gemStorage;
        }

        [Route("api/gems/{customerId}")]
        public List<Gems> Get(string customerId)
        {
            GemModel gemModel = new GemModel(_gemStorage);
            return gemModel.GetGemsForUser(customerId);
        }

        // GET: api/Gem
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // POST: api/Gem
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Gem/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Gem/5
        public void Delete(int id)
        {
        }
    }
}
