using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacmanGame
{
    public partial class Form1 : Form
    {
        List<ObjetoGrafico>Muros= new List<ObjetoGrafico>();
        List<ObjetoGrafico>Dots= new List<ObjetoGrafico>();
        List<ObjetoGrafico>Fantasmas= new List<ObjetoGrafico>();
        Pacman pacman = new Pacman(60,60);
        int tiempo = 0;
        Audio audio=new Audio();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Controls.Add(pacman.ImagenObjeto);
            Fantasma fantasma = new Fantasma("pinky",400,200,1);
            Fantasmas.Add(fantasma);
            this.Controls.Add(fantasma.ImagenObjeto);
            
            fantasma = new Fantasma("blinky", 400, 240, 2);
            Fantasmas.Add(fantasma);
            this.Controls.Add(fantasma.ImagenObjeto);

            fantasma = new Fantasma("inky", 400, 400, 3);
            Fantasmas.Add(fantasma);
            this.Controls.Add(fantasma.ImagenObjeto);

            fantasma = new Fantasma("clyde", 320, 200, 4);
            Fantasmas.Add(fantasma);
            this.Controls.Add(fantasma.ImagenObjeto);


            CargarMuros();
            CargarDots();
            audio.SeleccionarAudio(3);
            
        }
        void CargarDots()
        {
            var coor = CargarArchivo("dotCoor");
            for (int i = 0; i < coor.GetLength(0); i++) { 
                 Dot dot= new Dot(coor[i,0], coor[i,1]);
                 Dots.Add(dot);
                this.Controls.Add(dot.ImagenObjeto);            
            }
        }
        void CargarMuros()
        {
            var coor = CargarArchivo("coordenadas");
            for (int i = 0; i < coor.GetLength(0); i++)
            {
                Muro muro = new Muro(coor[i, 0], coor[i, 1]);
                Muros.Add(muro);
                this.Controls.Add(muro.ImagenObjeto);
            }
        }
        int[,] CargarArchivo(string nombre)
        {
            string archivo
                = Properties.Resources.ResourceManager.GetString(nombre);
            string[] lineas = archivo.Split('\n');
            int[,] coordenadas = new int[lineas.Length, 2];

            for (int i = 0; i < lineas.Length; i++)
            {
                lineas[i] = lineas[i].Trim();
                string[] strCoor = lineas[i].Split(';');
                coordenadas[i,0] = int.Parse(strCoor[0]);
                coordenadas[i,1] = int.Parse(strCoor[1]);
            }

            return coordenadas;

        }

        private void timerAnimacion_Tick(object sender, EventArgs e)
        {
            pacman.Animacion();
            int id = pacman.ComerDot(Dots);
            if(id!=-1)
            {
                lblPuntaje.Text = "Puntaje : " + pacman.Puntaje;
                this.Controls.Remove(Dots[id].ImagenObjeto);
                Dots.RemoveAt(id);
                audio.SeleccionarAudio(1);
            }

            id = pacman.Perder(Fantasmas);
            if (id != -1)
            {
                lblVidas.Text = "Vidas : " + pacman.Vidas;
                audio.SeleccionarAudio(2);
                pacman.setPos(60, 60);
            }

            if(Dots.Count==0 && tiempo<=90)
            {
                Mensaje mensaje = new Mensaje();
                mensaje.Estado = 1;
                mensaje.Show();
                timerAnimacion.Enabled = false;
                timerJuego.Enabled = false;
            }
            if(tiempo==90 && Dots.Count>0 || pacman.Vidas==0)
            {
                Mensaje mensaje = new Mensaje();
                mensaje.Estado = 0;
                mensaje.Show();
                timerAnimacion.Enabled=false;
                timerJuego.Enabled=false;
            }

            foreach (Fantasma fantasma in Fantasmas)
            {
                fantasma.Animacion();
                fantasma.Mover(Muros);
                fantasma.ColisionFantasmas(Fantasmas);
            }



        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            c=char.ToUpper(c);

            if (c == 'W')
            {
                if (!pacman.EvaluarColision(Muros))
                    pacman.MoverUp();
                else
                    pacman.Rebote(6);
            }
            else if (c == 'S')
            {
                if (!pacman.EvaluarColision(Muros))
                    pacman.MoverDown();
                else
                    pacman.Rebote(6);
            }

            else if (c == 'D')
            {
                if (!pacman.EvaluarColision(Muros))
                    pacman.MoverRight();
                else
                    pacman.Rebote(6);
            }

            else if (c == 'A')
            {
                if (!pacman.EvaluarColision(Muros))
                    pacman.MoverLeft();
                else
                    pacman.Rebote(6);
            }
        }

        private void timerJuego_Tick(object sender, EventArgs e)
        {
            tiempo++;
            lblTiempo.Text = "Tiempo : "+tiempo.ToString();
        }
    }
}
