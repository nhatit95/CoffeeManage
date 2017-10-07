using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManage.DTO
{
    public class ChucVu
    {
        public string IDChucVu { get; set; }
        public string TenChucVu { get; set; }
        public int LuongCa { get; set; }
        public virtual ICollection<ThongTinCaNhan> ThongTinCaNhans { get; set; }
        
    }
}
