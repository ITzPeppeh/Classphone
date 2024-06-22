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
    public partial class Form_C_Display_Sec2 : Form
    {
        public string TypeOfDisplay;

        public Form_C_Display_Sec2()
        {
            InitializeComponent();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Form_C_Display_Sec OldForm = new Form_C_Display_Sec();
            OldForm.Show();
            this.Close();
        }                   //btn BACK della configurazione

        #region Btn PIN [controllo se ha giá inserito 4 numeri, altrimenti lo aggiungo]

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 4) { return; }
            textBox1.Text = textBox1.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 4) { return; }
            textBox1.Text = textBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 4) { return; }
            textBox1.Text = textBox1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 4) { return; }
            textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 4) { return; }
            textBox1.Text = textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 4) { return; }
            textBox1.Text = textBox1.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 4) { return; }
            textBox1.Text = textBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 4) { return; }
            textBox1.Text = textBox1.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 4) { return; }
            textBox1.Text = textBox1.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 4) { return; }
            textBox1.Text = textBox1.Text + "0";
        }
#endregion

        List<int> ListForSeq = new List<int>();                                      //Creo la lista per le sequenze temporanea

        #region btn SEQUENCE

        private void btn_S_1_Click(object sender, EventArgs e)
        {

            btn_S_1.BackColor = Color.Violet; 
            btn_S_1.Enabled = false;

            btn_S_3.Enabled = false;                        //Disabilita i bottoni che non riesce a raggiungere
            btn_S_6.Enabled = false;
            btn_S_7.Enabled = false;
            btn_S_8.Enabled = false;
            btn_S_9.Enabled = false;

            if (btn_S_2.BackColor != Color.Violet)          //Abilita i bottoni che riesce a raggiungere ma controlla se l'ha giá usato
                btn_S_2.Enabled = true;
            if (btn_S_4.BackColor != Color.Violet)
                btn_S_4.Enabled = true;
            if (btn_S_5.BackColor != Color.Violet)
                btn_S_5.Enabled = true;

            ListForSeq.Add(1);                              //La aggiunge alla lista temporanea della sequenza [List<int>]
        }

        private void btn_S_2_Click(object sender, EventArgs e)
        {

            btn_S_2.BackColor = Color.Violet;
            btn_S_2.Enabled = false;

            btn_S_7.Enabled = false;
            btn_S_8.Enabled = false;
            btn_S_9.Enabled = false;

            if (btn_S_1.BackColor != Color.Violet)
                btn_S_1.Enabled = true;
            if (btn_S_3.BackColor != Color.Violet)
                btn_S_3.Enabled = true;
            if (btn_S_4.BackColor != Color.Violet)
                btn_S_4.Enabled = true;
            if (btn_S_5.BackColor != Color.Violet)
                btn_S_5.Enabled = true;
            if (btn_S_6.BackColor != Color.Violet)
                btn_S_6.Enabled = true;

            ListForSeq.Add(2);
        }

        private void btn_S_3_Click(object sender, EventArgs e)
        {

            btn_S_3.BackColor = Color.Violet;
            btn_S_3.Enabled = false;

            btn_S_1.Enabled = false;
            btn_S_4.Enabled = false;
            btn_S_7.Enabled = false;
            btn_S_8.Enabled = false;
            btn_S_9.Enabled = false;

            if (btn_S_2.BackColor != Color.Violet)
                btn_S_2.Enabled = true;
            if (btn_S_5.BackColor != Color.Violet)
                btn_S_5.Enabled = true;
            if (btn_S_6.BackColor != Color.Violet)
                btn_S_6.Enabled = true;

            ListForSeq.Add(3);
        }

        private void btn_S_4_Click(object sender, EventArgs e)
        {

             btn_S_4.BackColor = Color.Violet;
             btn_S_4.Enabled = false;

             btn_S_3.Enabled = false;
             btn_S_6.Enabled = false;
             btn_S_9.Enabled = false;

             if (btn_S_1.BackColor != Color.Violet)
                 btn_S_1.Enabled = true;
             if (btn_S_2.BackColor != Color.Violet)
                 btn_S_2.Enabled = true;
             if (btn_S_5.BackColor != Color.Violet)
                 btn_S_5.Enabled = true;
             if (btn_S_7.BackColor != Color.Violet)
                 btn_S_7.Enabled = true;
             if (btn_S_8.BackColor != Color.Violet)
                 btn_S_8.Enabled = true;

             ListForSeq.Add(4);
        }

        private void btn_S_5_Click(object sender, EventArgs e)
        {

             btn_S_5.BackColor = Color.Violet;
             btn_S_5.Enabled = false;

             if (btn_S_1.BackColor != Color.Violet)
                 btn_S_1.Enabled = true;
             if (btn_S_2.BackColor != Color.Violet)
                 btn_S_2.Enabled = true;
             if (btn_S_3.BackColor != Color.Violet)
                 btn_S_3.Enabled = true;
             if (btn_S_4.BackColor != Color.Violet)
                 btn_S_4.Enabled = true;
             if (btn_S_6.BackColor != Color.Violet)
                 btn_S_6.Enabled = true;
             if (btn_S_7.BackColor != Color.Violet)
                 btn_S_7.Enabled = true;
             if (btn_S_8.BackColor != Color.Violet)
                 btn_S_8.Enabled = true;
             if (btn_S_9.BackColor != Color.Violet)
                 btn_S_9.Enabled = true;

             ListForSeq.Add(5);
        }

        private void btn_S_6_Click(object sender, EventArgs e)
        {

             btn_S_6.BackColor = Color.Violet;
             btn_S_6.Enabled = false;

             btn_S_1.Enabled = false;
             btn_S_4.Enabled = false;
             btn_S_7.Enabled = false;

             if (btn_S_2.BackColor != Color.Violet)
                 btn_S_2.Enabled = true;
             if (btn_S_3.BackColor != Color.Violet)
                 btn_S_3.Enabled = true;
             if (btn_S_5.BackColor != Color.Violet)
                 btn_S_5.Enabled = true;
             if (btn_S_8.BackColor != Color.Violet)
                 btn_S_8.Enabled = true;
             if (btn_S_9.BackColor != Color.Violet)
                 btn_S_9.Enabled = true;

             ListForSeq.Add(6);
        }

        private void btn_S_7_Click(object sender, EventArgs e)
        {

             btn_S_7.BackColor = Color.Violet;
             btn_S_7.Enabled = false;

             btn_S_1.Enabled = false;
             btn_S_2.Enabled = false;
             btn_S_3.Enabled = false;
             btn_S_6.Enabled = false;
             btn_S_9.Enabled = false;

             if (btn_S_4.BackColor != Color.Violet)
                 btn_S_4.Enabled = true;
             if (btn_S_5.BackColor != Color.Violet)
                 btn_S_5.Enabled = true;
             if (btn_S_8.BackColor != Color.Violet)
                 btn_S_8.Enabled = true;

             ListForSeq.Add(7);
        }

        private void btn_S_8_Click(object sender, EventArgs e)
        {

             btn_S_8.BackColor = Color.Violet;
             btn_S_8.Enabled = false;

             btn_S_1.Enabled = false;
             btn_S_2.Enabled = false;
             btn_S_3.Enabled = false;

             if (btn_S_4.BackColor != Color.Violet)
                 btn_S_4.Enabled = true;
             if (btn_S_5.BackColor != Color.Violet)
                 btn_S_5.Enabled = true;
             if (btn_S_6.BackColor != Color.Violet)
                 btn_S_6.Enabled = true;
             if (btn_S_7.BackColor != Color.Violet)
                 btn_S_7.Enabled = true;
             if (btn_S_9.BackColor != Color.Violet)
                 btn_S_9.Enabled = true;

             ListForSeq.Add(8);
        }

        private void btn_S_9_Click(object sender, EventArgs e)
        {

             btn_S_9.BackColor = Color.Violet;
             btn_S_9.Enabled = false;

             btn_S_1.Enabled = false;
             btn_S_2.Enabled = false;
             btn_S_3.Enabled = false;
             btn_S_4.Enabled = false;
             btn_S_7.Enabled = false;

             if (btn_S_5.BackColor != Color.Violet)
                 btn_S_5.Enabled = true;
             if (btn_S_6.BackColor != Color.Violet)
                 btn_S_6.Enabled = true;
             if (btn_S_8.BackColor != Color.Violet)
                 btn_S_8.Enabled = true;

             ListForSeq.Add(9);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            btn_S_1.Enabled = true;
            btn_S_2.Enabled = true;
            btn_S_3.Enabled = true;
            btn_S_4.Enabled = true;
            btn_S_5.Enabled = true;
            btn_S_6.Enabled = true;
            btn_S_7.Enabled = true;
            btn_S_8.Enabled = true;
            btn_S_9.Enabled = true;

            btn_S_1.BackColor = Color.White;
            btn_S_2.BackColor = Color.White;
            btn_S_3.BackColor = Color.White;
            btn_S_4.BackColor = Color.White;
            btn_S_5.BackColor = Color.White;
            btn_S_6.BackColor = Color.White;
            btn_S_7.BackColor = Color.White;
            btn_S_8.BackColor = Color.White;
            btn_S_9.BackColor = Color.White;

            ListForSeq.Clear();

        }

