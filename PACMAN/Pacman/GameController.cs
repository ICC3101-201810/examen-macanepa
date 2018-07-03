using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pacman
{
    public class GameController
    {
        GameForm gameForm;
        Player player;

        public List<enemy> enemies { get; private set; }

        int finalScore = 0;

        public GameController(GameForm gameForm, Player player,List<enemy> enemies)
        {
            this.gameForm = gameForm;
            this.player = player;
            int posX = gameForm.Width;
            int posY = gameForm.Height;
            player.SetPos(posX/2, posY/2);

            this.enemies = enemies;

            foreach(enemy enemy in enemies)
            {
                enemy.OnKill += Die;
            }

            gameForm.LoadEnemies(enemies);

        }


        private void Die(object sender, EventArgs e) 
        {
            finalScore = player.points;
            MessageBox.Show("GAME OVER\nSCORE: " + finalScore.ToString());
        }

        


    }

}
