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
    public partial class changedeviceinfoform : Form
    {
        public changedeviceinfoform()
        {
            InitializeComponent();
        }

        private bool status = false;
        private int index = 50;

        private void listBox2_MouseClick(object sender, MouseEventArgs e)
        {
            index = this.listBox2.IndexFromPoint(e.Location);
            if (!status)
                status = true;
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            index = this.listBox1.IndexFromPoint(e.Location);
            if (!status)
                status = true;
        }

        private void changedeviceinfoform_Load(object sender, EventArgs e)
        {
            if (DB_Settings.Language)
            {
                label1.Text = "Nome dispotivo:";
                label2.Text = "Zona attuale: " + DB_Settings.Zone;
                listBox2.Visible = true;
                listBox1.Visible = false;
            }
            else
            {
                label1.Text = "Device name:";
                label2.Text = "Current zone: " + DB_Settings.Zone;
                listBox1.Visible = true;
                listBox2.Visible = false;
            }
            textBox1.Text = DB_Settings.DeviceName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (textBox1.Text == "")
            {
                if(!DB_Settings.Language)
                    errorProvider1.SetError(textBox1, "Insert Device Name");
                else
                    errorProvider1.SetError(textBox1, "Inserisci Nome Dispositivo");
                return;
            }

            if(index != 50)
            {
                if (DB_Settings.Language)
                {
                    DB_Settings.Zone = listBox2.Items[index].ToString();
                }
                else
                {
                    DB_Settings.Zone = listBox1.Items[index].ToString();
                }
            }

            DB_Settings.DeviceName = textBox1.Text;

            DB_Settings.ReloadFile();

            this.Close();

        }

    

            //Form_LockScreen LockForm = new Form_LockScreen();
            //LockForm.Show();
            //this.Close();


        

        
    }
}
