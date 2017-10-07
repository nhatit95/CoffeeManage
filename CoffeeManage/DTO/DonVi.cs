using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManage.DTO
{
    public class DonVi
    {
        public string IDDonVi { get; set; }
        public string TenDonVi { get; set; }
        public virtual ICollection<NguyenLieu> NguyenLieus { get; set; }
    }
}
