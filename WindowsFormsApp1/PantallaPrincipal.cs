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
    
    public partial class PantallaPrincipal : Form
    {
        private string nombreUsuario;
        private string apellidoUsuario;
        private bool cerrandoSesion = false;
        public PantallaPrincipal(string usuario, string rol, string nombre, string apellido)
        {
            //Guardar nombres del usuario que inicia sesion para futura auditoria
            nombreUsuario = nombre;
            apellidoUsuario = apellido;

            InitializeComponent();

            pnlClientesMascotas.Visible = false;

            lblUsuarioActual.Text = $"Usuario: {nombreUsuario} {apellidoUsuario}";
           
            if (rol == "usuario") {
                btnAdminSistema.Hide();
            }
            
            
            
            

            
            //Doble buffer para cargar en segundo plano imagenes y componentes pesados
            this.DoubleBuffered = true;
            typeof(TableLayoutPanel).InvokeMember("DoubleBuffered",
                                                  System.Reflection.BindingFlags.SetProperty | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic,
                                                  null, pnlMenuPrincipal, new object[] { true });
            this.DoubleBuffered = true;
            typeof(TableLayoutPanel).InvokeMember("DoubleBuffered",
                                                  System.Reflection.BindingFlags.SetProperty | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic,
                                                  null, pnlClientesMascotas, new object[] { true });
            //Para cerrar completamente el programa si el usuario hace click en "X" del formulario, pero no por el boton "Cerrar Sesion"
            this.FormClosed += (s, args) =>
            {
                if (!cerrandoSesion)
                {
                    Application.Exit();
                }
            };
        }

        private void PantallaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnCitas_Click(object sender, EventArgs e)
        {

        }

        private void btnInventarioCompras_Click(object sender, EventArgs e)
        {

        }

        private void btnCitas_Click_1(object sender, EventArgs e)
        {

        }

        private void btnProvedoresCompras_Click(object sender, EventArgs e)
        {

        }

        private void btnAdminSistema_Click(object sender, EventArgs e)
        {

        }

        private void btnClientesMascotas_Click(object sender, EventArgs e)
        {
            pnlMenuPrincipal.Visible = false;
            pnlClientesMascotas.Visible = true;

        }

        private void lblNombreSistema_Click(object sender, EventArgs e)
        {

        }

        private void pnlMenuPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            cerrandoSesion = true;
            PantallaInicio pantallaLogin = new PantallaInicio();
            pantallaLogin.Show();
            this.Close();
        }

        private void modificarDatosDeCleinteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            pnlClientesMascotas.Visible = false;
            pnlMenuPrincipal.Visible = true;
        }

        /**
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // WS_EX_COMPOSITED
                return cp;
            }
        }
        **/
    }
}
