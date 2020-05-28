using System;

namespace ReadUpperAndLower
{
    class Program
    {
        private String str;
        private String seeUppers = "";
        private String seeLowers = "";
        private int n;
        private string[] Uppers;
        private string[] Lowers;
        private string[] tempUp;
        private string[] tempLo;

        public Program(string str)
        {
            this.str = str;
            n = str.Length;
            Uppers = new string[n];
            Lowers = new string[n];
            tempUp = new string[n];
            tempLo = new string[n];
        }

        private String uppers()
        {
            for (int i = 0; i < n; i++)
            {
                if (Char.IsUpper(str[i])) // If the character is Uppercased
                {
                    tempUp[i] = Convert.ToString(str[i]);
                }

            }
            for (int i = 0; i < tempUp.Length; i++)
            {
                if(tempUp[i] != null)
                {
                    Uppers[i] = tempUp[i];
                    seeUppers += $",{Uppers[i]}";
                }
            }
            return seeUppers;
        }
        private String lowers()
        {
            for (int i = 0; i < n; i++)
            {
                if (Char.IsLower(str[i])) // If the character is Lowercased
                {
                    tempLo[i] = Convert.ToString(str[i]);
                }

            }
            for (int i = 0; i < tempLo.Length; i++)
            {
                if (tempLo[i] != null)
                {
                    Lowers[i] = tempLo[i];
                    seeLowers += $",{Lowers[i]}";
                }
            }
            return seeLowers;
        }
        static void Main(string[] args)
        {
            Console.Write("Write a line:");
            String str = Console.ReadLine();
            var prog = new Program(str);


        }
    }
}
