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
    public partial class Registrar_Cliente : Form
    {
        public Registrar_Cliente()
        {
            InitializeComponent();
        }

        private void Registrar_Cliente_Load(object sender, EventArgs e)
        {

        }

        private void loginLbl_Click(object sender, EventArgs e)
        {

        }

        private void doneBtn_Click(object sender, EventArgs e)
        {

            String nombre = this.nombreTxt.Text;
            String login = this.loginTxt.Text;
            String pwd = this.pwdText.Text;

            if (!nombre.Equals("") && !login.Equals("") && !pwd.Equals(""))
            {
                this.msgLbl.Visible = false;
                if (Controller.agregarUsuario(nombre, login, pwd))
                {
                    this.msgLbl.Text = "Usuario ingresado con exito";
                    this.msgLbl.Visible = true;
                }

            }
            else
            {
                this.msgLbl.Text = "Todos los datos son requeridos.";
                this.msgLbl.Visible = true;
            }

        }
    }
}
