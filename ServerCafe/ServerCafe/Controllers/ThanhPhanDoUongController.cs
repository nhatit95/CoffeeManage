using ServerCafe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ServerCafe.Controllers
{
    public class ThanhPhanDoUongController : ApiController
    {
        ModelCafe db = new ModelCafe();
        // GET: api/LoaiDoUong
        public List<ThanhPhanDoUong> Get()
        {
            return db.ThanhPhanDoUongs.ToList();
        }

        // GET: api/ThanhPhanDoUong/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/ThanhPhanDoUong
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/ThanhPhanDoUong/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ThanhPhanDoUong/5
        public void Delete(int id)
        {
        }
    }
}
