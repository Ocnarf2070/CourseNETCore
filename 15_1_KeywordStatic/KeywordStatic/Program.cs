using System;

namespace KeywordStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Statics variables");
            var conversor = new Conversor();
            //conversor.velocidad = 3.0;
            Conversor.velocidad = 3.0;
            Console.WriteLine("Velocity in conversor: "+conversor);
            var conversor2 = new Conversor();
            Console.WriteLine("Velocity in conversor2: " + conversor2);

            Console.WriteLine("\nStatic Methods");
            Conversor.Conversor1();
            Console.WriteLine("Velocity after the method Conversor1: " + Conversor.velocidad);
            Conversor.Conversor2();
            Console.WriteLine("Velocity after the method Conversor2: " + Conversor.velocidad);

            Console.WriteLine("\nStatic Class");
            Conversor_2.Conversor2();
            Console.WriteLine("class Conversor_2");
            Console.WriteLine($"Velocity after the method Conversor2: {Conversor_2.toString}");


        }


        class Conversor
        {
            //Part 1

            //public static velocidad;
            public static double velocidad;

            //Part 2
            public static void Conversor1()
            {
                velocidad += 20;
            }
            public static void Conversor2()
            {
                velocidad += 75;
            }


            public override string ToString()
            {
                return velocidad.ToString();
            }
        }

        //Part 3
        static class Conversor_2 // All propieties and method must be statics
        {
            //public Conversor_2() // Static classes cannot be instanced nor have a constructor 
            //{

            //}
            static Conversor_2()
            {

            }

            public static double velocidad;

            public static void Conversor1()
            {
                velocidad += 20;
            }
            public static void Conversor2()
            {
                velocidad += 75;
            }

            public static new string toString => velocidad.ToString();
        }
        

    }
}
