namespace fint.Forms
{
    partial class MainForm
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

        public System.Windows.Forms.MenuStrip getMenu()
        {
            return this.menuStrip1;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.datosPersonalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadoCuentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proyectadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferenciaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.estadoCuentasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.realToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.transferenciasPendeintesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosPersonalesToolStripMenuItem,
            this.proveedoresToolStripMenuItem,
            this.estadoCuentasToolStripMenuItem,
            this.estadoCuentasToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(813, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // datosPersonalesToolStripMenuItem
            // 
            this.datosPersonalesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.datosPersonalesToolStripMenuItem.Name = "datosPersonalesToolStripMenuItem";
            this.datosPersonalesToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.datosPersonalesToolStripMenuItem.Text = "DatosPersonales";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.eliminarToolStripMenuItem.Text = "Desactivar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaCuentaToolStripMenuItem});
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.proveedoresToolStripMenuItem.Text = "Cuentas";
            // 
            // nuevaCuentaToolStripMenuItem
            // 
            this.nuevaCuentaToolStripMenuItem.Name = "nuevaCuentaToolStripMenuItem";
            this.nuevaCuentaToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.nuevaCuentaToolStripMenuItem.Text = "Nueva Cuenta";
            this.nuevaCuentaToolStripMenuItem.Click += new System.EventHandler(this.nuevaCuentaToolStripMenuItem_Click);
            // 
            // estadoCuentasToolStripMenuItem
            // 
            this.estadoCuentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.realToolStripMenuItem,
            this.proyectadoToolStripMenuItem,
            this.transferenciaToolStripMenuItem,
            this.transferenciaToolStripMenuItem1,
            this.transferenciasPendeintesToolStripMenuItem});
            this.estadoCuentasToolStripMenuItem.Name = "estadoCuentasToolStripMenuItem";
            this.estadoCuentasToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.estadoCuentasToolStripMenuItem.Text = "Acciones";
            // 
            // realToolStripMenuItem
            // 
            this.realToolStripMenuItem.Name = "realToolStripMenuItem";
            this.realToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.realToolStripMenuItem.Text = "Gastos";
            this.realToolStripMenuItem.Click += new System.EventHandler(this.realToolStripMenuItem_Click);
            // 
            // proyectadoToolStripMenuItem
            // 
            this.proyectadoToolStripMenuItem.Name = "proyectadoToolStripMenuItem";
            this.proyectadoToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.proyectadoToolStripMenuItem.Text = "Pagos";
            this.proyectadoToolStripMenuItem.Click += new System.EventHandler(this.proyectadoToolStripMenuItem_Click);
            // 
            // transferenciaToolStripMenuItem
            // 
            this.transferenciaToolStripMenuItem.Name = "transferenciaToolStripMenuItem";
            this.transferenciaToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.transferenciaToolStripMenuItem.Text = "Depositos/Extracciones";
            this.transferenciaToolStripMenuItem.Click += new System.EventHandler(this.transferenciaToolStripMenuItem_Click);
            // 
            // transferenciaToolStripMenuItem1
            // 
            this.transferenciaToolStripMenuItem1.Name = "transferenciaToolStripMenuItem1";
            this.transferenciaToolStripMenuItem1.Size = new System.Drawing.Size(211, 22);
            this.transferenciaToolStripMenuItem1.Text = "Transferencia";
            this.transferenciaToolStripMenuItem1.Click += new System.EventHandler(this.transferenciaToolStripMenuItem1_Click);
            // 
            // estadoCuentasToolStripMenuItem1
            // 
            this.estadoCuentasToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.realToolStripMenuItem1});
            this.estadoCuentasToolStripMenuItem1.Name = "estadoCuentasToolStripMenuItem1";
            this.estadoCuentasToolStripMenuItem1.Size = new System.Drawing.Size(97, 20);
            this.estadoCuentasToolStripMenuItem1.Text = "EstadoCuentas";
            // 
            // realToolStripMenuItem1
            // 
            this.realToolStripMenuItem1.Name = "realToolStripMenuItem1";
            this.realToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.realToolStripMenuItem1.Text = "Ver";
            this.realToolStripMenuItem1.Click += new System.EventHandler(this.realToolStripMenuItem1_Click);
            // 
            // transferenciasPendeintesToolStripMenuItem
            // 
            this.transferenciasPendeintesToolStripMenuItem.Name = "transferenciasPendeintesToolStripMenuItem";
            this.transferenciasPendeintesToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.transferenciasPendeintesToolStripMenuItem.Text = "Transferencias pendientes";
            this.transferenciasPendeintesToolStripMenuItem.Click += new System.EventHandler(this.transferenciasPendeintesToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 335);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FINT Desktop";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem datosPersonalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadoCuentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proyectadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadoCuentasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem realToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem transferenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaCuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transferenciaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem transferenciasPendeintesToolStripMenuItem;
    }
}

