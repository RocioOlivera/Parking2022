
namespace Parking2022.Windows
{
    partial class frmTiposDeVehiculos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTiposDeVehiculos));
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.cmnTipoVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoVehiculoMenuStrip = new System.Windows.Forms.MenuStrip();
            this.IconNuevo = new FontAwesome.Sharp.IconMenuItem();
            this.EditarMenu = new FontAwesome.Sharp.IconMenuItem();
            this.BorrarMenu = new FontAwesome.Sharp.IconMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.TipoVehiculoMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmnTipoVehiculo});
            this.dgvDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDatos.Location = new System.Drawing.Point(0, 82);
            this.dgvDatos.MultiSelect = false;
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(800, 368);
            this.dgvDatos.TabIndex = 3;
            // 
            // cmnTipoVehiculo
            // 
            this.cmnTipoVehiculo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnTipoVehiculo.HeaderText = "Tipo De Vehiculo";
            this.cmnTipoVehiculo.MinimumWidth = 6;
            this.cmnTipoVehiculo.Name = "cmnTipoVehiculo";
            this.cmnTipoVehiculo.ReadOnly = true;
            // 
            // TipoVehiculoMenuStrip
            // 
            this.TipoVehiculoMenuStrip.AutoSize = false;
            this.TipoVehiculoMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TipoVehiculoMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IconNuevo,
            this.EditarMenu,
            this.BorrarMenu});
            this.TipoVehiculoMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.TipoVehiculoMenuStrip.Name = "TipoVehiculoMenuStrip";
            this.TipoVehiculoMenuStrip.Size = new System.Drawing.Size(800, 82);
            this.TipoVehiculoMenuStrip.TabIndex = 2;
            this.TipoVehiculoMenuStrip.Text = "menuStrip1";
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
            // frmTiposDeVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.TipoVehiculoMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTiposDeVehiculos";
            this.Text = "Tipos de Vehiculos";
            this.Load += new System.EventHandler(this.frmTiposDeVehiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.TipoVehiculoMenuStrip.ResumeLayout(false);
            this.TipoVehiculoMenuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.MenuStrip TipoVehiculoMenuStrip;
        private FontAwesome.Sharp.IconMenuItem IconNuevo;
        private FontAwesome.Sharp.IconMenuItem EditarMenu;
        private FontAwesome.Sharp.IconMenuItem BorrarMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnTipoVehiculo;
    }
}