using CoffeeManage.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManage.View.Home
{
    public interface IHome
    {
        string TenTaiKhoan { get; set; }
        string TenChucVu { get; set; }
        List<KhuVuc> khuVuc { get; set; }
        List<Ban> Ban { get; set; }
        Ban ban { get; set; }
        KhuVuc kvActive { get; set; }
    }
}
