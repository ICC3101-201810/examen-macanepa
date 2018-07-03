using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Pacman
{
    public partial class GameForm : Form
    {
        MainMenu mainMenu;
        public event EventHandler OnUpdate;
        int x = 0;
        int y = 0;

        int DirX = 0;
        int DirY = 0;

        //Random rnd = new Random();
        //int posX = rnd.Next(0, this.Width);
        //int posY = rnd.Next(0, this.Height);

        int e1posX = 20;
        int e1PosY = 20;

        int e2PosX = 40;
        int e2PosY = 40;

        List<Fruit> listFruit = new List<Fruit>();
        List<enemy> enemies = new List<enemy>();

        public GameForm(Player player,MainMenu mainMenu)
        {
            InitializeComponent();
            this.mainMenu = mainMenu; 
            playerNameLabel.Text = "PLAYER: "+player.name;
            this.enemies = enemies;

            x = this.Size.Width / 2;
            y = this.Size.Height / 2;
            Timer();
        }

        public void Timer()
        {
            Timer timer = new Timer();
            timer.Interval = (10); // 1 sec
            timer.Tick += new EventHandler(Update);
            timer.Start();
        }

        public void LoadEnemies(List<enemy> enemies)
        {
            this.enemies = enemies;
        }
        public void Update(object sender, EventArgs e)
        {
            if (OnUpdate != null)
            { 
                OnUpdate(this, EventArgs.Empty);
            }

            
            //if (x >= this.Width)
            if (x >= 600)
            {
                x = 550;
            }
            if (x <= 0)
            {
                x = 2;
            }
            if (y >= 400)
            {
                y = 470;
            }
            if (y <= 0)
            {
                y = 2;
            }

            playerImg.Location = new Point(x,y);

            if (x <= this.Width && x >= 0 && x <= this.Height)
            {
                x += DirX * 5;
                y += DirY * 5;
            }

            DirX = 0;
            DirY = 0;

            













            foreach (enemy enemy in enemies)
            {
                
            }
            enemyRedImg.Location = new Point(enemies[0].currentPosX, enemies[0].currentPosY);
            enemies[0].Move(15);
            enemies[1].Move(15);




        }


        private int[] randomPos()
        {
            Random rnd = new Random();
            int posX = rnd.Next(0, this.Width);
            int posY = rnd.Next(0, this.Height);
            int[] coord = { posX, posY };
            return coord;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GameForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == 119)
            {
                //MessageBox.Show("w");
                DirY = -1;
            }
            else if (e.KeyChar == 115)
            {
                //MessageBox.Show("s");
                DirY = 1;
            }
            else
            {
                DirY = 0;
            }

            if (e.KeyChar == 97)
            {
                //MessageBox.Show("a");
                DirX = -1;
            }
            else if (e.KeyChar ==100)
            {
                //MessageBox.Show("d");
                DirX = 1;
            }
            else
            {
                DirX = 0;
            }
        }

        private void GameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainMenu.Show();
            //Application.Exit();
        }

        private void randomFruit()
        {
            Fruit fruit = new Fruit(this);
            listFruit.Add(fruit);
        }

        private void GameForm_Load(object sender, EventArgs e)
        {

        }
    }
}
