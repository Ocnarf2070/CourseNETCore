using System;

namespace BetterReadUpperAndLower
{
    class Program
    {
        //Atributes
        private String str;

        //Constructor
        public Program(string str)
        {
            this.str = str;
        }

        private String uppers()
        {
            string Uppers = "";
            foreach(var c in str)
            {
                if (Char.IsUpper(c))
                {
                    Uppers += $",{c}";
                }
            }
            if (Uppers.Length > 0) Uppers = Uppers.Substring(1);
            return Uppers;
        }
        private String lowers()
        {
            string Lowers = "";
            foreach (var c in str)
            {
                if (Char.IsLower(c))
                {
                    Lowers += $",{c}";
                }
            }
            if (Lowers.Length > 0) Lowers = Lowers.Substring(1);
            return Lowers;
        }
        static void Main(string[] args)
        {
            Console.Write("Write a line:");
            String str = Console.ReadLine();
            var prog = new Program(str);
            Console.WriteLine("Uppercased characters are: " + prog.uppers());
            Console.WriteLine("Lowercased characters are: " + prog.lowers());

        }
    }
}
