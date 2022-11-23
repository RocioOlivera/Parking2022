
namespace Parking2022.Windows
{
    partial class frmCtasCtes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCtasCtes));
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.cmnCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnSaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CtasCtesMenuStrip = new System.Windows.Forms.MenuStrip();
            this.IconNuevo = new FontAwesome.Sharp.IconMenuItem();
            this.EditarMenu = new FontAwesome.Sharp.IconMenuItem();
            this.BorrarMenu = new FontAwesome.Sharp.IconMenuItem();
            this.PrimeroMenuPag = new FontAwesome.Sharp.IconMenuItem();
            this.AnteriorMenuPag = new FontAwesome.Sharp.IconMenuItem();
            this.SiguienteMenuPag = new FontAwesome.Sharp.IconMenuItem();
            this.UltimoMenuPag = new FontAwesome.Sharp.IconMenuItem();
            this.IconDetalle = new FontAwesome.Sharp.IconMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.CtasCtesMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmnCliente,
            this.cmnSaldo});
            this.dgvDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDatos.Location = new System.Drawing.Point(0, 82);
            this.dgvDatos.MultiSelect = false;
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(914, 420);
            this.dgvDatos.TabIndex = 3;
            // 
            // cmnCliente
            // 
            this.cmnCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnCliente.HeaderText = "Cliente";
            this.cmnCliente.MinimumWidth = 6;
            this.cmnCliente.Name = "cmnCliente";
            this.cmnCliente.ReadOnly = true;
            // 
            // cmnSaldo
            // 
            this.cmnSaldo.HeaderText = "Saldo";
            this.cmnSaldo.MinimumWidth = 6;
            this.cmnSaldo.Name = "cmnSaldo";
            this.cmnSaldo.ReadOnly = true;
            this.cmnSaldo.Width = 125;
            // 
            // CtasCtesMenuStrip
            // 
            this.CtasCtesMenuStrip.AutoSize = false;
            this.CtasCtesMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CtasCtesMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IconNuevo,
            this.EditarMenu,
            this.BorrarMenu,
            this.PrimeroMenuPag,
            this.AnteriorMenuPag,
            this.SiguienteMenuPag,
            this.UltimoMenuPag,
            this.IconDetalle});
            this.CtasCtesMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.CtasCtesMenuStrip.Name = "CtasCtesMenuStrip";
            this.CtasCtesMenuStrip.Size = new System.Drawing.Size(914, 82);
            this.CtasCtesMenuStrip.TabIndex = 2;
            this.CtasCtesMenuStrip.Text = "menuStrip1";
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
            // IconDetalle
            // 
            this.IconDetalle.AutoSize = false;
            this.IconDetalle.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.IconDetalle.IconColor = System.Drawing.Color.Black;
            this.IconDetalle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconDetalle.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.IconDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.IconDetalle.Name = "IconDetalle";
            this.IconDetalle.Size = new System.Drawing.Size(152, 70);
            this.IconDetalle.Text = "Detalle";
            this.IconDetalle.Click += new System.EventHandler(this.IconDetalle_Click);
            // 
            // frmCtasCtes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 502);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.CtasCtesMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCtasCtes";
            this.Text = "frmCtasCtes";
            this.Load += new System.EventHandler(this.frmCtasCtes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.CtasCtesMenuStrip.ResumeLayout(false);
            this.CtasCtesMenuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.MenuStrip CtasCtesMenuStrip;
        private FontAwesome.Sharp.IconMenuItem IconNuevo;
        private FontAwesome.Sharp.IconMenuItem EditarMenu;
        private FontAwesome.Sharp.IconMenuItem BorrarMenu;
        private FontAwesome.Sharp.IconMenuItem PrimeroMenuPag;
        private FontAwesome.Sharp.IconMenuItem AnteriorMenuPag;
        private FontAwesome.Sharp.IconMenuItem SiguienteMenuPag;
        private FontAwesome.Sharp.IconMenuItem UltimoMenuPag;
        private FontAwesome.Sharp.IconMenuItem IconDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnSaldo;
    }
}