using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManage.DTO
{
    public class DoUong
    {
        public string IDDoUong { get; set; }
        public string TenDoUong { get; set; }
        public string IDLoaiDoUong { get; set; }
        public virtual LoaiDoUong LoaiDoUong { get; set; }
        public int GiaTien { get; set; }
        public int KhuyenMai { get; set; }
        public string IDNoiIn { get; set; }
        public virtual NoiIn NoiIn { get; set; }
        public virtual ICollection<ThanhPhanDoUong> ThanhPhanDoUongs { get; set; }
    }
}
