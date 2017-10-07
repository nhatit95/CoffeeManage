using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManage.DTO
{
    public class ThongTinCaNhan
    {
        public string IDUser { get; set; }
        public string Email { get; set; }
        public string IDChucVu { get; set; }
        public string Ten { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string NgaySinh { get; set; }
        public int NangLucLamViec { get; set; }
        public virtual ChucVu ChucVu { get; set; }
    }
}
