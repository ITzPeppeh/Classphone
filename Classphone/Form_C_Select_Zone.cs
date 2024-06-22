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
    public partial class Form_C_Select_Zone : Form
    {
        public Form_C_Select_Zone()
        {
            InitializeComponent();
        }

        private bool status = false;                                            //La variabile [status] mi servirá per sapere
        private int index;                                                      //se ha selezionato la zona

        private void Form_C_Select_Zone_Load(object sender, EventArgs e)
        {
            if (DB_Settings.Language)
            {
                label1.Text = "Seleziona la tua zona";
                listBox2.Visible = true;
                listBox1.Visible = false;
            }
            else
            {
                label1.Text = "Select your zone";
                listBox1.Visible = true;
                listBox2.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_C_Select_Language OldForm = new Form_C_Select_Language();
            this.Hide();
            OldForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (!status)
            {
                if (DB_Settings.Language)
                    errorProvider1.SetError(listBox2, "Seleziona la tua zona");
                else
                    errorProvider1.SetError(listBox1, "Select your zone");
                return;
            }

            if (DB_Settings.Language)                                                   //In base alla lingua prende l'item della zona e lo mette nell variabile stringa Zone
            {
                DB_Settings.Zone = listBox2.Items[index].ToString();                    
            }
            else
            {
                DB_Settings.Zone = listBox1.Items[index].ToString();
            }
            Form_C_Device_Name FormDevice = new Form_C_Device_Name();
            this.Hide();
            FormDevice.Show();
        }

        private void listBox2_MouseClick(object sender, MouseEventArgs e)
        {
            index = this.listBox2.IndexFromPoint(e.Location);
            if (!status)
                status = true;
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            index = this.listBox1.IndexFromPoint(e.Location);                       //prendo l'index dalla selezione dell'utente
            if (!status)
                status = true;
        }

    }
}
