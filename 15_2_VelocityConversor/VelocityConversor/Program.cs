using System;

namespace VelocityConversor
{
    class Program
    {
        static void Main(string[] args)
        {
            int option;
            char repeat = 'y';
            var conv = new Conversor();
            do
            {
                Console.WriteLine("Choose and option:\n" +
                "\t1 - Convert m/s to km/h\n" +
                "\t2 - Convert km/h to m/s");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        conv.msToKh();
                        break;
                    case 2:
                        conv.khToMs();
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
                Console.WriteLine("Do you want to exit the program? Y/n");
                repeat = Convert.ToChar(Console.ReadLine().ToLower());
                while (repeat != 'y' && repeat != 'n') //(!(repeat == y || repeat == n))
                {
                    Console.WriteLine("Invalid input.\nPlease introduce y to continue or n to exit.");
                    repeat = Convert.ToChar(Console.ReadLine().ToLower());
                }
            } while (repeat=='y');
            
            
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
