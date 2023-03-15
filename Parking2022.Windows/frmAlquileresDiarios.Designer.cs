
namespace Parking2022.Windows
{
    partial class frmAlquileresDiarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlquileresDiarios));
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.AlquileresDiariosMenuStrip = new System.Windows.Forms.MenuStrip();
            this.IconNuevo = new FontAwesome.Sharp.IconMenuItem();
            this.EditarMenu = new FontAwesome.Sharp.IconMenuItem();
            this.BorrarMenu = new FontAwesome.Sharp.IconMenuItem();
            this.IconRetirar = new FontAwesome.Sharp.IconMenuItem();
            this.btnFinalizarMenu = new FontAwesome.Sharp.IconMenuItem();
            this.cmnTipoVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnPatente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnTipoSector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnNroSector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnFechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnPagado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.AlquileresDiariosMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmnTipoVehiculo,
            this.cmnPatente,
            this.cmnTipoSector,
            this.cmnNroSector,
            this.cmnFechaIngreso,
            this.cmnPagado});
            this.dgvDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDatos.Location = new System.Drawing.Point(0, 82);
            this.dgvDatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDatos.MultiSelect = false;
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(806, 368);
            this.dgvDatos.TabIndex = 5;
            // 
            // AlquileresDiariosMenuStrip
            // 
            this.AlquileresDiariosMenuStrip.AutoSize = false;
            this.AlquileresDiariosMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.AlquileresDiariosMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IconNuevo,
            this.EditarMenu,
            this.BorrarMenu,
            this.IconRetirar,
            this.btnFinalizarMenu});
            this.AlquileresDiariosMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.AlquileresDiariosMenuStrip.Name = "AlquileresDiariosMenuStrip";
            this.AlquileresDiariosMenuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.AlquileresDiariosMenuStrip.Size = new System.Drawing.Size(806, 82);
            this.AlquileresDiariosMenuStrip.TabIndex = 4;
            this.AlquileresDiariosMenuStrip.Text = "menuStrip1";
            // 
            // IconNuevo
            // 
            this.IconNuevo.AutoSize = false;
            this.IconNuevo.IconChar = FontAwesome.Sharp.IconChar.FileUpload;
            this.IconNuevo.IconColor = System.Drawing.Color.Black;
            this.IconNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.IconNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.IconNuevo.Name = "IconNuevo";
            this.IconNuevo.Size = new System.Drawing.Size(120, 70);
            this.IconNuevo.Text = "Nuevo";
            this.IconNuevo.Click += new System.EventHandler(this.IconNuevo_Click);
            // 
            // EditarMenu
            // 
            this.EditarMenu.AutoSize = false;
            this.EditarMenu.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.EditarMenu.IconColor = System.Drawing.Color.Black;
            this.EditarMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EditarMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditarMenu.Margin = new System.Windows.Forms.Padding(4);
            this.EditarMenu.Name = "EditarMenu";
            this.EditarMenu.Size = new System.Drawing.Size(120, 70);
            this.EditarMenu.Text = "Editar";
            this.EditarMenu.Click += new System.EventHandler(this.EditarMenu_Click);
            // 
            // BorrarMenu
            // 
            this.BorrarMenu.AutoSize = false;
            this.BorrarMenu.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.BorrarMenu.IconColor = System.Drawing.Color.Black;
            this.BorrarMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BorrarMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BorrarMenu.Margin = new System.Windows.Forms.Padding(4);
            this.BorrarMenu.Name = "BorrarMenu";
            this.BorrarMenu.Size = new System.Drawing.Size(120, 70);
            this.BorrarMenu.Text = "Borrar";
            this.BorrarMenu.Click += new System.EventHandler(this.BorrarMenu_Click);
            // 
            // IconRetirar
            // 
            this.IconRetirar.AutoSize = false;
            this.IconRetirar.IconChar = FontAwesome.Sharp.IconChar.FileImport;
            this.IconRetirar.IconColor = System.Drawing.Color.Black;
            this.IconRetirar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconRetirar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.IconRetirar.Margin = new System.Windows.Forms.Padding(4);
            this.IconRetirar.Name = "IconRetirar";
            this.IconRetirar.Size = new System.Drawing.Size(152, 70);
            this.IconRetirar.Text = "Retirar Vehiculo";
            this.IconRetirar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.IconRetirar.Click += new System.EventHandler(this.IconRetirar_Click);
            // 
            // btnFinalizarMenu
            // 
            this.btnFinalizarMenu.AutoSize = false;
            this.btnFinalizarMenu.IconChar = FontAwesome.Sharp.IconChar.Undo;
            this.btnFinalizarMenu.IconColor = System.Drawing.Color.Black;
            this.btnFinalizarMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFinalizarMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnFinalizarMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnFinalizarMenu.Name = "btnFinalizarMenu";
            this.btnFinalizarMenu.Size = new System.Drawing.Size(122, 70);
            this.btnFinalizarMenu.Text = "Actualizar Estado";
            this.btnFinalizarMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFinalizarMenu.Click += new System.EventHandler(this.btnFinalizarMenu_Click);
            // 
            // cmnTipoVehiculo
            // 
            this.cmnTipoVehiculo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnTipoVehiculo.HeaderText = "Tipo De Vehiculo";
            this.cmnTipoVehiculo.MinimumWidth = 6;
            this.cmnTipoVehiculo.Name = "cmnTipoVehiculo";
            this.cmnTipoVehiculo.ReadOnly = true;
            // 
            // cmnPatente
            // 
            this.cmnPatente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnPatente.HeaderText = "Patente";
            this.cmnPatente.MinimumWidth = 6;
            this.cmnPatente.Name = "cmnPatente";
            this.cmnPatente.ReadOnly = true;
            // 
            // cmnTipoSector
            // 
            this.cmnTipoSector.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnTipoSector.HeaderText = "Tipo de Sector";
            this.cmnTipoSector.MinimumWidth = 6;
            this.cmnTipoSector.Name = "cmnTipoSector";
            this.cmnTipoSector.ReadOnly = true;
            // 
            // cmnNroSector
            // 
            this.cmnNroSector.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnNroSector.HeaderText = "Nro. del Sector";
            this.cmnNroSector.MinimumWidth = 6;
            this.cmnNroSector.Name = "cmnNroSector";
            this.cmnNroSector.ReadOnly = true;
            // 
            // cmnFechaIngreso
            // 
            this.cmnFechaIngreso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnFechaIngreso.HeaderText = "Fecha de Ingreso";
            this.cmnFechaIngreso.MinimumWidth = 6;
            this.cmnFechaIngreso.Name = "cmnFechaIngreso";
            this.cmnFechaIngreso.ReadOnly = true;
            // 
            // cmnPagado
            // 
            this.cmnPagado.HeaderText = "Pagado";
            this.cmnPagado.MinimumWidth = 6;
            this.cmnPagado.Name = "cmnPagado";
            this.cmnPagado.ReadOnly = true;
            this.cmnPagado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cmnPagado.Width = 125;
            // 
            // frmAlquileresDiarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 450);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.AlquileresDiariosMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAlquileresDiarios";
            this.Text = "Alquileres Diarios";
            this.Load += new System.EventHandler(this.frmAlquileresDiarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.AlquileresDiariosMenuStrip.ResumeLayout(false);
            this.AlquileresDiariosMenuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.MenuStrip AlquileresDiariosMenuStrip;
        private FontAwesome.Sharp.IconMenuItem IconNuevo;
        private FontAwesome.Sharp.IconMenuItem EditarMenu;
        private FontAwesome.Sharp.IconMenuItem BorrarMenu;
        private FontAwesome.Sharp.IconMenuItem btnFinalizarMenu;
        private FontAwesome.Sharp.IconMenuItem IconRetirar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnTipoVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnPatente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnTipoSector;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnNroSector;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnFechaIngreso;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cmnPagado;
    }
}