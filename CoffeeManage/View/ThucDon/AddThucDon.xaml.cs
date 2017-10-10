using CoffeeManage.DTO;
using CoffeeManage.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CoffeeManage.View.ThucDon
{
    /// <summary>
    /// Interaction logic for AddThucDon.xaml
    /// </summary>
    public partial class AddThucDon : Window,IAddThucDon
    {
        AddThucDonPresenter pre;
        public AddThucDon()
        {
            InitializeComponent();
            pre = new AddThucDonPresenter(this) ;
            LoadLoaiThucDon(cbbLoaithucdon);
            LoadNoiIn(cbbNoiIn);
        }

        public int GiaTien
        {
            get
            {
                return int.Parse(txtGiatien.Text);
            }

            set
            {
                txtGiatien.Text = value + "";
            }
        }

        public string IDThucDon
        {
            get
            {
                return txtIdthucdon.Text;
            }

            set
            {
                txtIdthucdon.Text = value;
            }
        }
        private bool _isAdd;
        public bool isAdd
        {
            get
            {
                return _isAdd;
            }

            set
            {
                _isAdd = value;
                if (!_isAdd) this.Title = "Sửa Thực Đơn";
                pre.LoadThucDon();
                this.Show();
            }
        }

        public int KhuyenMai
        {
            get
            {
                return int.Parse(txtKhuyenmai.Text);
            }

            set
            {
                txtKhuyenmai.Text = value + "";
            }
        }

        public string LoaiThucDon
        {
            get
            {
                return cbbLoaithucdon.SelectedValue.ToString();
            }

            set
            {
                cbbLoaithucdon.SelectedValue = value;
            }
        }

        public string NoiIn
        {
            get
            {
                return cbbNoiIn.SelectedValue.ToString();
            }

            set
            {
                cbbNoiIn.SelectedValue = value;
            }
        }

        public string TenThucDon
        {
            get
            {
                return txtTenthucdon.Text;
            }

            set
            {
                txtTenthucdon.Text = value;
            }
        }

        public void Huy()
        {
            this.Close();
        }

        public void LoadLoaiThucDon(ComboBox cb)
        {
            pre.LoadLoaiThucDon(cb);
        }

        public void LoadNoiIn(ComboBox cb)
        {
            pre.LoadNoiIn(cb);
        }

        public void Message(string message)
        {
            MessageBox.Show(message);
        }

        public void Them()
        {
            pre.Them();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Them();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Huy();
        }
    }
}
