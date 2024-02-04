using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class ChennaiWeather
    {
        
        public static void BeSafe(object o, AlertArgs e)
        {
            Console.WriteLine("\nBe safe- Chennai guardians");
            Console.WriteLine($"Zone: {e.levelOfWarning}");
            if (e.levelOfWarning == "red")
            {
                ChennaiWeather.RedAlert();
            }
            else if (e.levelOfWarning == "green")
            {
                ChennaiWeather.GoGreen();
            }
        }

        private static void GoGreen()
        {
            Console.WriteLine("Time to plan vacation in chennai");

        }

        public static void RedAlert()
        {
            Console.WriteLine("The state disaster management authority helpline is 1070," +
                " district emergency control centres 1077, WhatsApp number 9445869848 and Greater Chennai Corporation helpline 1913");
        }
    }
}
