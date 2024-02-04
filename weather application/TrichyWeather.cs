using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class TrichyWeather
    {
       
        public static void BeSafe(object o, AlertArgs e)
        {
            Console.WriteLine("\nBe safe- Trichy guardians");
            if (e.levelOfWarning == "red")
            {
                TrichyWeather.RedAlert();
            }
            else if (e.levelOfWarning == "green")
            {
                TrichyWeather.GoGreen();
            }
            else
            {
                TrichyWeather.GoOrange();
            }
        }

        private static void GoOrange()
        {
            Console.WriteLine("Indoor vacation is best!");
        }

        private static void GoGreen()
        {
            Console.WriteLine("Time to plan vacation in Trichy");

        }

        private static void RedAlert()
        {
            Console.WriteLine("The state disaster management authority helpline is 1070," +
                " district emergency control centres 1277, WhatsApp number 9660069848 and Greater Trichy Corporation helpline 1900");
        }
    }
}
