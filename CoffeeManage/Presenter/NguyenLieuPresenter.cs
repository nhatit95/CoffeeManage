using CoffeeManage.DAL;
using CoffeeManage.View.NguyenLieu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManage.Presenter
{
    class NguyenLieuPresenter
    {
        INguyenLieu nlView;
        NguyenLieuDAL nlDAL = new NguyenLieuDAL();
        public NguyenLieuPresenter(INguyenLieu nlView)
        {
            this.nlView = nlView;
            showData();
        }
        public async void showData()
        {
            nlView.listNguyenLieu = await nlDAL.GetListNguyenLieu();
        }
    }
}
