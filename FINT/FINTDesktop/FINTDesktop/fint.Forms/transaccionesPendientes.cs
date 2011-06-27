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
    public partial class transaccionesPendientes : Form
    {
        DataSet dsTransacciones = new DataSet();
        public transaccionesPendientes()
        {
            InitializeComponent();
            dsTransacciones = Controller.getInstancia().obtenerTransaccionesPendientes();
            dsTransacciones.Tables[0].Columns.Add("Display", typeof(string), "Concepto + ' Total: ' + Monto + ' Fecha: '+ Fecha");
        }

        private void transaccionesPendientes_Load(object sender, EventArgs e)
        {
            cargar();
         

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idtransac = int.Parse(this.listBox1.SelectedValue.ToString());
            if (Controller.getInstancia().confirmarComprobante(idtransac))
            {
                this.lbresultado.Text = "Transaccion realizada con exito";
                borrarseleccionado(idtransac);
                cargar();
            }
            else
            {
                this.lbresultado.Text = "Error";
            }
            
        }

        private void borrarseleccionado(int idTransac)
        {
            for (int i = 0; i < dsTransacciones.Tables[0].Rows.Count; i++)
            {
                if (dsTransacciones.Tables[0].Rows[i].RowState != DataRowState.Deleted)
                {
                    if (int.Parse(dsTransacciones.Tables[0].Rows[i]["NumTransac"].ToString()) == idTransac)
                    {
                        dsTransacciones.Tables[0].Rows[i].Delete();
                    }
                }
            }
        }

        private void cargar()
        {

            this.listBox1.DataSource = dsTransacciones.Tables[0];
            this.listBox1.DisplayMember = "Display";
            this.listBox1.ValueMember = "NumTransac";
        }




    }
}
