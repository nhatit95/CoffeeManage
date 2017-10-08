using ServerCafe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ServerCafe.Controllers
{
    public class BanController : ApiController
    {
        ModelCafe db = new ModelCafe();
        // GET: api/Ban
        public List<Ban> Get()
        {
            return db.Bans.ToList();
        }

        // GET: api/Ban/5
        public Ban Get(string id)
        {
            return db.Bans.Find(id);
        }

        // POST: api/Ban
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Ban/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Ban/5
        public void Delete(int id)
        {
        }
    }
}
