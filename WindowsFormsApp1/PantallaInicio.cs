using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class PantallaInicio : Form
    {
        public PantallaInicio()
        {
            InitializeComponent();
            this.FormClosed += PantallaInicio_FormClosed;
        }

        private void PantallaInicio_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtBoxUsuario.Text;
            string clave = txtBoxContraseña.Text;

            // Datos quemados: usuario, contraseña y rol
            var usuarios = new List<(string Usuario, string Clave, string Nombre, string Apellido, string Rol)>
            {
                ("admin", "admin123","NombreAdmin","ApellidoAdmin" ,"admin"),
                ("usuario", "user123","NombreUser","ApellidoUser" ,"usuario")
            };

            var usuarioEncontrado = usuarios.FirstOrDefault(u => u.Usuario == usuario && u.Clave == clave);

            if (!string.IsNullOrEmpty(usuarioEncontrado.Usuario))
            {
                await Task.Delay(10); 

                // Abrimos la pantalla principal y le pasamos el rol
                PantallaPrincipal pantalla = new PantallaPrincipal(usuarioEncontrado.Usuario, usuarioEncontrado.Rol, usuarioEncontrado.Nombre, usuarioEncontrado.Apellido);
                this.Hide(); // Oculta la pantalla de login, no la cierra
                pantalla.Show(); // Muestra la pantalla principal

            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PantallaInicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
