using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GIS_Chaser.Models;
using GIS_Chaser.Plumbing.TableInterfaces;
using GIS_Chaser.ScheduledTasks.Interfaces;

namespace GIS_Chaser.Controllers
{
    public class GemController : ApiController
    {
        private IGemStorage _gemStorage { get; set; }
        private IGemScheduleAdd _gemAdd { get; set; }

        public GemController(IGemStorage gemStorage, IGemScheduleAdd gemAdd)
        {
            _gemStorage = gemStorage;
            _gemAdd = gemAdd;
        }

        [Route("api/gems/{customerId}")]
        public int Get(string customerId)
        {
            GemModel gemModel = new GemModel(_gemStorage, _gemAdd);
            return gemModel.GetGems(customerId);
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
