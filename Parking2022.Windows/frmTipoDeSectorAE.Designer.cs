
namespace Parking2022.Windows
{
    partial class frmTipoDeSectorAE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTipoDeSectorAE));
            this.GuardarIconButton = new FontAwesome.Sharp.IconButton();
            this.CancelarIconButton = new FontAwesome.Sharp.IconButton();
            this.txtTipoSector = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.GuardarIconButton.Location = new System.Drawing.Point(171, 347);
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
            this.CancelarIconButton.Location = new System.Drawing.Point(483, 347);
            this.CancelarIconButton.Margin = new System.Windows.Forms.Padding(4);
            this.CancelarIconButton.Name = "CancelarIconButton";
            this.CancelarIconButton.Size = new System.Drawing.Size(161, 73);
            this.CancelarIconButton.TabIndex = 15;
            this.CancelarIconButton.Text = "Cancelar";
            this.CancelarIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CancelarIconButton.UseVisualStyleBackColor = false;
            this.CancelarIconButton.Click += new System.EventHandler(this.CancelarIconButton_Click);
            // 
            // txtTipoSector
            // 
            this.txtTipoSector.Location = new System.Drawing.Point(265, 73);
            this.txtTipoSector.Name = "txtTipoSector";
            this.txtTipoSector.Size = new System.Drawing.Size(419, 22);
            this.txtTipoSector.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tipo de Sector:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmTipoDeSectorAE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GuardarIconButton);
            this.Controls.Add(this.CancelarIconButton);
            this.Controls.Add(this.txtTipoSector);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTipoDeSectorAE";
            this.Text = "Nuevo Sector";
            this.Load += new System.EventHandler(this.frmTipoDeSectorAE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton GuardarIconButton;
        private FontAwesome.Sharp.IconButton CancelarIconButton;
        private System.Windows.Forms.TextBox txtTipoSector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}