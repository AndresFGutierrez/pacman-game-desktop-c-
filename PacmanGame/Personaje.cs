using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacmanGame
{
    internal class Personaje: ObjetoGrafico
    {
        //atributos
        int velocidad;
        string direccion;
        int estado;
        string nombre;

        public Personaje()
        {
            velocidad = 3;
            direccion = "left";
            estado = 1;
        }

        public Personaje(string nombre, int x, int y, int w, int h):
            base(nombre, x, y, w, h)
        {
            velocidad = 3;
            direccion = "left";
            estado = 1;
            this.nombre = nombre;
        }
        public void Animacion()
        {
            switch(estado)
            {
                case 1: 
                    nombreRecurso=nombre+"_"+estado+"_"+direccion;
                    estado = 2;
                    break;
                case 2:
                    nombreRecurso=nombre + "_" + estado + "_" + direccion;
                    estado = 1;
                    break;

            }
            ImagenObjeto.Image =
                (Image)Properties.Resources.ResourceManager.GetObject(nombreRecurso);

        }

        public void MoverUp()
        {
            this.posy -= velocidad;
            direccion = "up";
            setPos(posx, posy);
        }

        public void MoverDown()
        {
            this.posy += velocidad;
            direccion = "down";
            setPos(posx, posy);
        }
        public void MoverLeft()
        {
            this.posx -= velocidad;
            direccion = "left";
            setPos(posx, posy);
        }

        public void MoverRight()
        {
            this.posx += velocidad;
            direccion = "right";
            setPos(posx, posy);
        }

        public bool EvaluarColision(List<ObjetoGrafico> objetosGraficos)
        {
            for(int i=0; i<objetosGraficos.Count;i++)
            {
               if( this.GetRectangle().IntersectsWith(objetosGraficos[i].GetRectangle()))
                {
                    return true;
                }
            }
            return false;
        }
        public bool EvaluarColision(ObjetoGrafico objetosGraficos)
        {
                if (this.GetRectangle().IntersectsWith(objetosGraficos.GetRectangle()))
                {
                    return true;
                }
          
            return false;
        }

        public void Rebote(int velocidad)
        {
            switch (direccion) { 
            
            case "left":
                    {
                        this.posx += velocidad;
                        direccion = "right";
                    }break; 
            case "right":
                    {
                        this.posx -= velocidad;
                        direccion = "left";
                    }
                        break;
                case "up":
                    {
                        this.posy += velocidad;
                        direccion = "down";
                    }
                    break;
                case "down":
                        {
                        this.posy -= velocidad;
                        direccion = "up";
                    }
                    break;
            }
            setPos(posx, posy);
        }

    }
}
