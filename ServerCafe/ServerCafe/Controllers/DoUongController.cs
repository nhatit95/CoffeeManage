using ServerCafe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ServerCafe.Controllers
{
    public class DoUongController : ApiController
    {
        ModelCafe db = new ModelCafe();
        // GET: api/DoUong
        //[Authorize(Roles ="ChuQuan,QuanLy")]
        public List<DoUong> Get()
        {
            return db.DoUongs.ToList();
        }

        // GET: api/DoUong/5
        public DoUong Get(string id)
        {
            DoUong du=db.DoUongs.Find(id);
            return du;
        }

        // POST: api/DoUong
        [Authorize(Roles = "ChuQuan,QuanLy")]
        public bool Post(DoUong duu)
        {
            try
            {
                
                DoUong du = new DoUong();
                du.IDDoUong = duu.IDDoUong; du.TenDoUong = duu.TenDoUong; du.GiaTien = duu.GiaTien;
                du.LoaiDoUong = duu.LoaiDoUong;
                db.DoUongs.Add(du);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        // PUT: api/DoUong/5
        public bool Put(DoUong duu)
        {
            try
            {
      
                DoUong du = db.DoUongs.FirstOrDefault(x => x.IDDoUong == duu.IDDoUong);
                if (du == null) return false;
                du.TenDoUong = duu.TenDoUong; du.GiaTien = duu.GiaTien;du.LoaiDoUong = duu.LoaiDoUong;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        // DELETE: api/DoUong/5
        public bool Delete(string id)
        {
            DoUong du = db.DoUongs.FirstOrDefault(x => x.IDDoUong == id);
            if (du == null) return false;
            db.DoUongs.Remove(du);
            db.SaveChanges();
            return true;
        }
    }
}
