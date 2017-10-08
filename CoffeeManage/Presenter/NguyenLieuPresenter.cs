using CoffeeManage.DAL;
using CoffeeManage.View.NguyenLieu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CoffeeManage.Presenter
{
    class NguyenLieuPresenter
    {
        INguyenLieu nlView;
        NguyenLieuDAL nlDAL = new NguyenLieuDAL();
        public NguyenLieuPresenter(INguyenLieu nlView)
        {
            this.nlView = nlView;
        }
        public async void showData(DataGrid dg) 
        {
            List<DTO.NguyenLieu> nl = await nlDAL.GetListNguyenLieu();
            dg.ItemsSource = nl.Select(p => new {p.IDNguyenLieu,p.TenNguyenLieu,p.DonVi.TenDonVi,p.SoLuong });
            
            
        }
    }
}
