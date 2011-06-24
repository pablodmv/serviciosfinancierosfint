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
    public partial class Login : Form
    {

        private MainForm main;
        private static Controller controladora;

        public Login()
        {
            InitializeComponent();
           
        }

        public Login(MainForm f)
        {
            InitializeComponent();
            this.main = f;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            controladora = Controller.getInstancia();
            String usr = this.usrTxt.Text;
            String pwd = this.pwdTxt.Text;
            if (controladora.loginUsuario(usr, pwd).Tables[0].Rows.Count>0)
            {
                this.msgLbl.Visible = false;
                this.main.getMenu().Visible = true;
                this.Hide();
            }
            else
            {
                this.msgLbl.Visible = true;

            }

            
        }

        private void msgLbl_Click(object sender, EventArgs e)
        {

        }

        private void newUsrLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Form regCliente = new Registrar_Cliente();
            regCliente.Show();
        }
    }
}
