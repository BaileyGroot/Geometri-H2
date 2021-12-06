using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    public class Square
    {
        private int side;
        public int Side
        {
            get
            {
                return side;
            }
            set
            {
                side = 5;
            }
        }

        public Square()
        {

        }

        public Square(int a)
        {
            this.side = a;
        }

        public int Perimeter()
        {
            int a = 4 * side;
            return a;
        }

        public double Area()
        {
            double a = Math.Pow(side, 2);
            return a;
        }
    }
}
