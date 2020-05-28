using System;

namespace SwitchConditional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Switch Introduction");
            var data = 5;
            //var data = 7;
            switch (data)
            {
                case 5:
                    Console.WriteLine("Case " + data);
                    break;
                case 6:
                    Console.WriteLine("Case " + data);
                    break;
                default:
                    Console.WriteLine("Case default");
                    break;
            }
            var data2 = "Joel";
            switch (data2)
            {
                case "Joel":
                    Console.WriteLine("Case " + data2);
                    break;
                case "Alex":
                    Console.WriteLine("Case " + data2);
                    break;
                default:
                    Console.WriteLine("Case default");
                    break;
            }

            Console.WriteLine("\nSwitch Expressions #1");
            var data3 = 2;
            var result = data3 switch
            {
                1 => "Alex",
                2 => "Joel",
                3 => "PDHN",
                _ => "default"
            };
            Console.WriteLine("Case " + result);

            Console.WriteLine("\nSwitch Expressions #2");
            var (a, b, option) = (2, 6, "+"); //Tuple
            var result2 = option switch
            {
                "+" => a + b,
                "-" => a - b,
                "*" => a * b,
                "/" => a / b,
                "%" => a % b,
                _ => 0
            };
            Console.WriteLine(a+" "+option+" "+b+" = "+result2);
        }
    }
}
