using CapaNegocio;
using CapaPresentacion.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private bool isFormValid()
        {
            if (txtEmail.Text.Trim() == string.Empty || txtPassword.Text.Trim() == string.Empty)
            {
                MessageBox.Show("El Email y la Contraseña son requeridos.", "Ingrese su Email y Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (isFormValid())
            {
                using (DashboardForm df = new DashboardForm())
                {
                    df.ShowDialog();
                }

                txtEmail.Text = "";
                txtPassword.Text = "";
                txtEmail.Focus();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtEmail.Focus();
        }

        private void lblRegistrate_Click(object sender, EventArgs e)  //Abrir form Registro Usuario
        {
            using (RegistroUsuarioForm ru = new RegistroUsuarioForm())
            {
                ru.ShowDialog();
            }
        }
    }
}
