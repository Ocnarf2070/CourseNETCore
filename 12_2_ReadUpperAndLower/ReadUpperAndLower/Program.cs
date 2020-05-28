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

        private String uppers()
        {
            for (int i = 0; i < n; i++)
            {
                if (Char.IsUpper(str[i]))
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
        static void Main(string[] args)
        {
            var prog = new Program();
        }
    }
}
