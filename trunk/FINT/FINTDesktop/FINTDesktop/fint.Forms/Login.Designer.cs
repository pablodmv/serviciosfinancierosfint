namespace fint.Forms
{
    partial class Login
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
            this.usrLbl = new System.Windows.Forms.Label();
            this.pwdLbl = new System.Windows.Forms.Label();
            this.usrTxt = new System.Windows.Forms.TextBox();
            this.pwdTxt = new System.Windows.Forms.TextBox();
            this.doneBtn = new System.Windows.Forms.Button();
            this.msgLbl = new System.Windows.Forms.Label();
            this.newUsrLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // usrLbl
            // 
            this.usrLbl.AutoSize = true;
            this.usrLbl.Location = new System.Drawing.Point(12, 32);
            this.usrLbl.Name = "usrLbl";
            this.usrLbl.Size = new System.Drawing.Size(46, 13);
            this.usrLbl.TabIndex = 0;
            this.usrLbl.Text = "Usuario:";
            this.usrLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // pwdLbl
            // 
            this.pwdLbl.AutoSize = true;
            this.pwdLbl.Location = new System.Drawing.Point(12, 69);
            this.pwdLbl.Name = "pwdLbl";
            this.pwdLbl.Size = new System.Drawing.Size(64, 13);
            this.pwdLbl.TabIndex = 1;
            this.pwdLbl.Text = "Contraseña:";
            // 
            // usrTxt
            // 
            this.usrTxt.AcceptsTab = true;
            this.usrTxt.Location = new System.Drawing.Point(82, 29);
            this.usrTxt.Name = "usrTxt";
            this.usrTxt.Size = new System.Drawing.Size(157, 20);
            this.usrTxt.TabIndex = 2;
            // 
            // pwdTxt
            // 
            this.pwdTxt.Location = new System.Drawing.Point(82, 66);
            this.pwdTxt.Name = "pwdTxt";
            this.pwdTxt.PasswordChar = '*';
            this.pwdTxt.Size = new System.Drawing.Size(157, 20);
            this.pwdTxt.TabIndex = 3;
            this.pwdTxt.UseSystemPasswordChar = true;
            this.pwdTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // doneBtn
            // 
            this.doneBtn.Location = new System.Drawing.Point(164, 146);
            this.doneBtn.Name = "doneBtn";
            this.doneBtn.Size = new System.Drawing.Size(75, 23);
            this.doneBtn.TabIndex = 4;
            this.doneBtn.Text = "Aceptar";
            this.doneBtn.UseVisualStyleBackColor = true;
            this.doneBtn.Click += new System.EventHandler(this.doneBtn_Click);
            // 
            // msgLbl
            // 
            this.msgLbl.AutoSize = true;
            this.msgLbl.ForeColor = System.Drawing.Color.Red;
            this.msgLbl.Location = new System.Drawing.Point(79, 186);
            this.msgLbl.Name = "msgLbl";
            this.msgLbl.Size = new System.Drawing.Size(165, 13);
            this.msgLbl.TabIndex = 5;
            this.msgLbl.Text = "Usuario o Contraseña Incorrectos";
            this.msgLbl.Visible = false;
            this.msgLbl.Click += new System.EventHandler(this.msgLbl_Click);
            // 
            // newUsrLink
            // 
            this.newUsrLink.ActiveLinkColor = System.Drawing.Color.MediumBlue;
            this.newUsrLink.AutoSize = true;
            this.newUsrLink.Location = new System.Drawing.Point(2, 110);
            this.newUsrLink.Name = "newUsrLink";
            this.newUsrLink.Size = new System.Drawing.Size(74, 13);
            this.newUsrLink.TabIndex = 6;
            this.newUsrLink.TabStop = true;
            this.newUsrLink.Text = "nuevo usuario";
            this.newUsrLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.newUsrLink_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 208);
            this.Controls.Add(this.newUsrLink);
            this.Controls.Add(this.msgLbl);
            this.Controls.Add(this.doneBtn);
            this.Controls.Add(this.pwdTxt);
            this.Controls.Add(this.usrTxt);
            this.Controls.Add(this.pwdLbl);
            this.Controls.Add(this.usrLbl);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usrLbl;
        private System.Windows.Forms.Label pwdLbl;
        private System.Windows.Forms.TextBox usrTxt;
        private System.Windows.Forms.TextBox pwdTxt;
        private System.Windows.Forms.Button doneBtn;
        private System.Windows.Forms.Label msgLbl;
        private System.Windows.Forms.LinkLabel newUsrLink;
    }
}