
namespace Parking2022.Windows
{
    partial class frmDetalleCtaCte
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label address1Label;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetalleCtaCte));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTelDeContacto = new System.Windows.Forms.TextBox();
            this.txtApellidoYNombre = new System.Windows.Forms.TextBox();
            this.txtNumDocumento = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnIngresarPago = new System.Windows.Forms.Button();
            this.dgDatos = new System.Windows.Forms.DataGridView();
            this.cmnFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnDebe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnHaber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nameLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            address1Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(24, 28);
            nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(127, 17);
            nameLabel.TabIndex = 18;
            nameLabel.Text = "Apellido y Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(27, 94);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(116, 17);
            label1.TabIndex = 20;
            label1.Text = "Tel. de Contacto:";
            // 
            // address1Label
            // 
            address1Label.AutoSize = true;
            address1Label.Location = new System.Drawing.Point(27, 62);
            address1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            address1Label.Name = "address1Label";
            address1Label.Size = new System.Drawing.Size(121, 17);
            address1Label.TabIndex = 20;
            address1Label.Text = "Num. Documento:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnOK);
            this.splitContainer1.Panel2.Controls.Add(this.btnCancelar);
            this.splitContainer1.Panel2.Controls.Add(this.txtSaldo);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.btnIngresarPago);
            this.splitContainer1.Panel2.Controls.Add(this.dgDatos);
            this.splitContainer1.Size = new System.Drawing.Size(805, 542);
            this.splitContainer1.SplitterDistance = 147;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(nameLabel);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(address1Label);
            this.groupBox1.Controls.Add(this.txtTelDeContacto);
            this.groupBox1.Controls.Add(this.txtApellidoYNombre);
            this.groupBox1.Controls.Add(this.txtNumDocumento);
            this.groupBox1.Location = new System.Drawing.Point(14, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(709, 138);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Cliente ";
            // 
            // txtTelDeContacto
            // 
            this.txtTelDeContacto.Location = new System.Drawing.Point(220, 88);
            this.txtTelDeContacto.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelDeContacto.Name = "txtTelDeContacto";
            this.txtTelDeContacto.ReadOnly = true;
            this.txtTelDeContacto.Size = new System.Drawing.Size(451, 22);
            this.txtTelDeContacto.TabIndex = 21;
            this.txtTelDeContacto.TabStop = false;
            // 
            // txtApellidoYNombre
            // 
            this.txtApellidoYNombre.Location = new System.Drawing.Point(220, 23);
            this.txtApellidoYNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidoYNombre.Name = "txtApellidoYNombre";
            this.txtApellidoYNombre.ReadOnly = true;
            this.txtApellidoYNombre.Size = new System.Drawing.Size(451, 22);
            this.txtApellidoYNombre.TabIndex = 21;
            this.txtApellidoYNombre.TabStop = false;
            // 
            // txtNumDocumento
            // 
            this.txtNumDocumento.Location = new System.Drawing.Point(220, 58);
            this.txtNumDocumento.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumDocumento.Name = "txtNumDocumento";
            this.txtNumDocumento.ReadOnly = true;
            this.txtNumDocumento.Size = new System.Drawing.Size(451, 22);
            this.txtNumDocumento.TabIndex = 21;
            this.txtNumDocumento.TabStop = false;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(190, 302);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(120, 62);
            this.btnOK.TabIndex = 85;
            this.btnOK.Text = "OK";
            this.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(369, 302);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 62);
            this.btnCancelar.TabIndex = 82;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(142, 263);
            this.txtSaldo.Margin = new System.Windows.Forms.Padding(4);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(277, 22);
            this.txtSaldo.TabIndex = 84;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 266);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 83;
            this.label3.Text = "Saldo:";
            // 
            // btnIngresarPago
            // 
            this.btnIngresarPago.Location = new System.Drawing.Point(547, 153);
            this.btnIngresarPago.Margin = new System.Windows.Forms.Padding(4);
            this.btnIngresarPago.Name = "btnIngresarPago";
            this.btnIngresarPago.Size = new System.Drawing.Size(151, 74);
            this.btnIngresarPago.TabIndex = 80;
            this.btnIngresarPago.Text = "Ingresar Pagos";
            this.btnIngresarPago.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnIngresarPago.UseVisualStyleBackColor = true;
            // 
            // dgDatos
            // 
            this.dgDatos.AllowUserToAddRows = false;
            this.dgDatos.AllowUserToDeleteRows = false;
            this.dgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmnFecha,
            this.cmnDebe,
            this.cmnHaber});
            this.dgDatos.Location = new System.Drawing.Point(44, 4);
            this.dgDatos.Margin = new System.Windows.Forms.Padding(4);
            this.dgDatos.Name = "dgDatos";
            this.dgDatos.ReadOnly = true;
            this.dgDatos.RowHeadersVisible = false;
            this.dgDatos.RowHeadersWidth = 51;
            this.dgDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDatos.Size = new System.Drawing.Size(375, 242);
            this.dgDatos.TabIndex = 1;
            // 
            // cmnFecha
            // 
            this.cmnFecha.HeaderText = "Fecha";
            this.cmnFecha.MinimumWidth = 6;
            this.cmnFecha.Name = "cmnFecha";
            this.cmnFecha.ReadOnly = true;
            this.cmnFecha.Width = 125;
            // 
            // cmnDebe
            // 
            this.cmnDebe.HeaderText = "Debe";
            this.cmnDebe.MinimumWidth = 6;
            this.cmnDebe.Name = "cmnDebe";
            this.cmnDebe.ReadOnly = true;
            this.cmnDebe.Width = 125;
            // 
            // cmnHaber
            // 
            this.cmnHaber.HeaderText = "Haber";
            this.cmnHaber.MinimumWidth = 6;
            this.cmnHaber.Name = "cmnHaber";
            this.cmnHaber.ReadOnly = true;
            this.cmnHaber.Width = 125;
            // 
            // frmDetalleCtaCte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 542);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDetalleCtaCte";
            this.Text = "frmDatellaCtaCte";
            this.Load += new System.EventHandler(this.frmDetalleCtaCte_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTelDeContacto;
        private System.Windows.Forms.TextBox txtApellidoYNombre;
        private System.Windows.Forms.TextBox txtNumDocumento;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnIngresarPago;
        private System.Windows.Forms.DataGridView dgDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnDebe;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnHaber;
    }
}