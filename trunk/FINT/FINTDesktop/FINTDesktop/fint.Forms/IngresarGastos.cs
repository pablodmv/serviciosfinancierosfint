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
    public partial class IngresarGastos : Form
    {
        int idusuario;
        DataSet dsCuentas = new DataSet();
        public IngresarGastos()
        {
            InitializeComponent();
        }

        private void descLbl_Click(object sender, EventArgs e)
        {

        }

        private void montoTxt_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void descTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void montoLbl_Click(object sender, EventArgs e)
        {

        }

        private void doneBtn_Click(object sender, EventArgs e)
        {

            String nFac = this.nFacTxt.Text;
            String desc = this.descTxt.Text;
            int idcuenta = int.Parse(this.comboBox1.SelectedValue.ToString());
            try
            {
                Decimal tmpMonto = Decimal.Parse(this.montoTxt.Text);
                Decimal monto = (Decimal)tmpMonto;
                String fVen = this.fVenDPicker.Value.ToString("dd/MM/yyyy");
                int estado = (int)Estado.Pendiente;

                //Console.WriteLine(fVen.Date.ToString());
                //Console.WriteLine(fVen.ToString());

                if (!nFac.Equals("") && !desc.Equals("") && !monto.Equals(""))
                {

                    if (Controller.getInstancia().ingresarGasto(nFac, desc, monto, fVen, estado,idcuenta))
                    {
                        this.msgLbl.Text = "Gasto ingresado con exito.";

                        this.clear();
                    }

                }
                else
                {
                    this.msgLbl.Text = "Todos los datos son requeridos.";
                }
            }
            catch (Exception ex )
            {
                
               this.msgLbl.Text = "Monto incorrecto.";
            }
           



        }


        private void clear()
        {
            this.nFacTxt.Text = "";
            this.descTxt.Text = "";
            this.montoTxt.Text = "";
            this.fVenDPicker.Value = DateTime.Today;
            this.msgLbl.Text = "";

        }

        private void IngresarGastos_Load(object sender, EventArgs e)
        {
            this.fVenDPicker.Value = DateTime.Today;
            idusuario = Controller.getInstancia().IdUsuario;
            dsCuentas = Controller.getInstancia().obtenerCuentasXusuario(idusuario);
            this.comboBox1.DataSource = dsCuentas.Tables[0];
            this.comboBox1.DisplayMember = "Descripcion";
            this.comboBox1.ValueMember = "id";
        }


    }

    public enum Estado
    {
        Pendiente,
        Realizada
    }
}
