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
        public IngresarDepExt()
        {
            InitializeComponent();
        }

        private void depRBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            String monto = this.montoTxt.Text;
            String conc = this.descTxt.Text;  
            String cuenta = this.listCuentaCmb.SelectedText;

            if (!monto.Equals("") && !conc.Equals("") && !cuenta.Equals(""))
            {

                String tipoTrans = "";
                if (this.depRBtn.Checked)
                {
                    //this.msgLbl.Text = "Deposito.";
                    tipoTrans = "Deposito";
                }
                else
                {
                    //this.msgLbl.Text = "Extracción.";
                    tipoTrans = "Extraccion";
                }

                if (Controller.realizarMovimiento(cuenta, double.Parse(monto), conc, tipoTrans))
                {
                    this.msgLbl.Text = "Transacción realizada con exito.";
                }

            }
            else
            {
                this.msgLbl.Text = "Todos los datos son requeridos.";
            }
        }
    }
}
