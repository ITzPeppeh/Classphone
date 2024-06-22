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
    public partial class AddressBook : Form
    {
        public AddressBook()
        {
            InitializeComponent();
        }
        
        public static int index = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Home OldForm = new Form_Home();
            OldForm.Show();
            this.Close();
        } //btn per tornare alla home

        private void button2_Click(object sender, EventArgs e)
        {
            Form_AddContact FormNewContact = new Form_AddContact();
            FormNewContact.ShowDialog();
            ReloadListBox();
        }// btn che apre il form per aggiungere un nuovo contatto

        private void AddressBook_Load(object sender, EventArgs e)
        {
            ReloadListBox();

        } //carica i contatti nella listbox chiamando la funzione ReloadListBox

        private void ReloadListBox()
        {
            listBox1.Items.Clear();                             //pulisce listbox
            if (!DB_Settings.ListOfContacts.Any())             //se è vuota non fa nulla     
            {
                return;
            }

            foreach (var s in DB_Settings.ListOfContacts)              //foreach della lista dei contatti aggiungendo alla listbox "nome cognome"
            {
                listBox1.Items.Add(s.name + " " + s.surname);                  
            }
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)     //apre il form per il singolo contatto
        {
            Form_ContactInfo formcinfo = new Form_ContactInfo();                   //istanziamento form singolo contatto
            index = this.listBox1.IndexFromPoint(e.Location);                       //prende l'index dell'item selezionato
            foreach (var s in DB_Settings.ListOfContacts)                       //Foreach della lista d'oggetti 
            {
                if (listBox1.Items[index].ToString() == (s.name + " " + s.surname))     //cercando il contatto e la aggiunge ai textbox del Form_ContactInfo
                {
                    formcinfo.textBox1.Text = s.name;
                    formcinfo.textBox2.Text = s.surname;
                    formcinfo.textBox3.Text = s.number.ToString();
                }
            }
            this.Hide();
            formcinfo.ShowDialog();
            DB_Settings.ReloadFile();
            ReloadListBox();

        }
    }
}
