namespace WindowsFormsApp1
{
    partial class PantallaPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaPrincipal));
            this.btnInventarioCompras = new System.Windows.Forms.Button();
            this.btnClientesMascotas = new System.Windows.Forms.Button();
            this.btnAdminSistema = new System.Windows.Forms.Button();
            this.btnCitas = new System.Windows.Forms.Button();
            this.btnProvedoresCompras = new System.Windows.Forms.Button();
            this.lblNombreSistema = new System.Windows.Forms.Label();
            this.pnlMenuPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblUsuarioActual = new System.Windows.Forms.Label();
            this.pnlClientesMascotas = new System.Windows.Forms.TableLayoutPanel();
            this.menuStripClientesMascotas = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mascotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarDatosDeCleinteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarNuevaMascotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarMascotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarDatosDeMascotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnVolverMenu = new System.Windows.Forms.Button();
            this.pnlMenuPrincipal.SuspendLayout();
            this.pnlClientesMascotas.SuspendLayout();
            this.menuStripClientesMascotas.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInventarioCompras
            // 
            this.btnInventarioCompras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInventarioCompras.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnInventarioCompras.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.InventarioVentasImagen;
            this.btnInventarioCompras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlMenuPrincipal.SetColumnSpan(this.btnInventarioCompras, 2);
            this.btnInventarioCompras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInventarioCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventarioCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventarioCompras.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnInventarioCompras.Location = new System.Drawing.Point(238, 370);
            this.btnInventarioCompras.Name = "btnInventarioCompras";
            this.btnInventarioCompras.Size = new System.Drawing.Size(335, 227);
            this.btnInventarioCompras.TabIndex = 4;
            this.btnInventarioCompras.Text = "Ventas e Inventario";
            this.btnInventarioCompras.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInventarioCompras.UseVisualStyleBackColor = false;
            this.btnInventarioCompras.Click += new System.EventHandler(this.btnInventarioCompras_Click);
            // 
            // btnClientesMascotas
            // 
            this.btnClientesMascotas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClientesMascotas.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnClientesMascotas.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.ClienteMascotaImagen;
            this.btnClientesMascotas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlMenuPrincipal.SetColumnSpan(this.btnClientesMascotas, 2);
            this.btnClientesMascotas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientesMascotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientesMascotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientesMascotas.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnClientesMascotas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClientesMascotas.Location = new System.Drawing.Point(238, 157);
            this.btnClientesMascotas.Name = "btnClientesMascotas";
            this.btnClientesMascotas.Size = new System.Drawing.Size(335, 207);
            this.btnClientesMascotas.TabIndex = 3;
            this.btnClientesMascotas.Text = "Clientes y Mascotas";
            this.btnClientesMascotas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClientesMascotas.UseVisualStyleBackColor = false;
            this.btnClientesMascotas.Click += new System.EventHandler(this.btnClientesMascotas_Click);
            // 
            // btnAdminSistema
            // 
            this.btnAdminSistema.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdminSistema.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAdminSistema.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.SistemaImagen;
            this.btnAdminSistema.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdminSistema.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdminSistema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminSistema.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAdminSistema.Location = new System.Drawing.Point(909, 157);
            this.btnAdminSistema.Name = "btnAdminSistema";
            this.pnlMenuPrincipal.SetRowSpan(this.btnAdminSistema, 2);
            this.btnAdminSistema.Size = new System.Drawing.Size(161, 440);
            this.btnAdminSistema.TabIndex = 5;
            this.btnAdminSistema.Text = "Sistema";
            this.btnAdminSistema.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdminSistema.UseVisualStyleBackColor = false;
            this.btnAdminSistema.Click += new System.EventHandler(this.btnAdminSistema_Click);
            // 
            // btnCitas
            // 
            this.btnCitas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCitas.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCitas.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.CitaImagen;
            this.btnCitas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCitas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCitas.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCitas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCitas.Location = new System.Drawing.Point(579, 157);
            this.btnCitas.Name = "btnCitas";
            this.btnCitas.Size = new System.Drawing.Size(324, 207);
            this.btnCitas.TabIndex = 6;
            this.btnCitas.Text = "Citas y Agendamiento";
            this.btnCitas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCitas.UseVisualStyleBackColor = false;
            this.btnCitas.Click += new System.EventHandler(this.btnCitas_Click_1);
            // 
            // btnProvedoresCompras
            // 
            this.btnProvedoresCompras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProvedoresCompras.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnProvedoresCompras.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.ProovedoresComprasImagen;
            this.btnProvedoresCompras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnProvedoresCompras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProvedoresCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProvedoresCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProvedoresCompras.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnProvedoresCompras.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProvedoresCompras.Location = new System.Drawing.Point(579, 370);
            this.btnProvedoresCompras.Name = "btnProvedoresCompras";
            this.btnProvedoresCompras.Size = new System.Drawing.Size(324, 227);
            this.btnProvedoresCompras.TabIndex = 7;
            this.btnProvedoresCompras.Text = "Compras y Proveedores";
            this.btnProvedoresCompras.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProvedoresCompras.UseVisualStyleBackColor = false;
            this.btnProvedoresCompras.Click += new System.EventHandler(this.btnProvedoresCompras_Click);
            // 
            // lblNombreSistema
            // 
            this.lblNombreSistema.AutoEllipsis = true;
            this.lblNombreSistema.BackColor = System.Drawing.Color.Transparent;
            this.pnlMenuPrincipal.SetColumnSpan(this.lblNombreSistema, 4);
            this.lblNombreSistema.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNombreSistema.Font = new System.Drawing.Font("Dubai", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreSistema.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblNombreSistema.Location = new System.Drawing.Point(238, 0);
            this.lblNombreSistema.Name = "lblNombreSistema";
            this.lblNombreSistema.Size = new System.Drawing.Size(832, 154);
            this.lblNombreSistema.TabIndex = 8;
            this.lblNombreSistema.Text = "Sistema de Gestión y Agendamiento de Citas \r\npara Cuidado Estético de Mascotas";
            this.lblNombreSistema.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNombreSistema.Click += new System.EventHandler(this.lblNombreSistema_Click);
            // 
            // pnlMenuPrincipal
            // 
            this.pnlMenuPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.pnlMenuPrincipal.ColumnCount = 7;
            this.pnlMenuPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.067567F));
            this.pnlMenuPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.78041F));
            this.pnlMenuPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.15878F));
            this.pnlMenuPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.64189F));
            this.pnlMenuPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.87162F));
            this.pnlMenuPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.10473F));
            this.pnlMenuPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.290541F));
            this.pnlMenuPrincipal.Controls.Add(this.btnProvedoresCompras, 4, 2);
            this.pnlMenuPrincipal.Controls.Add(this.btnInventarioCompras, 2, 2);
            this.pnlMenuPrincipal.Controls.Add(this.btnClientesMascotas, 2, 1);
            this.pnlMenuPrincipal.Controls.Add(this.btnCitas, 4, 1);
            this.pnlMenuPrincipal.Controls.Add(this.lblNombreSistema, 2, 0);
            this.pnlMenuPrincipal.Controls.Add(this.btnAdminSistema, 5, 1);
            this.pnlMenuPrincipal.Controls.Add(this.btnLogOut, 1, 5);
            this.pnlMenuPrincipal.Controls.Add(this.lblUsuarioActual, 1, 4);
            this.pnlMenuPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuPrincipal.Name = "pnlMenuPrincipal";
            this.pnlMenuPrincipal.RowCount = 6;
            this.pnlMenuPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.26316F));
            this.pnlMenuPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.02632F));
            this.pnlMenuPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.6579F));
            this.pnlMenuPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.447369F));
            this.pnlMenuPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.394737F));
            this.pnlMenuPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.210527F));
            this.pnlMenuPrincipal.Size = new System.Drawing.Size(1184, 761);
            this.pnlMenuPrincipal.TabIndex = 9;
            this.pnlMenuPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMenuPrincipal_Paint);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogOut.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.CerrarSesionImagen;
            this.btnLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(77, 706);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(141, 38);
            this.btnLogOut.TabIndex = 9;
            this.btnLogOut.Text = "Cerrar sesión";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblUsuarioActual
            // 
            this.lblUsuarioActual.AutoSize = true;
            this.pnlMenuPrincipal.SetColumnSpan(this.lblUsuarioActual, 4);
            this.lblUsuarioActual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUsuarioActual.Font = new System.Drawing.Font("Dubai Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioActual.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblUsuarioActual.Location = new System.Drawing.Point(63, 649);
            this.lblUsuarioActual.Name = "lblUsuarioActual";
            this.lblUsuarioActual.Size = new System.Drawing.Size(840, 41);
            this.lblUsuarioActual.TabIndex = 10;
            this.lblUsuarioActual.Text = "Usuario: Nombre Apellido";
            this.lblUsuarioActual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlClientesMascotas
            // 
            this.pnlClientesMascotas.BackColor = System.Drawing.Color.Transparent;
            this.pnlClientesMascotas.ColumnCount = 3;
            this.pnlClientesMascotas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.445946F));
            this.pnlClientesMascotas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.26013F));
            this.pnlClientesMascotas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.29392F));
            this.pnlClientesMascotas.Controls.Add(this.btnVolverMenu, 1, 3);
            this.pnlClientesMascotas.Controls.Add(this.menuStripClientesMascotas, 0, 0);
            this.pnlClientesMascotas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlClientesMascotas.Location = new System.Drawing.Point(0, 0);
            this.pnlClientesMascotas.Name = "pnlClientesMascotas";
            this.pnlClientesMascotas.RowCount = 5;
            this.pnlClientesMascotas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.073587F));
            this.pnlClientesMascotas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.621551F));
            this.pnlClientesMascotas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.03285F));
            this.pnlClientesMascotas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.467805F));
            this.pnlClientesMascotas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.541393F));
            this.pnlClientesMascotas.Size = new System.Drawing.Size(1184, 761);
            this.pnlClientesMascotas.TabIndex = 11;
            // 
            // menuStripClientesMascotas
            // 
            this.menuStripClientesMascotas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStripClientesMascotas.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlClientesMascotas.SetColumnSpan(this.menuStripClientesMascotas, 3);
            this.menuStripClientesMascotas.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStripClientesMascotas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripClientesMascotas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.mascotasToolStripMenuItem});
            this.menuStripClientesMascotas.Location = new System.Drawing.Point(0, 0);
            this.menuStripClientesMascotas.Name = "menuStripClientesMascotas";
            this.menuStripClientesMascotas.Size = new System.Drawing.Size(1184, 31);
            this.menuStripClientesMascotas.TabIndex = 0;
            this.menuStripClientesMascotas.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarClienteToolStripMenuItem,
            this.modificarDatosDeCleinteToolStripMenuItem,
            this.consultarClienteToolStripMenuItem});
            this.clientesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientesToolStripMenuItem.ForeColor = System.Drawing.Color.Coral;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(77, 27);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // mascotasToolStripMenuItem
            // 
            this.mascotasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarNuevaMascotaToolStripMenuItem,
            this.modificarDatosDeMascotaToolStripMenuItem,
            this.consultarMascotasToolStripMenuItem});
            this.mascotasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mascotasToolStripMenuItem.ForeColor = System.Drawing.Color.Coral;
            this.mascotasToolStripMenuItem.Name = "mascotasToolStripMenuItem";
            this.mascotasToolStripMenuItem.Size = new System.Drawing.Size(87, 27);
            this.mascotasToolStripMenuItem.Text = "Mascotas";
            // 
            // registrarClienteToolStripMenuItem
            // 
            this.registrarClienteToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrarClienteToolStripMenuItem.Name = "registrarClienteToolStripMenuItem";
            this.registrarClienteToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.registrarClienteToolStripMenuItem.Text = "Registrar cliente";
            // 
            // modificarDatosDeCleinteToolStripMenuItem
            // 
            this.modificarDatosDeCleinteToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarDatosDeCleinteToolStripMenuItem.Name = "modificarDatosDeCleinteToolStripMenuItem";
            this.modificarDatosDeCleinteToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.modificarDatosDeCleinteToolStripMenuItem.Text = "Modificar datos de cliente";
            this.modificarDatosDeCleinteToolStripMenuItem.Click += new System.EventHandler(this.modificarDatosDeCleinteToolStripMenuItem_Click);
            // 
            // registrarNuevaMascotaToolStripMenuItem
            // 
            this.registrarNuevaMascotaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrarNuevaMascotaToolStripMenuItem.Name = "registrarNuevaMascotaToolStripMenuItem";
            this.registrarNuevaMascotaToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.registrarNuevaMascotaToolStripMenuItem.Text = "Registrar nueva mascota";
            // 
            // consultarMascotasToolStripMenuItem
            // 
            this.consultarMascotasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultarMascotasToolStripMenuItem.Name = "consultarMascotasToolStripMenuItem";
            this.consultarMascotasToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.consultarMascotasToolStripMenuItem.Text = "Consultar mascotas ";
            // 
            // consultarClienteToolStripMenuItem
            // 
            this.consultarClienteToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultarClienteToolStripMenuItem.Name = "consultarClienteToolStripMenuItem";
            this.consultarClienteToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.consultarClienteToolStripMenuItem.Text = "Consultar cliente";
            // 
            // modificarDatosDeMascotaToolStripMenuItem
            // 
            this.modificarDatosDeMascotaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarDatosDeMascotaToolStripMenuItem.Name = "modificarDatosDeMascotaToolStripMenuItem";
            this.modificarDatosDeMascotaToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.modificarDatosDeMascotaToolStripMenuItem.Text = "Modificar datos de mascota";
            // 
            // btnVolverMenu
            // 
            this.btnVolverMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVolverMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverMenu.Location = new System.Drawing.Point(103, 664);
            this.btnVolverMenu.Name = "btnVolverMenu";
            this.btnVolverMenu.Size = new System.Drawing.Size(150, 28);
            this.btnVolverMenu.TabIndex = 1;
            this.btnVolverMenu.Text = "Volver al Menu";
            this.btnVolverMenu.UseVisualStyleBackColor = true;
            this.btnVolverMenu.Click += new System.EventHandler(this.btnVolverMenu_Click);
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.FondoPantalla;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.pnlClientesMascotas);
            this.Controls.Add(this.pnlMenuPrincipal);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripClientesMascotas;
            this.Name = "PantallaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PantallaPrincipal";
            this.Load += new System.EventHandler(this.PantallaPrincipal_Load);
            this.pnlMenuPrincipal.ResumeLayout(false);
            this.pnlMenuPrincipal.PerformLayout();
            this.pnlClientesMascotas.ResumeLayout(false);
            this.pnlClientesMascotas.PerformLayout();
            this.menuStripClientesMascotas.ResumeLayout(false);
            this.menuStripClientesMascotas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInventarioCompras;
        private System.Windows.Forms.Button btnClientesMascotas;
        private System.Windows.Forms.Button btnAdminSistema;
        private System.Windows.Forms.Button btnCitas;
        private System.Windows.Forms.Button btnProvedoresCompras;
        private System.Windows.Forms.Label lblNombreSistema;
        private System.Windows.Forms.TableLayoutPanel pnlMenuPrincipal;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lblUsuarioActual;
        private System.Windows.Forms.TableLayoutPanel pnlClientesMascotas;
        private System.Windows.Forms.MenuStrip menuStripClientesMascotas;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarDatosDeCleinteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mascotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarNuevaMascotaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarMascotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarDatosDeMascotaToolStripMenuItem;
        private System.Windows.Forms.Button btnVolverMenu;
    }
}