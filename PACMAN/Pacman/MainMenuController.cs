using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    public class MainMenuController
    {
        
        MainMenu mainMenu;
        //public List<Score> ScoresList { get; private set; }
        public List<Score> ScoresList = new List<Score>();

        public MainMenuController(MainMenu mainMenu)
        {
            this.mainMenu = mainMenu;
            AddScores();
            mainMenu.SetScores(ScoresList);
            mainMenu.OnIniciar += StartGame;
        }

        


        private void StartGame(object sender, IniciarEventArgs e)
        {
            Player player = new Player(0, 0, e.name);

            List<enemy> enemies = new List<enemy>();

            enemy red = new enemy(player);
            enemy pink = new enemy(player);

            enemies.Add(red);
            enemies.Add(pink);

            GameForm gameForm = new GameForm(player);
            GameController gameController = new GameController(gameForm, player,enemies);
            mainMenu.Hide();
            gameForm.Show();

        }

        private void AddScores()
        {
            ScoresList.Add(new Score("Mati", 300));
            ScoresList.Add(new Score("Wiwi", 1500));
            ScoresList.Add(new Score("pdf", 54));
            ScoresList.Add(new Score("wkleñ", 10));
        }
    }
}
