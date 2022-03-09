
using System;
using System.Linq;

namespace ConsoleApp1
{

    class Program
    {

        static void Main(string[] args)
        {
            /*
            int a = 21;
            int c;
            c = a;
            Console.WriteLine("Line 1 - =  Value of c = {0}", c);

            c += a;
            Console.WriteLine("Line 2 - += Value of c = {0}", c);

            c -= a;
            Console.WriteLine("Line 3 - -=  Value of c = {0}", c);

            c *= a;
            Console.WriteLine("Line 4 - *=  Value of c = {0}", c);

            c /= a;
            Console.WriteLine("Line 5 - /=  Value of c = {0}", c);

            c = 200;
            c %= a;
            Console.WriteLine("Line 6 - %=  Value of c = {0}", c);

            c <<= 3;
            Console.WriteLine("Line 7 - <<=  Value of c = {0}", c);

            c >>= 3;
            Console.WriteLine("Line 8 - >>=  Value of c = {0}", c);

            c &= 2;
            Console.WriteLine("Line 9 - &=  Value of c = {0}", c);

            c ^= 2;
            Console.WriteLine("Line 10 - ^=  Value of c = {0}", c);

            c |= 2;
            Console.WriteLine("Line 11 - |=  Value of c = {0}", c);
            Console.ReadLine();
            */

            /*Book book1 = new Book();
            book1.title = "dasfa";
            book1.author = "dsafa";
            book1.pages = 200;*/

            var dates = new[]
            {
                DateTime.UtcNow.AddHours(-1),
                DateTime.UtcNow,
                DateTime.UtcNow.AddHours(+1),

            };

            foreach (var anonymous in
             dates.Select(
                 date => new { Formatted = $"{date:MMM dd, yyyy hh:mm zzz}", date.Ticks }))

            { Console.WriteLine($"Ticks: {anonymous.Ticks}, formatted: {anonymous.Formatted}"); }



        }
    }
}
