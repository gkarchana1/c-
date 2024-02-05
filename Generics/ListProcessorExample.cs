using System;
using System.Collections.Generic;

public class ListProcessor<T>
{
    private List<T> internalList;

    public ListProcessor()
    {
        internalList = new List<T>();
    }

    public void AddItem(T item)
    {
        internalList.Add(item);
    }


    public void DisplayItems()
    {
        foreach (var item in internalList)
        {
            Console.WriteLine(item);
        }
    }
}

class ListProcessorExample
{
  /*  static void Main()
    {
        // Create a ListProcessor for integers
        ListProcessor<object> intListProcessor = new ListProcessor<object>();

        intListProcessor.AddItem(42);
        intListProcessor.AddItem(15);
        intListProcessor.AddItem("hello");
        Console.WriteLine("Integer List:");
        intListProcessor.DisplayItems();


        // Create a ListProcessor for strings
        ListProcessor<string> stringListProcessor = new ListProcessor<string>();

        stringListProcessor.AddItem("Hello");
        stringListProcessor.AddItem("World");
        Console.WriteLine("\nString List:");
        stringListProcessor.DisplayItems();
    }*/
}
