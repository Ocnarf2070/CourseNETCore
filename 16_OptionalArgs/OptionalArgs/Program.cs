using System;

namespace OptionalArgs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Optional Parameters");
            var prog = new Program();
            prog.method("C#", "Jesus", 52);
            prog.method("C#", "Jesus");
            prog.method("C#");
            //prog.method("C#", 52); This method cannot be call in this way because it expects a string, not a int

            Console.WriteLine("/nOptional Parameters with name");
            prog.method("C#",quantity: 52);
            prog.method(quantity: 52, course:"C#");
            prog.method("C#", quantity: null);
            prog.method(null);

            Console.WriteLine("/nKeywords readonly and const");
            //prog.value = 56; It cannot change the value, unless it is in a constructor
            Console.WriteLine("Value: "+prog.value);
            //prog.VALUE = 56; It cannot change the value and cannot be called
            //VALUE = 56; Neither this way
            Console.WriteLine("VALUE: " + VALUE); //It can be call by itself. Not object Program needed 

        }

        //Part 1 and 2
        private void method(string course, string name = "Jose", int? quantity = 9)
        {
            Console.WriteLine($"course: {course}\t quantity: {quantity}\t name: {name}");
        }

        //Part 3
        readonly int value = 23;
        const int VALUE = 98;
        public Program()
        {
            value = 10; // Because it is in a constructor, it can change the value of the variable
            //VALUE = 56; Although it is in a constructor, it cannot change its value
        }
    }
}
