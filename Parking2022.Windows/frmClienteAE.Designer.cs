
namespace Parking2022.Windows
{
    partial class frmClienteAE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClienteAE));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApellidoYNombre = new System.Windows.Forms.TextBox();
            this.txtNumDocumento = new System.Windows.Forms.TextBox();
            this.txtTelContacto = new System.Windows.Forms.TextBox();
            this.CancelarIconButton = new FontAwesome.Sharp.IconButton();
            this.GuardarIconButton = new FontAwesome.Sharp.IconButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Apellido y Nombres:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Num. de Documento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tel de Contacto:";
            // 
            // txtApellidoYNombre
            // 
            this.txtApellidoYNombre.Location = new System.Drawing.Point(243, 63);
            this.txtApellidoYNombre.Name = "txtApellidoYNombre";
            this.txtApellidoYNombre.Size = new System.Drawing.Size(419, 22);
            this.txtApellidoYNombre.TabIndex = 3;
            // 
            // txtNumDocumento
            // 
            this.txtNumDocumento.Location = new System.Drawing.Point(243, 127);
            this.txtNumDocumento.Name = "txtNumDocumento";
            this.txtNumDocumento.Size = new System.Drawing.Size(419, 22);
            this.txtNumDocumento.TabIndex = 4;
            // 
            // txtTelContacto
            // 
            this.txtTelContacto.Location = new System.Drawing.Point(243, 184);
            this.txtTelContacto.Name = "txtTelContacto";
            this.txtTelContacto.Size = new System.Drawing.Size(419, 22);
            this.txtTelContacto.TabIndex = 5;
            // 
            // CancelarIconButton
            // 
            this.CancelarIconButton.BackColor = System.Drawing.Color.Red;
            this.CancelarIconButton.ForeColor = System.Drawing.Color.White;
            this.CancelarIconButton.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.CancelarIconButton.IconColor = System.Drawing.Color.White;
            this.CancelarIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CancelarIconButton.Location = new System.Drawing.Point(444, 340);
            this.CancelarIconButton.Margin = new System.Windows.Forms.Padding(4);
            this.CancelarIconButton.Name = "CancelarIconButton";
            this.CancelarIconButton.Size = new System.Drawing.Size(161, 73);
            this.CancelarIconButton.TabIndex = 7;
            this.CancelarIconButton.Text = "Cancelar";
            this.CancelarIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CancelarIconButton.UseVisualStyleBackColor = false;
            this.CancelarIconButton.Click += new System.EventHandler(this.CancelarIconButton_Click);
            // 
            // GuardarIconButton
            // 
            this.GuardarIconButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.GuardarIconButton.ForeColor = System.Drawing.Color.White;
            this.GuardarIconButton.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.GuardarIconButton.IconColor = System.Drawing.Color.White;
            this.GuardarIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.GuardarIconButton.Location = new System.Drawing.Point(132, 340);
            this.GuardarIconButton.Margin = new System.Windows.Forms.Padding(4);
            this.GuardarIconButton.Name = "GuardarIconButton";
            this.GuardarIconButton.Size = new System.Drawing.Size(161, 73);
            this.GuardarIconButton.TabIndex = 8;
            this.GuardarIconButton.Text = "Guardar";
            this.GuardarIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GuardarIconButton.UseVisualStyleBackColor = false;
            this.GuardarIconButton.Click += new System.EventHandler(this.GuardarIconButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmClienteAE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(747, 450);
            this.Controls.Add(this.GuardarIconButton);
            this.Controls.Add(this.CancelarIconButton);
            this.Controls.Add(this.txtTelContacto);
            this.Controls.Add(this.txtNumDocumento);
            this.Controls.Add(this.txtApellidoYNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmClienteAE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApellidoYNombre;
        private System.Windows.Forms.TextBox txtNumDocumento;
        private System.Windows.Forms.TextBox txtTelContacto;
        private FontAwesome.Sharp.IconButton CancelarIconButton;
        private FontAwesome.Sharp.IconButton GuardarIconButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}