using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_angle
{
    class Program
    {
        static void Main(string[] args)
        {
            Angle angle = new Angle(57,17,44);
            Console.WriteLine("{0} град {1}\' {2}\" = {3:F} рад", angle.Gradus, angle.Min, angle.Sec, angle.ToRadians());
            Console.ReadKey();
        }
    }
    class Angle
    {
        int gradus, min, sec;
        public int Gradus
        {
            set
            {
                if (value >= 0 && value <= 360)
                    gradus = value;
                else
                    Console.WriteLine("Значение градусов вне допустимого диапазона");
            }
            get
            {
                return gradus;
            }
        }
        public int Min
        {
            set
            {
                if (value >= 0 && value <= 60)
                    min = value;
                else
                    Console.WriteLine("Значение минут вне допустимого диапазона");
            }
            get
            {
                return min;
            }
        }
        public int Sec
        {
            set
            {
                if (value >= 0 && value <= 60)
                    sec = value;
                else
                    Console.WriteLine("Значение секунд вне допустимого диапазона");
            }
            get
            {
                return sec;
            }
        }
        public Angle(int gradus = 0, int min = 0, int sec = 0)
        {
            Gradus = gradus;
            Min = min;
            Sec = sec;
        }
        public double ToRadians()
        {
            double rad = ((gradus + min / 60 + sec / 3600) * Math.PI / 180);
            return rad;
        }
    }
}
