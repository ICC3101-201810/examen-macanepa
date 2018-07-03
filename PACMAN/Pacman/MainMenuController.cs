using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

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


    /*
        public static void SerializeAll()
        {
            try
            {
                using (Stream stream = File.Open("../../archivos/usuariosData.bin", FileMode.OpenOrCreate))
                {
                    BinaryFormatter scoresData = new BinaryFormatter();
                    scoresData.Serialize(stream, ScoresList);
                }
            }
            catch (IOException) { MessageBox.Show("No se pudo serializar", "Error"); }

            try
            {
                using (Stream stream = File.Open("../../archivos/cursosData.bin", FileMode.OpenOrCreate))
                {
                    BinaryFormatter cursosData = new BinaryFormatter();
                    cursosData.Serialize(stream, cursos);
                }
            }
            catch (IOException) { MessageBox.Show("No se pudo serializar", "Error"); }

        }

        public static void DeSerializeAll()
        {
            try
            {
                using (Stream stream = File.Open("../../archivos/usuariosData.bin", FileMode.Open))
                {
                    BinaryFormatter usuariosData = new BinaryFormatter();

                    var usuariosSerializated = (List<Usuario>)usuariosData.Deserialize(stream);
                    foreach (Usuario user in usuariosSerializated)
                    {
                        if (user is Estudiante)
                        {
                            Estudiante estudiante = (Estudiante)user;

                        }
                        else if (user is Administrador)
                        {
                            Administrador admin = (Administrador)user;
                        }
                        usuarios.Add(user);

                    }
                }
            }
            catch (IOException) { }

            try
            {
                using (Stream stream = File.Open("../../archivos/cursosData.bin", FileMode.Open))
                {
                    BinaryFormatter cursosData = new BinaryFormatter();

                    var cursosSerializated = (List<CursoCurricular>)cursosData.Deserialize(stream);
                    foreach (CursoCurricular curs in cursosSerializated)
                    {
                        cursos.Add(curs);
                    }
                }
            }
            catch (IOException) { MessageBox.Show("No se pudo deserializar los cursos", "Error"); }
        }
        */

    }
    
}
