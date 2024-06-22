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
    public partial class Form_Notepad : Form
    {
        public Form_Notepad()
        {
            InitializeComponent();
        }

        private void Form_Notepad_Load(object sender, EventArgs e)      //funzione per caricare il contenuto del file notepad.txt in textbox1
        {
            string docPath = AppDomain.CurrentDomain.BaseDirectory;
            docPath = Path.Combine(docPath, "notepad.txt");

            if (File.Exists(docPath))
            {
                string si;
                using (StreamReader sr = new StreamReader(docPath))
                {
                    si = sr.ReadToEnd();
                    textBox1.Text = si;
                }

            }
            else
            {
                File.Create("notepad.txt");
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)      //funzione per salvare il contenuto del textbox1 in notepad.txt
        {
            string docPath = AppDomain.CurrentDomain.BaseDirectory;
            docPath = Path.Combine(docPath, "notepad.txt");

            System.IO.File.WriteAllText(docPath, string.Empty);

            using (StreamWriter sw = new StreamWriter(docPath, true))
            {
                sw.Write(textBox1.Text);
            }

        }

        private void btn_Back_Click(object sender, EventArgs e)     //btn per tornare alla Home
        {
            this.Close();
            Form_Home OldForm = new Form_Home();
            OldForm.Show();
        }

    }
}
