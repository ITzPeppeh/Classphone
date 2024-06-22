
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
    public partial class Form_C_Display_Sec : Form
    {
        public Form_C_Display_Sec()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_C_Device_Name OldForm = new Form_C_Device_Name();
            OldForm.Show();
            this.Hide();
        }

        private void Form_C_Display_Sec_Load(object sender, EventArgs e)
        {
            if (DB_Settings.Language)
            {
                label1.Text = "Seleziona modalità di blocco schermo";
                btn_TAP.Text = "Doppio tocco";
                btn_SEQUENCE.Text = "Sequenza";
            }
            else
            {
                label1.Text = "Select screen lock mode";
                btn_TAP.Text = "Double tap";
                btn_SEQUENCE.Text = "Sequence";
            }
        }

        private void btn_PIN_Click(object sender, EventArgs e)
        {
            Form_C_Display_Sec2 NewForm = new Form_C_Display_Sec2();        //Istanzia secondo form per il blocco schermo

            if (btn_BackSettings.Visible)                               //Controllo se questo form l'ha aperto dai settings
            {
                NewForm.btn_donesettings.Visible = true;
                NewForm.button13.Visible = true;
            }
            else
            {
                NewForm.button20.Visible = true;
                NewForm.button12.Visible = true;
            }

            NewForm.Show();
            NewForm.pnl_PIN.Visible = true;
            NewForm.TypeOfDisplay = "PIN";                              //Setta una variabile pubblica tipo stringa PIN che servirá per mostrare il pannello
            this.Hide();

            //
            NewForm.pnl_PASSWORD.Visible = false;
            NewForm.pnl_SEQUENCE.Visible = false;
        }

        private void btn_PASSWORD_Click(object sender, EventArgs e)
        {
            Form_C_Display_Sec2 NewForm = new Form_C_Display_Sec2();

            if (btn_BackSettings.Visible)                               //Controllo se questo form l'ha aperto dai settings
            {
                NewForm.btn_donesettings.Visible = true;
                NewForm.button13.Visible = true;
            }
            else
            {
                NewForm.button20.Visible = true;
                NewForm.button12.Visible = true;
            }

            NewForm.Show();
            NewForm.pnl_PASSWORD.Visible = true;
            NewForm.TypeOfDisplay = "PWD";
            this.Hide();

            //
            NewForm.pnl_PIN.Visible = false;
            NewForm.pnl_SEQUENCE.Visible = false;
        }

        private void btn_SEQUENCE_Click(object sender, EventArgs e)
        {
            Form_C_Display_Sec2 NewForm = new Form_C_Display_Sec2();

            if (btn_BackSettings.Visible)                               //Controllo se questo form l'ha aperto dai settings
            {
                NewForm.btn_donesettings.Visible = true;
                NewForm.button13.Visible = true;
            }
            else
            {
                NewForm.button20.Visible = true;
                NewForm.button12.Visible = true;
            }

            NewForm.Show();
            NewForm.pnl_SEQUENCE.Visible = true;
            NewForm.TypeOfDisplay = "SEQUENCE";
            this.Hide();

            //
            NewForm.pnl_PASSWORD.Visible = false;
            NewForm.pnl_PIN.Visible = false;
        }

        private void btn_TAP_Click(object sender, EventArgs e)
        {

            DB_Settings.TypeOfLockScreen = "TAP";

            string docPath = AppDomain.CurrentDomain.BaseDirectory;                                 //Get del percorso del file eseguibile

            if (btn_BackSettings.Visible)                                                           //Controllo se questo form l'ha aperto dai settings
            {
                System.IO.File.WriteAllText(Path.Combine(docPath, "config.txt"), string.Empty);     //Svuoto il file [config.txt]
            }


            
            using (StreamWriter sw = new StreamWriter(Path.Combine(docPath, "config.txt"), true)) //scrivo su file tutti i parametri separati tra loro in sequenza
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
                    "Contact{\n");
                    if (!DB_Settings.ListOfContacts.Any())                                      //Controllo se la lista dei contatti é vuota
                        sw.Write("¬\n}");
                    else
                    {
                        foreach (var s in DB_Settings.ListOfContacts)                           //foreach di tutta la lista dei contatti [Lista d'oggetti]
                        {
                            sw.Write(
                            "[\n" +
                            "Nome:" + s.name + "¬\n" +
                            "Cognome:" + s.surname + "¬\n" +
                            "Cell:" + s.number + "¬\n" +
                            "]\n"
                            );
                        }
                    sw.Write("}");

                    }

                sw.Flush();
                sw.Close();
            }
            if (!btn_BackSettings.Visible)                                          //Controlla se non l'ha aperto dalle impostazioni
            {
                Application.Restart();                                              //Riavvia il telefono
            }
            else
            {
                Settings FormSettings = new Settings();
                FormSettings.Show();
                this.Close();
            }
            
        }

        private void btn_BackSettings_Click(object sender, EventArgs e)
        {
            Settings Form_Settings = new Settings();
            Form_Settings.Show();
            this.Close();
        }

    }
}
