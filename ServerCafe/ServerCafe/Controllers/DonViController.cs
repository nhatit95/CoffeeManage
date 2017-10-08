using ServerCafe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ServerCafe.Controllers
{
    public class DonViController : ApiController
    {
        ModelCafe db = new ModelCafe();
        // GET: api/DonVi
        public List<DonVi> Get()
        {
            return db.DonVis.ToList();
        }

        // GET: api/DonVi/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/DonVi
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/DonVi/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/DonVi/5
        public void Delete(int id)
        {
        }
    }
}
