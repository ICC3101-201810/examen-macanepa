﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pacman
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            MainMenu mainMenu = new MainMenu();
            MainMenuController mainMenuController = new MainMenuController(mainMenu);

            Application.Run(mainMenu);




            

        }
    }
}
