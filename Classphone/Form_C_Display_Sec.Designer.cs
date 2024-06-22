namespace Classphone
{
    partial class Form_C_Display_Sec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_C_Display_Sec));
            this.button1 = new System.Windows.Forms.Button();
            this.btn_PIN = new System.Windows.Forms.Button();
            this.btn_PASSWORD = new System.Windows.Forms.Button();
            this.btn_SEQUENCE = new System.Windows.Forms.Button();
            this.btn_TAP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_BackSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(9, 460);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 45);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_PIN
            // 
            this.btn_PIN.BackColor = System.Drawing.Color.White;
            this.btn_PIN.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PIN.Location = new System.Drawing.Point(73, 158);
            this.btn_PIN.Name = "btn_PIN";
            this.btn_PIN.Size = new System.Drawing.Size(151, 51);
            this.btn_PIN.TabIndex = 1;
            this.btn_PIN.Text = "PIN";
            this.btn_PIN.UseVisualStyleBackColor = false;
            this.btn_PIN.Click += new System.EventHandler(this.btn_PIN_Click);
            // 
            // btn_PASSWORD
            // 
            this.btn_PASSWORD.BackColor = System.Drawing.Color.White;
            this.btn_PASSWORD.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PASSWORD.Location = new System.Drawing.Point(73, 215);
            this.btn_PASSWORD.Name = "btn_PASSWORD";
            this.btn_PASSWORD.Size = new System.Drawing.Size(151, 51);
            this.btn_PASSWORD.TabIndex = 2;
            this.btn_PASSWORD.Text = "Password";
            this.btn_PASSWORD.UseVisualStyleBackColor = false;
            this.btn_PASSWORD.Click += new System.EventHandler(this.btn_PASSWORD_Click);
            // 
            // btn_SEQUENCE
            // 
            this.btn_SEQUENCE.BackColor = System.Drawing.Color.White;
            this.btn_SEQUENCE.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SEQUENCE.Location = new System.Drawing.Point(73, 272);
            this.btn_SEQUENCE.Name = "btn_SEQUENCE";
            this.btn_SEQUENCE.Size = new System.Drawing.Size(151, 51);
            this.btn_SEQUENCE.TabIndex = 3;
            this.btn_SEQUENCE.UseVisualStyleBackColor = false;
            this.btn_SEQUENCE.Click += new System.EventHandler(this.btn_SEQUENCE_Click);
            // 
            // btn_TAP
            // 
            this.btn_TAP.BackColor = System.Drawing.Color.White;
            this.btn_TAP.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TAP.Location = new System.Drawing.Point(73, 329);
            this.btn_TAP.Name = "btn_TAP";
            this.btn_TAP.Size = new System.Drawing.Size(151, 51);
            this.btn_TAP.TabIndex = 4;
            this.btn_TAP.UseVisualStyleBackColor = false;
            this.btn_TAP.Click += new System.EventHandler(this.btn_TAP_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 72);
            this.label1.TabIndex = 5;
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_BackSettings
            // 
            this.btn_BackSettings.FlatAppearance.BorderSize = 0;
            this.btn_BackSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BackSettings.Image = ((System.Drawing.Image)(resources.GetObject("btn_BackSettings.Image")));
            this.btn_BackSettings.Location = new System.Drawing.Point(9, 460);
            this.btn_BackSettings.Name = "btn_BackSettings";
            this.btn_BackSettings.Size = new System.Drawing.Size(45, 45);
            this.btn_BackSettings.TabIndex = 6;
            this.btn_BackSettings.UseVisualStyleBackColor = true;
            this.btn_BackSettings.Visible = false;
            this.btn_BackSettings.Click += new System.EventHandler(this.btn_BackSettings_Click);
            // 
            // Form_C_Display_Sec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(307, 514);
            this.Controls.Add(this.btn_BackSettings);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_TAP);
            this.Controls.Add(this.btn_SEQUENCE);
            this.Controls.Add(this.btn_PASSWORD);
            this.Controls.Add(this.btn_PIN);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_C_Display_Sec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form_C_Display_Sec_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_PIN;
        private System.Windows.Forms.Button btn_PASSWORD;
        private System.Windows.Forms.Button btn_SEQUENCE;
        private System.Windows.Forms.Button btn_TAP;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button btn_BackSettings;
    }
}