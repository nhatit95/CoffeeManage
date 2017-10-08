using CoffeeManage.DAL;
using CoffeeManage.DTO;
using CoffeeManage.View.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManage.Presenter
{
    class HomePresenter
    {
        IHome homeView;
        ChucVuDAL cvDAL;
        ThongTinCaNhanDAL ttcnDAL;

        public HomePresenter(IHome homeView)
        {
            this.homeView = homeView;
            cvDAL = new ChucVuDAL(); ttcnDAL = new ThongTinCaNhanDAL();
            setThongTinDN();
        }
        public async Task setThongTinDN()
        {

            ThongTinCaNhan tt = await ttcnDAL.GetThongTinCaNhan(HttpConnect.email);
            homeView.TenTaiKhoan = tt.Ten;
            homeView.TenChucVu = tt.ChucVu.TenChucVu;
        }
    }
}
