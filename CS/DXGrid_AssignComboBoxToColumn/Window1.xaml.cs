using System.Collections.ObjectModel;
using System.Windows;

namespace DXGrid_AssignComboBoxToColumn {
    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
            this.DataContext = new MyViewModel();
        }
    }
    public class MyViewModel {
        public MyViewModel() {
            CreateList();
        }

        public ObservableCollection<Person> PersonList { get; set; }
        public ObservableCollection<ProductType> TypeList { get; set; }
        void CreateList() {
            PersonList = new ObservableCollection<Person>();
            for (int i = 0; i < 20; i++) {
                Person p = new Person(i);
                PersonList.Add(p);
            }
            TypeList = new ObservableCollection<ProductType>();
            for (int i = 0; i < 3; i++) {
                TypeList.Add(new ProductType(i));
            }
        }
    }
    public class Person {
        public Person(int i) {
            ProductName = "FirstName" + i;
       
            UnitPrice = i;
            Type = 0;
        }

        public string ProductName { get; set; }

        public int Type { get; set; }

        public int UnitPrice { get; set; }
    }

    public class ProductType {
        public ProductType(int i) {
            Id = i;
            TypeName = "Type" + i;
        }
        public int Id { get; set; }
        public string TypeName { get; set; }
    }
}
