using CoffeeManage.Presenter;
using CoffeeManage.View.HoaDon;
using CoffeeManage.View.Home;
using CoffeeManage.View.NguyenLieu;
using CoffeeManage.View.NhanVien;
using CoffeeManage.View.ThucDon;
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

namespace CoffeeManage
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Home : Window,IHome
    {
        HomePresenter pre;
        public string TenTaiKhoan
        {
            get
            {
                return tbTenTaiKhoan.Text;
            }

            set
            {
                tbTenTaiKhoan.Text = value;
            }
        }

        public string TenChucVu
        {
            get
            {
                return tbTenChucVu.Text;
            }

            set
            {
                tbTenChucVu.Text = value;
            }
        }

        public Home()
        {
            InitializeComponent();
            pre = new HomePresenter(this);
            AddTang();
            AddBan();
        }
        public void AddTang()
        {
            string[] btnName = { "Tầng 1", "Tầng 2" };
            Button[] btTang = new Button[btnName.Length];
            SolidColorBrush bb = new SolidColorBrush();
            // bb.Color = (Color)ColorConverter.ConvertFromString("#FF35F3EB");
            Style style = Application.Current.FindResource("LibraryFloor") as Style;
            for (int i = 0; i < btTang.Length; i++)
            {

                btTang[i] = new Button();
                btTang[i].Content = btnName[i];
                //btTang[i].Background = bb;
                //btTang[i].VerticalAlignment = VerticalAlignment.Stretch;
                btTang[i].Height = 100;
                btTang[i].FontSize = 20;
                btTang[i].Style = style;
                btTang[i].Margin = new Thickness(10);
                panelTang.Children.Add(btTang[i]);
            }
        }
        public void AddBan()
        {
            string[] btnName = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };
            Button[] btTang = new Button[btnName.Length];
            SolidColorBrush bb = new SolidColorBrush();
            Style style = Application.Current.FindResource("LibraryTable") as Style;
            // bb.Color = (Color)ColorConverter.ConvertFromString("#FF4ED41C");
            this.Background = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,../View/Img/background.jpg")));
            for (int i = 0; i < btTang.Length; i++)
            {
                
                btTang[i] = new Button();
               // btTang[i].Background = new ImageBrush(new BitmapImage(new Uri(@"C://Users/Administrator/Downloads/Shutterstock Downloader by Juno_okyo/table.png")));
                btTang[i].Content = btnName[i];
                btTang[i].Content = btTang[i].Content;
               // btTang[i].Background = bb;
                btTang[i].Width = 150;
                btTang[i].Height = 150;
                btTang[i].FontSize = 20;
                btTang[i].Style = style;
                btTang[i].Margin = new Thickness(10);
                panelBan.Children.Add(btTang[i]);
            }
        }
        public void QuanLyNguyenLieu()
        {

        }

        private void itNguyenLieu_Click(object sender, RoutedEventArgs e)
        {
            NguyenLieu nl = new NguyenLieu();
            nl.ShowDialog();
        }

        private void itThucDon_Click(object sender, RoutedEventArgs e)
        {
            ThucDon td = new ThucDon();
            td.ShowDialog();
        }

        private void itNhanVien_Click(object sender, RoutedEventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.ShowDialog();
        }

        
    }
}
