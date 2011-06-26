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
    public partial class IngresarDepExt : Form
    {
        private DataSet dsCuentas = new DataSet();
        int idusuario;

        public IngresarDepExt()
        {
            InitializeComponent();
            idusuario = Controller.getInstancia().IdUsuario;
            dsCuentas = Controller.getInstancia().obtenerCuentasXusuario(idusuario);
        }

        private void depRBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Boolean resultado = false;
                Double monto = Double.Parse(this.montoTxt.Text);
                String conc = this.descTxt.Text;
                int cuenta = int.Parse(this.listCuentaCmb.SelectedValue.ToString());

                if (!this.montoTxt.Text.Equals("") && !conc.Equals("") && !cuenta.Equals(""))
                {

                    if (this.depRBtn.Checked)
                    {

                        resultado = Controller.getInstancia().realizarDeposito(cuenta, (Decimal)monto, conc);
                    }
                    else
                    {
                        resultado = Controller.getInstancia().realizarExtraccion(cuenta, (Decimal)monto, conc);

                    }

                    //  if (Controller.realizarMovimiento(cuenta, double.Parse(monto), conc, tipoTrans))
                    if (resultado)
                    {
                        this.msgLbl.Text = "Transacción realizada con exito.";
                    }
                    else
                    {
                        this.msgLbl.Text = "Error en la transaccion.";
                    }

                }
                else
                {
                    this.msgLbl.Text = "Todos los datos son requeridos.";
                }
            }
            catch (Exception)
            {

                this.msgLbl.Text = "Monto incorrecto";
            }
        }

        private void IngresarDepExt_Load(object sender, EventArgs e)
        {
            this.listCuentaCmb.DataSource = dsCuentas.Tables[0];
            this.listCuentaCmb.DisplayMember = "Descripcion";
            this.listCuentaCmb.ValueMember = "id";

        }
    }
}
