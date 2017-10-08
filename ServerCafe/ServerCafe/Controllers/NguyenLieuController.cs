using ServerCafe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ServerCafe.Controllers
{
    public class NguyenLieuController : ApiController
    {
        ModelCafe db = new ModelCafe();
        // GET: api/NguyenLieu
        public List<NguyenLieu> Get()
        {
            return db.NguyenLieus.ToList();
        }

        // GET: api/NguyenLieu/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/NguyenLieu
        public bool Post(NguyenLieu nl)
        {
            try
            {
                db.NguyenLieus.Add(nl);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // PUT: api/NguyenLieu/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/NguyenLieu/5
        public void Delete(int id)
        {
        }
    }
}
