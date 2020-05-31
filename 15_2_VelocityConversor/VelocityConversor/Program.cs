using System;

namespace VelocityConversor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Conversor
    {
        private double velocity;

        public void msToKh()
        {
            Console.Write("Introduce a velocity in m/s: ");
            velocity = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{velocity} m/s = {velocity * 3600 / 1000} km/h");
        }
        public void khToMs()
        {
            Console.Write("Introduce a velocity in km/h: ");
            velocity = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{velocity} km/h = {velocity * 1000 / 3600} m/s");

        }
    }
}
