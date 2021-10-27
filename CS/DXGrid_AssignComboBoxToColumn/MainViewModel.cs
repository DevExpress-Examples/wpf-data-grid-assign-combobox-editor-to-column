using System.Collections.Generic;
using System.Linq;

namespace DXGrid_AssignComboBoxToColumn {
    public class Person {
        public string ProductName { get; set; }
        public int Type { get; set; }
        public int UnitPrice { get; set; }

        public Person(int i) {
            ProductName = "FirstName" + i;
            UnitPrice = i;
            Type = 0;
        }
    }

    public class ProductType {
        public int Id { get; set; }
        public string TypeName { get; set; }

        public ProductType(int i) {
            Id = i;
            TypeName = "Type" + i;
        }
    }

    public class MyViewModel {
        public List<Person> PersonList { get; set; }
        public List<ProductType> TypeList { get; set; }

        public MyViewModel() {
            PersonList = new List<Person>(GetPersonData(20));
            TypeList = new List<ProductType>(GetTypeData(3));
        }

        static IEnumerable<Person> GetPersonData(int count) {
            return Enumerable.Range(0, count).Select(x => new Person(x));
        }

        static IEnumerable<ProductType> GetTypeData(int count) {
            return Enumerable.Range(0, count).Select(x => new ProductType(x));
        }
    }
}
