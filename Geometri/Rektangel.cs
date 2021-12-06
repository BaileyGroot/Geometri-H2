using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    class Rektangel : Square
    {
        private int sidetwo;

        public int Sidetwo { get; set; }

        public Rektangel(int side, int sidetwo) : base(side)
        {
            this.sidetwo = Sidetwo;
        }

        public int Bredden()
        {
            int a = side * sidetwo;
            return a;
        }
    }
}
