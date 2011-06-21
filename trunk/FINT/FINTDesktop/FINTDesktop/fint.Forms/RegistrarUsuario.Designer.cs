namespace fint.Forms
{
    partial class Registrar_Cliente
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
            this.nombreLbl = new System.Windows.Forms.Label();
            this.nombreTxt = new System.Windows.Forms.TextBox();
            this.loginLbl = new System.Windows.Forms.Label();
            this.loginTxt = new System.Windows.Forms.TextBox();
            this.pwdLabel = new System.Windows.Forms.Label();
            this.pwdText = new System.Windows.Forms.TextBox();
            this.doneBtn = new System.Windows.Forms.Button();
            this.msgLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nombreLbl
            // 
            this.nombreLbl.AutoSize = true;
            this.nombreLbl.Location = new System.Drawing.Point(12, 34);
            this.nombreLbl.Name = "nombreLbl";
            this.nombreLbl.Size = new System.Drawing.Size(47, 13);
            this.nombreLbl.TabIndex = 0;
            this.nombreLbl.Text = "Nombre:";
            // 
            // nombreTxt
            // 
            this.nombreTxt.Location = new System.Drawing.Point(65, 27);
            this.nombreTxt.Name = "nombreTxt";
            this.nombreTxt.Size = new System.Drawing.Size(177, 20);
            this.nombreTxt.TabIndex = 1;
            // 
            // loginLbl
            // 
            this.loginLbl.AutoSize = true;
            this.loginLbl.Location = new System.Drawing.Point(23, 72);
            this.loginLbl.Name = "loginLbl";
            this.loginLbl.Size = new System.Drawing.Size(36, 13);
            this.loginLbl.TabIndex = 2;
            this.loginLbl.Text = "Login:";
            this.loginLbl.Click += new System.EventHandler(this.loginLbl_Click);
            // 
            // loginTxt
            // 
            this.loginTxt.Location = new System.Drawing.Point(65, 69);
            this.loginTxt.Name = "loginTxt";
            this.loginTxt.Size = new System.Drawing.Size(124, 20);
            this.loginTxt.TabIndex = 3;
            // 
            // pwdLabel
            // 
            this.pwdLabel.AutoSize = true;
            this.pwdLabel.Location = new System.Drawing.Point(12, 121);
            this.pwdLabel.Name = "pwdLabel";
            this.pwdLabel.Size = new System.Drawing.Size(56, 13);
            this.pwdLabel.TabIndex = 4;
            this.pwdLabel.Text = "Password:";
            // 
            // pwdText
            // 
            this.pwdText.Location = new System.Drawing.Point(65, 118);
            this.pwdText.Name = "pwdText";
            this.pwdText.PasswordChar = '*';
            this.pwdText.Size = new System.Drawing.Size(124, 20);
            this.pwdText.TabIndex = 5;
            this.pwdText.UseSystemPasswordChar = true;
            // 
            // doneBtn
            // 
            this.doneBtn.Location = new System.Drawing.Point(167, 203);
            this.doneBtn.Name = "doneBtn";
            this.doneBtn.Size = new System.Drawing.Size(75, 23);
            this.doneBtn.TabIndex = 6;
            this.doneBtn.Text = "Aceptar";
            this.doneBtn.UseVisualStyleBackColor = true;
            this.doneBtn.Click += new System.EventHandler(this.doneBtn_Click);
            // 
            // msgLbl
            // 
            this.msgLbl.AutoSize = true;
            this.msgLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.msgLbl.Location = new System.Drawing.Point(62, 242);
            this.msgLbl.Name = "msgLbl";
            this.msgLbl.Size = new System.Drawing.Size(0, 13);
            this.msgLbl.TabIndex = 7;
            this.msgLbl.Visible = false;
            // 
            // Registrar_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.msgLbl);
            this.Controls.Add(this.doneBtn);
            this.Controls.Add(this.pwdText);
            this.Controls.Add(this.pwdLabel);
            this.Controls.Add(this.loginTxt);
            this.Controls.Add(this.loginLbl);
            this.Controls.Add(this.nombreTxt);
            this.Controls.Add(this.nombreLbl);
            this.Name = "Registrar_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Usuario";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Registrar_Cliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nombreLbl;
        private System.Windows.Forms.TextBox nombreTxt;
        private System.Windows.Forms.Label loginLbl;
        private System.Windows.Forms.TextBox loginTxt;
        private System.Windows.Forms.Label pwdLabel;
        private System.Windows.Forms.TextBox pwdText;
        private System.Windows.Forms.Button doneBtn;
        private System.Windows.Forms.Label msgLbl;
    }
}