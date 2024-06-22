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
    public partial class Form_AddContact : Form
    {
        public Form_AddContact()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                if (DB_Settings.Language)
                    errorProvider1.SetError(button1, "Contatto vuoto");
                else
                    errorProvider1.SetError(button1, "Contact Empty");
                return;
            }

            bool IsNew = true;
            foreach (var s in DB_Settings.ListOfContacts)
            {
                if (s.name == textBox1.Text && s.surname == textBox2.Text)
                    IsNew = false;
            }
            if (!IsNew)
            {
                if (DB_Settings.Language)
                    errorProvider1.SetError(button1, "Contatto esistente");
                else
                    errorProvider1.SetError(button1, "Contact Exist");
                return;
            }
            
            int TryNumber;
            if(!int.TryParse(textBox3.Text,out TryNumber))
            {
                if (DB_Settings.Language)
                    errorProvider1.SetError(button1, "Numero non valido");
                else
                    errorProvider1.SetError(button1, "Number invalid");
                return;
            }

            ContactClass NewContact = new ContactClass()
            {
                name = textBox1.Text,
                surname = textBox2.Text,
                number = TryNumber
            };
            DB_Settings.ListOfContacts.Add(NewContact);
            DB_Settings.ReloadFile();
            this.Close();



        }

        private void Form_AddContact_Load(object sender, EventArgs e)
        {
            if (DB_Settings.Language)
            {
                label4.Text = "Nuovo contatto";
                label1.Text = "Nome:";
                label2.Text = "Cognome:";
                label3.Text = "Numero:";

            }
            else
            {
                label4.Text = "New Contact";
                label1.Text = "Name:";
                label2.Text = "Surname:";
                label3.Text = "Number:";
            }
        }
    }
}
;