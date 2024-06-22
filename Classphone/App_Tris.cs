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
    public partial class App_Tris : Form
    {
        Random ran = new Random();

        public App_Tris()
        {
            InitializeComponent();
        }

        private int x, WhoIsPlaying = 0;

        private void rBtn_1_CheckedChanged(object sender, EventArgs e)      //Abilita il btn per iniziare la partita
        {
            if(rBtn_1.Checked)
            {
                btn_StartMatch.Enabled = true;
            }
        }

        private void rBtn_2_CheckedChanged(object sender, EventArgs e)      //Abilita il btn per iniziare la partita
        {
            if (rBtn_2.Checked)
            {
                btn_StartMatch.Enabled = true;
            }
        }

        private void btn_StartMatch_Click(object sender, EventArgs e)       //Btn inizio partita
        {
            grbox_player.Enabled = false;                                   //Disabilita il groupbox per selezionare i giocatori
            btn_Reset.Visible = true;                                       //Mostra btn Reset
            panel1.Enabled = true;                                          //Panel1 é il goco con i 9 bottoni
            btn_StartMatch.Enabled = false;
            label1.Text = "";

            if (rBtn_1.Checked)                                         //Controlla se ha selezionato 1 giocatore 
            {
                Game1Player();
            }
            else
            {
                Game2Player();
            }

        }

        private void btn_Reset_Click(object sender, EventArgs e)           //btn Reset
        {
            CliarAll();
        }

        private void CliarAll()                         //Funzione che pulisce tutti i testi dei bottoni e li abilita
        {
            btn_Game1.Text = "";
            btn_Game2.Text = "";
            btn_Game3.Text = "";
            btn_Game4.Text = "";
            btn_Game5.Text = "";
            btn_Game6.Text = "";
            btn_Game7.Text = "";
            btn_Game8.Text = "";
            btn_Game9.Text = "";
            btn_StartMatch.Enabled = true;

            btn_Game1.Enabled = true;
            btn_Game2.Enabled = true;
            btn_Game3.Enabled = true;
            btn_Game4.Enabled = true;
            btn_Game5.Enabled = true;
            btn_Game6.Enabled = true;
            btn_Game7.Enabled = true;
            btn_Game8.Enabled = true;
            btn_Game9.Enabled = true;
            panel1.Enabled = false;
            btn_Reset.Visible = false;
            grbox_player.Enabled = true;
        }

        private void Game1Player()
        {
            int selected;
            x = ran.Next(2);                    //Randomizza 0 o 1  [Se 0 la prima mossa tocca al computer]
            if (x == 0)
            {
                selected = ran.Next(1, 10);     //Randomizza da 1 a 9 e fa lo switch e disabilita il tasto
                switch (selected)
                {
                    case 1:
                        btn_Game1.Text = "X";
                        btn_Game1.Enabled = false;
                        break;
                    case 2:
                        btn_Game2.Text = "X";
                        btn_Game2.Enabled = false;
                        break;
                    case 3:
                        btn_Game3.Text = "X";
                        btn_Game3.Enabled = false;
                        break;
                    case 4:
                        btn_Game4.Text = "X";
                        btn_Game4.Enabled = false;
                        break;
                    case 5:
                        btn_Game5.Text = "X";
                        btn_Game5.Enabled = false;
                        break;
                    case 6:
                        btn_Game6.Text = "X";
                        btn_Game6.Enabled = false;
                        break;
                    case 7:
                        btn_Game7.Text = "X";
                        btn_Game7.Enabled = false;
                        break;
                    case 8:
                        btn_Game8.Text = "X";
                        btn_Game8.Enabled = false;
                        break;
                    case 9:
                        btn_Game9.Text = "X";
                        btn_Game9.Enabled = false;
                        break;
                }
            }
        }

        private void Game2Player()                      //Funzione che setta la variabile WhoIsPlaying a 1 [Nella variabile ci saranno 1 e 2, che equivalgono al giocatore 1 o 2]
        {
            WhoIsPlaying = 1;
        }

        private bool Checkking_1Player(int y)           //Funzione per il giocatore alla partita contro il bot
        {
            switch (y)                                  //Switch del parametro y    [come parametro verrá passato a che posizione ha fatto la mossa]
            {                                           //E controlla tutte le possibile vincite e se vince ritorna Vero [True], altrimetri [False]
                case 1:
                    if (btn_Game2.Text == "") { }
                    else if (btn_Game2.Text == "X") { }
                    else
                    {
                        if (btn_Game3.Text == "") { }
                        else if (btn_Game3.Text == "X") { }
                        else
                        {
                            return true;
                        }
                    }
                    if (btn_Game5.Text == "") { }
                    else if (btn_Game5.Text == "X") { }
                    else
                    {
                        if (btn_Game9.Text == "") { }
                        else if (btn_Game9.Text == "X") { }
                        else
                        {
                            return true;
                        }
                    }
                    if (btn_Game4.Text == "") { }
                    else if (btn_Game4.Text == "X") { }
                    else
                    {
                        if (btn_Game7.Text == "") { }
                        else if (btn_Game7.Text == "X") { }
                        else
                        {
                            return true;
                        }
                    }
                    break;
                case 2:
                    if (btn_Game1.Text == "") { }
                    else if (btn_Game1.Text == "X") { }
                    else
                    {
                        if (btn_Game3.Text == "") { }
                        else if (btn_Game3.Text == "X") { }
                        else
                        {
                            return true;
                        }
                    }
                    if (btn_Game5.Text == "") { }
                    else if (btn_Game5.Text == "X") { }
                    else
                    {
                        if (btn_Game8.Text == "") { }
                        else if (btn_Game8.Text == "X") { }
                        else
                        {
                            return true;
                        }
                    }
                    break;
                case 3:
                    if (btn_Game2.Text == "") { }
                    else if (btn_Game2.Text == "X") { }
                    else
                    {
                        if (btn_Game1.Text == "") { }
                        else if (btn_Game1.Text == "X") { }
                        else
                        {
                            return true;
                        }
                    }
                    if (btn_Game5.Text == "") { }
                    else if (btn_Game5.Text == "X") { }
                    else
                    {
                        if (btn_Game7.Text == "") { }
                        else if (btn_Game7.Text == "X") { }
                        else
                        {
                            return true;
                        }
                    }
                    if (btn_Game6.Text == "") { }
                    else if (btn_Game6.Text == "X") { }
                    else
                    {
                        if (btn_Game9.Text == "") { }
                        else if (btn_Game9.Text == "X") { }
                        else
                        {
                            return true;
                        }
                    }
                    break;
                case 4:
                    if (btn_Game1.Text == "") { }
                    else if (btn_Game1.Text == "X") { }
                    else
                    {
                        if (btn_Game7.Text == "") { }
                        else if (btn_Game7.Text == "X") { }
                        else
                        {
                            return true;
                        }
                    }
                    if (btn_Game5.Text == "") { }
                    else if (btn_Game5.Text == "X") { }
                    else
                    {
                        if (btn_Game6.Text == "") { }
                        else if (btn_Game6.Text == "X") { }
                        else
                        {
                            return true;
                        }
                    }
                    break;
                case 5:
                    if (btn_Game1.Text == "") { }
                    else if (btn_Game1.Text == "X") { }
                    else
                    {
                        if (btn_Game9.Text == "") { }
                        else if (btn_Game9.Text == "X") { }
                        else
                        {
                            return true;
                        }
                    }
                    if (btn_Game2.Text == "") { }
                    else if (btn_Game2.Text == "X") { }
                    else
                    {
                        if (btn_Game8.Text == "") { }
                        else if (btn_Game8.Text == "X") { }
                        else
                        {
                            return true;
                        }
                    }
                    if (btn_Game3.Text == "") { }
                    else if (btn_Game3.Text == "X") { }
                    else
                    {
                        if (btn_Game7.Text == "") { }
                        else if (btn_Game7.Text == "X") { }
                        else
                        {
                            return true;
                        }
                    }
                    if (btn_Game4.Text == "") { }
                    else if (btn_Game4.Text == "X") { }
                    else
                    {
                        if (btn_Game6.Text == "") { }
                        else if (btn_Game6.Text == "X") { }
                        else
                        {
                            return true;
                        }
                    }
                    break;
                case 6:
                    if (btn_Game3.Text == "") { }
                    else if (btn_Game3.Text == "X") { }
                    else
                    {
                        if (btn_Game9.Text == "") { }
                        else if (btn_Game9.Text == "X") { }
                        else
                        {
                            return true;
                        }
                    }
                    if (btn_Game5.Text == "") { }
                    else if (btn_Game5.Text == "X") { }
                    else
                    {
                        if (btn_Game4.Text == "") { }
                        else if (btn_Game4.Text == "X") { }
                        else
                        {
                            return true;
                        }
                    }
                    break;
                case 7:
                    if (btn_Game4.Text == "") { }
                    else if (btn_Game4.Text == "X") { }
                    else
                    {
                        if (btn_Game1.Text == "") { }
                        else if (btn_Game1.Text == "X") { }
                        else
                        {
                            return true;
                        }
                    }
                    if (btn_Game5.Text == "") { }
                    else if (btn_Game5.Text == "X") { }
                    else
                    {
                        if (btn_Game3.Text == "") { }
                        else if (btn_Game3.Text == "X") { }
                        else
                        {
                            return true;
                        }
                    }
                    if (btn_Game8.Text == "") { }
                    else if (btn_Game8.Text == "X") { }
                    else
                    {
                        if (btn_Game9.Text == "") { }
                        else if (btn_Game9.Text == "X") { }
                        else
                        {
                            return true;
                        }
                    }
                    break;
                case 8:
                    if (btn_Game5.Text == "") { }
                    else if (btn_Game5.Text == "X") { }
                    else
                    {
                        if (btn_Game2.Text == "") { }
                        else if (btn_Game2.Text == "X") { }
                        else
                        {
                            return true;
                        }
                    }
                    if (btn_Game7.Text == "") { }
                    else if (btn_Game7.Text == "X") { }
                    else
                    {
                        if (btn_Game9.Text == "") { }
                        else if (btn_Game9.Text == "X") { }
                        else
                        {
                            return true;
                        }
                    }
                    break;
                case 9:
                    if (btn_Game6.Text == "") { }
                    else if (btn_Game6.Text == "X") { }
                    else
                    {
                        if (btn_Game3.Text == "") { }
                        else if (btn_Game3.Text == "X") { }
                        else
                        {
                            return true;
                        }
                    }
                    if (btn_Game5.Text == "") { }
                    else if (btn_Game5.Text == "X") { }
                    else
                    {
                        if (btn_Game1.Text == "") { }
                        else if (btn_Game1.Text == "X") { }
                        else
                        {
                            return true;
                        }
                    }
                    if (btn_Game8.Text == "") { }
                    else if (btn_Game8.Text == "X") { }
                    else
                    {
                        if (btn_Game7.Text == "") { }
                        else if (btn_Game7.Text == "X") { }
                        else
                        {
                            return true;
                        }
                    }
                    break;
            }

            return false;
        }

        private void Selected_Bot_1Player()             //Funzione del bot che randomizza la mossa e la imposta
        {
            int selected;
            do
            {
                selected = ran.Next(1, 10);
                switch(selected)
                {
                    case 1:
                        if (btn_Game1.Text == "")
                        {
                            btn_Game1.Text = "X";
                            btn_Game1.Enabled = false;
                        }
                        else
                        {
                            selected = 10;
                        }
                        break;
                    case 2:
                        if (btn_Game2.Text == "")
                        {
                            btn_Game2.Text = "X";
                            btn_Game2.Enabled = false;
                        }
                        else
                        {
                            selected = 10;
                        }
                        break;
                    case 3:
                        if (btn_Game3.Text == "")
                        {
                            btn_Game3.Text = "X";
                            btn_Game3.Enabled = false;
                        }
                        else
                        {
                            selected = 10;
                        }
                        break;
                    case 4:
                        if (btn_Game4.Text == "")
                        {
                            btn_Game4.Text = "X";
                            btn_Game4.Enabled = false;
                        }
                        else
                        {
                            selected = 10;
                        }
                        break;
                    case 5:
                        if (btn_Game5.Text == "")
                        {
                            btn_Game5.Text = "X";
                            btn_Game5.Enabled = false;
                        }
                        else
                        {
                            selected = 10;
                        }
                        break;
                    case 6:
                        if (btn_Game6.Text == "")
                        {
                            btn_Game6.Text = "X";
                            btn_Game6.Enabled = false;
                        }
                        else
                        {
                            selected = 10;
                        }
                        break;
                    case 7:
                        if (btn_Game7.Text == "")
                        {
                            btn_Game7.Text = "X";
                            btn_Game7.Enabled = false;
                        }
                        else
                        {
                            selected = 10;
                        }
                        break;
                    case 8:
                        if (btn_Game8.Text == "")
                        {
                            btn_Game8.Text = "X";
                            btn_Game8.Enabled = false;
                        }
                        else
                        {
                            selected = 10;
                        }
                        break;
                    case 9:
                        if (btn_Game9.Text == "")
                        {
                            btn_Game9.Text = "X";
                            btn_Game9.Enabled = false;
                        }
                        else
                        {
                            selected = 10;
                        }
                        break;
                }
            }
            while(selected == 10);

            if (Chekking_1Bot(selected))
            {
                if (DB_Settings.Language)
                    label1.Text = "Hai perso!";
                else
                    label1.Text = "You Lost!";
                CliarAll();
            }
            else if (btn_Game1.Text != "" &&
                         btn_Game2.Text != "" &&
                         btn_Game3.Text != "" &&
                         btn_Game4.Text != "" &&
                         btn_Game5.Text != "" &&
                         btn_Game6.Text != "" &&
                         btn_Game7.Text != "" &&
                         btn_Game8.Text != "" &&
                         btn_Game9.Text != "")
            {
                    if (DB_Settings.Language)
                    {
                        label1.Text = "Pareggio!";
                    }
                    else
                    {
                        label1.Text = "Draw!";
                    }
                CliarAll();
            }
        }

        private bool Chekking_1Bot(int y)               //Funzione del bot che controlla la sua vincita
        {
            switch (y)
            {
                case 1:
                    if (btn_Game2.Text == "") { }
                    else if (btn_Game2.Text == "O") { }
                    else
                    {
                        if (btn_Game3.Text == "") { }
                        else if (btn_Game3.Text == "O") { }
                        else
                        {
                            return true;
                        }
                    }
                    if (btn_Game5.Text == "") { }
                    else if (btn_Game5.Text == "O") { }
                    else
                    {
                        if (btn_Game9.Text == "") { }
                        else if (btn_Game9.Text == "O") { }
                        else
                        {
                            return true;
                        }
                    }
                    if (btn_Game4.Text == "") { }
                    else if (btn_Game4.Text == "O") { }
                    else
                    {
                        if (btn_Game7.Text == "") { }
                        else if (btn_Game7.Text == "O") { }
                        else
                        {
                            return true;
                        }
                    }
                    break;
                case 2:
                    if (btn_Game1.Text == "") { }
                    else if (btn_Game1.Text == "O") { }
                    else
                    {
                        if (btn_Game3.Text == "") { }
                        else if (btn_Game3.Text == "O") { }
                        else
                        {
                            return true;
                        }
                    }
                    if (btn_Game5.Text == "") { }
                    else if (btn_Game5.Text == "X") { }
                    else
                    {
                        if (btn_Game8.Text == "") { }
                        else if (btn_Game8.Text == "O") { }
                        else
                        {
                            return true;
                        }
                    }
                    break;
                case 3:
                    if (btn_Game2.Text == "") { }
                    else if (btn_Game2.Text == "O") { }
                    else
                    {
                        if (btn_Game1.Text == "") { }
                        else if (btn_Game1.Text == "O") { }
                        else
                        {
                            return true;
                        }
                    }
                    if (btn_Game5.Text == "") { }
                    else if (btn_Game5.Text == "O") { }
                    else
                    {
                        if (btn_Game7.Text == "") { }
                        else if (btn_Game7.Text == "O") { }
                        else
                        {
                            return true;
                        }
                    }
                    if (btn_Game6.Text == "") { }
                    else if (btn_Game6.Text == "O") { }
                    else
                    {
                        if (btn_Game9.Text == "") { }
                        else if (btn_Game9.Text == "O") { }
                        else
                        {
                            return true;
                        }
                    }
                    break;
                case 4:
                    if (btn_Game1.Text == "") { }
                    else if (btn_Game1.Text == "O") { }
                    else
                    {
                        if (btn_Game7.Text == "") { }
                        else if (btn_Game7.Text == "O") { }
                        else
                        {
                            return true;
                        }
                    }
                    if (btn_Game5.Text == "") { }
                    else if (btn_Game5.Text == "O") { }
                    else
                    {
                        if (btn_Game6.Text == "") { }
                        else if (btn_Game6.Text == "O") { }
                        else
                        {
                            return true;
                        }
                    }
                    break;
                case 5:
                    if (btn_Game1.Text == "") { }
                    else if (btn_Game1.Text == "O") { }
                    else
                    {
                        if (btn_Game9.Text == "") { }
                        else if (btn_Game9.Text == "O") { }
                        else
                        {
                            return true;
                        }
                    }
                    if (btn_Game2.Text == "") { }
                    else if (btn_Game2.Text == "O") { }
                    else
                    {
                        if (btn_Game8.Text == "") { }
                        else if (btn_Game8.Text == "O") { }
                        else
                        {
                            return true;
                        }
                    }
                    if (btn_Game3.Text == "") { }
                    else if (btn_Game3.Text == "O") { }
                    else
                    {
                        if (btn_Game7.Text == "") { }
                        else if (btn_Game7.Text == "O") { }
                        else
                        {
                            return true;
                        }
                    }
                    if (btn_Game4.Text == "") { }
                    else if (btn_Game4.Text == "O") { }
                    else
                    {
                        if (btn_Game6.Text == "") { }
                        else if (btn_Game6.Text == "O") { }
                        else
                        {
                            return true;
                        }
                    }
                    break;
                case 6:
                    if (btn_Game3.Text == "") { }
                    else if (btn_Game3.Text == "O") { }
                    else
                    {
                        if (btn_Game9.Text == "") { }
                        else if (btn_Game9.Text == "O") { }
                        else
                        {
                            return true;
                        }
                    }
                    if (btn_Game5.Text == "") { }
                    else if (btn_Game5.Text == "O") { }
                    else
                    {
                        if (btn_Game4.Text == "") { }
                        else if (btn_Game4.Text == "O") { }
                        else
                        {
                            return true;
                        }
                    }
                    break;
                case 7:
                    if (btn_Game4.Text == "") { }
                    else if (btn_Game4.Text == "O") { }
                    else
                    {
                        if (btn_Game1.Text == "") { }
                        else if (btn_Game1.Text == "O") { }
                        else
                        {
                            return true;
                        }
                    }
                    if (btn_Game5.Text == "") { }
                    else if (btn_Game5.Text == "O") { }
                    else
                    {
                        if (btn_Game3.Text == "") { }
                        else if (btn_Game3.Text == "O") { }
                        else
                        {
                            return true;
                        }
                    }
                    if (btn_Game8.Text == "") { }
                    else if (btn_Game8.Text == "O") { }
                    else
                    {
                        if (btn_Game9.Text == "") { }
                        else if (btn_Game9.Text == "O") { }
                        else
                        {
                            return true;
                        }
                    }
                    break;
                case 8:
                    if (btn_Game5.Text == "") { }
                    else if (btn_Game5.Text == "O") { }
                    else
                    {
                        if (btn_Game2.Text == "") { }
                        else if (btn_Game2.Text == "O") { }
                        else
                        {
                            return true;
                        }
                    }
                    if (btn_Game7.Text == "") { }
                    else if (btn_Game7.Text == "O") { }
                    else
                    {
                        if (btn_Game9.Text == "") { }
                        else if (btn_Game9.Text == "O") { }
                        else
                        {
                            return true;
                        }
                    }
                    break;
                case 9:
                    if (btn_Game6.Text == "") { }
                    else if (btn_Game6.Text == "O") { }
                    else
                    {
                        if (btn_Game3.Text == "") { }
                        else if (btn_Game3.Text == "O") { }
                        else
                        {
                            return true;
                        }
                    }
                    if (btn_Game5.Text == "") { }
                    else if (btn_Game5.Text == "O") { }
                    else
                    {
                        if (btn_Game1.Text == "") { }
                        else if (btn_Game1.Text == "O") { }
                        else
                        {
                            return true;
                        }
                    }
                    if (btn_Game8.Text == "") { }
                    else if (btn_Game8.Text == "O") { }
                    else
                    {
                        if (btn_Game7.Text == "") { }
                        else if (btn_Game7.Text == "O") { }
                        else
                        {
                            return true;
                        }
                    }
                    break;
            }

            return false;
        }

        private void btn_Game1_Click(object sender, EventArgs e)        //btn [1]
        {
            if (rBtn_1.Checked)                                         //Controlla se sta giocando un solo giocatore
            {
                btn_Game1.Text = "O";
                btn_Game1.Enabled = false;
                if (Checkking_1Player(1))                               //Richiama la funzione
                {
                    if (DB_Settings.Language)
                    {
                        label1.Text = "Hai vinto!";
                    }
                    else
                    {
                        label1.Text = "You won!";
                    }
                    CliarAll();
                }
                else if(IsDraw())
                {
                    if (DB_Settings.Language)
                    {
                        label1.Text = "Pareggio!";
                    }
                    else
                    {
                        label1.Text = "Draw!";
                    }
                    CliarAll();
                }
                else
                {
                    Selected_Bot_1Player();
                }
            }
            else                                                                    
            {
                if (WhoIsPlaying == 1)                                                  //Controlla chi sta giocando                              
                {
                    btn_Game1.Text = "O";
                    btn_Game1.Enabled = false;
                    if (CheckPlayer(1, 1) == 1)                                         //Chiama la funzione passando il giocatore e la mossa
                    {
                        if (DB_Settings.Language)
                        {
                            label1.Text = "Ha vinto giocatore 1!";
                        }
                        else
                        {
                            label1.Text = "Player 1 has won!";
                        }
                        CliarAll();
                    }
                    else if (IsDraw())
                    {
                        if (DB_Settings.Language)
                        {
                            label1.Text = "Pareggio!";
                        }
                        else
                        {
                            label1.Text = "Draw!";
                        }
                        CliarAll();
                    }
                    else
                    {
                        WhoIsPlaying = 2;
                    }
                }
                else
                {
                    btn_Game1.Text = "X";
                    btn_Game1.Enabled = false;
                    if(CheckPlayer(2, 1) == 2)
                    {
                        if (DB_Settings.Language)
                        {
                            label1.Text = "Ha vinto giocatore 2!";
                        }
                        else
                        {
                            label1.Text = "Player 2 has won!";
                        }
                        CliarAll();
                    }
                    else if (IsDraw())
                    {
                        if (DB_Settings.Language)
                        {
                            label1.Text = "Pareggio!";
                        }
                        else
                        {
                            label1.Text = "Draw!";
                        }
                        CliarAll();
                    }
                    else
                    {
                        WhoIsPlaying = 1;
                    }
                }
            }

        }

        private void btn_Game2_Click(object sender, EventArgs e)        //btn [2]
        {


            if (rBtn_1.Checked)
            {
                btn_Game2.Text = "O";
                btn_Game2.Enabled = false;
                if (Checkking_1Player(2))
                {
                    if (DB_Settings.Language)
                    {
                        label1.Text = "Hai vinto!";
                    }
                    else
                    {
                        label1.Text = "You won!";
                    }
                    CliarAll();
                }
                else if (IsDraw())
                {
                    if (DB_Settings.Language)
                    {
                        label1.Text = "Pareggio!";
                    }
                    else
                    {
                        label1.Text = "Draw!";
                    }
                    CliarAll();
                }
                else
                {
                    Selected_Bot_1Player();
                }
            }
            else
            {
                if (WhoIsPlaying == 1)
                {
                    btn_Game2.Text = "O";
                    btn_Game2.Enabled = false;
                    if (CheckPlayer(1, 2) == 1)
                    {
                        if (DB_Settings.Language)
                        {
                            label1.Text = "Ha vinto giocatore 1!";
                        }
                        else
                        {
                            label1.Text = "Player 1 has won!";
                        }
                        CliarAll();
                    }
                    else if (IsDraw())
                    {
                        if (DB_Settings.Language)
                        {
                            label1.Text = "Pareggio!";
                        }
                        else
                        {
                            label1.Text = "Draw!";
                        }
                        CliarAll();
                    }
                    else
                    {
                        WhoIsPlaying = 2;
                    }
                }
                else
                {
                    btn_Game2.Text = "X";
                    btn_Game2.Enabled = false;
                    if (CheckPlayer(2, 2) == 2)
                    {
                        if (DB_Settings.Language)
                        {
                            label1.Text = "Ha vinto giocatore 2!";
                        }
                        else
                        {
                            label1.Text = "Player 2 has won!";
                        }
                        CliarAll();
                    }
                    else if (IsDraw())
                    {
                        if (DB_Settings.Language)
                        {
                            label1.Text = "Pareggio!";
                        }
                        else
                        {
                            label1.Text = "Draw!";
                        }
                        CliarAll();
                    }
                    else
                    {
                        WhoIsPlaying = 1;
                    }
                }
            }
        }

        private void btn_Game3_Click(object sender, EventArgs e)        //btn [3]
        {
            if (rBtn_1.Checked)
            {
                if (Checkking_1Player(3))
                {
                    btn_Game3.Text = "O";
                    btn_Game3.Enabled = false;

                    if (DB_Settings.Language)
                    {
                        label1.Text = "Hai vinto!";
                    }
                    else
                    {
                        label1.Text = "You won!";
                    }
                    CliarAll();
                }
                else if (IsDraw())
                {
                    if (DB_Settings.Language)
                    {
                        label1.Text = "Pareggio!";
                    }
                    else
                    {
                        label1.Text = "Draw!";
                    }
                    CliarAll();
                }
                else
                {
                    Selected_Bot_1Player();
                }
            }
            else
            {
                if (WhoIsPlaying == 1)
                {
                    btn_Game3.Text = "O";
                    btn_Game3.Enabled = false;
                    if (CheckPlayer(1, 3) == 1)
                    {
                        if (DB_Settings.Language)
                        {
                            label1.Text = "Ha vinto giocatore 1!";
                        }
                        else
                        {
                            label1.Text = "Player 1 has won!";
                        }
                        CliarAll();
                    }
                    else if (IsDraw())
                    {
                        if (DB_Settings.Language)
                        {
                            label1.Text = "Pareggio!";
                        }
                        else
                        {
                            label1.Text = "Draw!";
                        }
                        CliarAll();
                    }
                    else
                    {
                        WhoIsPlaying = 2;
                    }
                }
                else
                {
                    btn_Game3.Text = "X";
                    btn_Game3.Enabled = false;
                    if (CheckPlayer(2, 3) == 2)
                    {
                        if (DB_Settings.Language)
                        {
                            label1.Text = "Ha vinto giocatore 2!";
                        }
                        else
                        {
                            label1.Text = "Player 2 has won!";
                        }
                        CliarAll();
                    }
                    else if (IsDraw())
                    {
                        if (DB_Settings.Language)
                        {
                            label1.Text = "Pareggio!";
                        }
                        else
                        {
                            label1.Text = "Draw!";
                        }
                        CliarAll();
                    }
                    else
                    {
                        WhoIsPlaying = 1;
                    }
                }
            }
        }

        private void btn_Game4_Click(object sender, EventArgs e)        //btn [4]
        {       
            if (rBtn_1.Checked)
            {
                btn_Game4.Text = "O";
                btn_Game4.Enabled = false;
                if (Checkking_1Player(4))
                {
                    if (DB_Settings.Language)
                    {
                        label1.Text = "Hai vinto!";
                    }
                    else
                    {
                        label1.Text = "You won!";
                    }
                    CliarAll();
                }
                else if (IsDraw())
                {
                    if (DB_Settings.Language)
                    {
                        label1.Text = "Pareggio!";
                    }
                    else
                    {
                        label1.Text = "Draw!";
                    }
                    CliarAll();
                }
                else
                {
                    Selected_Bot_1Player();
                }
            }
            else
            {
                if (WhoIsPlaying == 1)
                {
                    btn_Game4.Text = "O";
                    btn_Game4.Enabled = false;
                    if (CheckPlayer(1, 4) == 1)
                    {
                        if (DB_Settings.Language)
                        {
                            label1.Text = "Ha vinto giocatore 1!";
                        }
                        else
                        {
                            label1.Text = "Player 1 has won!";
                        }
                        CliarAll();
                    }
                    else if (IsDraw())
                    {
                        if (DB_Settings.Language)
                        {
                            label1.Text = "Pareggio!";
                        }
                        else
                        {
                            label1.Text = "Draw!";
                        }
                        CliarAll();
                    }
                    else
                    {
                        WhoIsPlaying = 2;
                    }
                }
                else
                {
                    btn_Game4.Text = "X";
                    btn_Game4.Enabled = false;
                    if (CheckPlayer(2, 4) == 2)
                    {
                        if (DB_Settings.Language)
                        {
                            label1.Text = "Ha vinto giocatore 1!";
                        }
                        else
                        {
                            label1.Text = "Player 1 has won!";
                        }
                        CliarAll();
                    }
                    else if (IsDraw())
                    {
                        if (DB_Settings.Language)
                        {
                            label1.Text = "Pareggio!";
                        }
                        else
                        {
                            label1.Text = "Draw!";
                        }
                        CliarAll();
                    }
                    else
                    {
                        WhoIsPlaying = 1;
                    }
                }
            }
        }

        private void btn_Game5_Click(object sender, EventArgs e)        //btn [5]
        {

            if (rBtn_1.Checked)
            {
                btn_Game5.Text = "O";
                btn_Game5.Enabled = false;
                if (Checkking_1Player(5))
                {
                    if (DB_Settings.Language)
                    {
                        label1.Text = "Hai vinto!";
                    }
                    else
                    {
                        label1.Text = "You won!";
                    }
                    CliarAll();
                }
                else if (IsDraw())
                {
                    if (DB_Settings.Language)
                    {
                        label1.Text = "Pareggio!";
                    }
                    else
                    {
                        label1.Text = "Draw!";
                    }
                    CliarAll();
                }
                else
                {
                    Selected_Bot_1Player();
                }
            }
            else
            {
                if (WhoIsPlaying == 1)
                {
                    btn_Game5.Text = "O";
                    btn_Game5.Enabled = false;
                    if (CheckPlayer(1, 5) == 1)
                    {
                        if (DB_Settings.Language)
                        {
                            label1.Text = "Ha vinto giocatore 1!";
                        }
                        else
                        {
                            label1.Text = "Player 1 has won!";
                        }
                        CliarAll();
                    }
                    else if (IsDraw())
                    {
                        if (DB_Settings.Language)
                        {
                            label1.Text = "Pareggio!";
                        }
                        else
                        {
                            label1.Text = "Draw!";
                        }
                        CliarAll();
                    }
                    else
                    {
                        WhoIsPlaying = 2;
                    }
                }
                else
                {
                    btn_Game5.Text = "X";
                    btn_Game5.Enabled = false;
                    if (CheckPlayer(2, 5) == 2)
                    {
                        if (DB_Settings.Language)
                        {
                            label1.Text = "Ha vinto giocatore 2!";
                        }
                        else
                        {
                            label1.Text = "Player 2 has won!";
                        }
                        CliarAll();
                    }
                    else if (IsDraw())
                    {
                        if (DB_Settings.Language)
                        {
                            label1.Text = "Pareggio!";
                        }
                        else
                        {
                            label1.Text = "Draw!";
                        }
                        CliarAll();
                    }
                    else
                    {
                        WhoIsPlaying = 1;
                    }
                }
            }
        }

        private void btn_Game6_Click(object sender, EventArgs e)        //btn [6]
        {

            if (rBtn_1.Checked)
            {
                btn_Game6.Text = "O";
                btn_Game6.Enabled = false;
                if (Checkking_1Player(6))
                {
                    if (DB_Settings.Language)
                    {
                        label1.Text = "Hai vinto!";
                    }
                    else
                    {
                        label1.Text = "You won!";
                    }
                    CliarAll();
                }
                else if (IsDraw())
                {
                    if (DB_Settings.Language)
                    {
                        label1.Text = "Pareggio!";
                    }
                    else
                    {
                        label1.Text = "Draw!";
                    }
                    CliarAll();
                }
                else
                {
                    Selected_Bot_1Player();
                }
            }
            else
            {
                if (WhoIsPlaying == 1)
                {
                    btn_Game6.Text = "O";
                    btn_Game6.Enabled = false;
                    if (CheckPlayer(1, 6) == 1)
                    {
                        if (DB_Settings.Language)
                        {
                            label1.Text = "Ha vinto giocatore 1!";
                        }
                        else
                        {
                            label1.Text = "Player 1 has won!";
                        }
                        CliarAll();
                    }
                    else if (IsDraw())
                    {
                        if (DB_Settings.Language)
                        {
                            label1.Text = "Pareggio!";
                        }
                        else
                        {
                            label1.Text = "Draw!";
                        }
                        CliarAll();
                    }
                    else
                    {
                        WhoIsPlaying = 2;
                    }
                }
                else
                {
                    btn_Game6.Text = "X";
                    btn_Game6.Enabled = false;
                    if (CheckPlayer(2, 6) == 2)
                    {
                        if (DB_Settings.Language)
                        {
                            label1.Text = "Ha vinto giocatore 2!";
                        }
                        else
                        {
                            label1.Text = "Player 2 has won!";
                        }
                        CliarAll();
                    }
                    else if (IsDraw())
                    {
                        if (DB_Settings.Language)
                        {
                            label1.Text = "Pareggio!";
                        }
                        else
                        {
                            label1.Text = "Draw!";
                        }
                        CliarAll();
                    }
                    else
                    {
                        WhoIsPlaying = 1;
                    }
                }
            }
        }

        private void btn_Game7_Click(object sender, EventArgs e)        //btn [7]
        {

            if (rBtn_1.Checked)
            {
                btn_Game7.Text = "O";
                btn_Game7.Enabled = false;
                if (Checkking_1Player(7))
                {
                    if (DB_Settings.Language)
                    {
                        label1.Text = "Hai vinto!";
                    }
                    else
                    {
                        label1.Text = "You won!";
                    }
                    CliarAll();
                }
                else if (IsDraw())
                {
                    if (DB_Settings.Language)
                    {
                        label1.Text = "Pareggio!";
                    }
                    else
                    {
                        label1.Text = "Draw!";
                    }
                    CliarAll();
                }
                else
                {
                    Selected_Bot_1Player();
                }
            }
            else
            {
                if (WhoIsPlaying == 1)
                {
                    btn_Game7.Text = "O";
                    btn_Game7.Enabled = false;
                    if (CheckPlayer(1, 7) == 1)
                    {
                        if (DB_Settings.Language)
                        {
                            label1.Text = "Ha vinto giocatore 1!";
                        }
                        else
                        {
                            label1.Text = "Player 1 has won!";
                        }
                        CliarAll();
                    }
                    else if (IsDraw())
                    {
                        if (DB_Settings.Language)
                        {
                            label1.Text = "Pareggio!";
                        }
                        else
                        {
                            label1.Text = "Draw!";
                        }
                        CliarAll();
                    }
                    else
                    {
                        WhoIsPlaying = 2;
                    }
                }
                else
                {
                    btn_Game7.Text = "X";
                    btn_Game7.Enabled = false;
                    if (CheckPlayer(2, 7) == 2)
                    {
                        if (DB_Settings.Language)
                        {
                            label1.Text = "Ha vinto giocatore 2!";
                        }
                        else
                        {
                            label1.Text = "Player 2 has won!";
                        }
                        CliarAll();
                    }
                    else if (IsDraw())
                    {
                        if (DB_Settings.Language)
                        {
                            label1.Text = "Pareggio!";
                        }
                        else
                        {
                            label1.Text = "Draw!";
                        }
                        CliarAll();
                    }
                    else
                    {
                        WhoIsPlaying = 1;
                    }
                }
            }
        }

        private void btn_Game8_Click(object sender, EventArgs e)        //btn [8]
        {

            if (rBtn_1.Checked)
            {
                btn_Game8.Text = "O";
                btn_Game8.Enabled = false;
                if (Checkking_1Player(8))
                {
                    if (DB_Settings.Language)
                    {
                        label1.Text = "Hai vinto!";
                    }
                    else
                    {
                        label1.Text = "You won!";
                    }
                    CliarAll();
                }
                else if (IsDraw())
                {
                    if (DB_Settings.Language)
                    {
                        label1.Text = "Pareggio!";
                    }
                    else
                    {
                        label1.Text = "Draw!";
                    }
                    CliarAll();
                }
                else
                {
                    Selected_Bot_1Player();
                }
            }
            else
            {
                if (WhoIsPlaying == 1)
                {
                    btn_Game8.Text = "O";
                    btn_Game8.Enabled = false;
                    if (CheckPlayer(1, 8) == 1)
                    {
                        if (DB_Settings.Language)
                        {
                            label1.Text = "Ha vinto giocatore 1!";
                        }
                        else
                        {
                            label1.Text = "Player 1 has won!";
                        }
                        CliarAll();
                    }
                    else if (IsDraw())
                    {
                        if (DB_Settings.Language)
                        {
                            label1.Text = "Pareggio!";
                        }
                        else
                        {
                            label1.Text = "Draw!";
                        }
                        CliarAll();
                    }
                    else
                    {
                        WhoIsPlaying = 2;
                    }
                }
                else
                {
                    btn_Game8.Text = "X";
                    btn_Game8.Enabled = false;
                    if (CheckPlayer(2, 8) == 2)
                    {
                        if (DB_Settings.Language)
                        {
                            label1.Text = "Ha vinto giocatore 2!";
                        }
                        else
                        {
                            label1.Text = "Player 2 has won!";
                        }
                        CliarAll();
                    }
                    else if (IsDraw())
                    {
                        if (DB_Settings.Language)
                        {
                            label1.Text = "Pareggio!";
                        }
                        else
                        {
                            label1.Text = "Draw!";
                        }
                        CliarAll();
                    }
                    else
                    {
                        WhoIsPlaying = 1;
                    }
                }
            }
        }

        private void btn_Game9_Click(object sender, EventArgs e)        //btn [9]
        {

            if (rBtn_1.Checked)
            {
                btn_Game9.Text = "O";
                btn_Game9.Enabled = false;
                if (Checkking_1Player(9))
                {
                    if (DB_Settings.Language)
                    {
                        label1.Text = "Hai vinto!";
                    }
                    else
                    {
                        label1.Text = "You won!";
                    }
                    CliarAll();
                }
                else if (IsDraw())
                {
                    if (DB_Settings.Language)
                    {
                        label1.Text = "Pareggio!";
                    }
                    else
                    {
                        label1.Text = "Draw!";
                    }
                    CliarAll();
                }
                else
                {
                    Selected_Bot_1Player();
                }
            }
            else
            {
                if (WhoIsPlaying == 1)
                {
                    btn_Game9.Text = "O";
                    btn_Game9.Enabled = false;
                    if (CheckPlayer(1, 9) == 1)
                    {
                        if (DB_Settings.Language)
                        {
                            label1.Text = "Ha vinto giocatore 1!";
                        }
                        else
                        {
                            label1.Text = "Player 1 has won!";
                        }
                        CliarAll();
                    }
                    else if (IsDraw())
                    {
                        if (DB_Settings.Language)
                        {
                            label1.Text = "Pareggio!";
                        }
                        else
                        {
                            label1.Text = "Draw!";
                        }
                        CliarAll();
                    }
                    else
                    {
                        WhoIsPlaying = 2;
                    }
                }
                else
                {
                    btn_Game9.Text = "X";
                    btn_Game9.Enabled = false;
                    if (CheckPlayer(2, 9) == 2)
                    {
                        if (DB_Settings.Language)
                        {
                            label1.Text = "Ha vinto giocatore 2!";
                        }
                        else
                        {
                            label1.Text = "Player 2 has won!";
                        }
                        CliarAll();
                    }
                    else if (IsDraw())
                    {
                        if (DB_Settings.Language)
                        {
                            label1.Text = "Pareggio!";
                        }
                        else
                        {
                            label1.Text = "Draw!";
                        }
                        CliarAll();
                    }
                    else
                    {
                        WhoIsPlaying = 1;
                    }
                }
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)        //btn che ritorna alla Home
        {
            Form_Home OldForm = new Form_Home();
            OldForm.Show();
            this.Close();
        }

        private int CheckPlayer(int Who, int y)        //Controlla se i giocatori hanno vinto oppure restituisce 0 [ Player1[O] = 1 | Player2[X] = 2 ]
        {
            if (Who == 2)
            {
                #region Algoritmo per il giocatore [X]
                switch (y)
                {

                    case 1:
                        if (btn_Game2.Text == "") { }
                        else if (btn_Game2.Text == "O") { }
                        else
                        {
                            if (btn_Game3.Text == "") { }
                            else if (btn_Game3.Text == "O") { }
                            else
                            {
                                return 2;
                            }
                        }
                        if (btn_Game5.Text == "") { }
                        else if (btn_Game5.Text == "O") { }
                        else
                        {
                            if (btn_Game9.Text == "") { }
                            else if (btn_Game9.Text == "O") { }
                            else
                            {
                                return 2;
                            }
                        }
                        if (btn_Game4.Text == "") { }
                        else if (btn_Game4.Text == "O") { }
                        else
                        {
                            if (btn_Game7.Text == "") { }
                            else if (btn_Game7.Text == "O") { }
                            else
                            {
                                return 2;
                            }
                        }
                        break;
                    case 2:
                        if (btn_Game1.Text == "") { }
                        else if (btn_Game1.Text == "O") { }
                        else
                        {
                            if (btn_Game3.Text == "") { }
                            else if (btn_Game3.Text == "O") { }
                            else
                            {
                                return 2;
                            }
                        }
                        if (btn_Game5.Text == "") { }
                        else if (btn_Game5.Text == "X") { }
                        else
                        {
                            if (btn_Game8.Text == "") { }
                            else if (btn_Game8.Text == "O") { }
                            else
                            {
                                return 2;
                            }
                        }
                        break;
                    case 3:
                        if (btn_Game2.Text == "") { }
                        else if (btn_Game2.Text == "O") { }
                        else
                        {
                            if (btn_Game1.Text == "") { }
                            else if (btn_Game1.Text == "O") { }
                            else
                            {
                                return 2;
                            }
                        }
                        if (btn_Game5.Text == "") { }
                        else if (btn_Game5.Text == "O") { }
                        else
                        {
                            if (btn_Game7.Text == "") { }
                            else if (btn_Game7.Text == "O") { }
                            else
                            {
                                return 2;
                            }
                        }
                        if (btn_Game6.Text == "") { }
                        else if (btn_Game6.Text == "O") { }
                        else
                        {
                            if (btn_Game9.Text == "") { }
                            else if (btn_Game9.Text == "O") { }
                            else
                            {
                                return 2;
                            }
                        }
                        break;
                    case 4:
                        if (btn_Game1.Text == "") { }
                        else if (btn_Game1.Text == "O") { }
                        else
                        {
                            if (btn_Game7.Text == "") { }
                            else if (btn_Game7.Text == "O") { }
                            else
                            {
                                return 2;
                            }
                        }
                        if (btn_Game5.Text == "") { }
                        else if (btn_Game5.Text == "O") { }
                        else
                        {
                            if (btn_Game6.Text == "") { }
                            else if (btn_Game6.Text == "O") { }
                            else
                            {
                                return 2;
                            }
                        }
                        break;
                    case 5:
                        if (btn_Game1.Text == "") { }
                        else if (btn_Game1.Text == "O") { }
                        else
                        {
                            if (btn_Game9.Text == "") { }
                            else if (btn_Game9.Text == "O") { }
                            else
                            {
                                return 2;
                            }
                        }
                        if (btn_Game2.Text == "") { }
                        else if (btn_Game2.Text == "O") { }
                        else
                        {
                            if (btn_Game8.Text == "") { }
                            else if (btn_Game8.Text == "O") { }
                            else
                            {
                                return 2;
                            }
                        }
                        if (btn_Game3.Text == "") { }
                        else if (btn_Game3.Text == "O") { }
                        else
                        {
                            if (btn_Game7.Text == "") { }
                            else if (btn_Game7.Text == "O") { }
                            else
                            {
                                return 2;
                            }
                        }
                        if (btn_Game4.Text == "") { }
                        else if (btn_Game4.Text == "O") { }
                        else
                        {
                            if (btn_Game6.Text == "") { }
                            else if (btn_Game6.Text == "O") { }
                            else
                            {
                                return 2;
                            }
                        }
                        break;
                    case 6:
                        if (btn_Game3.Text == "") { }
                        else if (btn_Game3.Text == "O") { }
                        else
                        {
                            if (btn_Game9.Text == "") { }
                            else if (btn_Game9.Text == "O") { }
                            else
                            {
                                return 2;
                            }
                        }
                        if (btn_Game5.Text == "") { }
                        else if (btn_Game5.Text == "O") { }
                        else
                        {
                            if (btn_Game4.Text == "") { }
                            else if (btn_Game4.Text == "O") { }
                            else
                            {
                                return 2;
                            }
                        }
                        break;
                    case 7:
                        if (btn_Game4.Text == "") { }
                        else if (btn_Game4.Text == "O") { }
                        else
                        {
                            if (btn_Game1.Text == "") { }
                            else if (btn_Game1.Text == "O") { }
                            else
                            {
                                return 2;
                            }
                        }
                        if (btn_Game5.Text == "") { }
                        else if (btn_Game5.Text == "O") { }
                        else
                        {
                            if (btn_Game3.Text == "") { }
                            else if (btn_Game3.Text == "O") { }
                            else
                            {
                                return 2;
                            }
                        }
                        if (btn_Game8.Text == "") { }
                        else if (btn_Game8.Text == "O") { }
                        else
                        {
                            if (btn_Game9.Text == "") { }
                            else if (btn_Game9.Text == "O") { }
                            else
                            {
                                return 2;
                            }
                        }
                        break;
                    case 8:
                        if (btn_Game5.Text == "") { }
                        else if (btn_Game5.Text == "O") { }
                        else
                        {
                            if (btn_Game2.Text == "") { }
                            else if (btn_Game2.Text == "O") { }
                            else
                            {
                                return 2;
                            }
                        }
                        if (btn_Game7.Text == "") { }
                        else if (btn_Game7.Text == "O") { }
                        else
                        {
                            if (btn_Game9.Text == "") { }
                            else if (btn_Game9.Text == "O") { }
                            else
                            {
                                return 2;
                            }
                        }
                        break;
                    case 9:
                        if (btn_Game6.Text == "") { }
                        else if (btn_Game6.Text == "O") { }
                        else
                        {
                            if (btn_Game3.Text == "") { }
                            else if (btn_Game3.Text == "O") { }
                            else
                            {
                                return 2;
                            }
                        }
                        if (btn_Game5.Text == "") { }
                        else if (btn_Game5.Text == "O") { }
                        else
                        {
                            if (btn_Game1.Text == "") { }
                            else if (btn_Game1.Text == "O") { }
                            else
                            {
                                return 2;
                            }
                        }
                        if (btn_Game8.Text == "") { }
                        else if (btn_Game8.Text == "O") { }
                        else
                        {
                            if (btn_Game7.Text == "") { }
                            else if (btn_Game7.Text == "O") { }
                            else
                            {
                                return 2;
                            }
                        }
                        break;
                }
                #endregion
            }
            else
            {
                #region Algoritmo per il giocatore [O]
                switch (y)
                {
                    case 1:
                        if (btn_Game2.Text == "") { }
                        else if (btn_Game2.Text == "X") { }
                        else
                        {
                            if (btn_Game3.Text == "") { }
                            else if (btn_Game3.Text == "X") { }
                            else
                            {
                                return 1;
                            }
                        }
                        if (btn_Game5.Text == "") { }
                        else if (btn_Game5.Text == "X") { }
                        else
                        {
                            if (btn_Game9.Text == "") { }
                            else if (btn_Game9.Text == "X") { }
                            else
                            {
                                return 1;
                            }
                        }
                        if (btn_Game4.Text == "") { }
                        else if (btn_Game4.Text == "X") { }
                        else
                        {
                            if (btn_Game7.Text == "") { }
                            else if (btn_Game7.Text == "X") { }
                            else
                            {
                                return 1;
                            }
                        }
                        break;
                    case 2:
                        if (btn_Game1.Text == "") { }
                        else if (btn_Game1.Text == "X") { }
                        else
                        {
                            if (btn_Game3.Text == "") { }
                            else if (btn_Game3.Text == "X") { }
                            else
                            {
                                return 1;
                            }
                        }
                        if (btn_Game5.Text == "") { }
                        else if (btn_Game5.Text == "X") { }
                        else
                        {
                            if (btn_Game8.Text == "") { }
                            else if (btn_Game8.Text == "X") { }
                            else
                            {
                                return 1;
                            }
                        }
                        break;
                    case 3:
                        if (btn_Game2.Text == "") { }
                        else if (btn_Game2.Text == "X") { }
                        else
                        {
                            if (btn_Game1.Text == "") { }
                            else if (btn_Game1.Text == "X") { }
                            else
                            {
                                return 1;
                            }
                        }
                        if (btn_Game5.Text == "") { }
                        else if (btn_Game5.Text == "X") { }
                        else
                        {
                            if (btn_Game7.Text == "") { }
                            else if (btn_Game7.Text == "X") { }
                            else
                            {
                                return 1;
                            }
                        }
                        if (btn_Game6.Text == "") { }
                        else if (btn_Game6.Text == "X") { }
                        else
                        {
                            if (btn_Game9.Text == "") { }
                            else if (btn_Game9.Text == "X") { }
                            else
                            {
                                return 1;
                            }
                        }
                        break;
                    case 4:
                        if (btn_Game1.Text == "") { }
                        else if (btn_Game1.Text == "X") { }
                        else
                        {
                            if (btn_Game7.Text == "") { }
                            else if (btn_Game7.Text == "X") { }
                            else
                            {
                                return 1;
                            }
                        }
                        if (btn_Game5.Text == "") { }
                        else if (btn_Game5.Text == "X") { }
                        else
                        {
                            if (btn_Game6.Text == "") { }
                            else if (btn_Game6.Text == "X") { }
                            else
                            {
                                return 1;
                            }
                        }
                        break;
                    case 5:
                        if (btn_Game1.Text == "") { }
                        else if (btn_Game1.Text == "X") { }
                        else
                        {
                            if (btn_Game9.Text == "") { }
                            else if (btn_Game9.Text == "X") { }
                            else
                            {
                                return 1;
                            }
                        }
                        if (btn_Game2.Text == "") { }
                        else if (btn_Game2.Text == "X") { }
                        else
                        {
                            if (btn_Game8.Text == "") { }
                            else if (btn_Game8.Text == "X") { }
                            else
                            {
                                return 1;
                            }
                        }
                        if (btn_Game3.Text == "") { }
                        else if (btn_Game3.Text == "X") { }
                        else
                        {
                            if (btn_Game7.Text == "") { }
                            else if (btn_Game7.Text == "X") { }
                            else
                            {
                                return 1;
                            }
                        }
                        if (btn_Game4.Text == "") { }
                        else if (btn_Game4.Text == "X") { }
                        else
                        {
                            if (btn_Game6.Text == "") { }
                            else if (btn_Game6.Text == "X") { }
                            else
                            {
                                return 1;
                            }
                        }
                        break;
                    case 6:
                        if (btn_Game3.Text == "") { }
                        else if (btn_Game3.Text == "X") { }
                        else
                        {
                            if (btn_Game9.Text == "") { }
                            else if (btn_Game9.Text == "X") { }
                            else
                            {
                                return 1;
                            }
                        }
                        if (btn_Game5.Text == "") { }
                        else if (btn_Game5.Text == "X") { }
                        else
                        {
                            if (btn_Game4.Text == "") { }
                            else if (btn_Game4.Text == "X") { }
                            else
                            {
                                return 1;
                            }
                        }
                        break;
                    case 7:
                        if (btn_Game4.Text == "") { }
                        else if (btn_Game4.Text == "X") { }
                        else
                        {
                            if (btn_Game1.Text == "") { }
                            else if (btn_Game1.Text == "X") { }
                            else
                            {
                                return 1;
                            }
                        }
                        if (btn_Game5.Text == "") { }
                        else if (btn_Game5.Text == "X") { }
                        else
                        {
                            if (btn_Game3.Text == "") { }
                            else if (btn_Game3.Text == "X") { }
                            else
                            {
                                return 1;
                            }
                        }
                        if (btn_Game8.Text == "") { }
                        else if (btn_Game8.Text == "X") { }
                        else
                        {
                            if (btn_Game9.Text == "") { }
                            else if (btn_Game9.Text == "X") { }
                            else
                            {
                                return 1;
                            }
                        }
                        break;
                    case 8:
                        if (btn_Game5.Text == "") { }
                        else if (btn_Game5.Text == "X") { }
                        else
                        {
                            if (btn_Game2.Text == "") { }
                            else if (btn_Game2.Text == "X") { }
                            else
                            {
                                return 1;
                            }
                        }
                        if (btn_Game7.Text == "") { }
                        else if (btn_Game7.Text == "X") { }
                        else
                        {
                            if (btn_Game9.Text == "") { }
                            else if (btn_Game9.Text == "X") { }
                            else
                            {
                                return 1;
                            }
                        }
                        break;
                    case 9:
                        if (btn_Game6.Text == "") { }
                        else if (btn_Game6.Text == "X") { }
                        else
                        {
                            if (btn_Game3.Text == "") { }
                            else if (btn_Game3.Text == "X") { }
                            else
                            {
                                return 1;
                            }
                        }
                        if (btn_Game5.Text == "") { }
                        else if (btn_Game5.Text == "X") { }
                        else
                        {
                            if (btn_Game1.Text == "") { }
                            else if (btn_Game1.Text == "X") { }
                            else
                            {
                                return 1;
                            }
                        }
                        if (btn_Game8.Text == "") { }
                        else if (btn_Game8.Text == "X") { }
                        else
                        {
                            if (btn_Game7.Text == "") { }
                            else if (btn_Game7.Text == "X") { }
                            else
                            {
                                return 1;
                            }
                        }
                        break;
                }
                #endregion
            }

            return 0;
        }

        private bool IsDraw()                      //Controlla la partitá controllando i testi dei 9 bottoni
        {
            if (btn_Game1.Text != "" &&
                btn_Game2.Text != "" &&
                btn_Game3.Text != "" &&
                btn_Game4.Text != "" &&
                btn_Game5.Text != "" &&
                btn_Game6.Text != "" &&
                btn_Game7.Text != "" &&
                btn_Game8.Text != "" &&
                btn_Game9.Text != "")
            {
                return true;
            }

            return false;
        }

        private void App_Tris_Load(object sender, EventArgs e)
        {
            if (DB_Settings.Language)
            {
                btn_StartMatch.Text = "Gioca";
                rBtn_1.Text= "1 giocatore";
                rBtn_2.Text= "2 giocatori";
                grbox_player.Text = "Seleziona giocatori";
            }
            else
                {
                btn_StartMatch.Text = "Play";
                rBtn_1.Text= "1 player";
                rBtn_2.Text = "2 players";
                grbox_player.Text = "Select players";

            }
           
        }

                   

    }
}
