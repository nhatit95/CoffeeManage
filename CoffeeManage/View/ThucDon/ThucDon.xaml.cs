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
    public partial class ThucDon : Window
    {
        public ThucDon()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            AddThucDon addtd = new AddThucDon();
            addtd.ShowDialog();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            EditThucDon edittd = new EditThucDon();
            edittd.ShowDialog();
        }
    }
}
