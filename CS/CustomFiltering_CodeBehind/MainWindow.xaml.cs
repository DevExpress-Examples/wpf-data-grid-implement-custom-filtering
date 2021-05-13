using DevExpress.Xpf.Grid;
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

namespace CustomFiltering_CodeBehind {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            grid.ItemsSource = GetItems();
        }
        static IEnumerable<object> GetItems() {
            return new object[] { "A", "B", "C", "D", "E", "F", "G", "H" };
        }

        void OnCustomRowFilter(object sender, RowFilterEventArgs e) {
            if(chkHideOdd.IsChecked.Value && e.ListSourceRowIndex % 2 == 1)
                e.Visible = false;
            if(chkHideEven.IsChecked.Value && e.ListSourceRowIndex % 2 == 0)
                e.Visible = false;
            e.Handled = !e.Visible ? true : false;
        }

        void OnCheckedChanged(object sender, RoutedEventArgs e) {
            grid.RefreshData();
        }
    }
}
