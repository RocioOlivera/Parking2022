
namespace Parking2022.Windows
{
    partial class frmAlquilerDiarioAE
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlquilerDiarioAE));
            this.GuardarIconButton = new FontAwesome.Sharp.IconButton();
            this.CancelarIconButton = new FontAwesome.Sharp.IconButton();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxTipoSector = new System.Windows.Forms.ComboBox();
            this.cbxNroSector = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.FechaDtp = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.ActivoCbx = new System.Windows.Forms.CheckBox();
            this.cbxTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // GuardarIconButton
            // 
            this.GuardarIconButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.GuardarIconButton.ForeColor = System.Drawing.Color.White;
            this.GuardarIconButton.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.GuardarIconButton.IconColor = System.Drawing.Color.White;
            this.GuardarIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.GuardarIconButton.Location = new System.Drawing.Point(156, 380);
            this.GuardarIconButton.Margin = new System.Windows.Forms.Padding(4);
            this.GuardarIconButton.Name = "GuardarIconButton";
            this.GuardarIconButton.Size = new System.Drawing.Size(161, 73);
            this.GuardarIconButton.TabIndex = 16;
            this.GuardarIconButton.Text = "Guardar";
            this.GuardarIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GuardarIconButton.UseVisualStyleBackColor = false;
            this.GuardarIconButton.Click += new System.EventHandler(this.GuardarIconButton_Click);
            // 
            // CancelarIconButton
            // 
            this.CancelarIconButton.BackColor = System.Drawing.Color.Red;
            this.CancelarIconButton.ForeColor = System.Drawing.Color.White;
            this.CancelarIconButton.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.CancelarIconButton.IconColor = System.Drawing.Color.White;
            this.CancelarIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CancelarIconButton.Location = new System.Drawing.Point(474, 380);
            this.CancelarIconButton.Margin = new System.Windows.Forms.Padding(4);
            this.CancelarIconButton.Name = "CancelarIconButton";
            this.CancelarIconButton.Size = new System.Drawing.Size(161, 73);
            this.CancelarIconButton.TabIndex = 15;
            this.CancelarIconButton.Text = "Cancelar";
            this.CancelarIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CancelarIconButton.UseVisualStyleBackColor = false;
            this.CancelarIconButton.Click += new System.EventHandler(this.CancelarIconButton_Click);
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(348, 83);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(224, 22);
            this.txtPatente.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tipo de Sector:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Patente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tipo de Vehiculo";
            // 
            // cbxTipoSector
            // 
            this.cbxTipoSector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoSector.FormattingEnabled = true;
            this.cbxTipoSector.Location = new System.Drawing.Point(348, 136);
            this.cbxTipoSector.Name = "cbxTipoSector";
            this.cbxTipoSector.Size = new System.Drawing.Size(224, 24);
            this.cbxTipoSector.TabIndex = 17;
            this.cbxTipoSector.SelectedIndexChanged += new System.EventHandler(this.cbxTipoSector_SelectedIndexChanged);
            // 
            // cbxNroSector
            // 
            this.cbxNroSector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNroSector.FormattingEnabled = true;
            this.cbxNroSector.Location = new System.Drawing.Point(348, 190);
            this.cbxNroSector.Name = "cbxNroSector";
            this.cbxNroSector.Size = new System.Drawing.Size(224, 24);
            this.cbxNroSector.TabIndex = 19;
            this.cbxNroSector.SelectedIndexChanged += new System.EventHandler(this.cbxNroSector_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Nro del Sector:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(180, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Fecha de Ingreso:";
            // 
            // FechaDtp
            // 
            this.FechaDtp.Enabled = false;
            this.FechaDtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDtp.Location = new System.Drawing.Point(348, 248);
            this.FechaDtp.Name = "FechaDtp";
            this.FechaDtp.Size = new System.Drawing.Size(224, 22);
            this.FechaDtp.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(252, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Activo:";
            // 
            // ActivoCbx
            // 
            this.ActivoCbx.AutoSize = true;
            this.ActivoCbx.Checked = true;
            this.ActivoCbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ActivoCbx.Enabled = false;
            this.ActivoCbx.Location = new System.Drawing.Point(348, 312);
            this.ActivoCbx.Name = "ActivoCbx";
            this.ActivoCbx.Size = new System.Drawing.Size(18, 17);
            this.ActivoCbx.TabIndex = 23;
            this.ActivoCbx.UseVisualStyleBackColor = true;
            // 
            // cbxTipoVehiculo
            // 
            this.cbxTipoVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoVehiculo.FormattingEnabled = true;
            this.cbxTipoVehiculo.Location = new System.Drawing.Point(348, 28);
            this.cbxTipoVehiculo.Name = "cbxTipoVehiculo";
            this.cbxTipoVehiculo.Size = new System.Drawing.Size(224, 24);
            this.cbxTipoVehiculo.TabIndex = 24;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAlquilerDiarioAE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 501);
            this.Controls.Add(this.cbxTipoVehiculo);
            this.Controls.Add(this.ActivoCbx);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.FechaDtp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxNroSector);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxTipoSector);
            this.Controls.Add(this.GuardarIconButton);
            this.Controls.Add(this.CancelarIconButton);
            this.Controls.Add(this.txtPatente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "frmAlquilerDiarioAE";
            this.Text = "Nuevo Alquiler Diario";
            this.Load += new System.EventHandler(this.frmAlquilerDiarioAE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton GuardarIconButton;
        private FontAwesome.Sharp.IconButton CancelarIconButton;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxTipoSector;
        private System.Windows.Forms.ComboBox cbxNroSector;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker FechaDtp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox ActivoCbx;
        private System.Windows.Forms.ComboBox cbxTipoVehiculo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}