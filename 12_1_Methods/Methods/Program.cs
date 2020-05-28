using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //------------------- Part 1
            if (args.Length>0) Console.WriteLine(args[0]);
            metodoPrivado();
            var data = new Program();
            data.metodoPrivado2();
            Console.ReadLine();

            //-------------------- Part 2
            data.metodoPublico();
            Console.WriteLine(data.metodoPrivado3());
            var str = data.metodoPrivado4();
            Console.WriteLine(str);
            Console.WriteLine(data.metodoPrivado5());
            Console.ReadLine();



        }
        private static void metodoPrivado()
        {
            Console.WriteLine("Privated Method 1");
        }
        private void metodoPrivado2()
        {
            Console.WriteLine("Privated Method 2");
        }
        public void metodoPublico()
        {
            Console.WriteLine("Public Method 1");
        }
        private string metodoPrivado3()
        {
            return "Privated Method 3";
        }
        private string metodoPrivado4()
        {
            return $"Privated Method {4}";
        }
        private int metodoPrivado5()
        {
            return Convert.ToInt32("52");
        }
    }
}
