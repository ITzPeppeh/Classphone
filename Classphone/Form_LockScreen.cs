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
    public partial class Form_LockScreen : Form
    {

        public Form_LockScreen()
        {
            InitializeComponent();

            ChargingClass();
        }

        private void ChargingClass()
        {
            string riga = "";
            string WhatIsIt = "";
            string Tipo = "";
            string parola = "";
            bool IsNewContact = false;
            ContactClass NewContact;
            string nome = "", cognome = "", cell = "";

            if (DB_Settings.ListOfContacts.Any())                           //Controlla se la lista dei contatti sia vuota e la pulisce
            {
                DB_Settings.ListOfContacts.Clear();
            }

            if (DB_Settings.ValutOfLockScren.Any())                         //Controlla se la lista della sequenza sia vuota e la pulisce
            {
                DB_Settings.ValutOfLockScren.Clear();
            }



            string docPath = AppDomain.CurrentDomain.BaseDirectory;             //Get del Path del file eseguibile
            docPath = Path.Combine(docPath, "config.txt");

            using (StreamReader sr = new StreamReader(docPath))
            {   
                do                                                              //Ciclo di tutte le righe del file
                {
                    riga = sr.ReadLine();
                    if (riga == "Settings{")                                    // se trova  "Settings{" setta il WhatIsIt a S
                    {
                        WhatIsIt = "S";
                        continue;

                    }
                    else if (riga == "}" && WhatIsIt == "S")                    //Se WhatIsIt é a S e la riga é } non siamo piú nei parametri dei settings
                    {
                        riga = "";
                        WhatIsIt = "";
                    }
                    else if (riga == "Contact{")                                // se trova  "Contact{" setta il WhatIsIt a C
                    {
                        WhatIsIt = "C";
                        continue;
                    }
                    else if (riga == "}" && WhatIsIt == "C")                    //Se WhatIsIt é a C e la riga é } non siamo piú nei parametri dei contatti
                    {
                        WhatIsIt = "";
                    }
                    else if (WhatIsIt == "S")                                   //Controlla se WhatIsIt é S
                    {                                                           
                        parola = "";
                        Tipo = "";
                        for (int k = 0; k < riga.Length; k++)                   //Ciclo di tutta la riga, carattere per carattere | riga[k]
                        {
                            if (riga[k] != '¬' && riga[k] != ':')               //Se non sono keyword, inserisce il valore in [parola]
                            {
                                parola = parola + riga[k];
                            }
                            if (riga[k] == ':')                                 //Se il carattere é ':', mette il valore di parola nella variabile Tipo
                            {
                                Tipo = parola;
                                parola = "";
                            }
                            if (riga[k] == '¬')                                 //Se il carattere é '¬', switch di Tipo per ogni parametro dei settaggi
                            {                                                   //e lo inserisce nella classe DB_Settings
                                switch (Tipo)
                                {
                                    case "Lingua":
                                        DB_Settings.Language = bool.Parse(parola);
                                        break;
                                    case "Zona":
                                        DB_Settings.Zone = parola; DB_Settings.Zone = parola;
                                        break;
                                    case "DeviceName":
                                        DB_Settings.DeviceName = parola;
                                        break;
                                    case "TipoLockScreen":
                                        DB_Settings.TypeOfLockScreen = parola;
                                        break;
                                    case "ValueLockScreen":
                                        if (DB_Settings.TypeOfLockScreen == "SEQUENCE")
                                        {
                                            for (int i = 0; i < parola.Length; i++)
                                            {
                                                DB_Settings.ValutOfLockScren.Add(int.Parse(parola[i].ToString()));
                                            }
                                        }
                                        else
                                        {
                                            DB_Settings.ValueOfLockScreen = parola;
                                        }
                                        break;
                                    case "BackColor":
                                        DB_Settings.BackgroundColor = parola;
                                        break;

                                }
                            }


                        }
                    }
                    else if (WhatIsIt == "C")                                                       //Controlla se WhatIsIt é C
                    {
                        parola = "";
                        Tipo = "";
                        if (riga == "[")                                                            //Controlla se riga é l'inizio del contatto
                        {
                            IsNewContact = true;
                            continue;
                        }
                        if(riga == "]")                                                             //Controlla se riga é la fine del contatto
                        {
                            NewContact = new ContactClass()                                         //Inizializza il contatto, inserendo i parametri
                                            {
                                                name = nome,
                                                surname = cognome,
                                                number = int.Parse(cell)
                                            };
                            DB_Settings.ListOfContacts.Add(NewContact);                             //Aggiunge il contatto nella lista

                            nome = "";
                            cognome = "";
                            cell = "";
                            IsNewContact = false;
                            continue;
                        }
                        if (IsNewContact)                                                           //Controlla se siamo nei parametri del contatto
                        {
                            for (int k = 0; k < riga.Length; k++)                                   //for della riga carattere per carattere
                            {
                                if (riga[k] != '¬' && riga[k] != ':')                               //Se non sono keyword, inserisce il valore in [parola]
                                {
                                    parola = parola + riga[k];
                                }
                                if (riga[k] == ':')                                                 //Se il carattere é ':', mette il valore di parola nella variabile Tipo
                                {
                                    Tipo = parola;
                                    parola = "";
                                }
                                if (riga[k] == '¬')                                                 //Se il carattere é '¬', switch di Tipo per ogni parametro del contatto
                                {
                                    switch (Tipo)
                                    {
                                        case "Nome":
                                            nome = parola;
                                            break;
                                        case "Cognome":
                                            cognome = parola;
                                            break;
                                        case "Cell":
                                            cell = parola;
                                            break;
                                    }
                                }
                            }
                        }
                    }
                } while (riga != "}");

                sr.Close();
            }





        }

        private void Form_LockScreen_Load(object sender, EventArgs e)
        {
            if (DB_Settings.TypeOfLockScreen == "PIN")
            {
                pnl_PIN.Visible = true;

                pnl_PASSWORD.Visible = false;
                pnl_SEQUENCE.Visible = false;
            }
            else if (DB_Settings.TypeOfLockScreen == "PWD")
            {
                pnl_PASSWORD.Visible = true;

                pnl_PIN.Visible = false;
                pnl_SEQUENCE.Visible = false;
            }
            else if (DB_Settings.TypeOfLockScreen == "SEQUENCE")
            {
                pnl_SEQUENCE.Visible = true;

                pnl_PASSWORD.Visible = false;
                pnl_PIN.Visible = false;
            }

            if (DB_Settings.Language)
                label1.Text = "Sblocca il dispositivo";
            else
                label1.Text = "Unlock your device";

        }

        #region Btn PIN [inserisce il carattere nel textbox e chiama la funziona Controllore PIN]

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
            ControllorePIN();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
            ControllorePIN();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
            ControllorePIN();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
            ControllorePIN();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
            ControllorePIN();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
            ControllorePIN();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
            ControllorePIN();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
            ControllorePIN();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
            ControllorePIN();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
            ControllorePIN();
        }
        #endregion

        private void ControllorePIN()                                           //controlla l'inserimento del pin nel textbox
        {
            if (DB_Settings.ValueOfLockScreen == textBox1.Text)                 //Controlla se ha inserito il pin correttamente
            {
                Form_Home NewForm = new Form_Home();
                NewForm.Show();
                this.Hide();
            }
            if (textBox1.TextLength == 4) { textBox1.Clear(); }     //se ha inserito 4 numeri pulisce il textbox
        }

        List<int> ListForSeq = new List<int>();                                 //istanzia la lista temporanea per la sequenza

        #region btn SEQUENCE

        private void btn_S_1_Click(object sender, EventArgs e)
        {

            btn_S_1.BackColor = Color.Violet;
            btn_S_1.Enabled = false;

            btn_S_3.Enabled = false;                                //Disabilita i bottoni irraggiungibili
            btn_S_6.Enabled = false;
            btn_S_7.Enabled = false;
            btn_S_8.Enabled = false;
            btn_S_9.Enabled = false;

            if (btn_S_2.BackColor != Color.Violet)                  //Abilita i bottoni che riesce a raggiungere ma controlla se l'ha giá usato
                btn_S_2.Enabled = true;
            if (btn_S_4.BackColor != Color.Violet)
                btn_S_4.Enabled = true;
            if (btn_S_5.BackColor != Color.Violet)
                btn_S_5.Enabled = true;

            ListForSeq.Add(1);
            ControlloreSequenza();
        }

        private void btn_S_2_Click(object sender, EventArgs e)
        {

            btn_S_2.BackColor = Color.Violet;
            btn_S_2.Enabled = false;

            btn_S_7.Enabled = false;
            btn_S_8.Enabled = false;
            btn_S_9.Enabled = false;

            if (btn_S_1.BackColor != Color.Violet)
                btn_S_1.Enabled = true;
            if (btn_S_3.BackColor != Color.Violet)
                btn_S_3.Enabled = true;
            if (btn_S_4.BackColor != Color.Violet)
                btn_S_4.Enabled = true;
            if (btn_S_5.BackColor != Color.Violet)
                btn_S_5.Enabled = true;
            if (btn_S_6.BackColor != Color.Violet)
                btn_S_6.Enabled = true;

            ListForSeq.Add(2);
            ControlloreSequenza();
        }

        private void btn_S_3_Click(object sender, EventArgs e)
        {

            btn_S_3.BackColor = Color.Violet;
            btn_S_3.Enabled = false;

            btn_S_1.Enabled = false;
            btn_S_4.Enabled = false;
            btn_S_7.Enabled = false;
            btn_S_8.Enabled = false;
            btn_S_9.Enabled = false;

            if (btn_S_2.BackColor != Color.Violet)
                btn_S_2.Enabled = true;
            if (btn_S_5.BackColor != Color.Violet)
                btn_S_5.Enabled = true;
            if (btn_S_6.BackColor != Color.Violet)
                btn_S_6.Enabled = true;

            ListForSeq.Add(3);
            ControlloreSequenza();
        }

        private void btn_S_4_Click(object sender, EventArgs e)
        {
            btn_S_4.BackColor = Color.Violet;
            btn_S_4.Enabled = false;

            btn_S_3.Enabled = false;
            btn_S_6.Enabled = false;
            btn_S_9.Enabled = false;

            if (btn_S_1.BackColor != Color.Violet)
                btn_S_1.Enabled = true;
            if (btn_S_2.BackColor != Color.Violet)
                btn_S_2.Enabled = true;
            if (btn_S_5.BackColor != Color.Violet)
                btn_S_5.Enabled = true;
            if (btn_S_7.BackColor != Color.Violet)
                btn_S_7.Enabled = true;
            if (btn_S_8.BackColor != Color.Violet)
                btn_S_8.Enabled = true;

            ListForSeq.Add(4);
            ControlloreSequenza();
        }

        private void btn_S_5_Click(object sender, EventArgs e)
        {
            btn_S_5.BackColor = Color.Violet;
            btn_S_5.Enabled = false;

            if (btn_S_1.BackColor != Color.Violet)
                btn_S_1.Enabled = true;
            if (btn_S_2.BackColor != Color.Violet)
                btn_S_2.Enabled = true;
            if (btn_S_3.BackColor != Color.Violet)
                btn_S_3.Enabled = true;
            if (btn_S_4.BackColor != Color.Violet)
                btn_S_4.Enabled = true;
            if (btn_S_6.BackColor != Color.Violet)
                btn_S_6.Enabled = true;
            if (btn_S_7.BackColor != Color.Violet)
                btn_S_7.Enabled = true;
            if (btn_S_8.BackColor != Color.Violet)
                btn_S_8.Enabled = true;
            if (btn_S_9.BackColor != Color.Violet)
                btn_S_9.Enabled = true;

            ListForSeq.Add(5);
            ControlloreSequenza();
        }

        private void btn_S_6_Click(object sender, EventArgs e)
        {
            btn_S_6.BackColor = Color.Violet;
            btn_S_6.Enabled = false;

            btn_S_1.Enabled = false;
            btn_S_4.Enabled = false;
            btn_S_7.Enabled = false;

            if (btn_S_2.BackColor != Color.Violet)
                btn_S_2.Enabled = true;
            if (btn_S_3.BackColor != Color.Violet)
                btn_S_3.Enabled = true;
            if (btn_S_5.BackColor != Color.Violet)
                btn_S_5.Enabled = true;
            if (btn_S_8.BackColor != Color.Violet)
                btn_S_8.Enabled = true;
            if (btn_S_9.BackColor != Color.Violet)
                btn_S_9.Enabled = true;

            ListForSeq.Add(6);
            ControlloreSequenza();
        }

        private void btn_S_7_Click(object sender, EventArgs e)
        {

            btn_S_7.BackColor = Color.Violet;
            btn_S_7.Enabled = false;

            btn_S_1.Enabled = false;
            btn_S_2.Enabled = false;
            btn_S_3.Enabled = false;
            btn_S_6.Enabled = false;
            btn_S_9.Enabled = false;

            if (btn_S_4.BackColor != Color.Violet)
                btn_S_4.Enabled = true;
            if (btn_S_5.BackColor != Color.Violet)
                btn_S_5.Enabled = true;
            if (btn_S_8.BackColor != Color.Violet)
                btn_S_8.Enabled = true;

            ListForSeq.Add(7);
            ControlloreSequenza();
        }

        private void btn_S_8_Click(object sender, EventArgs e)
        {

            btn_S_8.BackColor = Color.Violet;
            btn_S_8.Enabled = false;

            btn_S_1.Enabled = false;
            btn_S_2.Enabled = false;
            btn_S_3.Enabled = false;

            if (btn_S_4.BackColor != Color.Violet)
                btn_S_4.Enabled = true;
            if (btn_S_5.BackColor != Color.Violet)
                btn_S_5.Enabled = true;
            if (btn_S_6.BackColor != Color.Violet)
                btn_S_6.Enabled = true;
            if (btn_S_7.BackColor != Color.Violet)
                btn_S_7.Enabled = true;
            if (btn_S_9.BackColor != Color.Violet)
                btn_S_9.Enabled = true;

            ListForSeq.Add(8);
            ControlloreSequenza();
        }

        private void btn_S_9_Click(object sender, EventArgs e)
        {

            btn_S_9.BackColor = Color.Violet;
            btn_S_9.Enabled = false;

            btn_S_1.Enabled = false;
            btn_S_2.Enabled = false;
            btn_S_3.Enabled = false;
            btn_S_4.Enabled = false;
            btn_S_7.Enabled = false;

            if (btn_S_5.BackColor != Color.Violet)
                btn_S_5.Enabled = true;
            if (btn_S_6.BackColor != Color.Violet)
                btn_S_6.Enabled = true;
            if (btn_S_8.BackColor != Color.Violet)
                btn_S_8.Enabled = true;

            ListForSeq.Add(9);
            ControlloreSequenza();
        }
        #endregion

        private void ControlloreSequenza()                                      //controlla la sequenza se é giusta
        {
            string value1 = "", value2 = "";

            foreach (var s in ListForSeq)                           //prende la sequenza inserita nel blocco schermo
            {
                value1 = value1 + s.ToString();
            }

            foreach (int s in DB_Settings.ValutOfLockScren)         //prende la sequenza memorizzata nel blocco schermo
            {
                value2 = value2 + s.ToString();
            }
            if (value1 == value2)                                   //controlla se sono uguali
            {
                Form_Home NewForm = new Form_Home();
                NewForm.Show();
                this.Hide();
            }
        }

        private void button11_Click(object sender, EventArgs e)                 //Bottone reset della sequenza
        {
            btn_S_1.Enabled = true;                                 //Abilita tutti i bottoni
            btn_S_2.Enabled = true;
            btn_S_3.Enabled = true;
            btn_S_4.Enabled = true;
            btn_S_5.Enabled = true;
            btn_S_6.Enabled = true;
            btn_S_7.Enabled = true;
            btn_S_8.Enabled = true;
            btn_S_9.Enabled = true;

            btn_S_1.BackColor = Color.White;                        //Setto i background color di tutti i bottoni
            btn_S_2.BackColor = Color.White;
            btn_S_3.BackColor = Color.White;
            btn_S_4.BackColor = Color.White;
            btn_S_5.BackColor = Color.White;
            btn_S_6.BackColor = Color.White;
            btn_S_7.BackColor = Color.White;
            btn_S_8.BackColor = Color.White;
            btn_S_9.BackColor = Color.White;

            ListForSeq.Clear();                                     //Pulisco la lista temporanea della sequenza
        }

        private void Form_LockScreen_DoubleClick(object sender, EventArgs e)    //Evento se il blocco schermo é Doppio TAP
        {
            if (DB_Settings.TypeOfLockScreen == "TAP")
            {
                Form_Home NewForm = new Form_Home();
                NewForm.Show();
                this.Hide();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)           //Controllo della password inserita nel textbox
        {
            if (DB_Settings.ValueOfLockScreen == textBox2.Text)
            {
                Form_Home NewForm = new Form_Home();
                NewForm.Show();
                this.Hide();
            }
            else if (textBox2.TextLength == textBox2.MaxLength)
                textBox2.Clear();
        }

        private void button12_Click(object sender, EventArgs e)                 //Tasto OFF
        {
            Application.Exit();
        }

        private void button15_Click(object sender, EventArgs e)                 //Occhiolino PIN
        {
            if (textBox1.UseSystemPasswordChar)
                textBox1.UseSystemPasswordChar = false;
            else
                textBox1.UseSystemPasswordChar = true;
        }

        private void button14_Click(object sender, EventArgs e)                 //Occhiolino PWD
        {
            if (textBox2.UseSystemPasswordChar)
                textBox2.UseSystemPasswordChar = false;
            else
                textBox2.UseSystemPasswordChar = true;
        }

       
    }
}
