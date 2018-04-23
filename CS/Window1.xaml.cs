using System.Windows;
using DevExpress.Xpf.Grid;

namespace CustomFiltering {

    public partial class Window1 : Window {

        public Window1() {
            InitializeComponent();
            grid.DataSource = new object[] { "A", "B", "C", "D", "E", "F", "G", "H" };
        }

        private void grid_CustomRowFilter(object sender, RowFilterEventArgs e) {
            if (chkHideOdd.IsChecked.Value && e.ListSourceRowIndex % 2 == 1)
                e.Visible = false;
            if (chkHideEven.IsChecked.Value && e.ListSourceRowIndex % 2 == 0)
                e.Visible = false;
            e.Handled = !e.Visible ? true : false;
        }

        private void chk_CheckedOrUnchecked(object sender, RoutedEventArgs e) {
            grid.RefreshData();
        }
    }
}
