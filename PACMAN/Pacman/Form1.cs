using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pacman
{
    public partial class Form1 : Form
    {
        public Form1(List<Score> listScore)
        {
            InitializeComponent();

            int max = 10;
            int c = 0;
            if (listScore != null)
            {
                List<Score> printList = listScore.OrderByDescending(o => o.score).ToList();
                foreach (Score score in printList)
                {
                    string line = score.name + ": " + score.score.ToString();
                    topScores.Items.Add(line);
                    c++;
                    if (c > max-1) { break; }
                }
            }

        }
    }
}
