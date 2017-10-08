using CoffeeManage.Presenter;
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
using CoffeeManage.DTO;

namespace CoffeeManage
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Home : Window,IHome
    {
        HomePresenter pre;
        public Home()
        {
            InitializeComponent();
            this.Background = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,../View/Img/background.jpg")));
            pre = new HomePresenter(this);
        }
        public string TenTaiKhoan
        {
            get{ return tbTenTaiKhoan.Text; }
            set{tbTenTaiKhoan.Text = value;}
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

        private List<KhuVuc> _khuVuc;
        public List<KhuVuc> khuVuc
        {
            get
            {
                return _khuVuc;
            }

            set
            {
                _khuVuc = value;
                AddKhuVuc(_khuVuc);
            }
        }
        private Ban _ban;
        public Ban ban
        {
            get
            {
                return _ban;
            }

            set
            {
                _ban = value;
            }
        }
        private KhuVuc _kvActive;
        public KhuVuc kvActive
        {
            get
            {
                return _kvActive;
            }

            set
            {
                _kvActive = value;
                 AddBan(kvActive.Bans.OrderBy(p=> p.IDBan).ToList());
            }
        }

        public void AddKhuVuc(List<DTO.KhuVuc> kv)
        {
            for (int i = 0; i < kv.Count; i++)
            {
                Button bt = new Button();
                bt.Content = kv.ElementAt(i).IDKhuVuc;
                bt.Click += Bt_Click;
                SetBTKV(bt);
            }
        }

        private void Bt_Click(object sender, RoutedEventArgs e)
        {
            Button bt = (Button)sender;
            kvActive = _khuVuc.Single(p => p.IDKhuVuc == bt.Content.ToString() );
        }

        public void SetBTKV(Button bt)
        {
            Style style = Application.Current.FindResource("LibraryFloor") as Style;
            bt.Height = 100; bt.FontSize = 30;
            bt.Foreground = colorBr("#0099FF");bt.FontStyle = FontStyles.Oblique;
            bt.Style = style; bt.Margin = new Thickness(10);
            panelKhuVuc.Children.Add(bt);
        }
        public void AddBan(List<DTO.Ban> ba)
        {
            panelBan.Children.Clear();
            for (int i = 0; i < ba.Count; i++)
            {
                Button bt = new Button();
                bt.Content = ba.ElementAt(i).IDBan;
                SetBTBan(bt);
                try
                {
                    Order od = ba.ElementAt(i).Orders.FirstOrDefault(p => p.ThoiGianRa == "00/00/0000 00:00:00.00");
                    if (od == null) setColorBan(bt, 0);
                    else
                    {
                        if (od.DaThanhToan) setColorBan(bt, 2);
                        else setColorBan(bt, 1);
                        int giatien = od.ChiTietOrders.Sum(p => p.DoUong.GiaTien * p.SoLuong) + od.PhuThu;
                        bt.Content = "   " + bt.Content + "\n\n" + giatien;
                    }
                }
                catch
                {
                    setColorBan(bt, 0);
                    continue;
                }
            }
        }
        public void SetBTBan(Button bt)
        {
            
            Style style = Application.Current.FindResource("LibraryTable") as Style;
            bt.Width = 150; bt.Height = 150;
            bt.FontSize = 20; bt.Foreground = colorBr("#003322");
            bt.FontStyle = FontStyles.Oblique; bt.Style = style;
            bt.Margin = new Thickness(10);panelBan.Children.Add(bt);
        }
        public SolidColorBrush colorBr(string color)
        {
            SolidColorBrush bb = new SolidColorBrush();
            bb.Color = (Color)ColorConverter.ConvertFromString(color);
            return bb;
        }
        public void setColorBan(Button bt,int state)
        {
            switch (state)
            {
                case 0:bt.Background=colorBr("#ffffff"); break;
                case 1: bt.Background = colorBr("#21FFFF"); break;
                case 2: bt.Background = colorBr("#F4570B"); break;
            }
        }
        private void itNguyenLieu_Click(object sender, RoutedEventArgs e)
        {
            View.NguyenLieu.NguyenLieu nl = new View.NguyenLieu.NguyenLieu();
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
