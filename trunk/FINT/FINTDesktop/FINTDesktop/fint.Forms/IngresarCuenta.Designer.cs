namespace fint.Forms
{
    partial class IngresarCuenta
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
            this.noCuentaLbl = new System.Windows.Forms.Label();
            this.descLbl = new System.Windows.Forms.Label();
            this.saldoLbl = new System.Windows.Forms.Label();
            this.provLbl = new System.Windows.Forms.Label();
            this.provCmb = new System.Windows.Forms.ComboBox();
            this.noCuentaTxt = new System.Windows.Forms.MaskedTextBox();
            this.descTxt = new System.Windows.Forms.TextBox();
            this.saldoTxt = new System.Windows.Forms.MaskedTextBox();
            this.doneBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // noCuentaLbl
            // 
            this.noCuentaLbl.AutoSize = true;
            this.noCuentaLbl.Location = new System.Drawing.Point(53, 24);
            this.noCuentaLbl.Name = "noCuentaLbl";
            this.noCuentaLbl.Size = new System.Drawing.Size(56, 13);
            this.noCuentaLbl.TabIndex = 0;
            this.noCuentaLbl.Text = "NºCuenta:";
            // 
            // descLbl
            // 
            this.descLbl.AutoSize = true;
            this.descLbl.Location = new System.Drawing.Point(43, 57);
            this.descLbl.Name = "descLbl";
            this.descLbl.Size = new System.Drawing.Size(66, 13);
            this.descLbl.TabIndex = 1;
            this.descLbl.Text = "Descripción:";
            // 
            // saldoLbl
            // 
            this.saldoLbl.AutoSize = true;
            this.saldoLbl.Location = new System.Drawing.Point(72, 119);
            this.saldoLbl.Name = "saldoLbl";
            this.saldoLbl.Size = new System.Drawing.Size(37, 13);
            this.saldoLbl.TabIndex = 2;
            this.saldoLbl.Text = "Saldo:";
            this.saldoLbl.Click += new System.EventHandler(this.saldoLbl_Click);
            // 
            // provLbl
            // 
            this.provLbl.AutoSize = true;
            this.provLbl.Location = new System.Drawing.Point(3, 162);
            this.provLbl.Name = "provLbl";
            this.provLbl.Size = new System.Drawing.Size(106, 13);
            this.provLbl.TabIndex = 3;
            this.provLbl.Text = "Proveedor Asociado:";
            this.provLbl.Click += new System.EventHandler(this.provLbl_Click);
            // 
            // provCmb
            // 
            this.provCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.provCmb.FormattingEnabled = true;
            this.provCmb.Location = new System.Drawing.Point(150, 159);
            this.provCmb.Name = "provCmb";
            this.provCmb.Size = new System.Drawing.Size(121, 21);
            this.provCmb.TabIndex = 4;
            this.provCmb.SelectedIndexChanged += new System.EventHandler(this.provCmb_SelectedIndexChanged);
            // 
            // noCuentaTxt
            // 
            this.noCuentaTxt.Location = new System.Drawing.Point(150, 21);
            this.noCuentaTxt.Mask = "00000";
            this.noCuentaTxt.Name = "noCuentaTxt";
            this.noCuentaTxt.Size = new System.Drawing.Size(121, 20);
            this.noCuentaTxt.TabIndex = 5;
            // 
            // descTxt
            // 
            this.descTxt.Location = new System.Drawing.Point(150, 54);
            this.descTxt.Multiline = true;
            this.descTxt.Name = "descTxt";
            this.descTxt.Size = new System.Drawing.Size(209, 49);
            this.descTxt.TabIndex = 6;
            // 
            // saldoTxt
            // 
            this.saldoTxt.Location = new System.Drawing.Point(150, 116);
            this.saldoTxt.Mask = "9999999";
            this.saldoTxt.Name = "saldoTxt";
            this.saldoTxt.Size = new System.Drawing.Size(100, 20);
            this.saldoTxt.TabIndex = 7;
            this.saldoTxt.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.saldoTxt_MaskInputRejected);
            // 
            // doneBtn
            // 
            this.doneBtn.Location = new System.Drawing.Point(284, 209);
            this.doneBtn.Name = "doneBtn";
            this.doneBtn.Size = new System.Drawing.Size(75, 23);
            this.doneBtn.TabIndex = 8;
            this.doneBtn.Text = "Aceptar";
            this.doneBtn.UseVisualStyleBackColor = true;
            this.doneBtn.Click += new System.EventHandler(this.doneBtn_Click);
            // 
            // IngresarCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 281);
            this.Controls.Add(this.doneBtn);
            this.Controls.Add(this.saldoTxt);
            this.Controls.Add(this.descTxt);
            this.Controls.Add(this.noCuentaTxt);
            this.Controls.Add(this.provCmb);
            this.Controls.Add(this.provLbl);
            this.Controls.Add(this.saldoLbl);
            this.Controls.Add(this.descLbl);
            this.Controls.Add(this.noCuentaLbl);
            this.Name = "IngresarCuenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IngresarCuenta";
            this.Load += new System.EventHandler(this.IngresarCuenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label noCuentaLbl;
        private System.Windows.Forms.Label descLbl;
        private System.Windows.Forms.Label saldoLbl;
        private System.Windows.Forms.Label provLbl;
        private System.Windows.Forms.ComboBox provCmb;
        private System.Windows.Forms.MaskedTextBox noCuentaTxt;
        private System.Windows.Forms.TextBox descTxt;
        private System.Windows.Forms.MaskedTextBox saldoTxt;
        private System.Windows.Forms.Button doneBtn;
    }
}