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
    public partial class MainMenu : Form
    {
        public event EventHandler<IniciarEventArgs> OnIniciar;
        List<Score> listaScore;
        public MainMenu()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para Moverte usa:\n WASD");
            IniciarEventArgs iniciarEventArgs = new IniciarEventArgs();
            iniciarEventArgs.name = playerNameTextBox.Text;
            OnIniciar(this, iniciarEventArgs);
        }

        private void scoresButton_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1(listaScore);
            form.ShowDialog();
        }
        public void SetScores(List<Score> listaScore)
        {
            this.listaScore = listaScore;
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
