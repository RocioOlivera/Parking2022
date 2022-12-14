
namespace Parking2022.Windows
{
    partial class frmFormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFormPrincipal));
            this.ContenedorPanel = new System.Windows.Forms.Panel();
            this.BarraMenuPrincipalStrip = new System.Windows.Forms.MenuStrip();
            this.IconClientes = new FontAwesome.Sharp.IconMenuItem();
            this.IconCtasCtes = new FontAwesome.Sharp.IconMenuItem();
            this.IconAlquileresAsociados = new FontAwesome.Sharp.IconMenuItem();
            this.IconTarifas = new FontAwesome.Sharp.IconMenuItem();
            this.IconTipoVehiculo = new FontAwesome.Sharp.IconMenuItem();
            this.iconTipoSector = new FontAwesome.Sharp.IconMenuItem();
            this.IconAlquileresDiarios = new FontAwesome.Sharp.IconMenuItem();
            this.BarraMenuPrincipalStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContenedorPanel
            // 
            this.ContenedorPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ContenedorPanel.BackgroundImage")));
            this.ContenedorPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ContenedorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContenedorPanel.Location = new System.Drawing.Point(0, 117);
            this.ContenedorPanel.Margin = new System.Windows.Forms.Padding(4);
            this.ContenedorPanel.Name = "ContenedorPanel";
            this.ContenedorPanel.Size = new System.Drawing.Size(1622, 636);
            this.ContenedorPanel.TabIndex = 3;
            this.ContenedorPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ContenedorPanel_Paint);
            // 
            // BarraMenuPrincipalStrip
            // 
            this.BarraMenuPrincipalStrip.AutoSize = false;
            this.BarraMenuPrincipalStrip.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BarraMenuPrincipalStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.BarraMenuPrincipalStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IconTipoVehiculo,
            this.iconTipoSector,
            this.IconTarifas,
            this.IconAlquileresDiarios,
            this.IconAlquileresAsociados,
            this.IconClientes,
            this.IconCtasCtes});
            this.BarraMenuPrincipalStrip.Location = new System.Drawing.Point(0, 0);
            this.BarraMenuPrincipalStrip.Name = "BarraMenuPrincipalStrip";
            this.BarraMenuPrincipalStrip.Size = new System.Drawing.Size(1622, 117);
            this.BarraMenuPrincipalStrip.TabIndex = 3;
            this.BarraMenuPrincipalStrip.Text = "menuStrip1";
            // 
            // IconClientes
            // 
            this.IconClientes.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.IconClientes.CheckOnClick = true;
            this.IconClientes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconClientes.IconChar = FontAwesome.Sharp.IconChar.Restroom;
            this.IconClientes.IconColor = System.Drawing.Color.Black;
            this.IconClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconClientes.IconSize = 70;
            this.IconClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.IconClientes.Name = "IconClientes";
            this.IconClientes.Size = new System.Drawing.Size(164, 113);
            this.IconClientes.Text = "Clientes";
            this.IconClientes.Click += new System.EventHandler(this.IconClientes_Click);
            // 
            // IconCtasCtes
            // 
            this.IconCtasCtes.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.IconCtasCtes.CheckOnClick = true;
            this.IconCtasCtes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconCtasCtes.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.IconCtasCtes.IconColor = System.Drawing.Color.Black;
            this.IconCtasCtes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconCtasCtes.IconSize = 70;
            this.IconCtasCtes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.IconCtasCtes.Name = "IconCtasCtes";
            this.IconCtasCtes.Size = new System.Drawing.Size(259, 113);
            this.IconCtasCtes.Text = "Cuentas Corrientes";
            this.IconCtasCtes.Click += new System.EventHandler(this.IconCtasCtes_Click);
            // 
            // IconAlquileresAsociados
            // 
            this.IconAlquileresAsociados.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.IconAlquileresAsociados.CheckOnClick = true;
            this.IconAlquileresAsociados.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconAlquileresAsociados.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.IconAlquileresAsociados.IconColor = System.Drawing.Color.Black;
            this.IconAlquileresAsociados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconAlquileresAsociados.IconSize = 70;
            this.IconAlquileresAsociados.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.IconAlquileresAsociados.Name = "IconAlquileresAsociados";
            this.IconAlquileresAsociados.Size = new System.Drawing.Size(286, 113);
            this.IconAlquileresAsociados.Text = "Alquieleres Asociados";
            this.IconAlquileresAsociados.Click += new System.EventHandler(this.IconAlquileresAsociados_Click);
            // 
            // IconTarifas
            // 
            this.IconTarifas.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.IconTarifas.CheckOnClick = true;
            this.IconTarifas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconTarifas.IconChar = FontAwesome.Sharp.IconChar.Donate;
            this.IconTarifas.IconColor = System.Drawing.Color.Black;
            this.IconTarifas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconTarifas.IconSize = 70;
            this.IconTarifas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.IconTarifas.Name = "IconTarifas";
            this.IconTarifas.Size = new System.Drawing.Size(150, 113);
            this.IconTarifas.Text = "Tarifas";
            this.IconTarifas.Click += new System.EventHandler(this.IconTarifas_Click);
            // 
            // IconTipoVehiculo
            // 
            this.IconTipoVehiculo.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.IconTipoVehiculo.CheckOnClick = true;
            this.IconTipoVehiculo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconTipoVehiculo.IconChar = FontAwesome.Sharp.IconChar.CarSide;
            this.IconTipoVehiculo.IconColor = System.Drawing.Color.Black;
            this.IconTipoVehiculo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconTipoVehiculo.IconSize = 70;
            this.IconTipoVehiculo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.IconTipoVehiculo.Name = "IconTipoVehiculo";
            this.IconTipoVehiculo.Size = new System.Drawing.Size(251, 113);
            this.IconTipoVehiculo.Text = "Tipo De Vehiculos";
            this.IconTipoVehiculo.Click += new System.EventHandler(this.IconTipoVehiculo_Click);
            // 
            // iconTipoSector
            // 
            this.iconTipoSector.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.iconTipoSector.CheckOnClick = true;
            this.iconTipoSector.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconTipoSector.IconChar = FontAwesome.Sharp.IconChar.Adjust;
            this.iconTipoSector.IconColor = System.Drawing.Color.Black;
            this.iconTipoSector.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconTipoSector.IconSize = 70;
            this.iconTipoSector.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconTipoSector.Name = "iconTipoSector";
            this.iconTipoSector.Size = new System.Drawing.Size(243, 113);
            this.iconTipoSector.Text = "Tipo De Sectores";
            this.iconTipoSector.Click += new System.EventHandler(this.iconTipoSector_Click);
            // 
            // IconAlquileresDiarios
            // 
            this.IconAlquileresDiarios.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.IconAlquileresDiarios.CheckOnClick = true;
            this.IconAlquileresDiarios.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconAlquileresDiarios.IconChar = FontAwesome.Sharp.IconChar.CalendarDay;
            this.IconAlquileresDiarios.IconColor = System.Drawing.Color.Black;
            this.IconAlquileresDiarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconAlquileresDiarios.IconSize = 70;
            this.IconAlquileresDiarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.IconAlquileresDiarios.Name = "IconAlquileresDiarios";
            this.IconAlquileresDiarios.Size = new System.Drawing.Size(248, 113);
            this.IconAlquileresDiarios.Text = "Alquileres Diarios";
            this.IconAlquileresDiarios.Click += new System.EventHandler(this.IconAlquileresDiarios_Click_1);
            // 
            // frmFormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1622, 753);
            this.Controls.Add(this.ContenedorPanel);
            this.Controls.Add(this.BarraMenuPrincipalStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFormPrincipal";
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmFormPrincipal_Load);
            this.BarraMenuPrincipalStrip.ResumeLayout(false);
            this.BarraMenuPrincipalStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ContenedorPanel;
        private System.Windows.Forms.MenuStrip BarraMenuPrincipalStrip;
        private FontAwesome.Sharp.IconMenuItem IconClientes;
        private FontAwesome.Sharp.IconMenuItem IconCtasCtes;
        private FontAwesome.Sharp.IconMenuItem IconAlquileresAsociados;
        private FontAwesome.Sharp.IconMenuItem IconTarifas;
        private FontAwesome.Sharp.IconMenuItem IconTipoVehiculo;
        private FontAwesome.Sharp.IconMenuItem iconTipoSector;
        private FontAwesome.Sharp.IconMenuItem IconAlquileresDiarios;
    }
}

