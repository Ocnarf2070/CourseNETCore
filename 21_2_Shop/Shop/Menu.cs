using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    class Menu : IMenu
    {
        Storage s = new Sweeties();
        public double requestPayment()
        {
            bool validPayment = false;
            double payment = 0;
            while (!validPayment)
            {
                Console.Write("How much do you want to pay? 5 or 10? ");
                payment = double.Parse(Console.ReadLine());
                if (payment != 5 && payment != 10) Console.WriteLine("Invalid payment");
                else validPayment = true;
            }
            return payment;
        }

        public void sales()
        {
            double total = 0;
            string op = "";
            do
            {
                Console.Write("Introduce the name of the product: ");
                string prod = Console.ReadLine();
                var product = s.GetProduct(prod);
                double payment = 0;
                while (product == null)
                {
                    Console.WriteLine("Sweet not avaliable.\nPlease select another.");
                    prod = Console.ReadLine();
                    product = s.GetProduct(prod);
                }
                Console.WriteLine("You need to pay {0}€(Euros)", product.Price);
                payment = requestPayment();
                while(payment < product.Price)
                {
                    Console.WriteLine("Not enough money. You still need to pay {0}€ more.",
                        (product.Price - payment).ToString());
                    payment += requestPayment();
                }
                if (payment > product.Price) 
                    Console.WriteLine("Your change is {0}€(Euros)", (payment - product.Price).ToString());
                total += product.Price;
                Console.WriteLine($"Your total payment is {total} €(Euros)");
                Console.WriteLine("Do you like to buy another product? Y/n");
                op = Console.ReadLine().ToLower();
            } while (op.Equals("y"));
        }

        public void sweeties()
        {
            var op = "";
            bool _continue = false;
            do
            {
                Console.Clear();
                Console.WriteLine("Sweeties sales");
                var sweeties = s.GetProducts();
                if(sweeties.Count == 0)
                {
                    Console.WriteLine("There are no sweeties.\n" +
                        "Do you want to add some? Y/n");
                    op = Console.ReadLine().ToLower();
                    if (op.Equals("y"))
                    {
                        Console.Write("How many do you want to add? ");
                        int quantity = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < quantity; i++)
                        {
                            Product p = new Product();
                            Console.WriteLine("New sweet");
                            Console.Write("Introduce the name: ");
                            p.Name = Console.ReadLine();
                            Console.Write("Introduce the price: ");
                            p.Price = Convert.ToDouble(Console.ReadLine());
                            s.AddProduct(p);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("List of sweeties");
                    foreach (var sweet in sweeties)
                    {
                        Console.WriteLine($"ID: {sweet.ID}\tSweet: {sweet.Name}\tPrice:{sweet.Price}");
                    }
                    Console.WriteLine("Do you want to buy a sweet? Y/n");
                    op = Console.ReadLine().ToLower();
                    if (op.Equals("y")) sales();
                }
                Console.WriteLine("Do you want to continue? Y/n");
                op = Console.ReadLine().ToLower();
                _continue = op.Equals("y");
            } while (_continue);
        }
    }
}
