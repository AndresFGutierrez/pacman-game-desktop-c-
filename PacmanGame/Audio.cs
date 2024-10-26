using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace PacmanGame
{
    internal class Audio
    {
        SoundPlayer player;
        public Audio()
        { }
        public void SeleccionarAudio(int tipo)
        {
            switch (tipo)
            {
                case 1:
                    player = new SoundPlayer(Properties.Resources.waka);
                    break;
                case 2:
                    player = new SoundPlayer(Properties.Resources.pacman_death);
                    break;
                case 3:
                    player = new SoundPlayer(Properties.Resources.pacman_beginning);
                    break;

            }
            player.Play();
        }


    }
}
