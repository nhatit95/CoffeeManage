using ServerCafe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ServerCafe.Controllers
{
    public class ThongTinCaNhanController : ApiController
    {
        ModelCafe modelCafe = new ModelCafe();
        // GET: api/ThongTinCaNhan
        [Authorize(Roles = "ChuQuan,QuanLy,ThuNgan")]
        public List<ThongTinCaNhan> Get()
        {
            return modelCafe.ThongTinCaNhans.ToList();
        }

        // GET: api/ThongTinCaNhan/5
        [Authorize(Roles ="ChuQuan,QuanLy,ThuNgan")]
        public ThongTinCaNhan Get(string id)
        {
            ThongTinCaNhan tt = modelCafe.ThongTinCaNhans.Single(p=> p.Email==id);
            return tt;
        }

        // POST: api/ThongTinCaNhan
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/ThongTinCaNhan/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ThongTinCaNhan/5
        public void Delete(int id)
        {
        }
    }
}
