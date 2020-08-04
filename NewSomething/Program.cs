using System;

namespace NewSomething
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            
            //var number = 1;
            //var fee = 2;
            //float totalPrice = 20.95f;
            //char character = 'A';
            //const string firstName = "James";
            //var isWorking = false;

            //Console.WriteLine(number);
            //Console.WriteLine(fee);
            //Console.WriteLine(totalPrice);
            //Console.WriteLine(character);
            //Console.WriteLine(firstName);
            //Console.WriteLine(isWorking);

            // Implicit Type Conversion

            byte b = 1;
            int i = b;

            //Explicit Type Conversion
            float f = 1.0f;
            int s = (int) f;

            //NonCompatible types
            var number = "1234";
            int osdi = Convert.ToInt32(number);

            try
            {
                string str = "1234";
                byte djs = Convert.ToByte(str);
            }
            catch (Exception)
            {
                Console.WriteLine("Cannot be converted");
            }

            int a = 1;
            int big = a++;
            int re = ++a;
            a -= 5;
            int y = a;
            Console.WriteLine(big);
            Console.WriteLine(re);
        }
    }
}
