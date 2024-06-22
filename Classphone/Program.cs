using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;


namespace Classphone
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string path = AppDomain.CurrentDomain.BaseDirectory;        //Prende il Path del file Classphone.exe
            path = Path.Combine(path, "config.txt");                    

            if (File.Exists(path))                                      //Controlla se esiste
            {
                string si;
                using (StreamReader sr = new StreamReader(path))
                {
                    si = sr.ReadToEnd();                                //Prende tutti il file
                }                                                       // e controlliamo se é vuoto
                if (si == "")
                {
                    Application.Run(new Form_Welcome());                //Inizio dal form di configurazione del Telefono
                }
                else
                {
                    Application.Run(new Form_LockScreen());             //Inizio dal blocco schermo
                }
            }
            else
            {
                File.Create("config.txt");
                Application.Run(new Form_Welcome());
            }
        }
    }
}
