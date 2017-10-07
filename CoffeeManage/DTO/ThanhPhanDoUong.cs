using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManage.DTO
{
    public class ThanhPhanDoUong
    {
        public string IDThanhPhanDoUong { get; set; }
        public string IDDoUong { get; set; }
        public virtual DoUong DoUong { get; set; }
        public string IDNguyenLieu { get; set; }
        public virtual NguyenLieu NguyenLieu { get; set; }
        public float SoLuong { get; set; }
    }
}
