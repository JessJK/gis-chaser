using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GIS_Chaser.Controllers
{
    public class SchedulerController : ApiController
    {
        // GET: api/Scheduler
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Scheduler/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Scheduler
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Scheduler/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Scheduler/5
        public void Delete(int id)
        {
        }
    }
}
