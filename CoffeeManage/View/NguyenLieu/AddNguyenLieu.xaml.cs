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

namespace CoffeeManage.View.NguyenLieu
{
    /// <summary>
    /// Interaction logic for AddNguyenLieu.xaml
    /// </summary>
    public partial class AddNguyenLieu : Window,IAddNguyenLieu
    {
        public AddNguyenLieu()
        {
            InitializeComponent();
        }

        public string DonViTinh
        {
            get
            {
                return cbbDonvitinh.SelectedValue.ToString();
            }

            set
            {
                cbbDonvitinh.SelectedValue = value;
            }
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

        public string IDNguyenLieu
        {
            get
            {
                return txtIdnguyenlieu.Text;
            }

            set
            {
                txtIdnguyenlieu.Text = value;
            }
        }

        public float SoLuong
        {
            get
            {
                return int.Parse(txtSoluong.Text);
            }

            set
            {
                txtSoluong.Text = value + "";
            }
        }

        public string TenNguyenLieu
        {
            get
            {
                return txtTennguyenlieu.Text;
            }

            set
            {
                txtTennguyenlieu.Text = value;
            }
        }

        public void Huy()
        {
            this.Close();
        }

        public void Them()
        {
            throw new NotImplementedException();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Huy();
        }
    }
}
