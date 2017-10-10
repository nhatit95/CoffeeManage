using ServerCafe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ServerCafe.Controllers
{
    public class ChiTietOrderController : ApiController
    {
        ModelCafe db = new ModelCafe();
        // GET: api/ChiTietOrder
        public List<ChiTietOrder> Get()
        {
            return db.ChiTietOrders.ToList();
        }

        // GET: api/ChiTietOrder/5
        public ChiTietOrder Get(string id)
        {
            return db.ChiTietOrders.Find(id);
        }

        // POST: api/ChiTietOrder
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/ChiTietOrder/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ChiTietOrder/5
        public void Delete(int id)
        {
        }
    }
}
