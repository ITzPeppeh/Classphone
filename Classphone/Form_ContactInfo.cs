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
    public partial class Form_ContactInfo : Form
    {
        public Form_ContactInfo()
        {
            InitializeComponent();
        }

        private void Form_ContactInfo_Load(object sender, EventArgs e)
        {
            if (DB_Settings.Language)
            {
                label1.Text = "Nome:";
                label2.Text = "Cognome:";
                label3.Text = "Numero:";

            }
            else
            {
                label1.Text = "Name:";
                label2.Text = "Surname:";
                label3.Text = "Number:";
            }
        }

        private void btn_editcontact_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (textBox1.ReadOnly)                                                          //Controlla se c'é la proprietá ReadOnly e la disabilita
            {
                textBox1.ReadOnly = false;
                textBox2.ReadOnly = false;
                textBox3.ReadOnly = false;
                button1.Enabled = false;
            }
            else
            {
                if (textBox1.Text == "" && textBox2.Text == "")                                     //Controlla se nel modificare abbia tolto completamente tutti e due
                {
                    if (DB_Settings.Language)
                        errorProvider1.SetError(btn_editcontact, "Aggiungi il nome o cognome");
                    else
                        errorProvider1.SetError(btn_editcontact, "Add name or surname");
                    return;
                }

                int TryNumber;
                if(!int.TryParse(textBox3.Text,out TryNumber))                              //Controlla se ha inserito numeri nel textbox
                {
                    if (DB_Settings.Language)
                        errorProvider1.SetError(btn_editcontact, "Numero non valido");
                    else
                        errorProvider1.SetError(btn_editcontact, "Number invalid");
                    return;
                }
                                                                                                //Modifica i parametri del contatto
                DB_Settings.ListOfContacts.ElementAt(AddressBook.index).name = textBox1.Text;
                DB_Settings.ListOfContacts.ElementAt(AddressBook.index).surname = textBox2.Text;
                DB_Settings.ListOfContacts.ElementAt(AddressBook.index).number = TryNumber;
                
                textBox1.ReadOnly = true;                                                       //Rimette il readonly dei textbox
                textBox2.ReadOnly = true;
                textBox3.ReadOnly = true;
                button1.Enabled = true;
            }
            

        }

        private void btn_Back_Click(object sender, EventArgs e)         //Btn per tornare alla Rubrica
        {
            AddressBook FormAdrres = new AddressBook();
            FormAdrres.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)              //Btn per eliminare il contatto
        {
            AreYouSureQuestionMark yesorno = new AreYouSureQuestionMark();      //Istanzia il form
            if (DB_Settings.Language)                                           //Modifica i testi del form o lo mostra
            {
                yesorno.label1.Text = "Sei sicuro di voler eliminare il contatto?";
                yesorno.button1.Text = "SI";
            }
            else
            {
                yesorno.label1.Text = "Are you sure to delete this contact?";
                yesorno.button1.Text = "YES";
            }
            yesorno.ShowDialog();
            if (AreYouSureQuestionMark.YESORNO)                                 //Controlla se la variabile statica sia True o False
            {
                DB_Settings.ListOfContacts.RemoveAt(AddressBook.index);         //Elimina il contatto
            }
            AddressBook FormAdrres = new AddressBook();                 //Riporta alla Rubrica
            FormAdrres.Show();
            this.Close();
        }
    }
}
