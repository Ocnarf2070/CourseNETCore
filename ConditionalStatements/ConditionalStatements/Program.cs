using System;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("IF Conditions");
            int valor1 = 9;
            int valor2 = 8;
            var data = valor1 != valor2;
            Console.WriteLine("Valor1: {0}\tValor2: {1}\tdata: {2}", valor1, valor2, data);
            if (data)
            {
                Console.WriteLine("The condition {0} is True", "v1!=v2");
            }

            valor2 = 9;
            data = valor1 != valor2;
            Console.WriteLine("Valor1: {0}\tValor2: {1}\tdata: {2}", valor1, valor2, data);
            if (data)
            {
                Console.WriteLine("The condition {0} is True", "v1!=v2");
            }

            valor2 = 8;
            Console.WriteLine("Valor1: {0}\tValor2: {1}", valor1, valor2);
            if (valor1 != valor2)
            {
                Console.WriteLine("The condition {0} is True", "v1!=v2");
            }

            Console.WriteLine("Valor1: {0}\tValor2: {1}", valor1, valor2);
            if (valor1 != valor2 && valor1 == valor2)
            {
                Console.WriteLine("The condition {0} is True", "(v1!=v2)&&(v1==v2)");
            }

            double valor3 = 10;
            double valor4 = 10;

            Console.WriteLine("Valor1: {0}\tValor2: {1}\tValor3: {2}\tValor4:{3}",
                valor1, valor2, valor3, valor4);
            if (valor1 != valor2 && valor3 == valor4)
            {
                Console.WriteLine("The condition {0} is True", "(v1!=v2)&&(v3==v4)");
            }

            valor4 = 11;
            Console.WriteLine("Valor1: {0}\tValor2: {1}\tValor3: {2}\tValor4:{3}",
               valor1, valor2, valor3, valor4);
            if (valor1 != valor2 || valor3 == valor4)
            {
                Console.WriteLine("The condition {0} is True", "(v1!=v2)||(v3==v4)");
            }

            valor2 = 9; valor4 = 10;
            Console.WriteLine("Valor1: {0}\tValor2: {1}\tValor3: {2}\tValor4:{3}",
               valor1, valor2, valor3, valor4);
            if (valor1 != valor2 || valor3 == valor4)
            {
                Console.WriteLine("The condition {0} is True", "(v1!=v2)||(v3==v4)");
            }

            Console.WriteLine("\nIF-ELSE Conditions");
            valor1 = 9; valor2 = 9; valor3 = 10; valor4 = 11;
            Console.WriteLine("Valor1: {0}\tValor2: {1}\tValor3: {2}\tValor4:{3}",
               valor1, valor2, valor3, valor4);
            if (valor1 != valor2 || valor3 == valor4)
            {
                Console.WriteLine("The condition {0} is True", "(v1!=v2)||(v3==v4)");
            }
            else
            {
                Console.WriteLine("The condition {0} is False", "(v1!=v2)||(v3==v4)");

            }

            Console.WriteLine("\nIF-ELSE Nested Conditions");
            valor1 = 8; valor2 = 9; valor3 = 10; valor4 = 11;
            data = valor1 != valor2;
            Console.WriteLine("Valor1: {0}\tValor2: {1}\tValor3: {2}\tValor4:{3}\tdata:{4}",
               valor1, valor2, valor3, valor4, data);
            if(data)
            {
                Console.WriteLine("The condition {0} is True", "(v1!=v2)");
                if (valor3 == valor4)
                {
                    Console.WriteLine("The condition {0} is True", "(v3==v4)");
                }
                else
                {
                    Console.WriteLine("The condition {0} is False", "(v3==v4)");
                }
            }
            else
            {
                Console.WriteLine("The condition {0} is False", "(v1!=v2)");

            }
            valor3 = 11;
            Console.WriteLine("Valor1: {0}\tValor2: {1}\tValor3: {2}\tValor4:{3}\tdata:{4}",
               valor1, valor2, valor3, valor4, data);
            if (data)
            {
                Console.WriteLine("The condition {0} is True", "(v1!=v2)");
                if (valor3 == valor4)
                {
                    Console.WriteLine("The condition {0} is True", "(v3==v4)");
                }
                else
                {
                    Console.WriteLine("The condition {0} is False", "(v3==v4)");
                }
            }
            else
            {
                Console.WriteLine("The condition {0} is False", "(v1!=v2)");

            }

            Console.WriteLine("\nConditional Operator");

            Console.WriteLine("\t* If-Else");
            valor1 = 8; valor2 = 9; valor3 = 10; valor4 = 11;
            String name;
            data = valor1 != valor2;
            Console.WriteLine("Valor1: {0}\tValor2: {1}\tValor3: {2}\tValor4:{3}\tdata:{4}",
               valor1, valor2, valor3, valor4, data);

            if (data)
            {
                name = "Alex";
            }
            else
            {
                name = "Joel";
            }

            Console.WriteLine("Name = {0}", name);

            valor1 = 9;
            data = valor1 != valor2;
            Console.WriteLine("Valor1: {0}\tValor2: {1}\tValor3: {2}\tValor4:{3}\tdata:{4}",
               valor1, valor2, valor3, valor4, data);

            if (data)
            {
                name = "Alex";
            }
            else
            {
                name = "Joel";
            }

            Console.WriteLine("Name = {0}", name);

            Console.WriteLine("\t* Operator ? ");
            valor1 = 8;
            data = valor1 != valor2;
            Console.WriteLine("Valor1: {0}\tValor2: {1}\tValor3: {2}\tValor4:{3}\tdata:{4}",
                           valor1, valor2, valor3, valor4, data);
            name = data ? "Alex" : "Joel";
            Console.WriteLine("Name = {0}", name);

            valor1 = 9;
            data = valor1 != valor2;
            Console.WriteLine("Valor1: {0}\tValor2: {1}\tValor3: {2}\tValor4:{3}\tdata:{4}",
                           valor1, valor2, valor3, valor4, data);
            name = data ? "Alex" : "Joel";
            Console.WriteLine("Name = {0}", name);




        }
    }
}
