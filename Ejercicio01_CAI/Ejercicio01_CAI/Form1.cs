using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio01_CAI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            // 1. Validaciones
            Boolean permiteAvanzar = true;

            // 1.1 Validaciones de integridad de datos
            // 1.2 Validaciones de negocio

            // 1.1.1 Validación null usuario
            if (txtUsuario.Text == "")
            {
                permiteAvanzar = false;
                MessageBox.Show("Por favor, ingrese un usuario.");
            }

            // 1.2.1 Longitud de usuario (mayor igual a 6)
            else if (txtUsuario.Text.Length < 6)
            {
                permiteAvanzar = false;
                MessageBox.Show("El usuario debe contener al menos 6 caracteres.");
            }

            // 1.1.1 Validación null pw
            if (txtPassword.Text == "")
            {
                permiteAvanzar = false;
                MessageBox.Show("Por favor, ingrese una contraseña.");
            }

            // 1.2.2 Longitud de contraseña (mayor igual a 6)
            else if (txtPassword.Text.Length < 6)
            {
                permiteAvanzar = false;
                MessageBox.Show("La contraseña debe contener al menos 6 caracteres.");
            }

            //permiteAvanzar = validarCredenciales(txtUsuario.Text, txtPassword.Text);

            // 1.3 Primer Login? -> Cambio password
            // 1.4 Expiración Password post 30 días
            //if (permiteAvanzar)
            //{
            //    validarEstadoContraseña(txtUsuario.Text);
            //}

            // 2. Login exitoso, redirigir.
            if (permiteAvanzar)
            {
                this.Hide();
                FormMenu formMenu = new FormMenu();
                formMenu.ShowDialog();
            }
        }

        // 1.4    
        //private void validarEstadoContraseña(string usuarioLogin)
        //{
        //    Credencial credencialLogin = buscarUsuario(usuarioLogin);
        //    if (credencialLogin.FechaUltimoIngreso == null)
        //    {
        //        // Redirigir al cambio de contraseña
        //    }

        //    if (credencialLogin.FechaUltimoIngreso < DateTime.Today.AddDays(-30))
        //    {
        //        // Redirigir al cambio de contraseña
        //    }
        

        //    private Boolean validarCredenciales(string usuarioLogin, string passwordLogin)
        //{

        //}

        

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
