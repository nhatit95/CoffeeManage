using ServerCafe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ServerCafe.Controllers
{
    public class ChucVuController : ApiController
    {
        ModelCafe modelCafe = new ModelCafe();
        // GET: api/ChucVu
        [Authorize(Roles = "ChuQuan,QuanLy,ThuNgan")]
        public List<ChucVu> Get()
        {
            return modelCafe.ChucVus.ToList();
        }
        [Authorize(Roles ="ChuQuan,QuanLy,ThuNgan")]
        // GET: api/ChucVu/5
        public ChucVu Get(string id)
        {
            return modelCafe.ChucVus.Single(p=> p.IDChucVu==id);
        }

        // POST: api/ChucVu
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/ChucVu/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ChucVu/5
        public void Delete(int id)
        {
        }
    }
}
