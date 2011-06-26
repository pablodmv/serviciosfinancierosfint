namespace fint.Forms
{
    partial class IngresarDepExt
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
            this.cuentaLbl = new System.Windows.Forms.Label();
            this.listCuentaCmb = new System.Windows.Forms.ComboBox();
            this.montoTxt = new System.Windows.Forms.MaskedTextBox();
            this.montoLbl = new System.Windows.Forms.Label();
            this.descLbl = new System.Windows.Forms.Label();
            this.descTxt = new System.Windows.Forms.TextBox();
            this.depRBtn = new System.Windows.Forms.RadioButton();
            this.extRBtn = new System.Windows.Forms.RadioButton();
            this.doneBtn = new System.Windows.Forms.Button();
            this.msgLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cuentaLbl
            // 
            this.cuentaLbl.AutoSize = true;
            this.cuentaLbl.Location = new System.Drawing.Point(12, 41);
            this.cuentaLbl.Name = "cuentaLbl";
            this.cuentaLbl.Size = new System.Drawing.Size(103, 13);
            this.cuentaLbl.TabIndex = 0;
            this.cuentaLbl.Text = "Seleccionar Cuenta:";
            // 
            // listCuentaCmb
            // 
            this.listCuentaCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listCuentaCmb.FormattingEnabled = true;
            this.listCuentaCmb.Location = new System.Drawing.Point(121, 38);
            this.listCuentaCmb.Name = "listCuentaCmb";
            this.listCuentaCmb.Size = new System.Drawing.Size(178, 21);
            this.listCuentaCmb.TabIndex = 1;
            // 
            // montoTxt
            // 
            this.montoTxt.Location = new System.Drawing.Point(121, 75);
            this.montoTxt.Name = "montoTxt";
            this.montoTxt.Size = new System.Drawing.Size(178, 20);
            this.montoTxt.TabIndex = 2;
            // 
            // montoLbl
            // 
            this.montoLbl.AutoSize = true;
            this.montoLbl.Location = new System.Drawing.Point(75, 78);
            this.montoLbl.Name = "montoLbl";
            this.montoLbl.Size = new System.Drawing.Size(40, 13);
            this.montoLbl.TabIndex = 3;
            this.montoLbl.Text = "Monto:";
            // 
            // descLbl
            // 
            this.descLbl.AutoSize = true;
            this.descLbl.Location = new System.Drawing.Point(59, 112);
            this.descLbl.Name = "descLbl";
            this.descLbl.Size = new System.Drawing.Size(56, 13);
            this.descLbl.TabIndex = 4;
            this.descLbl.Text = "Concepto:";
            // 
            // descTxt
            // 
            this.descTxt.Location = new System.Drawing.Point(121, 109);
            this.descTxt.Multiline = true;
            this.descTxt.Name = "descTxt";
            this.descTxt.Size = new System.Drawing.Size(178, 49);
            this.descTxt.TabIndex = 5;
            // 
            // depRBtn
            // 
            this.depRBtn.AutoSize = true;
            this.depRBtn.Location = new System.Drawing.Point(121, 179);
            this.depRBtn.Name = "depRBtn";
            this.depRBtn.Size = new System.Drawing.Size(70, 17);
            this.depRBtn.TabIndex = 6;
            this.depRBtn.TabStop = true;
            this.depRBtn.Text = "Depositar";
            this.depRBtn.UseVisualStyleBackColor = true;
            this.depRBtn.CheckedChanged += new System.EventHandler(this.depRBtn_CheckedChanged);
            // 
            // extRBtn
            // 
            this.extRBtn.AutoSize = true;
            this.extRBtn.Location = new System.Drawing.Point(241, 179);
            this.extRBtn.Name = "extRBtn";
            this.extRBtn.Size = new System.Drawing.Size(58, 17);
            this.extRBtn.TabIndex = 7;
            this.extRBtn.TabStop = true;
            this.extRBtn.Text = "Extraer";
            this.extRBtn.UseVisualStyleBackColor = true;
            // 
            // doneBtn
            // 
            this.doneBtn.Location = new System.Drawing.Point(224, 227);
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
            this.msgLbl.Location = new System.Drawing.Point(87, 272);
            this.msgLbl.Name = "msgLbl";
            this.msgLbl.Size = new System.Drawing.Size(0, 13);
            this.msgLbl.TabIndex = 9;
            // 
            // IngresarDepExt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 294);
            this.Controls.Add(this.msgLbl);
            this.Controls.Add(this.doneBtn);
            this.Controls.Add(this.extRBtn);
            this.Controls.Add(this.depRBtn);
            this.Controls.Add(this.descTxt);
            this.Controls.Add(this.descLbl);
            this.Controls.Add(this.montoLbl);
            this.Controls.Add(this.montoTxt);
            this.Controls.Add(this.listCuentaCmb);
            this.Controls.Add(this.cuentaLbl);
            this.Name = "IngresarDepExt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingresar Depositos/Extracciones";
            this.Load += new System.EventHandler(this.IngresarDepExt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cuentaLbl;
        private System.Windows.Forms.ComboBox listCuentaCmb;
        private System.Windows.Forms.MaskedTextBox montoTxt;
        private System.Windows.Forms.Label montoLbl;
        private System.Windows.Forms.Label descLbl;
        private System.Windows.Forms.TextBox descTxt;
        private System.Windows.Forms.RadioButton depRBtn;
        private System.Windows.Forms.RadioButton extRBtn;
        private System.Windows.Forms.Button doneBtn;
        private System.Windows.Forms.Label msgLbl;
    }
}