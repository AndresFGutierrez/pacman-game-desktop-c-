using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacmanGame
{
    internal class ObjetoGrafico
    {//atributos
        protected int posx, posy;
        PictureBox imagenObjeto;
        protected string nombreRecurso;

        public PictureBox ImagenObjeto { get => imagenObjeto; 
            set => imagenObjeto = value; }

        public ObjetoGrafico() { }
        public ObjetoGrafico(string nombre,int x, int y, int w, int h)
        {
            posx = x;
            posy = y;
            imagenObjeto = new PictureBox();
            imagenObjeto.Width = w;
            imagenObjeto.Height = h;
            setPos(x, y);
            imagenObjeto.SizeMode = PictureBoxSizeMode.StretchImage;
            imagenObjeto.BackColor = Color.Transparent;
            imagenObjeto.Image =
                (Image)Properties.Resources.ResourceManager.GetObject(nombre);

        }
        public void setPos(int x, int y)
        { 
            posx = x;
            posy = y; 
            imagenObjeto.Location = new System.Drawing.Point(posx, posy);
        }
        public Rectangle GetRectangle()
        {
            return imagenObjeto.Bounds;
  
        }

    }   

}
