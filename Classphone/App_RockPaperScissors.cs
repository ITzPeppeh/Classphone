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
    public partial class App_RockPaperScissors : Form
    {
        Random casualnumber = new Random();
        int score1 = 0;
        int score2 = 0;

        public App_RockPaperScissors()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            labelGam.Text = "";
            if (radio1Player.Checked)
            {
                Game1Player(); // Call function void //
            }
            else
            {
                Game2Player(); // Call function void //
            }
        }

        private void buttonStartMatch_Click(object sender, EventArgs e)         //Btn inizio partita
        {
            if (radio1Player.Checked)
            {
                group1stPlayer.Enabled = true;
                group1stPlayer.Visible = true;
                group2ndPlayer.Visible = false;
                buttonStartMatch.Enabled = false;

                buttonStart.Enabled = true;
                buttonStart.Visible = true;
                buttonEnd.Enabled = true;
                groupBoxPlayer.Enabled = false;
                buttonForceStop.Visible = true;
                buttonForceStop.Enabled = true;

            }
            else if (radio2Player.Checked)
            {
                group1stPlayer.Enabled = true;
                group1stPlayer.Visible = true;
                group2ndPlayer.Enabled = false;
                group2ndPlayer.Visible = false;
                buttonStartMatch.Enabled = false;
                buttonStart.Enabled = false;
                buttonStart.Visible = false;
                button1.Enabled = true;
                button1.Visible = true;
                buttonEnd.Enabled = true;
                groupBoxPlayer.Enabled = false;
                buttonForceStop.Visible = true;
                buttonForceStop.Enabled = true;
            }
           
        }

        private void buttonEnd_Click(object sender, EventArgs e)                    //Btn Fine partita che controlla gli score e li stampa
        {       
            if (radio1Player.Checked)
            {
                if (score1 < score2)
                {
                    if(DB_Settings.Language)
                        labelGam.Text= "Hai Perso";
                    else
                         labelGam.Text= "You Lost";
                }
                else if (score1 > score2)
                {
                    if (DB_Settings.Language)
                        labelGam.Text = "Hai vinto";
                    else
                        labelGam.Text = "You won";
                }
                else
                {
                    if (DB_Settings.Language)
                        labelGam.Text = "Pareggio";
                    else
                        labelGam.Text = "Draw";
                }
            }
            else
            {
                if (score1 < score2)
                {
                    if (DB_Settings.Language)
                        labelGam.Text = "Player 2 vince";
                    else
                        labelGam.Text = "PLayer 2 wins";
                }
                else if (score1 > score2)
                {
                    if (DB_Settings.Language)
                        labelGam.Text = "PLayer 1 vince";
                    else
                        labelGam.Text = "PLayer 1 wins";
                }
                else
                {
                    if (DB_Settings.Language)
                        labelGam.Text = "Pareggio";
                    else
                        labelGam.Text = "Draw";
                }
            }
            ClearAll(); // Call function void //
            groupBoxPlayer.Enabled = true;
        }

        private void buttonForceStop_Click(object sender, EventArgs e)          //Btn Reset
        {
            ClearAll(); // Call function void //
            if (!groupBoxPlayer.Enabled)
                groupBoxPlayer.Enabled = true;
        }

        private void radio1Player_CheckedChanged(object sender, EventArgs e)        //Evento se viene selezionato la partita con 1 player
        {
            if (radio1Player.Checked)
            {
                buttonStartMatch.Enabled = true;
                buttonStartMatch.Visible = true;
            }
            else
            {
                  if (group1stPlayer.Enabled)
                      group1stPlayer.Enabled = false;
                  if (group2ndPlayer.Enabled)
                      group2ndPlayer.Enabled = false;
                
            }
        }

        private void radio2Player_CheckedChanged(object sender, EventArgs e)        //Evento se viene selezionato la partita con 2 player
        {
            if (radio2Player.Checked)
            {
                buttonStartMatch.Enabled = true;
                buttonStartMatch.Visible = true;
            }
            else
            {
                 if (group1stPlayer.Enabled)
                      group1stPlayer.Enabled = false;
                 if (group2ndPlayer.Enabled)
                      group2ndPlayer.Enabled = false;
            }
        }

        void ClearAll()                                     //Funzione che pulisce tutto i label e resetta score
        {
            Score1stPlayer.Text = "";
            Score2ndPlayer.Text = "";
            labelGam.Text = "";
            score1 = 0;
            score2 = 0;
            if (radio1stPaper.Checked)
                radio1stPaper.Checked = false;
            if (radio1stScissors.Checked)
                radio1stScissors.Checked = false;
            if (radio1stRock.Checked)
                radio1stRock.Checked = false;
            if (radio2ndPaper.Checked)
                radio2ndPaper.Checked = false;
            if (radio2ndRock.Checked)
                radio2ndRock.Checked = false;
            if (radio2ndScissors.Checked)
                radio2ndScissors.Checked = false;
            if (radio1Player.Checked)
                radio1Player.Checked = false;
            if (radio2Player.Checked)
                radio2Player.Checked = false;
            if (group1stPlayer.Enabled)
                group1stPlayer.Enabled = false;
            if (group2ndPlayer.Enabled)
                group2ndPlayer.Enabled = false;
            if (buttonStart.Enabled)
                buttonStart.Enabled = false;
            if (buttonEnd.Enabled)
                buttonEnd.Enabled = false;
            if (buttonStartMatch.Enabled)
                buttonStartMatch.Enabled = false;
            if (buttonForceStop.Visible)
                buttonForceStop.Visible = false;
            if (buttonForceStop.Enabled)
                buttonForceStop.Enabled = false;
        }

        void Game1Player()                                  //Funzione che gestisce la partita con 1 player
        {
            string sel2 = RollN(casualnumber.Next(1, 4));                               //mossa computer
            #region Algoritmi per controllare il vincitore, il perdente o il pareggio
            if (radio1stPaper.Checked)
            {
                if (radio1stPaper.Text != sel2 && sel2 == "Scissors")
                {
                    score2++;
                    if(DB_Settings.Language)
                    labelGam.Text = "hai perso (forbici)";
                    else
                        labelGam.Text = "you lost (scissors)";
                    Score2ndPlayer.Text = score2.ToString();
                }
                else if (radio1stPaper.Text != sel2 && sel2 == "Rock")
                {
                    score1++;
                    if (DB_Settings.Language)
                        labelGam.Text = "hai vinto (sasso)";
                    else
                        labelGam.Text = "you won (rock)";
                    Score1stPlayer.Text = score1.ToString();
                }
                else
                {
                    if (DB_Settings.Language)
                        labelGam.Text = "Pareggio (carta)";
                    else
                        labelGam.Text = "draw (paper)";
                }
            }
            else if (radio1stScissors.Checked)
            {
                if (radio1stScissors.Text != sel2 && sel2 == "Rock")
                {
                    score2++;
                    if (DB_Settings.Language)
                        labelGam.Text = "hai perso (sasso)";
                    else
                        labelGam.Text = "you lost (rock)";
                    Score2ndPlayer.Text = score2.ToString();
                }
                else if (radio1stScissors.Text != sel2 && sel2 == "Paper")
                {
                    score1++;
                    if (DB_Settings.Language)
                        labelGam.Text = "hai vinto (carta)";
                    else
                        labelGam.Text = "you won (paper)";
                    Score1stPlayer.Text = score1.ToString();
                }
                else
                {
                    if (DB_Settings.Language)
                        labelGam.Text = "pareggio (forbici)";
                    else
                        labelGam.Text = "draw (scissors)";
                }
            }
            else if (radio1stRock.Checked)
            {
                if (radio1stRock.Text != sel2 && sel2 == "Scissors")
                {
                    score1++;
                    if (DB_Settings.Language)
                        labelGam.Text = "hai vinto (forbici)";
                    else
                        labelGam.Text = "you won (scissors)";
                    Score1stPlayer.Text = score1.ToString();
                }
                else if (radio1stRock.Text != sel2 && sel2 == "Paper")
                {
                    score2++;
                    if (DB_Settings.Language)
                        labelGam.Text = "hai perso (carta)";
                    else
                        labelGam.Text = "you lost (paper)";
                    Score2ndPlayer.Text = score2.ToString();
                }
                else
                {
                    if (DB_Settings.Language)
                        labelGam.Text = "pareggio (sasso)";
                    else
                        labelGam.Text = "draw (rock)";
                }
            }
            #endregion

        }

        void Game2Player()                                  //Funzione che gestisce la partita con 2 player
        {
            #region Algoritmi per controllare il vincitore, il perdente o il pareggio
            if (radio2ndPaper.Checked)
            {
                if (radio1stPaper.Checked)
                {
                    if(DB_Settings.Language)
                        labelGam.Text = "Pareggio";
                    else
                        labelGam.Text = "Draw";

                }
                else if (radio1stScissors.Checked)
                {
                    score1++;
                    if (DB_Settings.Language)
                        labelGam.Text = "Vince il player 1";
                    else
                        labelGam.Text = "Player 1 wins";
                    Score1stPlayer.Text = score1.ToString();
                }
                else if (radio1stRock.Checked)
                {
                    score2++;
                    if (DB_Settings.Language)
                        labelGam.Text = "Vince il player 2";
                    else
                        labelGam.Text = "Player 2 wins";
                    Score2ndPlayer.Text = score2.ToString();

                }
            }
            else if (radio2ndScissors.Checked)
            {
                if (radio1stPaper.Checked)
                {
                    score2++;
                    if (DB_Settings.Language)
                        labelGam.Text = "Vince il player 2";
                    else
                        labelGam.Text = "Player 2 wins";
                    Score2ndPlayer.Text = score2.ToString();
                }
                else if (radio1stScissors.Checked)
                {
                    if (DB_Settings.Language)
                        labelGam.Text = "Pareggio";
                    else
                        labelGam.Text = "Draw";
                }
                else if (radio1stRock.Checked)
                {
                    score1++;
                    if (DB_Settings.Language)
                        labelGam.Text = "Vince il player 1";
                    else
                        labelGam.Text = "Player 1 wins";
                    Score1stPlayer.Text = score1.ToString();

                }
            }
            else if (radio2ndRock.Checked)
            {
                if (radio1stPaper.Checked)
                {
                    score1++;
                    if (DB_Settings.Language)
                        labelGam.Text = "Vince il player 1";
                    else
                        labelGam.Text = "Player 1 wins";
                    Score1stPlayer.Text = score1.ToString();
                }
                else if (radio1stScissors.Checked)
                {
                    score2++;
                    if (DB_Settings.Language)
                        labelGam.Text = "Vince il player 2";
                    else
                        labelGam.Text = "Player 2 wins";
                    Score2ndPlayer.Text = score2.ToString();
                }
                else if (radio1stRock.Checked)
                {
                    if (DB_Settings.Language)
                        labelGam.Text = "Pareggio";
                    else
                        labelGam.Text = "Draw";

                }
            }
            else
            {
                if (DB_Settings.Language)
                {
                    labelGam.Text = "Scegli un opzione";
                }
                else
                {
                    labelGam.Text = "Choose an option";
                }
            }
            #endregion
        }

        string RollN(int num)                               //Funzione con uno switch per la mossa del computer
        {
            switch (num)
            {
                case 1:
                    return "Paper";
                case 2:
                    return "Scissors";
                case 3:
                    return "Rock";
            }
            return "";
        }

        private void button1_Click(object sender, EventArgs e)      //Btn per la mossa del 2° giocatore
        {
            labelGam.Text = "";
            if (radio1stPaper.Checked)
            {
                group2ndPlayer.Visible = true;
                group2ndPlayer.Enabled = true;
                group1stPlayer.Visible = false;

                buttonStart.Visible = true;
                button1.Visible = false;
            }
            else if(radio1stRock.Checked)
            {
                group2ndPlayer.Visible = true;
                group2ndPlayer.Enabled = true;
                group1stPlayer.Visible = false;

                buttonStart.Visible = true;
                button1.Visible = false;
            }
            else if(radio1stScissors.Checked)
            {
                group2ndPlayer.Visible = true;
                group2ndPlayer.Enabled = true;
                group1stPlayer.Visible = false;

                buttonStart.Visible = true;
                button1.Visible = false;
            }
            else
            {
                if (DB_Settings.Language)
                {
                    labelGam.Text = "Scegli un opzione";
                }
                else
                {
                    labelGam.Text = "Choose an option";
                }
                return;
            }
            buttonStart.Enabled = true;
            buttonStart.Visible = true;
        }

        private void btn_Back_Click(object sender, EventArgs e)     //Btn per tornare alla Home
        {
            Form_Home fhome = new Form_Home();
            fhome.Show();
            this.Close();
        }
      
    }
}                  
