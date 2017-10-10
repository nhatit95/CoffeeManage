using ServerCafe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ServerCafe.Controllers
{
    public class KhuVucController : ApiController
    {
        ModelCafe db = new ModelCafe();
        // GET: api/DonVi
        public List<KhuVuc> Get()
        {
            return db.KhuVucs.ToList();
        }

        // GET: api/KhuVuc/5
        public KhuVuc Get(string id)
        {
            return db.KhuVucs.Find(id);
        }

        // POST: api/KhuVuc
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/KhuVuc/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/KhuVuc/5
        public void Delete(int id)
        {
        }
    }
}
