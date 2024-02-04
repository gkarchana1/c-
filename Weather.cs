using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{

    class AlertArgs : EventArgs
    {
        public int temp { get; set; }

        //red orange green
        public string levelOfWarning { get; set; }
        public string place { get; set; }

    }
    class Weather
    {
        //  public delegate void EventHandler<AlertArgs>(object sender, AlertArgs e);
        public event EventHandler<AlertArgs> OnAlert;
    

        public void setForcast(int Temp, string city, string color) 
        {
            
             OnAlert?.Invoke(this, new AlertArgs() { temp = Temp, place = city, levelOfWarning = color});
        }

        static void Main(string[] args)
        {
            Weather cw = new Weather();
            Weather tw = new Weather();

            tw.OnAlert += TrichyWeather.BeSafe;
            cw.OnAlert += ChennaiWeather.BeSafe;
            cw.setForcast(40, "chennai", "red");
            tw.setForcast(25, "trichy", "green");

            }
        }
}
