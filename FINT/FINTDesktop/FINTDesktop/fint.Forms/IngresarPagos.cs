using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using fint.Forms.fint.controller;
using System.Threading;
using System.Collections;

namespace fint.Forms
{
    public partial class IngresarPagos : Form
    {
        private DataSet dsGastos = new DataSet();
        private DataSet dsCuentas = new DataSet();
        int idusuario;
        
        public IngresarPagos()
        {
            InitializeComponent();
            idusuario = Controller.getInstancia().IdUsuario;
            dsCuentas = Controller.getInstancia().obtenerCuentasXusuario(idusuario);
            dsGastos = Controller.getInstancia().obtenerGastosXusuario(idusuario);
            dsGastos.Tables[0].Columns.Add("Display", typeof(string), "Concepto + ' Total: ' + Monto");
        }

        private void IngresarPagos_Load(object sender, EventArgs e)
        {
            this.listCuentasCmb.DataSource = dsCuentas.Tables[0];
            this.listCuentasCmb.DisplayMember = "Descripcion";
            this.listCuentasCmb.ValueMember = "id";
            this.msgLbl.Text = "";
            cargarPagos();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pagarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int idGasto = int.Parse(this.lbGasto.SelectedValue.ToString());
                int idCuenta = int.Parse(this.listCuentasCmb.SelectedValue.ToString());
                if (Controller.getInstancia().realizarPago(idGasto, idCuenta))
                {
                    this.msgLbl.Text = "Pago Realizado con exito";
                    borrarseleccionado(idGasto);
                   cargarPagos();
                  //  this.msgLbl.Text = "";

                }
                else
                {
                    this.msgLbl.Text = "Ocurrio un error al realizar el pago";
                }
            }
            catch (Exception)
            {
                
                this.msgLbl.Text = "ERROR";
            }
            
        }

        private void borrarseleccionado(int idGasto)
        {
            for (int i = 0; i < dsGastos.Tables[0].Rows.Count; i++)
            {
                if (dsGastos.Tables[0].Rows[i].RowState != DataRowState.Deleted )
                {
                    if (int.Parse(dsGastos.Tables[0].Rows[i]["id"].ToString()) == idGasto)
                    {
                        dsGastos.Tables[0].Rows[i].Delete();
                    } 
                }
            }
        }

        public void cargarPagos()
        {
            this.lbGasto.BeginUpdate();
            this.lbGasto.DataSource = dsGastos.Tables[0];
            this.lbGasto.DisplayMember = "Display";
            this.lbGasto.ValueMember = "id";
            this.lbGasto.EndUpdate();


        }

    }
}
