
namespace Parking2022.Windows
{
    partial class frmFinalizarAlquiler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFinalizarAlquiler));
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TotalHorasDtp = new System.Windows.Forms.DateTimePicker();
            this.HoraSalidaDtp = new System.Windows.Forms.DateTimePicker();
            this.cbxTipoTarifa = new System.Windows.Forms.ComboBox();
            this.txtNoche = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GuardarIconButton = new FontAwesome.Sharp.IconButton();
            this.CancelarIconButton = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(432, 201);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(84, 21);
            this.checkBox2.TabIndex = 62;
            this.checkBox2.Text = "Retirado";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(313, 201);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(79, 21);
            this.checkBox1.TabIndex = 61;
            this.checkBox1.Text = "Pagado";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(463, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 17);
            this.label5.TabIndex = 60;
            this.label5.Text = "Importe a Pagar:";
            // 
            // TotalHorasDtp
            // 
            this.TotalHorasDtp.Enabled = false;
            this.TotalHorasDtp.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TotalHorasDtp.Location = new System.Drawing.Point(175, 87);
            this.TotalHorasDtp.Name = "TotalHorasDtp";
            this.TotalHorasDtp.ShowUpDown = true;
            this.TotalHorasDtp.Size = new System.Drawing.Size(140, 22);
            this.TotalHorasDtp.TabIndex = 59;
            // 
            // HoraSalidaDtp
            // 
            this.HoraSalidaDtp.Enabled = false;
            this.HoraSalidaDtp.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.HoraSalidaDtp.Location = new System.Drawing.Point(175, 42);
            this.HoraSalidaDtp.Name = "HoraSalidaDtp";
            this.HoraSalidaDtp.ShowUpDown = true;
            this.HoraSalidaDtp.Size = new System.Drawing.Size(140, 22);
            this.HoraSalidaDtp.TabIndex = 58;
            // 
            // cbxTipoTarifa
            // 
            this.cbxTipoTarifa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoTarifa.FormattingEnabled = true;
            this.cbxTipoTarifa.Location = new System.Drawing.Point(582, 36);
            this.cbxTipoTarifa.Name = "cbxTipoTarifa";
            this.cbxTipoTarifa.Size = new System.Drawing.Size(141, 24);
            this.cbxTipoTarifa.TabIndex = 57;
            // 
            // txtNoche
            // 
            this.txtNoche.Enabled = false;
            this.txtNoche.Location = new System.Drawing.Point(582, 89);
            this.txtNoche.Name = "txtNoche";
            this.txtNoche.Size = new System.Drawing.Size(141, 22);
            this.txtNoche.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 55;
            this.label4.Text = "Total de Horas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 54;
            this.label2.Text = "Hora de Retiro:";
            // 
            // GuardarIconButton
            // 
            this.GuardarIconButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.GuardarIconButton.ForeColor = System.Drawing.Color.White;
            this.GuardarIconButton.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.GuardarIconButton.IconColor = System.Drawing.Color.White;
            this.GuardarIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.GuardarIconButton.Location = new System.Drawing.Point(175, 336);
            this.GuardarIconButton.Margin = new System.Windows.Forms.Padding(4);
            this.GuardarIconButton.Name = "GuardarIconButton";
            this.GuardarIconButton.Size = new System.Drawing.Size(161, 73);
            this.GuardarIconButton.TabIndex = 53;
            this.GuardarIconButton.Text = "Guardar";
            this.GuardarIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GuardarIconButton.UseVisualStyleBackColor = false;
            // 
            // CancelarIconButton
            // 
            this.CancelarIconButton.BackColor = System.Drawing.Color.Red;
            this.CancelarIconButton.ForeColor = System.Drawing.Color.White;
            this.CancelarIconButton.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.CancelarIconButton.IconColor = System.Drawing.Color.White;
            this.CancelarIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CancelarIconButton.Location = new System.Drawing.Point(486, 336);
            this.CancelarIconButton.Margin = new System.Windows.Forms.Padding(4);
            this.CancelarIconButton.Name = "CancelarIconButton";
            this.CancelarIconButton.Size = new System.Drawing.Size(161, 73);
            this.CancelarIconButton.TabIndex = 52;
            this.CancelarIconButton.Text = "Cancelar";
            this.CancelarIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CancelarIconButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(475, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 51;
            this.label1.Text = "Tipo de Tarifa:";
            // 
            // frmFinalizarAlquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TotalHorasDtp);
            this.Controls.Add(this.HoraSalidaDtp);
            this.Controls.Add(this.cbxTipoTarifa);
            this.Controls.Add(this.txtNoche);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GuardarIconButton);
            this.Controls.Add(this.CancelarIconButton);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFinalizarAlquiler";
            this.Text = "FinalizarAlquiler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker TotalHorasDtp;
        private System.Windows.Forms.DateTimePicker HoraSalidaDtp;
        private System.Windows.Forms.ComboBox cbxTipoTarifa;
        private System.Windows.Forms.TextBox txtNoche;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton GuardarIconButton;
        private FontAwesome.Sharp.IconButton CancelarIconButton;
        private System.Windows.Forms.Label label1;
    }
}