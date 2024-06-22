using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Classphone
{
    public partial class Form_Home : Form
    {
        public Form_Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)          //Btn Calcolatrice
        {
            Calculator Form_Calculator = new Calculator();
            this.Hide();
            Form_Calculator.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)            //Btn Impostazioni
        {
            Settings Form_Settings = new Settings();
            this.Hide();
            Form_Settings.Show();
        }

        private void Form_Home_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromName(DB_Settings.BackgroundColor);       //Cambia sfondo
            timer1.Start();                                                     //
        }

        private void button2_Click(object sender, EventArgs e)              //Btn Rubrica
        {
            AddressBook Form_AddressBook = new AddressBook();
            Form_AddressBook.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)              //Btn Notepad
        {
            Form_Notepad FormNote = new Form_Notepad();
            FormNote.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)            //Questo evento inserisce in tempo reale negli appositi label data e ora
        {
            label1.Text = DateTime.Now.ToString("HH:mm");

            label2.Text = DateTime.Today.ToString("d");

        }

        private void button9_Click(object sender, EventArgs e)              //Btn Carta forbici sasso
        {
            App_RockPaperScissors RockPaperScr = new App_RockPaperScissors();
            RockPaperScr.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)              //Btn Tris
        {
            App_Tris Form_Tris = new App_Tris();
            Form_Tris.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)              //Btn Calendario
        {
            Form_calendar fcalendar = new Form_calendar();
            fcalendar.Show();
            this.Hide();

        }

        private void button5_Click_1(object sender, EventArgs e)            //Btn per ritornare al blocco schermo
        {
            Form_LockScreen LOCK = new Form_LockScreen();
            LOCK.Show();
            this.Close();
        }
    }
}
