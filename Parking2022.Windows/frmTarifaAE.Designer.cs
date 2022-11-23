
namespace Parking2022.Windows
{
    partial class frmTarifaAE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTarifaAE));
            this.GuardarIconButton = new FontAwesome.Sharp.IconButton();
            this.CancelarIconButton = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMediaEstadia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEstadia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNoche = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSemana = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtQuincena = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
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
            this.GuardarIconButton.Location = new System.Drawing.Point(175, 338);
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
            this.CancelarIconButton.Location = new System.Drawing.Point(478, 338);
            this.CancelarIconButton.Margin = new System.Windows.Forms.Padding(4);
            this.CancelarIconButton.Name = "CancelarIconButton";
            this.CancelarIconButton.Size = new System.Drawing.Size(161, 73);
            this.CancelarIconButton.TabIndex = 15;
            this.CancelarIconButton.Text = "Cancelar";
            this.CancelarIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CancelarIconButton.UseVisualStyleBackColor = false;
            this.CancelarIconButton.Click += new System.EventHandler(this.CancelarIconButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tipo de Vehículo:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(257, 128);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(141, 22);
            this.txtHora.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Hora:   $";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "TARIFAS SEGÚN EL TIEMPO";
            // 
            // txtMediaEstadia
            // 
            this.txtMediaEstadia.Location = new System.Drawing.Point(257, 175);
            this.txtMediaEstadia.Name = "txtMediaEstadia";
            this.txtMediaEstadia.Size = new System.Drawing.Size(141, 22);
            this.txtMediaEstadia.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Media Estadia:   $";
            // 
            // txtEstadia
            // 
            this.txtEstadia.Location = new System.Drawing.Point(257, 223);
            this.txtEstadia.Name = "txtEstadia";
            this.txtEstadia.Size = new System.Drawing.Size(141, 22);
            this.txtEstadia.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Estadia:   $";
            // 
            // txtNoche
            // 
            this.txtNoche.Location = new System.Drawing.Point(257, 266);
            this.txtNoche.Name = "txtNoche";
            this.txtNoche.Size = new System.Drawing.Size(141, 22);
            this.txtNoche.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(178, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "Noche:   $";
            // 
            // txtSemana
            // 
            this.txtSemana.Location = new System.Drawing.Point(539, 128);
            this.txtSemana.Name = "txtSemana";
            this.txtSemana.Size = new System.Drawing.Size(141, 22);
            this.txtSemana.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(449, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "Semana:   $";
            // 
            // txtQuincena
            // 
            this.txtQuincena.Location = new System.Drawing.Point(539, 175);
            this.txtQuincena.Name = "txtQuincena";
            this.txtQuincena.Size = new System.Drawing.Size(141, 22);
            this.txtQuincena.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(444, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 17);
            this.label8.TabIndex = 28;
            this.label8.Text = "Quincena:  $";
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(539, 223);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(141, 22);
            this.txtMes.TabIndex = 31;
            this.txtMes.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(475, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 17);
            this.label9.TabIndex = 30;
            this.label9.Text = "Mes:   $";
            // 
            // cbxTipoVehiculo
            // 
            this.cbxTipoVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoVehiculo.FormattingEnabled = true;
            this.cbxTipoVehiculo.Location = new System.Drawing.Point(297, 42);
            this.cbxTipoVehiculo.Name = "cbxTipoVehiculo";
            this.cbxTipoVehiculo.Size = new System.Drawing.Size(322, 24);
            this.cbxTipoVehiculo.TabIndex = 32;
            this.cbxTipoVehiculo.SelectedIndexChanged += new System.EventHandler(this.cbxTipoVehiculo_SelectedIndexChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmTarifaAE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbxTipoVehiculo);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtQuincena);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSemana);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNoche);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEstadia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMediaEstadia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GuardarIconButton);
            this.Controls.Add(this.CancelarIconButton);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTarifaAE";
            this.Text = "Tarifas";
            this.Load += new System.EventHandler(this.frmTarifaAE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton GuardarIconButton;
        private FontAwesome.Sharp.IconButton CancelarIconButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMediaEstadia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEstadia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNoche;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSemana;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtQuincena;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxTipoVehiculo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}