using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pacman
{
    
    public class enemy
    {
        public event EventHandler OnKill;

        Player player;

        public int currentPosX { get; private set; }
        public int currentPosY { get; private set; }

        public double dirX { get; private set; }
        public double dirY { get; private set; }

        double distancePlayer;
        double killDistance = 10;

        public enemy(Player player, int currentPosX = 40, int currentPosY = 40)
        {
            this.player = player;
            this.currentPosX = currentPosX;
            this.currentPosY = currentPosY;
        }


        private void calcDir()
        {
            int distX = (currentPosX - player.currentPosX);
            int distY = (currentPosY - player.currentPosY);

            double dirX = distX * 1.0 / (distY * 1.0 * distY * 1.0);
            double dirY = distY * 1.0 / (distY * 1.0 * distY * 1.0);

     
        }


        public void Move(int factor)
        {
            calcDir();
            //MessageBox.Show(currentPosX.ToString());
            currentPosX += Convert.ToInt32 (dirX * factor);
            currentPosY += Convert.ToInt32 (dirY * factor);
        }

        private void kill()
        {
            if (distancePlayer < 20)
            {
                OnKill(this,EventArgs.Empty);
            }
        }

    }
}
