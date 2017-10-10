using ServerCafe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ServerCafe.Controllers
{
    public class LoaiDoUongController : ApiController
    {
        ModelCafe db = new ModelCafe();
        // GET: api/LoaiDoUong
        public List<LoaiDoUong> Get()
        {
            return db.LoaiDoUongs.ToList();
        }

        // GET: api/LoaiDoUong/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/LoaiDoUong
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/LoaiDoUong/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/LoaiDoUong/5
        public void Delete(int id)
        {
        }
    }
}
