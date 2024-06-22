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
    public partial class Choose_backgroundcolor : Form
    {
        public Choose_backgroundcolor()
        {
            InitializeComponent();
        }
        Settings Impostazioni = new Settings();


        private void Choose_backgroundcolor_Load(object sender, EventArgs e)
        {
            if (DB_Settings.Language)
            {
                label1.Text = "Scegli un colore per il tuo sfondo";
                button1.Text = "Rosso";
                button4.Text = "Azzurro";
                button2.Text = "Verde";
                button5.Text = "Bianco";
                button3.Text = "Giallo";
                button6.Text = "Rosa";
            }
            else
            {
                button1.Text = "Red";
                button4.Text = "Light-Blue";
                button2.Text = "Green";
                button5.Text = "White";
                button3.Text = "Yellow";
                button6.Text = "Pink";
                label1.Text = "Choose your background color";

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB_Settings.BackgroundColor = "red";
            
            DB_Settings.ReloadFile();

            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DB_Settings.BackgroundColor = "lightblue";
            
            DB_Settings.ReloadFile();

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DB_Settings.BackgroundColor = "green";
            
            DB_Settings.ReloadFile();

            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DB_Settings.BackgroundColor = "white";
            
            DB_Settings.ReloadFile();

            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DB_Settings.BackgroundColor = "yellow";

            DB_Settings.ReloadFile();

            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DB_Settings.BackgroundColor = "pink";

            DB_Settings.ReloadFile();
            this.Close();
        }

        
    }
}
