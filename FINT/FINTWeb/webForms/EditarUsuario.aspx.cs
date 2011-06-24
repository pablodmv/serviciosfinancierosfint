﻿using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using FINTWeb.controller;

namespace FINTWeb.webForms
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String usr = "";
            if (Request.QueryString["usuarioTxt"] != null)
            {
                usr = Request.QueryString["usuarioTxt"];
            }
            this.usrLbl.Text = "Bienvenido Usuario: " + usr;
        }

        protected void doneBtn_Click(object sender, EventArgs e)
        {


            String nombre = this.nomTxt.Text;
            String pwd = this.pwdTxt.Text;

            if (!nombre.Equals("") && !pwd.Equals(""))
            {
                if (Controller.editarUsuario(nombre, pwd))
                {
                    this.msgLbl.Text = "Usuario editado con exito.";
                    this.clear();
                }

            }
            else
            {
                this.msgLbl.Text = "Todos Los datos son requeridos.";
            }
        }

        private void clear()
        {
            this.nomTxt.Text = "";
            this.pwdTxt.Text = "";

        }



        protected void backBtn_Click(object sender, EventArgs e)
        {
            Server.Transfer("~/webForms/Main.aspx", true);
        }
    }
}
