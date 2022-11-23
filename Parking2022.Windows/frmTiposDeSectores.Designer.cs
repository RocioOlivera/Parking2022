
namespace Parking2022.Windows
{
    partial class frmTiposDeSectores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTiposDeSectores));
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.cmnTipoSector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoSectorMenuStrip = new System.Windows.Forms.MenuStrip();
            this.IconNuevo = new FontAwesome.Sharp.IconMenuItem();
            this.EditarMenu = new FontAwesome.Sharp.IconMenuItem();
            this.BorrarMenu = new FontAwesome.Sharp.IconMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.TipoSectorMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmnTipoSector});
            this.dgvDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDatos.Location = new System.Drawing.Point(0, 82);
            this.dgvDatos.MultiSelect = false;
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(800, 368);
            this.dgvDatos.TabIndex = 5;
            this.dgvDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellContentClick);
            // 
            // cmnTipoSector
            // 
            this.cmnTipoSector.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnTipoSector.HeaderText = "Tipo De Sector";
            this.cmnTipoSector.MinimumWidth = 6;
            this.cmnTipoSector.Name = "cmnTipoSector";
            this.cmnTipoSector.ReadOnly = true;
            // 
            // TipoSectorMenuStrip
            // 
            this.TipoSectorMenuStrip.AutoSize = false;
            this.TipoSectorMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TipoSectorMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IconNuevo,
            this.EditarMenu,
            this.BorrarMenu});
            this.TipoSectorMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.TipoSectorMenuStrip.Name = "TipoSectorMenuStrip";
            this.TipoSectorMenuStrip.Size = new System.Drawing.Size(800, 82);
            this.TipoSectorMenuStrip.TabIndex = 4;
            this.TipoSectorMenuStrip.Text = "menuStrip1";
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
            // frmTiposDeSectores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.TipoSectorMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTiposDeSectores";
            this.Text = "TiposDeSectores";
            this.Load += new System.EventHandler(this.frmTiposDeSectores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.TipoSectorMenuStrip.ResumeLayout(false);
            this.TipoSectorMenuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.MenuStrip TipoSectorMenuStrip;
        private FontAwesome.Sharp.IconMenuItem IconNuevo;
        private FontAwesome.Sharp.IconMenuItem EditarMenu;
        private FontAwesome.Sharp.IconMenuItem BorrarMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnTipoSector;
    }
}