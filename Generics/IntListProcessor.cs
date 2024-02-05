using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    using System;
    using System.Collections.Generic;

    class IntListProcessor
    {
        private List<int> items;

        public IntListProcessor()
        {
            items = new List<int>();
        }

        public void AddItem(int item)
        {
            items.Add(item);
        }

        public void DisplayItems()
        {
            Console.WriteLine("Items in the list:");
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }



      /*  static void Main()
        {
            IntListProcessor processor = new IntListProcessor();

            // adding items
            processor.AddItem(10);
            processor.AddItem(20);
            processor.AddItem(30);

            // displaying items
            processor.DisplayItems();
        }*/
    }

}
