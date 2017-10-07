using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManage.View.NguyenLieu
{
    public interface INguyenLieu
    {
        List<DTO.NguyenLieu> listNguyenLieu { get; set; }
        void ShowData();
    }
}
