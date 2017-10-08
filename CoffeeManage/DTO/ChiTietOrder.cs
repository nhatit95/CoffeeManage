using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManage.DTO
{
    public class ChiTietOrder
    {
        public string IDChiTietOrder { get; set; }
        public string IDOrder { get; set; }
        public virtual Order Order { get; set; }
        public string IDDoUong { get; set; }
        public virtual DoUong DoUong { get; set; }
        public int SoLuong { get; set; }
        public string GhiChu { get; set; }
        public string ThoiGian { get; set; }
        public bool DaIn { get; set; }
    }
}
