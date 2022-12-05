using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid1
{
    //Який принцип S.O.L.I.D. порушено? Виправте!
    //single responsibility principle
    class Item
    {

    }
    class Order
    {
        private List<Item> itemList;

        internal List<Item> ItemList
        {
            get
            {
                return itemList;
            }

            set
            {
                itemList = value;
            }
        }

        public void CalculateTotalSum() {/*...*/}
        public void GetItems() {/*...*/}
        public void GetItemCount() {/*...*/}
        public void AddItem(Item item) {/*...*/}
        public void DeleteItem(Item item) {/*...*/}
    }

    class OrderManager 
    {
        public void PrintOrder(Order ord) {/*...*/}
        public void ShowOrder(Order ord) {/*...*/}
    }

    class OrderRepository
    {
        public void Load(Order ord) {/*...*/}
        public void Save(Order ord) {/*...*/}
        public void Update(Order ord) {/*...*/}
        public void Delete(Order ord) {/*...*/}
    }

    class Program
    {
        static void Main()
        {
        }
    }
}
