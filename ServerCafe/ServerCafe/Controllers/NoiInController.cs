using ServerCafe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ServerCafe.Controllers
{
    public class NoiInController : ApiController
    {
        ModelCafe db = new ModelCafe();
        // GET: api/DonVi
        public List<NoiIn> Get()
        {
            return db.NoiIns.ToList();
        }

        // GET: api/NoIn/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/NoIn
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/NoIn/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/NoIn/5
        public void Delete(int id)
        {
        }
    }
}
