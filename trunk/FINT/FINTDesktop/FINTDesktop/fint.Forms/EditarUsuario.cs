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
        public EditarUsuario()
        {
            InitializeComponent();
        }

        private void EditarUsuario_Load(object sender, EventArgs e)
        {

        }
        
        private void doneBtn_Click(object sender, EventArgs e)
        {

            String nombre = this.nomTxt.Text;
            String pwd = this.pwdTxt.Text;

            if (!nombre.Equals("") && !pwd.Equals(""))
            {  
                if(Controller.editarUsuario(nombre,pwd)){
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
