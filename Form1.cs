using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class frmLogin : Form
    {
        Usuarios usuarios = new Usuarios();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string user = txtUsuario.Text;
            string password = txtContra.Text;


            var lista = usuarios.Obtenerusuarios();
            var valider = lista.FirstOrDefault(u => u.NombreUsuario == user  && u.Contrasenia == password );

            if (valider != null)
            {
                this.Hide();
                Inicio inicio = new Inicio();
                inicio.Show();
            }
            else
            {
                MessageBox.Show("Fallaste");
            }
        }
    }
}
