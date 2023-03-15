
namespace Parking2022.Windows
{
    partial class frmTarifas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTarifas));
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.TarifasMenuStrip = new System.Windows.Forms.MenuStrip();
            this.IconNuevo = new FontAwesome.Sharp.IconMenuItem();
            this.EditarMenu = new FontAwesome.Sharp.IconMenuItem();
            this.BorrarMenu = new FontAwesome.Sharp.IconMenuItem();
            this.PrimeroMenuPag = new FontAwesome.Sharp.IconMenuItem();
            this.AnteriorMenuPag = new FontAwesome.Sharp.IconMenuItem();
            this.SiguienteMenuPag = new FontAwesome.Sharp.IconMenuItem();
            this.UltimoMenuPag = new FontAwesome.Sharp.IconMenuItem();
            this.cmnTipoVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnTiempoTarifa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.TarifasMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmnTipoVehiculo,
            this.cmnTiempoTarifa,
            this.cmnImporte});
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
            // TarifasMenuStrip
            // 
            this.TarifasMenuStrip.AutoSize = false;
            this.TarifasMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TarifasMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IconNuevo,
            this.EditarMenu,
            this.BorrarMenu,
            this.PrimeroMenuPag,
            this.AnteriorMenuPag,
            this.SiguienteMenuPag,
            this.UltimoMenuPag});
            this.TarifasMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.TarifasMenuStrip.Name = "TarifasMenuStrip";
            this.TarifasMenuStrip.Size = new System.Drawing.Size(800, 82);
            this.TarifasMenuStrip.TabIndex = 2;
            this.TarifasMenuStrip.Text = "menuStrip1";
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
            // PrimeroMenuPag
            // 
            this.PrimeroMenuPag.AutoSize = false;
            this.PrimeroMenuPag.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleLeft;
            this.PrimeroMenuPag.IconColor = System.Drawing.Color.Black;
            this.PrimeroMenuPag.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.PrimeroMenuPag.IconSize = 30;
            this.PrimeroMenuPag.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.PrimeroMenuPag.Margin = new System.Windows.Forms.Padding(3);
            this.PrimeroMenuPag.Name = "PrimeroMenuPag";
            this.PrimeroMenuPag.Size = new System.Drawing.Size(80, 70);
            this.PrimeroMenuPag.Text = "Primero";
            this.PrimeroMenuPag.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // AnteriorMenuPag
            // 
            this.AnteriorMenuPag.AutoSize = false;
            this.AnteriorMenuPag.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            this.AnteriorMenuPag.IconColor = System.Drawing.Color.Black;
            this.AnteriorMenuPag.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AnteriorMenuPag.IconSize = 30;
            this.AnteriorMenuPag.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AnteriorMenuPag.Margin = new System.Windows.Forms.Padding(3);
            this.AnteriorMenuPag.Name = "AnteriorMenuPag";
            this.AnteriorMenuPag.Size = new System.Drawing.Size(80, 70);
            this.AnteriorMenuPag.Text = "Anterior";
            this.AnteriorMenuPag.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // SiguienteMenuPag
            // 
            this.SiguienteMenuPag.AutoSize = false;
            this.SiguienteMenuPag.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
            this.SiguienteMenuPag.IconColor = System.Drawing.Color.Black;
            this.SiguienteMenuPag.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SiguienteMenuPag.IconSize = 30;
            this.SiguienteMenuPag.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SiguienteMenuPag.Margin = new System.Windows.Forms.Padding(3);
            this.SiguienteMenuPag.Name = "SiguienteMenuPag";
            this.SiguienteMenuPag.Size = new System.Drawing.Size(80, 70);
            this.SiguienteMenuPag.Text = "Siguiente";
            this.SiguienteMenuPag.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // UltimoMenuPag
            // 
            this.UltimoMenuPag.AutoSize = false;
            this.UltimoMenuPag.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleRight;
            this.UltimoMenuPag.IconColor = System.Drawing.Color.Black;
            this.UltimoMenuPag.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.UltimoMenuPag.IconSize = 30;
            this.UltimoMenuPag.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.UltimoMenuPag.Margin = new System.Windows.Forms.Padding(3);
            this.UltimoMenuPag.Name = "UltimoMenuPag";
            this.UltimoMenuPag.Size = new System.Drawing.Size(80, 70);
            this.UltimoMenuPag.Text = "Último";
            this.UltimoMenuPag.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // cmnTipoVehiculo
            // 
            this.cmnTipoVehiculo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnTipoVehiculo.HeaderText = "Tipo De Vehiculo";
            this.cmnTipoVehiculo.MinimumWidth = 6;
            this.cmnTipoVehiculo.Name = "cmnTipoVehiculo";
            this.cmnTipoVehiculo.ReadOnly = true;
            // 
            // cmnTiempoTarifa
            // 
            this.cmnTiempoTarifa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnTiempoTarifa.HeaderText = "Tiempo de Tarifa";
            this.cmnTiempoTarifa.MinimumWidth = 6;
            this.cmnTiempoTarifa.Name = "cmnTiempoTarifa";
            this.cmnTiempoTarifa.ReadOnly = true;
            // 
            // cmnImporte
            // 
            this.cmnImporte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnImporte.HeaderText = "Importe";
            this.cmnImporte.MinimumWidth = 6;
            this.cmnImporte.Name = "cmnImporte";
            this.cmnImporte.ReadOnly = true;
            // 
            // frmTarifas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.TarifasMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTarifas";
            this.Text = "Tarifas";
            this.Load += new System.EventHandler(this.frmTarifas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.TarifasMenuStrip.ResumeLayout(false);
            this.TarifasMenuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.MenuStrip TarifasMenuStrip;
        private FontAwesome.Sharp.IconMenuItem IconNuevo;
        private FontAwesome.Sharp.IconMenuItem EditarMenu;
        private FontAwesome.Sharp.IconMenuItem BorrarMenu;
        private FontAwesome.Sharp.IconMenuItem PrimeroMenuPag;
        private FontAwesome.Sharp.IconMenuItem AnteriorMenuPag;
        private FontAwesome.Sharp.IconMenuItem SiguienteMenuPag;
        private FontAwesome.Sharp.IconMenuItem UltimoMenuPag;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnTipoVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnTiempoTarifa;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnImporte;
    }
}