#endregion


        private void button12_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (pnl_PIN.Visible)
            {
                if (textBox1.Text == "")
                {
                    errorProvider1.SetError(textBox1, "PIN");
                    return;
                }
                DB_Settings.ValueOfLockScreen = textBox1.Text;
                DB_Settings.TypeOfLockScreen = "PIN";

                PrintToConfigFile();
                Application.Restart();
            }
            if (pnl_PASSWORD.Visible)
            {
                if (textBox2.Text == "")
                {
                    errorProvider1.SetError(textBox2, "PASSWORD");
                    return;
                }
                DB_Settings.ValueOfLockScreen = textBox2.Text;
                DB_Settings.TypeOfLockScreen = "PWD";

                PrintToConfigFile();
                Application.Restart();
            }
            if (pnl_SEQUENCE.Visible)
            {
                if (!ListForSeq.Any())
                {
                    errorProvider1.SetError(button11, "SEQUENCE");
                    return;
                }
                DB_Settings.TypeOfLockScreen = "SEQUENCE";
                DB_Settings.ValutOfLockScren = ListForSeq.ToList();

                PrintToConfigFile();
                Application.Restart();
            }
        }                   //btn DONE della configurazione

        private void Form_C_Display_Sec2_Load(object sender, EventArgs e)
        {
            if (DB_Settings.Language)
            {
                if (pnl_PIN.Visible)
                {
                    label1.Text = "Inserisci il nuovo PIN";
                }
                if (pnl_PASSWORD.Visible)
                {
                    label1.Text = "Inserisci la nuova PASSWORD";
                }
                if (pnl_SEQUENCE.Visible)
                {
                    label1.Text = "Inserisci la nuova SEQUENZA";
                }
                return;
            }

            if (pnl_PIN.Visible)
            {
                label1.Text = "Insert a new PIN";
            }
            if (pnl_PASSWORD.Visible)
            {
                label1.Text = "Insert a new PASSWORD";
            }
            if (pnl_SEQUENCE.Visible)
            {
                label1.Text = "Insert a new SEQUENCE";
            }
        }

        public void PrintToConfigFile()
        { 
            string docPath = AppDomain.CurrentDomain.BaseDirectory;     //Prende il Path del file eseguibile

            string Pattern = "";
            if (DB_Settings.TypeOfLockScreen == "SEQUENCE")
            {
                foreach (var s in DB_Settings.ValutOfLockScren)
                {
                    Pattern = Pattern + s.ToString();
                }
                using (StreamWriter sw = new StreamWriter(Path.Combine(docPath, "config.txt"), true)) //scrivo su file tutti i parametri separati tra loro in sequenza
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
                        "Contact{\n¬\n}");

                    sw.Flush();
                    sw.Close();
                }
            }
        }


        private void button13_Click(object sender, EventArgs e)
        {
            Form_C_Display_Sec FormChoose = new Form_C_Display_Sec();
            FormChoose.btn_BackSettings.Visible = true;
            FormChoose.Show();
            this.Close();



        }                   //btn BACK del form Settings

        private void btn_donesettings_Click(object sender, EventArgs e)              //btn DONE del form Settings
        {
            errorProvider1.Clear();
            string docPath = AppDomain.CurrentDomain.BaseDirectory;                 //Prende il Path del file eseguibile
            System.IO.File.WriteAllText(Path.Combine(docPath, "config.txt"), string.Empty); //Svuota il file config.txt

            if (pnl_PIN.Visible)
            {
                if (textBox1.Text == "")
                {
                    errorProvider1.SetError(textBox1, "PIN");
                    return;
                }
                DB_Settings.ValueOfLockScreen = textBox1.Text;
                DB_Settings.TypeOfLockScreen = "PIN";

            }
            if (pnl_PASSWORD.Visible)
            {
                if (textBox2.Text == "")
                {
                    errorProvider1.SetError(textBox2, "PASSWORD");
                    return;
                }
                DB_Settings.ValueOfLockScreen = textBox2.Text;
                DB_Settings.TypeOfLockScreen = "PWD";

            }
            if (pnl_SEQUENCE.Visible)
            {
                if (!ListForSeq.Any())
                {
                    errorProvider1.SetError(button11, "SEQUENCE");
                    return;
                }
                DB_Settings.TypeOfLockScreen = "SEQUENCE";
                DB_Settings.ValutOfLockScren = ListForSeq.ToList();

            }

            PrintToConfigFile();


            Form_Home FormHome = new Form_Home();

            FormHome.Show();
            this.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox2.UseSystemPasswordChar)
                textBox2.UseSystemPasswordChar = false;
            else
                textBox2.UseSystemPasswordChar = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.UseSystemPasswordChar)
                textBox1.UseSystemPasswordChar = false;
            else
                textBox1.UseSystemPasswordChar = true;
        }           
    }
}
