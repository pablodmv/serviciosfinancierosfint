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
    public partial class EliminarUsuario : Form
    {

        private String usrLogueado;

        public String UsrLogueado
        {
            get { return usrLogueado; }
            set { usrLogueado = value; }
        }

        public EliminarUsuario()
        {
            InitializeComponent();
        }

        public EliminarUsuario(String login)
        {
            InitializeComponent();
            this.usrLogueado = login;
        }




        private void EliminarUsuario_Load(object sender, EventArgs e)
        {
            this.msgLbl.Text = "El usuario "+ this.usrLogueado +" sera desactivado." ;
        }

        private void doneBtn_Click(object sender, EventArgs e)
        {

            if(Controller.desactivarUsuario(this.usrLogueado)){
                this.msgLbl.Text = "El usuario " + this.usrLogueado + " ha sido desactivado."; 

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
