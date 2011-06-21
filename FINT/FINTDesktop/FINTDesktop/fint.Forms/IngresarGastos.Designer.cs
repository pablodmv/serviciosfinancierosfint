namespace fint.Forms
{
    partial class IngresarGastos
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
            this.nFacLbl = new System.Windows.Forms.Label();
            this.nFacTxt = new System.Windows.Forms.MaskedTextBox();
            this.descLbl = new System.Windows.Forms.Label();
            this.descTxt = new System.Windows.Forms.TextBox();
            this.montoLbl = new System.Windows.Forms.Label();
            this.montoTxt = new System.Windows.Forms.MaskedTextBox();
            this.fVenLbl = new System.Windows.Forms.Label();
            this.fVenDPicker = new System.Windows.Forms.DateTimePicker();
            this.doneBtn = new System.Windows.Forms.Button();
            this.msgLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nFacLbl
            // 
            this.nFacLbl.AutoSize = true;
            this.nFacLbl.Location = new System.Drawing.Point(23, 40);
            this.nFacLbl.Name = "nFacLbl";
            this.nFacLbl.Size = new System.Drawing.Size(58, 13);
            this.nFacLbl.TabIndex = 0;
            this.nFacLbl.Text = "NºFactura:";
            // 
            // nFacTxt
            // 
            this.nFacTxt.Location = new System.Drawing.Point(99, 37);
            this.nFacTxt.Mask = "99999";
            this.nFacTxt.Name = "nFacTxt";
            this.nFacTxt.Size = new System.Drawing.Size(54, 20);
            this.nFacTxt.TabIndex = 1;
            this.nFacTxt.ValidatingType = typeof(int);
            // 
            // descLbl
            // 
            this.descLbl.AutoSize = true;
            this.descLbl.Location = new System.Drawing.Point(25, 66);
            this.descLbl.Name = "descLbl";
            this.descLbl.Size = new System.Drawing.Size(56, 13);
            this.descLbl.TabIndex = 2;
            this.descLbl.Text = "Concepto:";
            this.descLbl.Click += new System.EventHandler(this.descLbl_Click);
            // 
            // descTxt
            // 
            this.descTxt.Location = new System.Drawing.Point(99, 63);
            this.descTxt.Multiline = true;
            this.descTxt.Name = "descTxt";
            this.descTxt.Size = new System.Drawing.Size(221, 45);
            this.descTxt.TabIndex = 3;
            this.descTxt.TextChanged += new System.EventHandler(this.descTxt_TextChanged);
            // 
            // montoLbl
            // 
            this.montoLbl.AutoSize = true;
            this.montoLbl.Location = new System.Drawing.Point(41, 117);
            this.montoLbl.Name = "montoLbl";
            this.montoLbl.Size = new System.Drawing.Size(40, 13);
            this.montoLbl.TabIndex = 4;
            this.montoLbl.Text = "Monto:";
            this.montoLbl.Click += new System.EventHandler(this.montoLbl_Click);
            // 
            // montoTxt
            // 
            this.montoTxt.Location = new System.Drawing.Point(99, 114);
            this.montoTxt.Mask = "9999999";
            this.montoTxt.Name = "montoTxt";
            this.montoTxt.Size = new System.Drawing.Size(54, 20);
            this.montoTxt.TabIndex = 5;
            this.montoTxt.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.montoTxt_MaskInputRejected);
            // 
            // fVenLbl
            // 
            this.fVenLbl.AutoSize = true;
            this.fVenLbl.Location = new System.Drawing.Point(4, 146);
            this.fVenLbl.Name = "fVenLbl";
            this.fVenLbl.Size = new System.Drawing.Size(77, 13);
            this.fVenLbl.TabIndex = 6;
            this.fVenLbl.Text = "F.Vencimiento:";
            // 
            // fVenDPicker
            // 
            this.fVenDPicker.CustomFormat = "dd/MM/yyyy";
            this.fVenDPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fVenDPicker.Location = new System.Drawing.Point(99, 140);
            this.fVenDPicker.Name = "fVenDPicker";
            this.fVenDPicker.Size = new System.Drawing.Size(100, 20);
            this.fVenDPicker.TabIndex = 7;
            this.fVenDPicker.Value = new System.DateTime(2011, 6, 20, 0, 0, 0, 0);
            // 
            // doneBtn
            // 
            this.doneBtn.Location = new System.Drawing.Point(245, 191);
            this.doneBtn.Name = "doneBtn";
            this.doneBtn.Size = new System.Drawing.Size(75, 23);
            this.doneBtn.TabIndex = 8;
            this.doneBtn.Text = "Aceptar";
            this.doneBtn.UseVisualStyleBackColor = true;
            this.doneBtn.Click += new System.EventHandler(this.doneBtn_Click);
            // 
            // msgLbl
            // 
            this.msgLbl.AutoSize = true;
            this.msgLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.msgLbl.Location = new System.Drawing.Point(96, 231);
            this.msgLbl.Name = "msgLbl";
            this.msgLbl.Size = new System.Drawing.Size(0, 13);
            this.msgLbl.TabIndex = 9;
            // 
            // IngresarGastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 264);
            this.Controls.Add(this.msgLbl);
            this.Controls.Add(this.doneBtn);
            this.Controls.Add(this.fVenDPicker);
            this.Controls.Add(this.fVenLbl);
            this.Controls.Add(this.montoTxt);
            this.Controls.Add(this.montoLbl);
            this.Controls.Add(this.descTxt);
            this.Controls.Add(this.descLbl);
            this.Controls.Add(this.nFacTxt);
            this.Controls.Add(this.nFacLbl);
            this.Name = "IngresarGastos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IngresarGastos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nFacLbl;
        private System.Windows.Forms.MaskedTextBox nFacTxt;
        private System.Windows.Forms.Label descLbl;
        private System.Windows.Forms.TextBox descTxt;
        private System.Windows.Forms.Label montoLbl;
        private System.Windows.Forms.MaskedTextBox montoTxt;
        private System.Windows.Forms.Label fVenLbl;
        private System.Windows.Forms.DateTimePicker fVenDPicker;
        private System.Windows.Forms.Button doneBtn;
        private System.Windows.Forms.Label msgLbl;
    }
}