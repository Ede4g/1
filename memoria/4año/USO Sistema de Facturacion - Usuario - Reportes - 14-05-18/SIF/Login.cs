﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIF
{
    public partial class Login : Form
    {
        Boolean _Autorizado = false;
        SessionController.Sesion _SESION = SessionController.Sesion.Instance;
        public Login()
        {
            InitializeComponent();
        }

        public bool Autorizado
        {
            get
            {
                return _Autorizado;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (_SESION.ValidarSesion(txbUsuario.Text, txbPassword.Text))
            {
                _Autorizado =true;
                Close();
            }
            else
            {
                lblMensaje.Text = "DATOS ERRONEOS";
            }
            

        }
    }
}
