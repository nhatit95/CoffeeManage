using CoffeeManage.DAL;
using CoffeeManage.DTO;
using CoffeeManage.View.ThucDon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CoffeeManage.Presenter
{
    class AddThucDonPresenter
    {
        IAddThucDon view;
        LoaiDoUongDAL lduDAL = new LoaiDoUongDAL();
        NoiInDAL niDAL = new NoiInDAL();
        DoUongDAL duDAL = new DoUongDAL();
        public AddThucDonPresenter(IAddThucDon view)
        {
            this.view = view;
        }
        public async void LoadLoaiThucDon(ComboBox cb)
        {
            cb.ItemsSource = await lduDAL.GetListLoaiDoUong();
            cb.SelectedIndex = 0;
            

        }
        public async void LoadNoiIn(ComboBox cb)
        {
            cb.ItemsSource = await niDAL.GetListNoiIn();
            cb.SelectedIndex = 0;
        }
        public async void Them()
        {
            try
            {
                DTO.DoUong du = new DTO.DoUong{ IDDoUong = view.IDThucDon, TenDoUong = view.TenThucDon, IDLoaiDoUong = view.LoaiThucDon, GiaTien = view.GiaTien,KhuyenMai=view.KhuyenMai,IDNoiIn=view.NoiIn };
                if (await duDAL.InsertDoUong(du))
                {
                    view.Message("Thêm Mới Thành Công");
                    view.Huy();
                }
                else view.Message("Trùng khóa chính hoặc dữ liệu không hợp lệ");

            }
            catch (Exception)
            {
                view.Message("Trùng khóa chính hoặc dữ liệu không hợp lệ");
            }
        }
        public async void LoadThucDon()
        {
            DoUong du = await duDAL.GetDoUong(view.IDThucDon);
            view.TenThucDon = du.TenDoUong;
            view.GiaTien = du.GiaTien;
            view.KhuyenMai = du.KhuyenMai;
            view.LoaiThucDon = du.IDLoaiDoUong;
            view.NoiIn = du.IDNoiIn;
            
            
        }
    }
}
