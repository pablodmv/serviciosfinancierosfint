namespace fint.Forms
{
    partial class Transferencia
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
            this.cuentaIniLbl = new System.Windows.Forms.Label();
            this.cuentaIniCmb = new System.Windows.Forms.ComboBox();
            this.cuentaFinLbl = new System.Windows.Forms.Label();
            this.cuentaFinTxt = new System.Windows.Forms.MaskedTextBox();
            this.montoLbl = new System.Windows.Forms.Label();
            this.montoTxt = new System.Windows.Forms.MaskedTextBox();
            this.descLbl = new System.Windows.Forms.Label();
            this.descTxt = new System.Windows.Forms.TextBox();
            this.doneBtn = new System.Windows.Forms.Button();
            this.msgLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cuentaIniLbl
            // 
            this.cuentaIniLbl.AutoSize = true;
            this.cuentaIniLbl.Location = new System.Drawing.Point(12, 25);
            this.cuentaIniLbl.Name = "cuentaIniLbl";
            this.cuentaIniLbl.Size = new System.Drawing.Size(78, 13);
            this.cuentaIniLbl.TabIndex = 0;
            this.cuentaIniLbl.Text = "Cuenta Origen:";
            // 
            // cuentaIniCmb
            // 
            this.cuentaIniCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cuentaIniCmb.FormattingEnabled = true;
            this.cuentaIniCmb.Location = new System.Drawing.Point(96, 22);
            this.cuentaIniCmb.Name = "cuentaIniCmb";
            this.cuentaIniCmb.Size = new System.Drawing.Size(163, 21);
            this.cuentaIniCmb.TabIndex = 1;
            // 
            // cuentaFinLbl
            // 
            this.cuentaFinLbl.AutoSize = true;
            this.cuentaFinLbl.Location = new System.Drawing.Point(7, 62);
            this.cuentaFinLbl.Name = "cuentaFinLbl";
            this.cuentaFinLbl.Size = new System.Drawing.Size(83, 13);
            this.cuentaFinLbl.TabIndex = 2;
            this.cuentaFinLbl.Text = "Cuenta Destino:";
            // 
            // cuentaFinTxt
            // 
            this.cuentaFinTxt.Location = new System.Drawing.Point(96, 59);
            this.cuentaFinTxt.Mask = "00000";
            this.cuentaFinTxt.Name = "cuentaFinTxt";
            this.cuentaFinTxt.Size = new System.Drawing.Size(44, 20);
            this.cuentaFinTxt.TabIndex = 3;
            // 
            // montoLbl
            // 
            this.montoLbl.AutoSize = true;
            this.montoLbl.Location = new System.Drawing.Point(50, 97);
            this.montoLbl.Name = "montoLbl";
            this.montoLbl.Size = new System.Drawing.Size(40, 13);
            this.montoLbl.TabIndex = 4;
            this.montoLbl.Text = "Monto:";
            // 
            // montoTxt
            // 
            this.montoTxt.Location = new System.Drawing.Point(96, 94);
            this.montoTxt.Mask = "9999999";
            this.montoTxt.Name = "montoTxt";
            this.montoTxt.Size = new System.Drawing.Size(64, 20);
            this.montoTxt.TabIndex = 5;
            // 
            // descLbl
            // 
            this.descLbl.AutoSize = true;
            this.descLbl.Location = new System.Drawing.Point(34, 136);
            this.descLbl.Name = "descLbl";
            this.descLbl.Size = new System.Drawing.Size(56, 13);
            this.descLbl.TabIndex = 6;
            this.descLbl.Text = "Concepto:";
            // 
            // descTxt
            // 
            this.descTxt.Location = new System.Drawing.Point(96, 133);
            this.descTxt.Multiline = true;
            this.descTxt.Name = "descTxt";
            this.descTxt.Size = new System.Drawing.Size(163, 45);
            this.descTxt.TabIndex = 7;
            // 
            // doneBtn
            // 
            this.doneBtn.Location = new System.Drawing.Point(184, 199);
            this.doneBtn.Name = "doneBtn";
            this.doneBtn.Size = new System.Drawing.Size(75, 23);
            this.doneBtn.TabIndex = 8;
            this.doneBtn.Text = "Aceptar";
            this.doneBtn.UseVisualStyleBackColor = true;
            // 
            // msgLbl
            // 
            this.msgLbl.AutoSize = true;
            this.msgLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.msgLbl.Location = new System.Drawing.Point(66, 239);
            this.msgLbl.Name = "msgLbl";
            this.msgLbl.Size = new System.Drawing.Size(166, 13);
            this.msgLbl.TabIndex = 9;
            this.msgLbl.Text = "Transferencia realizada con exito.";
            // 
            // Transferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 267);
            this.Controls.Add(this.msgLbl);
            this.Controls.Add(this.doneBtn);
            this.Controls.Add(this.descTxt);
            this.Controls.Add(this.descLbl);
            this.Controls.Add(this.montoTxt);
            this.Controls.Add(this.montoLbl);
            this.Controls.Add(this.cuentaFinTxt);
            this.Controls.Add(this.cuentaFinLbl);
            this.Controls.Add(this.cuentaIniCmb);
            this.Controls.Add(this.cuentaIniLbl);
            this.Name = "Transferencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transferencias";
            this.Load += new System.EventHandler(this.Transferencia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cuentaIniLbl;
        private System.Windows.Forms.ComboBox cuentaIniCmb;
        private System.Windows.Forms.Label cuentaFinLbl;
        private System.Windows.Forms.MaskedTextBox cuentaFinTxt;
        private System.Windows.Forms.Label montoLbl;
        private System.Windows.Forms.MaskedTextBox montoTxt;
        private System.Windows.Forms.Label descLbl;
        private System.Windows.Forms.TextBox descTxt;
        private System.Windows.Forms.Button doneBtn;
        private System.Windows.Forms.Label msgLbl;
    }
}