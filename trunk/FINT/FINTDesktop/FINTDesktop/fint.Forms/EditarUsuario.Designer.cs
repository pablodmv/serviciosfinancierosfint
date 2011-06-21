namespace fint.Forms
{
    partial class EditarUsuario
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
            this.doneBtn = new System.Windows.Forms.Button();
            this.pwdTxt = new System.Windows.Forms.TextBox();
            this.pwdLbl = new System.Windows.Forms.Label();
            this.nomTxt = new System.Windows.Forms.TextBox();
            this.nomLbl = new System.Windows.Forms.Label();
            this.msgLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // doneBtn
            // 
            this.doneBtn.Location = new System.Drawing.Point(185, 125);
            this.doneBtn.Name = "doneBtn";
            this.doneBtn.Size = new System.Drawing.Size(75, 23);
            this.doneBtn.TabIndex = 9;
            this.doneBtn.Text = "Aceptar";
            this.doneBtn.UseVisualStyleBackColor = true;
            this.doneBtn.Click += new System.EventHandler(this.doneBtn_Click);
            // 
            // pwdTxt
            // 
            this.pwdTxt.Location = new System.Drawing.Point(98, 76);
            this.pwdTxt.Name = "pwdTxt";
            this.pwdTxt.PasswordChar = '*';
            this.pwdTxt.Size = new System.Drawing.Size(162, 20);
            this.pwdTxt.TabIndex = 8;
            this.pwdTxt.UseSystemPasswordChar = true;
            // 
            // pwdLbl
            // 
            this.pwdLbl.AutoSize = true;
            this.pwdLbl.Location = new System.Drawing.Point(3, 79);
            this.pwdLbl.Name = "pwdLbl";
            this.pwdLbl.Size = new System.Drawing.Size(91, 13);
            this.pwdLbl.TabIndex = 7;
            this.pwdLbl.Text = "Nuevo Password:";
            // 
            // nomTxt
            // 
            this.nomTxt.Location = new System.Drawing.Point(98, 34);
            this.nomTxt.Name = "nomTxt";
            this.nomTxt.Size = new System.Drawing.Size(162, 20);
            this.nomTxt.TabIndex = 6;
            // 
            // nomLbl
            // 
            this.nomLbl.AutoSize = true;
            this.nomLbl.Location = new System.Drawing.Point(12, 37);
            this.nomLbl.Name = "nomLbl";
            this.nomLbl.Size = new System.Drawing.Size(82, 13);
            this.nomLbl.TabIndex = 5;
            this.nomLbl.Text = "Nuevo Nombre:";
            // 
            // msgLbl
            // 
            this.msgLbl.AutoSize = true;
            this.msgLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.msgLbl.Location = new System.Drawing.Point(95, 170);
            this.msgLbl.Name = "msgLbl";
            this.msgLbl.Size = new System.Drawing.Size(0, 13);
            this.msgLbl.TabIndex = 10;
            // 
            // EditarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 211);
            this.Controls.Add(this.msgLbl);
            this.Controls.Add(this.doneBtn);
            this.Controls.Add(this.pwdTxt);
            this.Controls.Add(this.pwdLbl);
            this.Controls.Add(this.nomTxt);
            this.Controls.Add(this.nomLbl);
            this.Name = "EditarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarUsuario";
            this.Load += new System.EventHandler(this.EditarUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button doneBtn;
        private System.Windows.Forms.TextBox pwdTxt;
        private System.Windows.Forms.Label pwdLbl;
        private System.Windows.Forms.TextBox nomTxt;
        private System.Windows.Forms.Label nomLbl;
        private System.Windows.Forms.Label msgLbl;

    }
}