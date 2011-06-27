namespace fint.Forms
{
    partial class estadoCuentaReal
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
            this.lsbCuenta = new System.Windows.Forms.ComboBox();
            this.lbEstados = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnRemoto = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsbCuenta
            // 
            this.lsbCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lsbCuenta.FormattingEnabled = true;
            this.lsbCuenta.Location = new System.Drawing.Point(12, 51);
            this.lsbCuenta.Name = "lsbCuenta";
            this.lsbCuenta.Size = new System.Drawing.Size(392, 21);
            this.lsbCuenta.TabIndex = 1;
            // 
            // lbEstados
            // 
            this.lbEstados.FormattingEnabled = true;
            this.lbEstados.Location = new System.Drawing.Point(12, 133);
            this.lbEstados.Name = "lbEstados";
            this.lbEstados.Size = new System.Drawing.Size(669, 212);
            this.lbEstados.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Elegir Cuenta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Estado Cuenta";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(431, 52);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(99, 20);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.Value = new System.DateTime(2011, 6, 6, 0, 0, 0, 0);
            // 
            // btnRemoto
            // 
            this.btnRemoto.Location = new System.Drawing.Point(536, 78);
            this.btnRemoto.Name = "btnRemoto";
            this.btnRemoto.Size = new System.Drawing.Size(103, 23);
            this.btnRemoto.TabIndex = 8;
            this.btnRemoto.Text = "Remoto";
            this.btnRemoto.UseVisualStyleBackColor = true;
            this.btnRemoto.Click += new System.EventHandler(this.btnRemoto_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(428, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Fecha";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(536, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Estado Actual";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // estadoCuentaReal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 370);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRemoto);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbEstados);
            this.Controls.Add(this.lsbCuenta);
            this.Name = "estadoCuentaReal";
            this.Text = "Estado de Cuenta";
            this.Load += new System.EventHandler(this.estadoCuentaReal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox lsbCuenta;
        private System.Windows.Forms.ListBox lbEstados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnRemoto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}