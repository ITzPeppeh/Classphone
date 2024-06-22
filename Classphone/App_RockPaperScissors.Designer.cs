namespace Classphone
{
    partial class App_RockPaperScissors
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App_RockPaperScissors));
            this.buttonForceStop = new System.Windows.Forms.Button();
            this.buttonStartMatch = new System.Windows.Forms.Button();
            this.buttonEnd = new System.Windows.Forms.Button();
            this.labelGam = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.group2ndPlayer = new System.Windows.Forms.GroupBox();
            this.Score2ndPlayer = new System.Windows.Forms.Label();
            this.radio2ndScissors = new System.Windows.Forms.RadioButton();
            this.radio2ndPaper = new System.Windows.Forms.RadioButton();
            this.labelUseless2 = new System.Windows.Forms.Label();
            this.radio2ndRock = new System.Windows.Forms.RadioButton();
            this.group1stPlayer = new System.Windows.Forms.GroupBox();
            this.Score1stPlayer = new System.Windows.Forms.Label();
            this.radio1stScissors = new System.Windows.Forms.RadioButton();
            this.radio1stPaper = new System.Windows.Forms.RadioButton();
            this.radio1stRock = new System.Windows.Forms.RadioButton();
            this.labelUseless1 = new System.Windows.Forms.Label();
            this.groupBoxPlayer = new System.Windows.Forms.GroupBox();
            this.radio2Player = new System.Windows.Forms.RadioButton();
            this.radio1Player = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.group2ndPlayer.SuspendLayout();
            this.group1stPlayer.SuspendLayout();
            this.groupBoxPlayer.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonForceStop
            // 
            this.buttonForceStop.BackColor = System.Drawing.Color.White;
            this.buttonForceStop.Enabled = false;
            this.buttonForceStop.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonForceStop.Location = new System.Drawing.Point(96, 62);
            this.buttonForceStop.Name = "buttonForceStop";
            this.buttonForceStop.Size = new System.Drawing.Size(61, 29);
            this.buttonForceStop.TabIndex = 25;
            this.buttonForceStop.Text = "Reset";
            this.buttonForceStop.UseVisualStyleBackColor = false;
            this.buttonForceStop.Visible = false;
            this.buttonForceStop.Click += new System.EventHandler(this.buttonForceStop_Click);
            // 
            // buttonStartMatch
            // 
            this.buttonStartMatch.BackColor = System.Drawing.Color.White;
            this.buttonStartMatch.Enabled = false;
            this.buttonStartMatch.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartMatch.Location = new System.Drawing.Point(163, 20);
            this.buttonStartMatch.Name = "buttonStartMatch";
            this.buttonStartMatch.Size = new System.Drawing.Size(95, 29);
            this.buttonStartMatch.TabIndex = 24;
            this.buttonStartMatch.Text = "Start Match";
            this.buttonStartMatch.UseVisualStyleBackColor = false;
            this.buttonStartMatch.Click += new System.EventHandler(this.buttonStartMatch_Click);
            // 
            // buttonEnd
            // 
            this.buttonEnd.BackColor = System.Drawing.Color.White;
            this.buttonEnd.Enabled = false;
            this.buttonEnd.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnd.Location = new System.Drawing.Point(163, 55);
            this.buttonEnd.Name = "buttonEnd";
            this.buttonEnd.Size = new System.Drawing.Size(95, 29);
            this.buttonEnd.TabIndex = 23;
            this.buttonEnd.Text = "End Match";
            this.buttonEnd.UseVisualStyleBackColor = false;
            this.buttonEnd.Click += new System.EventHandler(this.buttonEnd_Click);
            // 
            // labelGam
            // 
            this.labelGam.AutoSize = true;
            this.labelGam.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGam.Location = new System.Drawing.Point(52, 109);
            this.labelGam.Name = "labelGam";
            this.labelGam.Size = new System.Drawing.Size(0, 31);
            this.labelGam.TabIndex = 22;
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.White;
            this.buttonStart.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(107, 440);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(95, 29);
            this.buttonStart.TabIndex = 21;
            this.buttonStart.Text = "Next Round";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Visible = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // group2ndPlayer
            // 
            this.group2ndPlayer.BackColor = System.Drawing.Color.White;
            this.group2ndPlayer.Controls.Add(this.Score2ndPlayer);
            this.group2ndPlayer.Controls.Add(this.radio2ndScissors);
            this.group2ndPlayer.Controls.Add(this.radio2ndPaper);
            this.group2ndPlayer.Controls.Add(this.labelUseless2);
            this.group2ndPlayer.Controls.Add(this.radio2ndRock);
            this.group2ndPlayer.Enabled = false;
            this.group2ndPlayer.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group2ndPlayer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.group2ndPlayer.Location = new System.Drawing.Point(30, 165);
            this.group2ndPlayer.Name = "group2ndPlayer";
            this.group2ndPlayer.Size = new System.Drawing.Size(243, 205);
            this.group2ndPlayer.TabIndex = 20;
            this.group2ndPlayer.TabStop = false;
            this.group2ndPlayer.Text = "2nd Player";
            this.group2ndPlayer.Visible = false;
            // 
            // Score2ndPlayer
            // 
            this.Score2ndPlayer.AutoSize = true;
            this.Score2ndPlayer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score2ndPlayer.Location = new System.Drawing.Point(58, 171);
            this.Score2ndPlayer.Name = "Score2ndPlayer";
            this.Score2ndPlayer.Size = new System.Drawing.Size(0, 19);
            this.Score2ndPlayer.TabIndex = 13;
            // 
            // radio2ndScissors
            // 
            this.radio2ndScissors.AutoSize = true;
            this.radio2ndScissors.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio2ndScissors.Location = new System.Drawing.Point(29, 98);
            this.radio2ndScissors.Name = "radio2ndScissors";
            this.radio2ndScissors.Size = new System.Drawing.Size(84, 21);
            this.radio2ndScissors.TabIndex = 14;
            this.radio2ndScissors.TabStop = true;
            this.radio2ndScissors.Text = "Scissors";
            this.radio2ndScissors.UseVisualStyleBackColor = true;
            // 
            // radio2ndPaper
            // 
            this.radio2ndPaper.AutoSize = true;
            this.radio2ndPaper.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio2ndPaper.Location = new System.Drawing.Point(29, 74);
            this.radio2ndPaper.Name = "radio2ndPaper";
            this.radio2ndPaper.Size = new System.Drawing.Size(65, 21);
            this.radio2ndPaper.TabIndex = 13;
            this.radio2ndPaper.TabStop = true;
            this.radio2ndPaper.Text = "Paper";
            this.radio2ndPaper.UseVisualStyleBackColor = true;
            // 
            // labelUseless2
            // 
            this.labelUseless2.AutoSize = true;
            this.labelUseless2.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUseless2.Location = new System.Drawing.Point(7, 170);
            this.labelUseless2.Name = "labelUseless2";
            this.labelUseless2.Size = new System.Drawing.Size(45, 20);
            this.labelUseless2.TabIndex = 8;
            this.labelUseless2.Text = "Score";
            // 
            // radio2ndRock
            // 
            this.radio2ndRock.AutoSize = true;
            this.radio2ndRock.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio2ndRock.Location = new System.Drawing.Point(29, 122);
            this.radio2ndRock.Name = "radio2ndRock";
            this.radio2ndRock.Size = new System.Drawing.Size(61, 21);
            this.radio2ndRock.TabIndex = 12;
            this.radio2ndRock.TabStop = true;
            this.radio2ndRock.Text = "Rock";
            this.radio2ndRock.UseVisualStyleBackColor = true;
            // 
            // group1stPlayer
            // 
            this.group1stPlayer.BackColor = System.Drawing.Color.White;
            this.group1stPlayer.Controls.Add(this.Score1stPlayer);
            this.group1stPlayer.Controls.Add(this.radio1stScissors);
            this.group1stPlayer.Controls.Add(this.radio1stPaper);
            this.group1stPlayer.Controls.Add(this.radio1stRock);
            this.group1stPlayer.Controls.Add(this.labelUseless1);
            this.group1stPlayer.Enabled = false;
            this.group1stPlayer.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group1stPlayer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.group1stPlayer.Location = new System.Drawing.Point(28, 167);
            this.group1stPlayer.Name = "group1stPlayer";
            this.group1stPlayer.Size = new System.Drawing.Size(245, 209);
            this.group1stPlayer.TabIndex = 19;
            this.group1stPlayer.TabStop = false;
            this.group1stPlayer.Text = "1st Player";
            this.group1stPlayer.Visible = false;
            // 
            // Score1stPlayer
            // 
            this.Score1stPlayer.AutoSize = true;
            this.Score1stPlayer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score1stPlayer.Location = new System.Drawing.Point(58, 174);
            this.Score1stPlayer.Name = "Score1stPlayer";
            this.Score1stPlayer.Size = new System.Drawing.Size(0, 19);
            this.Score1stPlayer.TabIndex = 12;
            // 
            // radio1stScissors
            // 
            this.radio1stScissors.AutoSize = true;
            this.radio1stScissors.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio1stScissors.Location = new System.Drawing.Point(29, 98);
            this.radio1stScissors.Name = "radio1stScissors";
            this.radio1stScissors.Size = new System.Drawing.Size(84, 21);
            this.radio1stScissors.TabIndex = 11;
            this.radio1stScissors.TabStop = true;
            this.radio1stScissors.Text = "Scissors";
            this.radio1stScissors.UseVisualStyleBackColor = true;
            // 
            // radio1stPaper
            // 
            this.radio1stPaper.AutoSize = true;
            this.radio1stPaper.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio1stPaper.Location = new System.Drawing.Point(29, 74);
            this.radio1stPaper.Name = "radio1stPaper";
            this.radio1stPaper.Size = new System.Drawing.Size(65, 21);
            this.radio1stPaper.TabIndex = 10;
            this.radio1stPaper.TabStop = true;
            this.radio1stPaper.Text = "Paper";
            this.radio1stPaper.UseVisualStyleBackColor = true;
            // 
            // radio1stRock
            // 
            this.radio1stRock.AutoSize = true;
            this.radio1stRock.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio1stRock.Location = new System.Drawing.Point(29, 122);
            this.radio1stRock.Name = "radio1stRock";
            this.radio1stRock.Size = new System.Drawing.Size(61, 21);
            this.radio1stRock.TabIndex = 8;
            this.radio1stRock.TabStop = true;
            this.radio1stRock.Text = "Rock";
            this.radio1stRock.UseVisualStyleBackColor = true;
            // 
            // labelUseless1
            // 
            this.labelUseless1.AutoSize = true;
            this.labelUseless1.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUseless1.Location = new System.Drawing.Point(7, 173);
            this.labelUseless1.Name = "labelUseless1";
            this.labelUseless1.Size = new System.Drawing.Size(45, 20);
            this.labelUseless1.TabIndex = 7;
            this.labelUseless1.Text = "Score";
            // 
            // groupBoxPlayer
            // 
            this.groupBoxPlayer.Controls.Add(this.radio2Player);
            this.groupBoxPlayer.Controls.Add(this.radio1Player);
            this.groupBoxPlayer.Controls.Add(this.label1);
            this.groupBoxPlayer.Location = new System.Drawing.Point(12, 17);
            this.groupBoxPlayer.Name = "groupBoxPlayer";
            this.groupBoxPlayer.Padding = new System.Windows.Forms.Padding(0);
            this.groupBoxPlayer.Size = new System.Drawing.Size(145, 71);
            this.groupBoxPlayer.TabIndex = 18;
            this.groupBoxPlayer.TabStop = false;
            // 
            // radio2Player
            // 
            this.radio2Player.AutoSize = true;
            this.radio2Player.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio2Player.Location = new System.Drawing.Point(7, 46);
            this.radio2Player.Name = "radio2Player";
            this.radio2Player.Size = new System.Drawing.Size(70, 18);
            this.radio2Player.TabIndex = 6;
            this.radio2Player.TabStop = true;
            this.radio2Player.Text = "2 Players";
            this.radio2Player.UseVisualStyleBackColor = true;
            this.radio2Player.CheckedChanged += new System.EventHandler(this.radio2Player_CheckedChanged);
            // 
            // radio1Player
            // 
            this.radio1Player.AutoSize = true;
            this.radio1Player.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio1Player.Location = new System.Drawing.Point(7, 28);
            this.radio1Player.Name = "radio1Player";
            this.radio1Player.Size = new System.Drawing.Size(64, 18);
            this.radio1Player.TabIndex = 5;
            this.radio1Player.TabStop = true;
            this.radio1Player.Text = "1 Player";
            this.radio1Player.UseVisualStyleBackColor = true;
            this.radio1Player.CheckedChanged += new System.EventHandler(this.radio1Player_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select how many players";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button1.Location = new System.Drawing.Point(86, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 35);
            this.button1.TabIndex = 26;
            this.button1.Text = "Next player move";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.FlatAppearance.BorderSize = 0;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Image = ((System.Drawing.Image)(resources.GetObject("btn_Back.Image")));
            this.btn_Back.Location = new System.Drawing.Point(12, 457);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(45, 45);
            this.btn_Back.TabIndex = 27;
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // App_RockPaperScissors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(307, 514);
            this.Controls.Add(this.group2ndPlayer);
            this.Controls.Add(this.group1stPlayer);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonForceStop);
            this.Controls.Add(this.buttonStartMatch);
            this.Controls.Add(this.buttonEnd);
            this.Controls.Add(this.labelGam);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.groupBoxPlayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "App_RockPaperScissors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App_RockPaperScissors";
            this.group2ndPlayer.ResumeLayout(false);
            this.group2ndPlayer.PerformLayout();
            this.group1stPlayer.ResumeLayout(false);
            this.group1stPlayer.PerformLayout();
            this.groupBoxPlayer.ResumeLayout(false);
            this.groupBoxPlayer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonForceStop;
        private System.Windows.Forms.Button buttonStartMatch;
        private System.Windows.Forms.Button buttonEnd;
        private System.Windows.Forms.Label labelGam;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.GroupBox group2ndPlayer;
        private System.Windows.Forms.Label Score2ndPlayer;
        private System.Windows.Forms.RadioButton radio2ndScissors;
        private System.Windows.Forms.RadioButton radio2ndPaper;
        private System.Windows.Forms.Label labelUseless2;
        private System.Windows.Forms.RadioButton radio2ndRock;
        private System.Windows.Forms.GroupBox group1stPlayer;
        private System.Windows.Forms.Label Score1stPlayer;
        private System.Windows.Forms.RadioButton radio1stScissors;
        private System.Windows.Forms.RadioButton radio1stPaper;
        private System.Windows.Forms.RadioButton radio1stRock;
        private System.Windows.Forms.Label labelUseless1;
        private System.Windows.Forms.GroupBox groupBoxPlayer;
        private System.Windows.Forms.RadioButton radio2Player;
        private System.Windows.Forms.RadioButton radio1Player;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Back;
    }
}