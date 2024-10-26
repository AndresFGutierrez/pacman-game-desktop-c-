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
    public partial class Mensaje : Form
    {
        int estado;
        public Mensaje()
        {
            InitializeComponent();
        }

        public int Estado { get => estado; set => estado = value; }

        private void Mensaje_Load(object sender, EventArgs e)
        {
            if(estado==0)
            {

                pictureBox1.Image = Properties.Resources.GameOver;
            }
            else
            {
                pictureBox1.Image= Properties.Resources.you_win;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
