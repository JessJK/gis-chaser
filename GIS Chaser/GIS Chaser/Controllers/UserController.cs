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
    public class UserController : ApiController
    {
        private IExtendUserTableStorage _userStorage { get; set; }

        public UserController(IExtendUserTableStorage userStorage)
        {
            _userStorage = userStorage;
        }

        //Get
        [Route("api/user/{customerId}")]
        public int Get(string customerId)
        {
            UserModel userModel = new UserModel(_userStorage);
            return userModel.GetPoints(customerId);
        }

        // GET api/UserController
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // POST api/UserController
        public void Post([FromBody]string value)
        {
        }

        // PUT api/UserController/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/UserController/5
        public void Delete(int id)
        {
        }
    }
}