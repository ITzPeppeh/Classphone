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
    public partial class Form_C_Device_Name : Form
    {
        public Form_C_Device_Name()
        {
            InitializeComponent();
        }

        private void Form_C_Device_Name_Load(object sender, EventArgs e)
        {
            if (DB_Settings.Language)
            {
                label1.Text = "Inserisci nome dispositivo";
            }
            else
            {
                label1.Text = "Insert device name";
            }
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (textBox1.Text == "")
            {
                if (DB_Settings.Language)
                    errorProvider1.SetError(textBox1, "Inserisci nome device");
                else
                    errorProvider1.SetError(textBox1, "Insert device name");
                return;
            }
            DB_Settings.DeviceName = textBox1.Text;                                         //inserisci il nome del dispositivo nella variabile DeviceName

            Form_C_Display_Sec NewForm = new Form_C_Display_Sec();
            this.Hide();
            NewForm.Show();
            NewForm.button1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_C_Select_Zone OldForm = new Form_C_Select_Zone();
            OldForm.Show();
            this.Hide();
        }
    }
}
