using System;

namespace ConsoleApp4
{
    class Stack
    {
        private int current = -1;
        private string[] items;

        public Stack(int size)
        {
            items = new string[size];
        }

        public bool Empty()
        {
            return current == -1;
        }

        public bool Full()
        {
            return current == items.Length - 1;
        }

        public bool Push(string item)
        {
            if (!Full())
            {
                items[++current] = item;
                return true;
            }
            return false;
        }

        public string Pop()
        {
            if (!Empty())
            {
                return items[current--];
            }
            return null; // or throw an exception or handle it in a way that makes sense for your application
        }
    }

    class Program
    {
       /* public static void Main(string[] args)
        {
            var colors = new Stack(3);

            colors.Push("Red");
            colors.Push("Green");
            colors.Push("Blue");
            //colors.Push(1);

            while (true)
            {
                var color = colors.Pop();

                if (color == null)
                {
                    break;
                }

                Console.WriteLine(color);
            }
        }*/
    }
}
