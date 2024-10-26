using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacmanGame
{
    internal class Muro:ObjetoGrafico
    {

        public Muro() { }
        public Muro(int x, int y):base("muro",x,y,18,18)
        {

        }
    }
}
