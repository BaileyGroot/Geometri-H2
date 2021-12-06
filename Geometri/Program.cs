using System;

namespace Geometri
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instance of the class: Square

            Square square = new Square(3);
            Square square1 = new Square(6);
            Square square2 = new Square(9);

            // Printing perimeter out

            square2.Side = 7;

            Console.WriteLine(square.Perimeter());
            Console.WriteLine(square1.Perimeter());
            Console.WriteLine(square.Area());
            Console.WriteLine(square1.Area());

            // Preventing the program from closing down.
            Console.ReadKey();

        }
    }
}
