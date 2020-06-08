using System;
using System.Collections.Generic;

namespace ClassList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part 1
            List<string> list = new List<string>();
            List<Object> list2 = new List<Object>();
            //list.Add(32); It cannot be beacuse it expected a string, not an integer 
            list.Add("Manuel");
            list2.Add(32);
            list2.Add("Leo");
            Console.WriteLine("Object saved in list 2 at 0: "+list2[0]);
            Console.WriteLine("Size of list2: "+list2.Count);
            Console.WriteLine("Adding an Object");
            list2.Add(true);
            Console.WriteLine("Size of list2: " + list2.Count);
            list2.Remove(32);
            Console.WriteLine("Removing an Object");
            Console.WriteLine("Size of list2: " + list2.Count);

            //Part 2
            Console.WriteLine("\n* ForEach Method\nObjects in list2:");
            list2.ForEach(item => { Console.Write(item+" "); });
            Console.WriteLine();
            Console.WriteLine("* Traditional Loop For\nObjects in list2:");
            for (int i = 0; i < list2.Count; i++)
            {
                Console.Write(list2[i]);
                if (i+1 != list2.Count)  Console.Write(", ");
                else Console.WriteLine();
            }
            Console.WriteLine("* Alternative Loop For\nObjects in list2:");
            int j = 0;
            for(; ; )
            {
                if (j < list2.Count)
                {
                    Console.Write(list2[j]);
                    j++;
                    if (j != list2.Count) Console.Write(", ");
                    else Console.WriteLine();
                }
                else break;
            }

            //Part 3
            Console.WriteLine("\n* One-lined ForEach Method\nObjects in list2:");
            list2.ForEach(item => Console.Write(item + " ") );
            Console.WriteLine();
            Console.WriteLine("* ForEach Loop\nObjects in list2:");
            foreach (var item in list2)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Insert Objects");
            list2.Insert(1, "JoseManuel");
            list2.Insert(1, 32);
            //list2.Insert(10, 0); IT canno be done because in this moment thw list only has 4 elements
            Console.WriteLine("Objects in list2:");
            list2.ForEach(item => Console.Write(item + " "));
            Console.WriteLine();
            Console.WriteLine("Position of '32' in list2: " + list2.IndexOf(32));
            Console.WriteLine("Position of '32' in list2 from the position 2: " + list2.IndexOf(32, 2));
            Console.WriteLine("Position of '32' in list2 from the position 1: " + list2.IndexOf(32, 1));
            Console.WriteLine("Position of '32' in list2 from the position 0 to 1: " + list2.IndexOf(32, 0, 1));
            Console.WriteLine("Position of '32' in list2 from the position 0 to 2: " + list2.IndexOf(32, 0, 2));

            //Part 4
            List<Object> list3 = new List<object>(list2.Count);
            list2.ForEach((item) => list3.Add(item));
            Console.WriteLine("\nClear list2");
            list2.Clear();
            Console.WriteLine("Objects in list2: ");
            list2.ForEach(item => { Console.Write(item + " "); });

            list3.Add("Leo");
            Console.WriteLine("Objects in list3: ");
            list3.ForEach(item => { Console.Write(item + " "); });
            Console.WriteLine();
            var ind = list3.LastIndexOf("Leo");
            Console.WriteLine("Position of 'Leo' in list3 from the end to the start: "+ind);
            ind = list3.LastIndexOf("Leo",2);
            Console.WriteLine("Position of 'Leo' in list3 from the position 2 to the start: " + ind);

            Console.WriteLine("Reverse list3");
            list3.Reverse();
            Console.WriteLine("Objects in list3: ");
            list3.ForEach(item => { Console.Write(item + " "); });
            Console.WriteLine();

            Console.WriteLine("Is '32' in list3? "+list3.Contains(32));
            Console.WriteLine("Is '323' in list3? " + list3.Contains(323));

            Console.WriteLine("Does 'Leo' exist in list3? " + list3.Exists(e => e.Equals("Leo")));
            // Console.WriteLine("Exists 'Leo' in list3? " + list3.Exists("Leo")); It cannot be done in this form because Exist needs a predicate
            Console.WriteLine("Does 'Pepe' exist in list3? " + list3.Exists(e => e.Equals("Pepe")));

        }
    }
}
