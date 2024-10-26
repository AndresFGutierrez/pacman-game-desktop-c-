using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacmanGame
{
    internal class Pacman:Personaje
    {
        //atributos
        int puntaje;
        int vidas;

        public Pacman() { }
        public Pacman(int x, int y):base("pacman",x,y,30,30)
        {
            puntaje=0;
            vidas=5;
        }
        public int Puntaje { get => puntaje; set => puntaje = value; }
        public int Vidas { get => vidas; set => vidas = value; }

        public int ComerDot(List<ObjetoGrafico> dots)
        {
            int id = -1;
            for (int i = 0; i < dots.Count; i++)
            {
                if(this.EvaluarColision(dots[i]))
                    {
                        id=i;
                        puntaje++;
                        break;  
                    }
            }
            return id;
        }

        public int Perder(List<ObjetoGrafico> Fantasmas)
        {
            int id = -1;
            for (int i = 0; i < Fantasmas.Count; i++)
            {
                if (this.EvaluarColision(Fantasmas[i]))
                {
                    id = i;
                   vidas--;
                    break;
                }
            }
            return id;
        }
    }
}
