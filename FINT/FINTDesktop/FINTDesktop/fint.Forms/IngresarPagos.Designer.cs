namespace fint.Forms
{
    partial class IngresarPagos
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
            this.listGasLbl = new System.Windows.Forms.Label();
            this.listCuLbl = new System.Windows.Forms.Label();
            this.listCuentasCmb = new System.Windows.Forms.ComboBox();
            this.pagarBtn = new System.Windows.Forms.Button();
            this.msgLbl = new System.Windows.Forms.Label();
            this.lbGasto = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listGasLbl
            // 
            this.listGasLbl.AutoSize = true;
            this.listGasLbl.Location = new System.Drawing.Point(12, 9);
            this.listGasLbl.Name = "listGasLbl";
            this.listGasLbl.Size = new System.Drawing.Size(97, 13);
            this.listGasLbl.TabIndex = 0;
            this.listGasLbl.Text = "Seleccionar Gasto:";
            this.listGasLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // listCuLbl
            // 
            this.listCuLbl.AutoSize = true;
            this.listCuLbl.Location = new System.Drawing.Point(5, 135);
            this.listCuLbl.Name = "listCuLbl";
            this.listCuLbl.Size = new System.Drawing.Size(103, 13);
            this.listCuLbl.TabIndex = 2;
            this.listCuLbl.Text = "Seleccionar Cuenta:";
            // 
            // listCuentasCmb
            // 
            this.listCuentasCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listCuentasCmb.FormattingEnabled = true;
            this.listCuentasCmb.Location = new System.Drawing.Point(126, 135);
            this.listCuentasCmb.Name = "listCuentasCmb";
            this.listCuentasCmb.Size = new System.Drawing.Size(256, 21);
            this.listCuentasCmb.TabIndex = 3;
            // 
            // pagarBtn
            // 
            this.pagarBtn.Location = new System.Drawing.Point(307, 162);
            this.pagarBtn.Name = "pagarBtn";
            this.pagarBtn.Size = new System.Drawing.Size(75, 23);
            this.pagarBtn.TabIndex = 4;
            this.pagarBtn.Text = "Pagar";
            this.pagarBtn.UseVisualStyleBackColor = true;
            this.pagarBtn.Click += new System.EventHandler(this.pagarBtn_Click);
            // 
            // msgLbl
            // 
            this.msgLbl.AutoSize = true;
            this.msgLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.msgLbl.Location = new System.Drawing.Point(123, 185);
            this.msgLbl.Name = "msgLbl";
            this.msgLbl.Size = new System.Drawing.Size(0, 13);
            this.msgLbl.TabIndex = 5;
            // 
            // lbGasto
            // 
            this.lbGasto.FormattingEnabled = true;
            this.lbGasto.Location = new System.Drawing.Point(15, 26);
            this.lbGasto.Name = "lbGasto";
            this.lbGasto.Size = new System.Drawing.Size(386, 82);
            this.lbGasto.TabIndex = 6;
            // 
            // IngresarPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 212);
            this.Controls.Add(this.lbGasto);
            this.Controls.Add(this.msgLbl);
            this.Controls.Add(this.pagarBtn);
            this.Controls.Add(this.listCuentasCmb);
            this.Controls.Add(this.listCuLbl);
            this.Controls.Add(this.listGasLbl);
            this.Name = "IngresarPagos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IngresarPagos";
            this.Load += new System.EventHandler(this.IngresarPagos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label listGasLbl;
        private System.Windows.Forms.Label listCuLbl;
        private System.Windows.Forms.ComboBox listCuentasCmb;
        private System.Windows.Forms.Button pagarBtn;
        private System.Windows.Forms.Label msgLbl;
        private System.Windows.Forms.ListBox lbGasto;
    }
}