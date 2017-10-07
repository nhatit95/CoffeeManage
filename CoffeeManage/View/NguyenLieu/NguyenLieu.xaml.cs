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

namespace CoffeeManage.View.NguyenLieu
{
    /// <summary>
    /// Interaction logic for NguyenLieu.xaml
    /// </summary>
    public partial class NguyenLieu : Window,INguyenLieu
    {
        NguyenLieuPresenter pre;
        private List<DTO.NguyenLieu> _listNguyenLieu;
        public List<DTO.NguyenLieu> listNguyenLieu
        {
            get
            {
                return _listNguyenLieu;
            }

            set
            {
                _listNguyenLieu = value;
                dataGrid.ItemsSource = _listNguyenLieu;
                
            }
        }

        public NguyenLieu()
        {
            InitializeComponent();
            pre = new NguyenLieuPresenter(this);
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            AddNguyenLieu addnl = new AddNguyenLieu();
           
            addnl.ShowDialog();
     
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            EditNguyenLieu editnl = new EditNguyenLieu();
           
            editnl.ShowDialog();
        }

        public void ShowData()
        {
            throw new NotImplementedException();
        }
    }
}
