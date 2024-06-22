namespace Classphone
{
    partial class App_Tris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App_Tris));
            this.btn_StartMatch = new System.Windows.Forms.Button();
            this.grbox_player = new System.Windows.Forms.GroupBox();
            this.rBtn_2 = new System.Windows.Forms.RadioButton();
            this.rBtn_1 = new System.Windows.Forms.RadioButton();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Game9 = new System.Windows.Forms.Button();
            this.btn_Game8 = new System.Windows.Forms.Button();
            this.btn_Game7 = new System.Windows.Forms.Button();
            this.btn_Game6 = new System.Windows.Forms.Button();
            this.btn_Game5 = new System.Windows.Forms.Button();
            this.btn_Game4 = new System.Windows.Forms.Button();
            this.btn_Game3 = new System.Windows.Forms.Button();
            this.btn_Game2 = new System.Windows.Forms.Button();
            this.btn_Game1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.grbox_player.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_StartMatch
            // 
            this.btn_StartMatch.Enabled = false;
            this.btn_StartMatch.FlatAppearance.BorderSize = 0;
            this.btn_StartMatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_StartMatch.Font = new System.Drawing.Font("Motor Oil 1937 M54", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_StartMatch.Location = new System.Drawing.Point(171, 22);
            this.btn_StartMatch.Name = "btn_StartMatch";
            this.btn_StartMatch.Size = new System.Drawing.Size(73, 32);
            this.btn_StartMatch.TabIndex = 0;
            this.btn_StartMatch.Text = "Start";
            this.btn_StartMatch.UseVisualStyleBackColor = true;
            this.btn_StartMatch.Click += new System.EventHandler(this.btn_StartMatch_Click);
            // 
            // grbox_player
            // 
            this.grbox_player.Controls.Add(this.rBtn_2);
            this.grbox_player.Controls.Add(this.rBtn_1);
            this.grbox_player.Font = new System.Drawing.Font("Motor Oil 1937 M54", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbox_player.Location = new System.Drawing.Point(21, 21);
            this.grbox_player.Name = "grbox_player";
            this.grbox_player.Size = new System.Drawing.Size(119, 79);
            this.grbox_player.TabIndex = 1;
            this.grbox_player.TabStop = false;
            this.grbox_player.Text = "Select player";
            // 
            // rBtn_2
            // 
            this.rBtn_2.AutoSize = true;
            this.rBtn_2.Location = new System.Drawing.Point(16, 48);
            this.rBtn_2.Name = "rBtn_2";
            this.rBtn_2.Size = new System.Drawing.Size(77, 17);
            this.rBtn_2.TabIndex = 0;
            this.rBtn_2.TabStop = true;
            this.rBtn_2.Text = "2 player";
            this.rBtn_2.UseVisualStyleBackColor = true;
            this.rBtn_2.CheckedChanged += new System.EventHandler(this.rBtn_2_CheckedChanged);
            // 
            // rBtn_1
            // 
            this.rBtn_1.AutoSize = true;
            this.rBtn_1.Location = new System.Drawing.Point(16, 25);
            this.rBtn_1.Name = "rBtn_1";
            this.rBtn_1.Size = new System.Drawing.Size(73, 17);
            this.rBtn_1.TabIndex = 0;
            this.rBtn_1.TabStop = true;
            this.rBtn_1.Text = "1 player";
            this.rBtn_1.UseVisualStyleBackColor = true;
            this.rBtn_1.CheckedChanged += new System.EventHandler(this.rBtn_1_CheckedChanged);
            // 
            // btn_Reset
            // 
            this.btn_Reset.FlatAppearance.BorderSize = 0;
            this.btn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reset.Font = new System.Drawing.Font("Motor Oil 1937 M54", 11.25F, System.Drawing.FontStyle.Italic);
            this.btn_Reset.Location = new System.Drawing.Point(171, 69);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(73, 37);
            this.btn_Reset.TabIndex = 2;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Visible = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Game9);
            this.panel1.Controls.Add(this.btn_Game8);
            this.panel1.Controls.Add(this.btn_Game7);
            this.panel1.Controls.Add(this.btn_Game6);
            this.panel1.Controls.Add(this.btn_Game5);
            this.panel1.Controls.Add(this.btn_Game4);
            this.panel1.Controls.Add(this.btn_Game3);
            this.panel1.Controls.Add(this.btn_Game2);
            this.panel1.Controls.Add(this.btn_Game1);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(57, 210);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 163);
            this.panel1.TabIndex = 3;
            // 
            // btn_Game9
            // 
            this.btn_Game9.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Game9.Location = new System.Drawing.Point(114, 106);
            this.btn_Game9.Name = "btn_Game9";
            this.btn_Game9.Size = new System.Drawing.Size(40, 40);
            this.btn_Game9.TabIndex = 1;
            this.btn_Game9.UseVisualStyleBackColor = true;
            this.btn_Game9.Click += new System.EventHandler(this.btn_Game9_Click);
            // 
            // btn_Game8
            // 
            this.btn_Game8.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Game8.Location = new System.Drawing.Point(68, 106);
            this.btn_Game8.Name = "btn_Game8";
            this.btn_Game8.Size = new System.Drawing.Size(40, 40);
            this.btn_Game8.TabIndex = 1;
            this.btn_Game8.UseVisualStyleBackColor = true;
            this.btn_Game8.Click += new System.EventHandler(this.btn_Game8_Click);
            // 
            // btn_Game7
            // 
            this.btn_Game7.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Game7.Location = new System.Drawing.Point(22, 106);
            this.btn_Game7.Name = "btn_Game7";
            this.btn_Game7.Size = new System.Drawing.Size(40, 40);
            this.btn_Game7.TabIndex = 1;
            this.btn_Game7.UseVisualStyleBackColor = true;
            this.btn_Game7.Click += new System.EventHandler(this.btn_Game7_Click);
            // 
            // btn_Game6
            // 
            this.btn_Game6.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Game6.Location = new System.Drawing.Point(114, 60);
            this.btn_Game6.Name = "btn_Game6";
            this.btn_Game6.Size = new System.Drawing.Size(40, 40);
            this.btn_Game6.TabIndex = 1;
            this.btn_Game6.UseVisualStyleBackColor = true;
            this.btn_Game6.Click += new System.EventHandler(this.btn_Game6_Click);
            // 
            // btn_Game5
            // 
            this.btn_Game5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Game5.Location = new System.Drawing.Point(68, 60);
            this.btn_Game5.Name = "btn_Game5";
            this.btn_Game5.Size = new System.Drawing.Size(40, 40);
            this.btn_Game5.TabIndex = 1;
            this.btn_Game5.UseVisualStyleBackColor = true;
            this.btn_Game5.Click += new System.EventHandler(this.btn_Game5_Click);
            // 
            // btn_Game4
            // 
            this.btn_Game4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Game4.Location = new System.Drawing.Point(22, 60);
            this.btn_Game4.Name = "btn_Game4";
            this.btn_Game4.Size = new System.Drawing.Size(40, 40);
            this.btn_Game4.TabIndex = 1;
            this.btn_Game4.UseVisualStyleBackColor = true;
            this.btn_Game4.Click += new System.EventHandler(this.btn_Game4_Click);
            // 
            // btn_Game3
            // 
            this.btn_Game3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Game3.Location = new System.Drawing.Point(114, 14);
            this.btn_Game3.Name = "btn_Game3";
            this.btn_Game3.Size = new System.Drawing.Size(40, 40);
            this.btn_Game3.TabIndex = 1;
            this.btn_Game3.UseVisualStyleBackColor = true;
            this.btn_Game3.Click += new System.EventHandler(this.btn_Game3_Click);
            // 
            // btn_Game2
            // 
            this.btn_Game2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Game2.Location = new System.Drawing.Point(68, 14);
            this.btn_Game2.Name = "btn_Game2";
            this.btn_Game2.Size = new System.Drawing.Size(40, 40);
            this.btn_Game2.TabIndex = 1;
            this.btn_Game2.UseVisualStyleBackColor = true;
            this.btn_Game2.Click += new System.EventHandler(this.btn_Game2_Click);
            // 
            // btn_Game1
            // 
            this.btn_Game1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Game1.Location = new System.Drawing.Point(22, 14);
            this.btn_Game1.Name = "btn_Game1";
            this.btn_Game1.Size = new System.Drawing.Size(40, 40);
            this.btn_Game1.TabIndex = 0;
            this.btn_Game1.UseVisualStyleBackColor = true;
            this.btn_Game1.Click += new System.EventHandler(this.btn_Game1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Motor Oil 1937 M54", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 40);
            this.label1.TabIndex = 4;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Back
            // 
            this.btn_Back.FlatAppearance.BorderSize = 0;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Image = ((System.Drawing.Image)(resources.GetObject("btn_Back.Image")));
            this.btn_Back.Location = new System.Drawing.Point(12, 457);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(45, 45);
            this.btn_Back.TabIndex = 28;
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // App_Tris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(307, 514);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.grbox_player);
            this.Controls.Add(this.btn_StartMatch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "App_Tris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App_Tris";
            this.Load += new System.EventHandler(this.App_Tris_Load);
            this.grbox_player.ResumeLayout(false);
            this.grbox_player.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_StartMatch;
        private System.Windows.Forms.GroupBox grbox_player;
        private System.Windows.Forms.RadioButton rBtn_2;
        private System.Windows.Forms.RadioButton rBtn_1;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Game9;
        private System.Windows.Forms.Button btn_Game8;
        private System.Windows.Forms.Button btn_Game7;
        private System.Windows.Forms.Button btn_Game6;
        private System.Windows.Forms.Button btn_Game5;
        private System.Windows.Forms.Button btn_Game4;
        private System.Windows.Forms.Button btn_Game3;
        private System.Windows.Forms.Button btn_Game2;
        private System.Windows.Forms.Button btn_Game1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Back;
    }
}