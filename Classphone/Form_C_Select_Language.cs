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
    public partial class Form_C_Select_Language : Form
    {
        public Form_C_Select_Language()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Seleziona lingua";
            button2.BackColor = Color.White;                            //Cambia colore dello sfondo del bottone
            button1.BackColor = Color.Khaki;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Select Language";
            button1.BackColor = Color.White;
            button2.BackColor = Color.Khaki;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_C_Select_Zone Form_Zone = new Form_C_Select_Zone();        //istanzio il form successivo
            errorProvider1.Clear();                                         //Pulisco gli errori provocati dal errorProvider

            if (button1.BackColor == Color.Khaki)                           //Controllo se ha selezionato il bottone ITALIANO
            {   
                DB_Settings.Language = true;
                Form_Zone.Show();
                this.Hide();
            }
            else if (button2.BackColor == Color.Khaki)                      //Controllo se ha selezionato il bottone ENGLISH
            {   
                DB_Settings.Language = false;
                Form_Zone.Show();
                this.Hide();
            }
            else
            {
                errorProvider1.SetError(button3, "Select Language");
            }
        }
    }
}
