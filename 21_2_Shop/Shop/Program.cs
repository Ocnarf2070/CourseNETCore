using System;

namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string op = "";
            bool _continue = false;
            do
            {
                Console.Clear();
                Console.WriteLine("What shop do you want to enter?\n" +
                    "1 - Sweeties Shop\n" +
                    "2 - Fruit Shop\n" +
                    "3 - Exit");
                switch (Console.ReadLine())
                {
                    case "1":
                        new Menu().sweeties();
                        break;
                    case "2":
                        new Menu().fruits();
                        break;
                    default:
                        _continue = false;
                        continue;
                }
                Console.WriteLine("Do you want to go another shop? Y/n");
                op = Console.ReadLine().ToLower();
                _continue = op.Equals("y");
            } while (_continue);
        }
    }
}
