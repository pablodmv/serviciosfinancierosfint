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
    public partial class IngresarCuenta : Form
    {
        private DataSet proveedores = new DataSet();
        public IngresarCuenta()
        {
            InitializeComponent();
            proveedores = Controller.getInstancia().obtenerProveedores();
        }

        private void IngresarCuenta_Load(object sender, EventArgs e)
        {
            this.provCmb.DataSource = proveedores.Tables[0];
            this.provCmb.DisplayMember = "Nombre";
            this.provCmb.ValueMember = "id";

        }

        private void saldoLbl_Click(object sender, EventArgs e)
        {

        }

        private void provLbl_Click(object sender, EventArgs e)
        {

        }

        private void provCmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            try
            {
                String numero = this.noCuentaTxt.Text;
                String descripcion = this.descTxt.Text;
                Double tmpsaldo = Double.Parse(this.saldoTxt.Text);
                Decimal saldo = (Decimal)tmpsaldo;
                int idProveedor = int.Parse(this.provCmb.SelectedValue.ToString());
                int idUsuario = int.Parse(Controller.getInstancia().dsUsuario.Tables[0].Rows[0]["id"].ToString());

                if (!numero.Equals("") && saldo != 0)
                {

                    this.msgLbl.Visible = false;

                    if (Controller.getInstancia().ingresarCuenta(numero, descripcion, saldo, idProveedor, idUsuario))
                    {
                        this.msgLbl.Text = "Cuenta ingresada con exito";
                        this.msgLbl.Visible = true;
                        this.clear();
                    }
                    else
                    {
                        this.msgLbl.Text = "Error al ingresar el Cuenta. Consulte";
                        this.msgLbl.Visible = true;
                    }

                }
                else
                {
                    this.msgLbl.Visible = true;
                }
            }
            catch (Exception)
            {
                this.msgLbl.Text = "Monto incorrecto";
                this.msgLbl.Visible = true;
            }
            
           
                
        }

        private void clear()
        {
            this.noCuentaTxt.Text = "";
            this.saldoTxt.Text = "";
            this.descTxt.Text = "";
        }


        private void saldoTxt_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
