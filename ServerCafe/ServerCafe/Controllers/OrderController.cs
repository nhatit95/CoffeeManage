using ServerCafe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ServerCafe.Controllers
{
    public class OrderController : ApiController
    {
        ModelCafe db = new ModelCafe();
        // GET: api/Order
        public List<Order> Get()
        {
            return db.Orders.ToList();
        }

        // GET: api/Order/5
        public Order Get(string id)
        {
            return db.Orders.Find(id);
        }

        // POST: api/Order
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Order/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Order/5
        public void Delete(int id)
        {
        }
    }
}
