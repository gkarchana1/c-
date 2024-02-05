using System;

namespace ConsoleApp4
{
    class Stack2<T>
    {
        private int current = -1;
        private T[] items;

        public Stack2(int size)
        {
            items = new T[size];
        }

        public bool Empty => current == -1;

        public bool Full => current == items.Length - 1;

        public bool Push(T item)
        {
            if (!Full)
            {
                items[++current] = item;
                return true;
            }
            return false;
        }

        public T? Pop() => !Empty ? items[current--] : default(T);
    }

    class Program2
    {
        /*public static void Main(string[] args)
        {
            var colors = new Stack2<string>(3);  // Use Stack2<string> instead of Stack<string>

            colors.Push("Red");
            colors.Push("Green");
            colors.Push("Blue");

            while (true)
            {
                var color = colors.Pop();

                if (color == null)
                {
                    break;
                }

                Console.WriteLine(color);
            }

            var dob = new Stack2<int>(3);

            dob.Push(18);
            dob.Push(16);
            dob.Push(2);

            while (true)
            {
                var bdate = dob.Pop();

                if (bdate == 0)
                {
                    break;
                }

                Console.WriteLine(bdate);
            }

        }*/
    }
}
