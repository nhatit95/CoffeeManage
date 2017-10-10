using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CoffeeManage.View.ThucDon
{
    public interface IAddThucDon
    {
        string IDThucDon { get; set; }
        string TenThucDon { get; set; }
        int GiaTien { get; set; }
        int KhuyenMai { get; set; }
        string LoaiThucDon { get; set; }
        string NoiIn { get; set; }
        bool isAdd { get; set; }
        void LoadNoiIn(ComboBox cb);
        void LoadLoaiThucDon(ComboBox cb);
        void Message(string message);
        void Them();
        void Huy();
    }
}
