using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoffeeManage.DTO
{
    public class NguyenLieu
    {
        [Key]
        public string IDNguyenLieu { get; set; }
        public string TenNguyenLieu { get; set; }
        public string IDDonVi { get; set; }
        [ForeignKey("IDDonVi")]
        public virtual DonVi DonVi { get; set; }
        public int Gia { get; set; }
        public float SoLuong { get; set; }

    }
}
