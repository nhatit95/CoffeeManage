using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CoffeeManage.View.NguyenLieu
{
    public interface IAddNguyenLieu
    {
        string IDNguyenLieu { get; set; }
        string TenNguyenLieu { get; set; }
        string DonViTinh { get; set; }
        int GiaTien { get; set; }
        float SoLuong { get; set; }
        void Message(string message);
        void Them();
        void Huy();
        void loadDonVi(ComboBox cb);
    }
}
