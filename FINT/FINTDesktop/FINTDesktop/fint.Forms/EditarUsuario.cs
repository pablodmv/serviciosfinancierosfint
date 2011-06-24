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
    public partial class EditarUsuario : Form
    {
        DataSet dsUsuario = new DataSet();
        static Controller controladora;
        public EditarUsuario()
        {
            InitializeComponent();
            controladora = Controller.getInstancia();
            dsUsuario = controladora.dsUsuario;
            

        }

        private void EditarUsuario_Load(object sender, EventArgs e)
        {
            this.nomTxt.Text = dsUsuario.Tables[0].Rows[0]["Nombre"].ToString();
            this.pwdTxt.Text = dsUsuario.Tables[0].Rows[0]["Password"].ToString();
            

        }
        
        private void doneBtn_Click(object sender, EventArgs e)
        {
            int idUsuario = int.Parse(dsUsuario.Tables[0].Rows[0]["id"].ToString());
            String nombre = this.nomTxt.Text;
            String pwd = this.pwdTxt.Text;

            if (!nombre.Equals("") && !pwd.Equals(""))
            {  
                
                if(controladora.editarUsuario(nombre,pwd,idUsuario)){
                    this.msgLbl.Text = "Usuario editado con exito.";
                }
                
            }
            else
            {
                this.msgLbl.Text = "Los datos son requeridos.";
            }




        }

        
    }
}
