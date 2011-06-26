using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using fint.Forms.fint.controller;

namespace fint.Forms
{
    public partial class estadoCuentaReal : Form
    {
        int idusuario;
        DataSet dsCuentas = new DataSet();
        public estadoCuentaReal()
        {
            InitializeComponent();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {

        }

        private void estadoCuentaReal_Load(object sender, EventArgs e)
        {
            idusuario = Controller.getInstancia().IdUsuario;
            dsCuentas = Controller.getInstancia().obtenerCuentasXusuario(idusuario);
            this.lsbCuenta.DataSource = dsCuentas.Tables[0];
            this.lsbCuenta.DisplayMember = "Descripcion";
            this.lsbCuenta.ValueMember = "id";
            this.dateTimePicker1.Value=DateTime.Today;
        }


    }
}
