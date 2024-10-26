using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PacmanGame
{
    internal class Fantasma: Personaje
    {
        //atributos
        int direccion;
        bool buscarDireccion;
        int id;

        public Fantasma()
        { }
        public Fantasma(string nombre,int x, int y, int id):
            base(nombre,x,y,32,32)
        {

            direccion = 2;
            buscarDireccion = false;
            this.id = id;       
        }

        public void Mover(List<ObjetoGrafico> Muros)
        { 
            Random random = new Random();
            if(buscarDireccion)
            {
                for(int i=0; i<10;i++)
                {
                    direccion=random.Next(1,5);
                }
                buscarDireccion = false;
            }
            else
            {
                if(!this.EvaluarColision(Muros))
                {
                    switch(direccion)
                    {
                        case 1: this.MoverUp(); break;
                        case 2: this.MoverRight(); break;
                        case 3: this.MoverDown(); break;
                        case 4: this.MoverLeft(); break;
                    }
                }
                else
                {
                    this.Rebote(9);
                    buscarDireccion = true;
                }
            }
        }

        public void  ColisionFantasmas(List<ObjetoGrafico> Fantasmas)
        {
            foreach (Fantasma fan in Fantasmas)
            {
                if(this.id!=fan.id)
                {
                    if(this.EvaluarColision(fan))
                    {
                        buscarDireccion = true;
                        this.Rebote(9);                  
                    }
                }
            }
        }
    }
}
