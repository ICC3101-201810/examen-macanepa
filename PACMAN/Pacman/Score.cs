using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    public class Score
    {
        public string name { get; private set; }
        public int score { get; private set; }

        public Score(string name, int score)
        {
            this.name = name;
            this.score = score;
        }
    }
}
