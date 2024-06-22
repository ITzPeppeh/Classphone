using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Classphone
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void btn_changelockscreen_Click(object sender, EventArgs e)                //Btn per cambiare blocco schermo
        {
            Form_C_Display_Sec Form_DisplayScreen = new Form_C_Display_Sec();
            Form_DisplayScreen.Show();
            Form_DisplayScreen.btn_BackSettings.Visible = true;
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)                          //Btn per cambiare la lingua
        {
            if (DB_Settings.Language)
            {
                DB_Settings.Language = false;
                button3.Text = "Change device info";
                button6.Text = "Format device";
                btn_changelockscreen.Text = "Change lockscreen";
                button4.Text = "Change Language";
                button2.Text = "Change background color";
            }
            else
            {
                DB_Settings.Language = true;
                button3.Text = "Cambia info dispositivo";
                button6.Text = "Formatta dispositivo";
                btn_changelockscreen.Text = "Cambia Blocco schermo";
                button4.Text = "Cambia lingua";
                button2.Text = "Cambia colore sfondo";
            }



            ChargingClassFromType();

        }

        private void ChargingClassFromType()                                            //Funzione void che riscrive il file "config.txt"
        {
            string docPath = AppDomain.CurrentDomain.BaseDirectory;     //Prende il Path del file eseguibile
            System.IO.File.WriteAllText(Path.Combine(docPath, "config.txt"), string.Empty);
            string Pattern = "";
            if (DB_Settings.TypeOfLockScreen == "SEQUENCE")
            {
                foreach (var s in DB_Settings.ValutOfLockScren)
                {
                    Pattern = Pattern + s.ToString();
                }
                using (StreamWriter sw = new StreamWriter(Path.Combine(docPath, "config.txt"), true)) //scrivo su file tutti i parametri separati tra loro da un underscore e concludo con una @ per capire la fine della riga
                {
                    sw.Write(
                        "Settings{\n" +
                        "Lingua:" + DB_Settings.Language + "¬\n" +
                        "Zona:" + DB_Settings.Zone + "¬\n" +
                        "DeviceName:" + DB_Settings.DeviceName + "¬\n" +
                        "TipoLockScreen:" + DB_Settings.TypeOfLockScreen + "¬\n" +
                        "ValueLockScreen:" + Pattern + "¬\n" +
                        "BackColor:" + DB_Settings.BackgroundColor + "¬\n" +
                        "}\n" +
                        "Contact{\n¬\n}");

                    sw.Flush();
                    sw.Close();
                }

            }
            else
            {
                using (StreamWriter sw = new StreamWriter(Path.Combine(docPath, "config.txt"), true)) //scrivo su file tutti i parametri separati tra loro da un underscore e concludo con una @ per capire la fine della riga
                {
                    sw.Write(
                        "Settings{\n" +
                        "Lingua:" + DB_Settings.Language + "¬\n" +
                        "Zona:" + DB_Settings.Zone + "¬\n" +
                        "DeviceName:" + DB_Settings.DeviceName + "¬\n" +
                        "TipoLockScreen:" + DB_Settings.TypeOfLockScreen + "¬\n" +
                        "ValueLockScreen:" + DB_Settings.ValueOfLockScreen + "¬\n" +
                        "BackColor:" + DB_Settings.BackgroundColor + "¬\n" +
                        "}\n" +
                        "Contact{\n¬\n}");

                    sw.Flush();
                    sw.Close();
                }
            }

            //Form_LockScreen LockForm = new Form_LockScreen();
            //LockForm.Show();
            //this.Close();


        }
       
        private void button2_Click(object sender, EventArgs e)                          //Btn per cambiare lo sfondo della home
        {
            Choose_backgroundcolor Choosecolor = new Choose_backgroundcolor();
            Choosecolor.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)                          //Btn per cambiare il nome del dispositivo e la zona
        {
            changedeviceinfoform form_changedevice = new changedeviceinfoform();
            form_changedevice.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)                              //Btn Formatta
        {
            AreYouSureQuestionMark yesorno = new AreYouSureQuestionMark();                                  //Istanzia form
            if (DB_Settings.Language)                                                               //In base alla lingua cambia i testi dei label e mostra il form
            {
                yesorno.label1.Text = "Sei sicuro? Tutti i tuoi dati e le preferenze andranno perse";
                yesorno.button1.Text = "SI";
            }
            else
            {
                yesorno.label1.Text = "Are you sure? All your data will be lost";
                yesorno.button1.Text = "YES";
            }
            yesorno.ShowDialog();
            if (AreYouSureQuestionMark.YESORNO)                                 //Controlla se la variabile statica é True. Se si svuota i file e riavvia il telefono
            {
                string docPath = AppDomain.CurrentDomain.BaseDirectory;
                string Path1 = Path.Combine(docPath, "config.txt");
                string Path2 = Path.Combine(docPath, "notepad.txt");

                System.IO.File.WriteAllText(Path1, string.Empty);
                System.IO.File.WriteAllText(Path2, string.Empty);

                Application.Restart();
            }
            
                
        }

        private void btn_Back_Click(object sender, EventArgs e)                         //Btn per tornare alla Home
        {
            Form_Home FormHome = new Form_Home();
            FormHome.Show();
            this.Close();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            if (DB_Settings.Language)
            {
                button3.Text = "Cambia info dispositivo";
                button6.Text = "Formatta dispositivo";
                btn_changelockscreen.Text = "Cambia Blocco schermo";
                button4.Text = "Cambia lingua";
                button2.Text = "Cambia colore sfondo";
            }
            else
            {
                button3.Text = "Change device info";
                button6.Text = "Format device";
                btn_changelockscreen.Text = "Change lockscreen";
                button4.Text = "Change Language";
                button2.Text = "Change background color";
            }
        }
    }
}
