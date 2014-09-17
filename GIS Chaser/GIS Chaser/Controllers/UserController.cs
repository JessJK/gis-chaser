using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GIS_Chaser.Models;
using GIS_Chaser.Services.Interfaces;

namespace GIS_Chaser.Controllers
{
    public class UserController : ApiController
    {
        private IExtendUserTableStorage _userStorage { get; set; }

        public UserController(IExtendUserTableStorage userStorage)
        {
            _userStorage = userStorage;
        }

        //Get
        [Route("api/points/{customerId}")]
        public int Get(string customerId)
        {
            UserModel pointsModel = new UserModel(_userStorage);
            return pointsModel.GetPoints(customerId);
        }

        // GET api/PointsController
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // POST api/PointsController
        public void Post([FromBody]string value)
        {
        }

        // PUT api/PointsController/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/PointsController/5
        public void Delete(int id)
        {
        }
    }
}