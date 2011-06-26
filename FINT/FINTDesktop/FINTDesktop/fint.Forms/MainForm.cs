using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using fint.Forms;

namespace fint.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Form login = new Login(this);
            
            login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.menuStrip1.Visible = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form editUser = new EditarUsuario();
            editUser.Show();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form desactivateUser = new EliminarUsuario("gus");
            desactivateUser.Show();
        }

        private void nuevaCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form ingresarCuenta = new IngresarCuenta();
            ingresarCuenta.Show();

        }

        private void proyectadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ingresarPago = new IngresarPagos();
            ingresarPago.Show();
        }

        private void realToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ingresarGasto = new IngresarGastos();
            ingresarGasto.Show();

        }

        private void transferenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form depExt = new IngresarDepExt();
            depExt.Show();
        }

        private void transferenciaToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            Form trans = new Transferencia();
            trans.Show();

        }

        private void realToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form estCuenta = new estadoCuentaReal();
            estCuenta.Show();

        }
    }
}
