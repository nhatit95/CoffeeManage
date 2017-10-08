using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManage.DTO
{
    public class Order
    {
        public string IDOrder { get; set; }
        public string IDBan { get; set; }
        public virtual Ban Ban { get; set; }
        public string IDThongTinCaNhan { get; set; }
        public virtual ThongTinCaNhan ThongTinCaNhan { get; set; }
        public string ThoiGianVao { get; set; }
        public string ThoiGianRa { get; set; }
        public bool DaThanhToan { get; set; }
        public int PhuThu { get; set; }
        public string GhiChu { get; set; }
        public virtual ICollection<ChiTietOrder> ChiTietOrders { get; set; }
    }
}
