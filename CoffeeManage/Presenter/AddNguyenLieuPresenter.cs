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
    class AddNguyenLieuPresenter
    {
        IAddNguyenLieu view;
        DonViDAL dvDAL = new DonViDAL();
        NguyenLieuDAL nlDAL = new NguyenLieuDAL();
        public AddNguyenLieuPresenter(IAddNguyenLieu view)
        {
            this.view = view;
        }
        public async void loadDonVi(ComboBox cb)
        {
            cb.ItemsSource = await dvDAL.GetListDonVi();
            cb.SelectedIndex = 0;
        }
        public async void Them()
        {
            try
            {
                DTO.NguyenLieu nl = new DTO.NguyenLieu { IDNguyenLieu = view.IDNguyenLieu, TenNguyenLieu = view.TenNguyenLieu, IDDonVi = view.DonViTinh, Gia = view.GiaTien, SoLuong = view.SoLuong };
                if(await nlDAL.InsertNguyenLieu(nl))
                {
                    view.Message("Thêm Mới Thành Công");
                    view.Huy();
                }
                else view.Message("Trùng khóa chính hoặc dữ liệu không hợp lệ");

            }
            catch(Exception)
            {
                view.Message("Trùng khóa chính hoặc dữ liệu không hợp lệ");
            }
        }
    }
}
