using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacmanGame
{
    internal class Dot: ObjetoGrafico
    {

        public Dot() { }
        public Dot(int x, int y):base("dot",x,y,12,12) 
        { }
    }
}
