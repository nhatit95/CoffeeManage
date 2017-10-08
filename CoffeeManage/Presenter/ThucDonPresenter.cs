using CoffeeManage.DAL;
using CoffeeManage.View.ThucDon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CoffeeManage.Presenter
{
    class ThucDonPresenter
    {
        IThucDon tdView;
        DoUongDAL duDAL = new DoUongDAL();
        public ThucDonPresenter(IThucDon tdView)
        {
            this.tdView = tdView;
        }
        public async void showData(DataGrid dg)
        {
            List<DTO.DoUong> nl = await duDAL.GetListDoUong();
            dg.ItemsSource = nl.Select(p => new { p.IDDoUong, p.TenDoUong, p.LoaiDoUong.TenLoaiDoUong,p.GiaTien, p.KhuyenMai,p.NoiIn.TenNoiIn });
        }
    }
}
