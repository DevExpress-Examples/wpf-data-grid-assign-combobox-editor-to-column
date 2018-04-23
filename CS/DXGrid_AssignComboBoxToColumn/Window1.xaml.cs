using System.Windows;

namespace DXGrid_AssignComboBoxToColumn {
    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
        }
    }
    public class NwindData {
        public static nwindDataSet.ProductsDataTable Data {
            get { return new nwindDataSetTableAdapters.ProductsTableAdapter().GetData(); }
        }
    }
}
