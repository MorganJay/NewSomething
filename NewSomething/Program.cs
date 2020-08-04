using System;
using Microsoft.SqlServer.Server;

namespace NewSomething
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            
            ////var number = 1;
            ////var fee = 2;
            ////float totalPrice = 20.95f;
            ////char character = 'A';
            ////const string firstName = "James";
            ////var isWorking = false;

            ////Console.WriteLine(number);
            ////Console.WriteLine(fee);
            ////Console.WriteLine(totalPrice);
            ////Console.WriteLine(character);
            ////Console.WriteLine(firstName);
            ////Console.WriteLine(isWorking);

            //// Implicit Type Conversion

            //byte b = 1;
            //int i = b;

            ////Explicit Type Conversion
            //float f = 1.0f;
            //int s = (int) f;

            ////NonCompatible types
            //var number = "1234";
            //int osdi = Convert.ToInt32(number);

            //try
            //{
            //    string str = "1234";
            //    byte djs = Convert.ToByte(str);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Cannot be converted");
            //}

            //int a = 1;
            //int big = a++;
            //int re = ++a;
            //a -= 5;
            //int y = a;
            //Console.WriteLine(big);
            //Console.WriteLine(re);

            //ClassesAndObjects
            Student s1Student = new Student {Name = "Ajayi Jacob", CGPA = 4.5};

            Student s2Student = new Student();
            s2Student.Name = "Wana Jacob";
            s2Student.CGPA = 5.0;

            Console.WriteLine(s1Student.Name);
            Console.WriteLine(s2Student.Name);

            if (s1Student.CGPA < s2Student.CGPA)
            {
                Console.WriteLine(s2Student.Name +" has a higher CGPA.");
            }
            else
            {
                Console.WriteLine(s1Student.Name + " has  a higher CGPA.");
            }

            string myName = "hahhdbd kaddaa";
            var myNameLength = myName.Length;

            Rectangle firstRectangle = new Rectangle
                { Height = 100, Width = 800, Colour = "red", Position = new Position {X = 0 , Y = 0}};

            Rectangle secondRectangle = new Rectangle { Height = 400, Width = 200, Colour = "blue"};
            secondRectangle.Position = new Position();
            secondRectangle.Position.X = 3;
            secondRectangle.Position.Y = 32;

            double sqr = Math.Sqrt(16);

            bool isFirstRectangleSquare = IsShapeSquare(firstRectangle);
            bool isSecondRectangleSquare = IsShapeSquare(secondRectangle);

            Console.WriteLine(isFirstRectangleSquare);
            Console.WriteLine(isSecondRectangleSquare);

             bool ab = SamePosition(firstRectangle, secondRectangle);
             Console.WriteLine(ab);
        }

        private static bool SamePosition(Rectangle firsRectangle, Rectangle secondRectangle)
        {
            if (firsRectangle.Position.X == secondRectangle.Position.X && firsRectangle.Position.Y == secondRectangle.Position.Y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsShapeSquare(Rectangle r)
        {
            if (r.Width == r.Height)
            {
                return true;
            }
            return false;
        }
        
    }
}
