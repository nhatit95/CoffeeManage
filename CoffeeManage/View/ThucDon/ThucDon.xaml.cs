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
    /// Interaction logic for ThucDon.xaml
    /// </summary>
    public partial class ThucDon : Window,IThucDon
    {
        ThucDonPresenter pre;
        public ThucDon()
        {
            InitializeComponent();
            pre = new ThucDonPresenter(this);
            ShowData(dataGrid);
        }

        public void ShowData(DataGrid dg)
        {
            pre.showData(dg);
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            AddThucDon addtd = new AddThucDon();
            addtd.ShowDialog();
            ShowData(dataGrid);
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string item = dataGrid.SelectedItem.ToString();
                string id = item.Substring(item.IndexOf('=') + 2, item.IndexOf(',') - item.IndexOf('=') - 2);
                AddThucDon addtd = new AddThucDon();
                addtd.IDThucDon = id; addtd.isAdd = false;
                addtd.ShowDialog();
                ShowData(dataGrid);
            }
            catch(Exception) { }
            
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
