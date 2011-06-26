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
    public partial class Transferencia : Form
    {
        private DataSet dsCuentas = new DataSet();
        private DataSet dsCuentas2 = new DataSet();
        int idusuario;
        public Transferencia()
        {
            InitializeComponent();
            idusuario = Controller.getInstancia().IdUsuario;
            dsCuentas = Controller.getInstancia().obtenerCuentasXusuario(idusuario);
            dsCuentas2 = Controller.getInstancia().obtenerCuentasXusuario(idusuario);
        }

        private void Transferencia_Load(object sender, EventArgs e)
        {

            this.cuentaIniCmb.DataSource = dsCuentas.Tables[0];
            this.cuentaIniCmb.DisplayMember = "Descripcion";
            this.cuentaIniCmb.ValueMember = "id";

            this.cuentaFinCmb.DataSource = dsCuentas2.Tables[0];
            this.cuentaFinCmb.DisplayMember = "Descripcion";
            this.cuentaFinCmb.ValueMember = "id";

        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            Double tmpmonto = Double.Parse(this.montoTxt.Text);
            Decimal monto = (Decimal)tmpmonto;
            String concepto = this.descTxt.Text;
            int cuentaini = int.Parse(this.cuentaIniCmb.SelectedValue.ToString());
            int cuentafin = int.Parse(this.cuentaFinCmb.SelectedValue.ToString());
            Boolean result = Controller.getInstancia().realizarTransferencia(cuentaini, cuentafin, monto, concepto);
            if (result)
            {
                this.msgLbl.Text = "Transferencia realizada con exito.";
            }
            else
            {
                this.msgLbl.Text = "error";
            }
        

        }
    }
}
