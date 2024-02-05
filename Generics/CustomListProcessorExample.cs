using System;
using System.Collections.Generic;

// Class to work with any kind of list using object
public class ListProcessor
{
    private List<object> internalList;

    public ListProcessor()
    {
        internalList = new List<object>();
    }

    // Add an item to the list
    public void AddItem(object item)
    {
        internalList.Add(item);
    }

    // Display all items in the list
    public void DisplayItems()
    {
        foreach (var item in internalList)
        {
            Console.WriteLine(item);
        }
    }
}

class CustomListProcessorExample
{
   /* static void Main()
    {
        // Create a ListProcessor for integers
        ListProcessor intListProcessor = new ListProcessor();
        intListProcessor.AddItem(42);
        intListProcessor.AddItem(15);
        Console.WriteLine("Integer List:");
        intListProcessor.DisplayItems();

        // Create a ListProcessor for strings
        ListProcessor stringListProcessor = new ListProcessor();
        stringListProcessor.AddItem("Hello");
        stringListProcessor.AddItem("World");
        Console.WriteLine("\nString List:");
        stringListProcessor.DisplayItems();
    }*/
}
