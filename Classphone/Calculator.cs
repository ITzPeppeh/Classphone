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
    public partial class Calculator : Form
    {
        CalculatorClass ClassCall = new CalculatorClass();
        public double number = 0;
        public string sign = "";

        public Calculator()
        {
            InitializeComponent();
        } 

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out number))
            { }
            else
            {
                number = 0;
            }
        }

       

        private void button_Back_Click(object sender, EventArgs e)
        {
            Form_Home FormHome = new Form_Home();
            this.Close();
            FormHome.Show();
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label_History.Text = "";
            sign = "";
            ClassCall.Clear();
            button_Result.Enabled = true;
        }

        #region Btn Tastierino

        private void button_0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button_dot_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }
        #endregion

        private void button_Negative_Click(object sender, EventArgs e)      //Btn Negative
        {
            double x = 0;
           double.TryParse(textBox1.Text, out x);
           textBox1.Text = (x * -1).ToString();
        }

        private void button_Sium_Click(object sender, EventArgs e)          //Btn Somma
        {
            sign = "+";
            ClassCall.SetNumber(number, "+");
            GoToHistory();
            textBox1.Clear();
            button_Result.Enabled = true;
        }

        private void button_Subtraction_Click(object sender, EventArgs e)       //Btn Sottrazione
        {
            sign = "-";
            ClassCall.SetNumber(number, "-");
            GoToHistory();
            textBox1.Clear();
            button_Result.Enabled = true;
        }

        private void button_Multiplication_Click(object sender, EventArgs e)        //Btn Moltiplicazione
        {
            sign = "*";
            ClassCall.SetNumber(number, "*");
            GoToHistory();
            textBox1.Clear();
            button_Result.Enabled = true;
        }

        private void button_Division_Click(object sender, EventArgs e)              //Btn Divisione
        {
            sign = "/";
            ClassCall.SetNumber(number, "/");
            GoToHistory();
            textBox1.Clear();
            button_Result.Enabled = true;
        }

        private void button_spqr_Click(object sender, EventArgs e)              //Btn radice quadrata
        {
            ClassCall.SetNumber(number, "sqrt");
            sign = "√";
            GoToHistory();
            textBox1.Text = ClassCall.GetResult().ToString();
            button_Result.Enabled = false;
            //MessageBox.Show(ClassCall.GetResult().ToString("F16"));
            //textBox1.Clear();
        }

        private void button_Result_Click(object sender, EventArgs e)            //Btn result
        {
            ClassCall.SetNumber(number, sign);
            sign = "=";
            GoToHistory();
            textBox1.Text = ClassCall.GetResult().ToString();
            button_Result.Enabled = false;
            
            //MessageBox.Show(ClassCall.GetResult().ToString("F16"));
        }

        void GoToHistory()                                                      //Funzione void che aggiunge al label i numeri e segni
        {
            if (label_History.Text != "")
            {
                label_History.Text = label_History.Text + number.ToString() + sign;
            }
            else
            {
                label_History.Text = number.ToString() + sign;
            }
        }

    }
}
