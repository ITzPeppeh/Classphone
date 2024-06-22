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
    public partial class Form_Welcome : Form
    {
        public Form_Welcome()
        {
            InitializeComponent();
        }

        private void Form_Welcome_Click(object sender, EventArgs e)
        {
            Form_C_Select_Language NewForm = new Form_C_Select_Language();      //Istanzio Il form
            NewForm.Show();                                                     //lo mostro
            this.Hide();                                                        //e nascondo questo form
        }
    }
}
