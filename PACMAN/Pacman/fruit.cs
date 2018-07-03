using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    public enum FruitType { CHERRY,STRBRRY }
    public class Fruit
    {
        int point;
        int deadTime;
        FruitType tipo;
        GameForm gameForm;

        public int posX { get; private set; }
        public int posY { get; private set; }

        public Fruit(GameForm gameForm, int deadTime=10)
        {
            this.point = point;
            this.deadTime = deadTime;
            this.gameForm = gameForm;

            randomFruit();

            if (tipo == FruitType.CHERRY)
            {
                point = 100;
            }
            else if (tipo == FruitType.STRBRRY)
            {
                point = 150;
            }




        }

        private void randomFruit()
        {
            Array values = Enum.GetValues(typeof(FruitType));
            Random random = new Random();
            FruitType randomBar = (FruitType)values.GetValue(random.Next(values.Length));
        }

        private void randomPos()
        {
            Random random = new Random();
            int posX = random.Next(0, gameForm.Width);
            int posY = random.Next(0, gameForm.Height);
        }

    }
}
