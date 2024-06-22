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
    public partial class Form_calendar : Form
    {
        public Form_calendar()
        {
            InitializeComponent();
        }

   

        private void button_Back_Click(object sender, EventArgs e) //btn per tornare alla home
        {
            this.Close();
            Form_Home fhome = new Form_Home();
            fhome.Show();
        }
    }
}
