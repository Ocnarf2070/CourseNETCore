using System;
using System.Linq;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("String Inmatability");        
            string name1 = "Alex";
            string name2 = "Jose";
            string name3 = name1;
            name1 += name2; // It delete the content of name1 and replace with the concatenation
            Console.WriteLine("Name1: " + name1);

            Console.WriteLine("\nString Format");
            Console.WriteLine("\t* Interpolation of Strings");
            var nombre = (nombre1: "Alejandro", nombre2: "Jesus",
                          age1: 23);
            Console.WriteLine($"Nombre: {nombre.nombre1}\tEdad : {nombre.age1}");
            Console.WriteLine($"Nombre: {nombre.nombre1}\tEdad : {25}");
            Console.WriteLine("\n\t* Compound Format");
            Console.WriteLine("Nombre: {0}\tEdad: {1}", nombre.nombre2, nombre.age1);
            Console.WriteLine("Nombre: {1}\tEdad: {0}", nombre.nombre2, nombre.age1);

            Console.WriteLine("\nSubstring");
            var cadena = "Curso de C# desde cero";
            Console.WriteLine("'{0}'-> Original String", cadena);
            Console.WriteLine("'{0}'\t\t-> Substring from position 9 to end", cadena.Substring(9));
            Console.WriteLine("'{0}'\t\t-> Substring from position 9 with size 11", cadena.Substring(9,11));

            var sub = cadena.Replace("desde cero", ".NET Core");
            Console.WriteLine("'{0}'\t-> Replace 'desde cero' to '.NET Core'", sub);
            var sub2 = cadena.Replace('c', 'C');
            Console.WriteLine("'{0}'-> Replace 'c' to 'C'", sub2);

            var sub3 = cadena.Remove(5);
            Console.WriteLine("'{0}'\t\t\t-> Substring subtracting from position 5 onwards", sub3);
            var sub4 = cadena.Remove(5,11);
            Console.WriteLine("'{0}'\t\t-> Substring subtracting 11 characters from position 5 ", sub4);


            Console.WriteLine("\nString Iterator");
            var data = cadena.IndexOf('#');
            Console.WriteLine("Original String: " + cadena);
            Console.WriteLine("Position of # in the string: " + data);
            var data2 = cadena.IndexOf("cero");
            Console.WriteLine("Position of 'cero' in the string: {0}-{1}",data2, data2+"cero".Length-1);
            var char_array = cadena.ToCharArray();
            Console.WriteLine("String to array of chars: [{0}]", string.Join(",", char_array));
            var lower = cadena.ToLower();
            Console.WriteLine("Lowercased String: " + lower);
            var upper = cadena.ToUpper();
            Console.WriteLine("Uppercased String: " + upper);
            var name = "Jose";
            var eq = cadena.Equals(name);
            Console.WriteLine("Is '{0}' equals to '{1}'? : {2}",cadena,name, eq);
            var cadena2 = "Curso de C# desde cero";
            var eq2 = cadena.Equals(cadena2);
            Console.WriteLine("Is '{0}' equals to '{1}'? : {2}", cadena, cadena2, eq2);
            Console.WriteLine("Iteration of the string:");
            foreach (var c in cadena)
            {
                Console.WriteLine(c);
            }


        }
    }
}
