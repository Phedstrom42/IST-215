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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab24._2_ModelFirstWithCustomerOrder
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CUSTOMER_ORDEREntities db = new CUSTOMER_ORDEREntities();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var custData1 = from c in db.CUSTOMERs
                         join o in db.ORDERs on
                         c.CustomerID equals o.CustomerID
                         select new
                         {
                             c.CustomerID,
                             CustomerName = c.CustomerName.Trim(),
                             c.City,
                             c.State,
                             o.OrderNum,
                             ProductNumber = o.ProductNumber.Trim(),
                             o.ProductName,
                             o.ProductType
                         };
            dataGrid1.ItemsSource = custData1.ToList();

        }
    }
}
