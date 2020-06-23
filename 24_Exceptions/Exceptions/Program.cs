using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Try-catch Structure");
            try
            {
                int data = Convert.ToInt32("k");
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                
            }

            Console.WriteLine("\nKeyword: catch");
            try
            {
                int[] array = { };
                int data = array[0];
            }
            catch(FormatException e)
            {
                Console.WriteLine("FormatException: " + e.Message);

            }
            catch (Exception e)
            {

                Console.WriteLine("Exception: " + e.Message);
                
            }

            try
            {
                int[] array = { };
                int data = array[0];
            }
            catch (FormatException e)
            {
                Console.WriteLine("Exception: " + e.Message);

            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("IndexOutOfRangeException: " + e.Message);

            }
            catch (Exception e)
            {

                Console.WriteLine("Exception: " + e.Message);
                
            }

            Console.WriteLine("\nKeyword: finally");

            try
            {
                int[] array = { };
                int data = array[0];
            }
            catch (FormatException e)
            {
                Console.WriteLine("Exception: " + e.Message);

            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("IndexOutOfRangeException: " + e.Message);

            }
            catch (Exception e)
            {

                Console.WriteLine("Exception: " + e.Message);

            }
            finally
            {
                Console.WriteLine("finally block");
            }

            Console.WriteLine("\nCustom Exceptions");

            try
            {
                int[] array = { };
                int data = array[0];
            }
            catch (FormatException e)
            {
                Console.WriteLine("Exception: " + e.Message);

            }
            catch (IndexOutOfRangeException e)
            {
               throw new CourseException("The program has thrown an exception");

            }
            catch (Exception e)
            {

                Console.WriteLine("Exception: " + e.Message);

            }
            finally
            {
                Console.WriteLine("finally block {");
                try
                {
                    throw new CourseException("The program has thrown an exception");
                }
                catch (CourseException e)
                {
                    Console.WriteLine(e.Message);

                }
                finally
                {
                    Console.WriteLine("finally block }");
                }
            }

           

        }
    }
}
