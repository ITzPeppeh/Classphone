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
    public partial class AreYouSureQuestionMark : Form
    {
        public AreYouSureQuestionMark()
        {
            InitializeComponent();
        }

        public static bool YESORNO = false;

        private void button1_Click(object sender, EventArgs e)
        {
            YESORNO = true;
            this.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            YESORNO = false;
            this.Close();
        }
       
    }
}
