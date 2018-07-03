using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    public class Player
    {
        public int currentPosX { get; private set; }
        public int currentPosY { get; private set; }

        int directionX = 0;
        int directionY = 0;

        public int points { get; private set; }
        public string name { get; private set; }

        public Player(int currentPosX, int currentPosY,string name)
        {
            this.currentPosX = currentPosX;
            this.currentPosY = currentPosY;
            this.name = name;
            points = 0;
        }

        public void SetPos(int posX, int posY)
        {
            currentPosX = posX;
            currentPosY = posY;
        }
    }
}
