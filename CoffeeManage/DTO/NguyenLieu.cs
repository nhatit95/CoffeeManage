using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManage.DTO
{
    public class NguyenLieu
    {
        public string IDNguyenLieu { get; set; }
        public string TenNguyenLieu { get; set; }
        public string IDDonVi { get; set; }
        public int Gia { get; set; }
        public float SoLuong { get; set; }
        public virtual DonVi DonVi { get; set; }
        public virtual ICollection<ThanhPhanDoUong> ThanhPhanDoUongs { get; set; }
    }
}
