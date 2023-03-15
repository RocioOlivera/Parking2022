
namespace Parking2022.Windows
{
    partial class frmFinalizarAlquilerAE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFinalizarAlquilerAE));
            this.label7 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.PictureTilde = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.txtFechaIngreso = new System.Windows.Forms.TextBox();
            this.txtNro = new System.Windows.Forms.TextBox();
            this.txtTipoSec = new System.Windows.Forms.TextBox();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.txtTipoVehiculo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotalHoras = new System.Windows.Forms.Label();
            this.cbxImporteAPagar = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.HoraSalidaDtp = new System.Windows.Forms.DateTimePicker();
            this.cbxTiempoTarifa = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GuardarIconButton = new FontAwesome.Sharp.IconButton();
            this.CancelarIconButton = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEfectivo = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label13 = new System.Windows.Forms.Label();
            this.txtVuelto = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDineroRecibido = new System.Windows.Forms.TextBox();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnMercadoPago = new FontAwesome.Sharp.IconButton();
            this.btnTransferencias = new FontAwesome.Sharp.IconButton();
            this.label16 = new System.Windows.Forms.Label();
            this.btnCuentadni = new FontAwesome.Sharp.IconButton();
            this.btnTarjetas = new FontAwesome.Sharp.IconButton();
            this.picCuadroTarifario = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureTilde)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCuadroTarifario)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 17);
            this.label7.TabIndex = 76;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.PictureTilde);
            this.splitContainer1.Panel1.Controls.Add(this.label12);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.cbxTipoVehiculo);
            this.splitContainer1.Panel1.Controls.Add(this.txtFechaIngreso);
            this.splitContainer1.Panel1.Controls.Add(this.txtNro);
            this.splitContainer1.Panel1.Controls.Add(this.txtTipoSec);
            this.splitContainer1.Panel1.Controls.Add(this.txtPatente);
            this.splitContainer1.Panel1.Controls.Add(this.txtTipoVehiculo);
            this.splitContainer1.Panel1.Controls.Add(this.label11);
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.CancelarIconButton);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.lblTotalHoras);
            this.splitContainer1.Panel1.Controls.Add(this.cbxImporteAPagar);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.HoraSalidaDtp);
            this.splitContainer1.Panel1.Controls.Add(this.cbxTiempoTarifa);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.GuardarIconButton);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(845, 567);
            this.splitContainer1.SplitterDistance = 478;
            this.splitContainer1.TabIndex = 89;
            // 
            // PictureTilde
            // 
            this.PictureTilde.BackColor = System.Drawing.Color.Transparent;
            this.PictureTilde.Image = ((System.Drawing.Image)(resources.GetObject("PictureTilde.Image")));
            this.PictureTilde.Location = new System.Drawing.Point(355, 12);
            this.PictureTilde.Margin = new System.Windows.Forms.Padding(0);
            this.PictureTilde.Name = "PictureTilde";
            this.PictureTilde.Size = new System.Drawing.Size(47, 50);
            this.PictureTilde.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureTilde.TabIndex = 112;
            this.PictureTilde.TabStop = false;
            this.PictureTilde.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(101, 251);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(278, 17);
            this.label12.TabIndex = 111;
            this.label12.Text = "- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Copperplate Gothic Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(84, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 28);
            this.label3.TabIndex = 110;
            this.label3.Text = "RETIRAR VEHÍCULO";
            // 
            // cbxTipoVehiculo
            // 
            this.cbxTipoVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoVehiculo.Enabled = false;
            this.cbxTipoVehiculo.FormattingEnabled = true;
            this.cbxTipoVehiculo.Location = new System.Drawing.Point(118, 19);
            this.cbxTipoVehiculo.Name = "cbxTipoVehiculo";
            this.cbxTipoVehiculo.Size = new System.Drawing.Size(141, 24);
            this.cbxTipoVehiculo.TabIndex = 109;
            this.cbxTipoVehiculo.Visible = false;
            this.cbxTipoVehiculo.SelectedIndexChanged += new System.EventHandler(this.cbxTipoVehiculo_SelectedIndexChanged_1);
            // 
            // txtFechaIngreso
            // 
            this.txtFechaIngreso.Location = new System.Drawing.Point(182, 137);
            this.txtFechaIngreso.Name = "txtFechaIngreso";
            this.txtFechaIngreso.Size = new System.Drawing.Size(250, 22);
            this.txtFechaIngreso.TabIndex = 108;
            // 
            // txtNro
            // 
            this.txtNro.Location = new System.Drawing.Point(182, 214);
            this.txtNro.Name = "txtNro";
            this.txtNro.Size = new System.Drawing.Size(131, 22);
            this.txtNro.TabIndex = 107;
            // 
            // txtTipoSec
            // 
            this.txtTipoSec.Location = new System.Drawing.Point(182, 176);
            this.txtTipoSec.Name = "txtTipoSec";
            this.txtTipoSec.Size = new System.Drawing.Size(131, 22);
            this.txtTipoSec.TabIndex = 106;
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(182, 100);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(150, 22);
            this.txtPatente.TabIndex = 105;
            // 
            // txtTipoVehiculo
            // 
            this.txtTipoVehiculo.Location = new System.Drawing.Point(182, 65);
            this.txtTipoVehiculo.Name = "txtTipoVehiculo";
            this.txtTipoVehiculo.Size = new System.Drawing.Size(150, 22);
            this.txtTipoVehiculo.TabIndex = 104;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(40, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 17);
            this.label11.TabIndex = 103;
            this.label11.Text = "Fecha Ingreso:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(75, 216);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 17);
            this.label10.TabIndex = 102;
            this.label10.Text = "Nro. sec:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(54, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 17);
            this.label9.TabIndex = 101;
            this.label9.Text = "Tipo de Sec:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(81, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 17);
            this.label8.TabIndex = 100;
            this.label8.Text = "Patente:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 17);
            this.label6.TabIndex = 99;
            this.label6.Text = "Tipo de Vehiculo:";
            // 
            // lblTotalHoras
            // 
            this.lblTotalHoras.AutoSize = true;
            this.lblTotalHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalHoras.Location = new System.Drawing.Point(157, 326);
            this.lblTotalHoras.Name = "lblTotalHoras";
            this.lblTotalHoras.Size = new System.Drawing.Size(36, 20);
            this.lblTotalHoras.TabIndex = 98;
            this.lblTotalHoras.Text = "___";
            // 
            // cbxImporteAPagar
            // 
            this.cbxImporteAPagar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxImporteAPagar.Enabled = false;
            this.cbxImporteAPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxImporteAPagar.FormattingEnabled = true;
            this.cbxImporteAPagar.Location = new System.Drawing.Point(283, 445);
            this.cbxImporteAPagar.Name = "cbxImporteAPagar";
            this.cbxImporteAPagar.Size = new System.Drawing.Size(126, 28);
            this.cbxImporteAPagar.TabIndex = 97;
            this.cbxImporteAPagar.SelectedIndexChanged += new System.EventHandler(this.cbxImporteAPagar_SelectedIndexChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(112, 450);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 19);
            this.label5.TabIndex = 96;
            this.label5.Text = "IMPORTE A PAGAR:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // HoraSalidaDtp
            // 
            this.HoraSalidaDtp.Enabled = false;
            this.HoraSalidaDtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoraSalidaDtp.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.HoraSalidaDtp.Location = new System.Drawing.Point(159, 284);
            this.HoraSalidaDtp.Name = "HoraSalidaDtp";
            this.HoraSalidaDtp.ShowUpDown = true;
            this.HoraSalidaDtp.Size = new System.Drawing.Size(120, 27);
            this.HoraSalidaDtp.TabIndex = 95;
            // 
            // cbxTiempoTarifa
            // 
            this.cbxTiempoTarifa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTiempoTarifa.FormattingEnabled = true;
            this.cbxTiempoTarifa.Location = new System.Drawing.Point(53, 409);
            this.cbxTiempoTarifa.Name = "cbxTiempoTarifa";
            this.cbxTiempoTarifa.Size = new System.Drawing.Size(218, 24);
            this.cbxTiempoTarifa.TabIndex = 94;
            this.cbxTiempoTarifa.SelectedIndexChanged += new System.EventHandler(this.cbxTiempoTarifa_SelectedIndexChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 93;
            this.label4.Text = "Total de Horas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 92;
            this.label2.Text = "Hora de Retiro:";
            // 
            // GuardarIconButton
            // 
            this.GuardarIconButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.GuardarIconButton.ForeColor = System.Drawing.Color.White;
            this.GuardarIconButton.IconChar = FontAwesome.Sharp.IconChar.ChevronCircleRight;
            this.GuardarIconButton.IconColor = System.Drawing.Color.White;
            this.GuardarIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.GuardarIconButton.IconSize = 30;
            this.GuardarIconButton.Location = new System.Drawing.Point(307, 498);
            this.GuardarIconButton.Margin = new System.Windows.Forms.Padding(4);
            this.GuardarIconButton.Name = "GuardarIconButton";
            this.GuardarIconButton.Size = new System.Drawing.Size(145, 58);
            this.GuardarIconButton.TabIndex = 91;
            this.GuardarIconButton.Text = "CONTINUAR";
            this.GuardarIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.GuardarIconButton.UseVisualStyleBackColor = false;
            this.GuardarIconButton.Click += new System.EventHandler(this.GuardarIconButton_Click_1);
            // 
            // CancelarIconButton
            // 
            this.CancelarIconButton.BackColor = System.Drawing.Color.Red;
            this.CancelarIconButton.ForeColor = System.Drawing.Color.White;
            this.CancelarIconButton.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.CancelarIconButton.IconColor = System.Drawing.Color.White;
            this.CancelarIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CancelarIconButton.Location = new System.Drawing.Point(13, 498);
            this.CancelarIconButton.Margin = new System.Windows.Forms.Padding(4);
            this.CancelarIconButton.Name = "CancelarIconButton";
            this.CancelarIconButton.Size = new System.Drawing.Size(62, 58);
            this.CancelarIconButton.TabIndex = 90;
            this.CancelarIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CancelarIconButton.UseVisualStyleBackColor = false;
            this.CancelarIconButton.Click += new System.EventHandler(this.CancelarIconButton_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 20);
            this.label1.TabIndex = 89;
            this.label1.Text = "Seleccione el tipo de Tarifa:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picCuadroTarifario);
            this.groupBox1.Controls.Add(this.btnTarjetas);
            this.groupBox1.Controls.Add(this.btnCuentadni);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.btnTransferencias);
            this.groupBox1.Controls.Add(this.btnMercadoPago);
            this.groupBox1.Controls.Add(this.btnEfectivo);
            this.groupBox1.Controls.Add(this.iconButton1);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtVuelto);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtDineroRecibido);
            this.groupBox1.Controls.Add(this.txtImporte);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Location = new System.Drawing.Point(9, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 553);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CONCRETAR PAGO";
            // 
            // btnEfectivo
            // 
            this.btnEfectivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEfectivo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEfectivo.BackgroundImage")));
            this.btnEfectivo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEfectivo.Enabled = false;
            this.btnEfectivo.ForeColor = System.Drawing.Color.White;
            this.btnEfectivo.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.btnEfectivo.IconColor = System.Drawing.Color.Transparent;
            this.btnEfectivo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEfectivo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEfectivo.Location = new System.Drawing.Point(9, 142);
            this.btnEfectivo.Margin = new System.Windows.Forms.Padding(4);
            this.btnEfectivo.Name = "btnEfectivo";
            this.btnEfectivo.Size = new System.Drawing.Size(104, 52);
            this.btnEfectivo.TabIndex = 113;
            this.btnEfectivo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEfectivo.UseVisualStyleBackColor = false;
            this.btnEfectivo.Click += new System.EventHandler(this.btnEfectivo_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.iconButton1.Enabled = false;
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButton1.Location = new System.Drawing.Point(87, 393);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(4);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(178, 52);
            this.iconButton1.TabIndex = 112;
            this.iconButton1.Text = "FINALIZAR RETIRO";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(79, 483);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(186, 23);
            this.label13.TabIndex = 11;
            this.label13.Text = "Vuelto a entregar:";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // txtVuelto
            // 
            this.txtVuelto.Enabled = false;
            this.txtVuelto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVuelto.Location = new System.Drawing.Point(60, 509);
            this.txtVuelto.Name = "txtVuelto";
            this.txtVuelto.Size = new System.Drawing.Size(221, 34);
            this.txtVuelto.TabIndex = 10;
            this.txtVuelto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(27, 290);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(289, 23);
            this.label14.TabIndex = 9;
            this.label14.Text = "- Ingrese el dinero recibido -";
            // 
            // txtDineroRecibido
            // 
            this.txtDineroRecibido.Enabled = false;
            this.txtDineroRecibido.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDineroRecibido.Location = new System.Drawing.Point(60, 316);
            this.txtDineroRecibido.Name = "txtDineroRecibido";
            this.txtDineroRecibido.Size = new System.Drawing.Size(221, 34);
            this.txtDineroRecibido.TabIndex = 8;
            this.txtDineroRecibido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtImporte
            // 
            this.txtImporte.Enabled = false;
            this.txtImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImporte.Location = new System.Drawing.Point(54, 54);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(221, 34);
            this.txtImporte.TabIndex = 7;
            this.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(75, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(181, 23);
            this.label15.TabIndex = 6;
            this.label15.Text = "Importe a cobrar:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnMercadoPago
            // 
            this.btnMercadoPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnMercadoPago.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMercadoPago.BackgroundImage")));
            this.btnMercadoPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMercadoPago.Enabled = false;
            this.btnMercadoPago.ForeColor = System.Drawing.Color.White;
            this.btnMercadoPago.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.btnMercadoPago.IconColor = System.Drawing.Color.Transparent;
            this.btnMercadoPago.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMercadoPago.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMercadoPago.Location = new System.Drawing.Point(121, 142);
            this.btnMercadoPago.Margin = new System.Windows.Forms.Padding(4);
            this.btnMercadoPago.Name = "btnMercadoPago";
            this.btnMercadoPago.Size = new System.Drawing.Size(104, 52);
            this.btnMercadoPago.TabIndex = 114;
            this.btnMercadoPago.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMercadoPago.UseVisualStyleBackColor = false;
            // 
            // btnTransferencias
            // 
            this.btnTransferencias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTransferencias.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTransferencias.BackgroundImage")));
            this.btnTransferencias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTransferencias.Enabled = false;
            this.btnTransferencias.ForeColor = System.Drawing.Color.White;
            this.btnTransferencias.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.btnTransferencias.IconColor = System.Drawing.Color.Transparent;
            this.btnTransferencias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTransferencias.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTransferencias.Location = new System.Drawing.Point(64, 201);
            this.btnTransferencias.Margin = new System.Windows.Forms.Padding(4);
            this.btnTransferencias.Name = "btnTransferencias";
            this.btnTransferencias.Size = new System.Drawing.Size(104, 52);
            this.btnTransferencias.TabIndex = 115;
            this.btnTransferencias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTransferencias.UseVisualStyleBackColor = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(4, 115);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(337, 23);
            this.label16.TabIndex = 116;
            this.label16.Text = "- Seleccione un medio de pago -";
            // 
            // btnCuentadni
            // 
            this.btnCuentadni.BackColor = System.Drawing.Color.White;
            this.btnCuentadni.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCuentadni.BackgroundImage")));
            this.btnCuentadni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCuentadni.Enabled = false;
            this.btnCuentadni.ForeColor = System.Drawing.Color.White;
            this.btnCuentadni.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.btnCuentadni.IconColor = System.Drawing.Color.Transparent;
            this.btnCuentadni.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCuentadni.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCuentadni.Location = new System.Drawing.Point(233, 142);
            this.btnCuentadni.Margin = new System.Windows.Forms.Padding(4);
            this.btnCuentadni.Name = "btnCuentadni";
            this.btnCuentadni.Size = new System.Drawing.Size(104, 52);
            this.btnCuentadni.TabIndex = 117;
            this.btnCuentadni.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCuentadni.UseVisualStyleBackColor = false;
            // 
            // btnTarjetas
            // 
            this.btnTarjetas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTarjetas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTarjetas.BackgroundImage")));
            this.btnTarjetas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTarjetas.Enabled = false;
            this.btnTarjetas.ForeColor = System.Drawing.Color.White;
            this.btnTarjetas.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.btnTarjetas.IconColor = System.Drawing.Color.Transparent;
            this.btnTarjetas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTarjetas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTarjetas.Location = new System.Drawing.Point(176, 201);
            this.btnTarjetas.Margin = new System.Windows.Forms.Padding(4);
            this.btnTarjetas.Name = "btnTarjetas";
            this.btnTarjetas.Size = new System.Drawing.Size(104, 52);
            this.btnTarjetas.TabIndex = 118;
            this.btnTarjetas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTarjetas.UseVisualStyleBackColor = false;
            // 
            // picCuadroTarifario
            // 
            this.picCuadroTarifario.Image = ((System.Drawing.Image)(resources.GetObject("picCuadroTarifario.Image")));
            this.picCuadroTarifario.Location = new System.Drawing.Point(-10, -4);
            this.picCuadroTarifario.Name = "picCuadroTarifario";
            this.picCuadroTarifario.Size = new System.Drawing.Size(364, 564);
            this.picCuadroTarifario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picCuadroTarifario.TabIndex = 113;
            this.picCuadroTarifario.TabStop = false;
            // 
            // frmFinalizarAlquilerAE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(845, 567);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label7);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmFinalizarAlquilerAE";
            this.Text = "FinalizarAlquiler";
            this.Load += new System.EventHandler(this.frmFinalizarAlquiler_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureTilde)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCuadroTarifario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxTipoVehiculo;
        private System.Windows.Forms.TextBox txtFechaIngreso;
        private System.Windows.Forms.TextBox txtNro;
        private System.Windows.Forms.TextBox txtTipoSec;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.TextBox txtTipoVehiculo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotalHoras;
        private System.Windows.Forms.ComboBox cbxImporteAPagar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker HoraSalidaDtp;
        private System.Windows.Forms.ComboBox cbxTiempoTarifa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton GuardarIconButton;
        private FontAwesome.Sharp.IconButton CancelarIconButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtVuelto;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDineroRecibido;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private FontAwesome.Sharp.IconButton btnEfectivo;
        private System.Windows.Forms.PictureBox PictureTilde;
        private FontAwesome.Sharp.IconButton btnTarjetas;
        private FontAwesome.Sharp.IconButton btnCuentadni;
        private System.Windows.Forms.Label label16;
        private FontAwesome.Sharp.IconButton btnTransferencias;
        private FontAwesome.Sharp.IconButton btnMercadoPago;
        private System.Windows.Forms.PictureBox picCuadroTarifario;
    }
}