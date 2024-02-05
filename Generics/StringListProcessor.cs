using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{

    class StringListProcessor
    {
        private List<string> items;

        public StringListProcessor()
        {
            items = new List<string>();
        }

        public void AddItem(string item)
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



       /* static void Main()
        {
            StringListProcessor processor = new StringListProcessor();

            // Adding items
            processor.AddItem("Apple");
            processor.AddItem("Banana");
            processor.AddItem("Orange");

            // Displaying items
            processor.DisplayItems();
        }*/
    }

}
