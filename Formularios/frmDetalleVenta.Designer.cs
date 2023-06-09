﻿using GerizimZZ.Clases;

namespace GerizimZZ
{
    partial class frmDetalleVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetalleVenta));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Imprimir = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.cmbPago = new System.Windows.Forms.ComboBox();
            this.delivery = new System.Windows.Forms.CheckBox();
            this.facturaLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCancelarVenta = new System.Windows.Forms.Button();
            this.btnGenerarVenta = new System.Windows.Forms.Button();
            this.dgDetalleVenta = new System.Windows.Forms.DataGridView();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCodigoCliente = new System.Windows.Forms.Label();
            this.lblCodCliente = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnNuevaDireccion = new System.Windows.Forms.Button();
            this.btnNuevoTelefono = new System.Windows.Forms.Button();
            this.cmbNumero = new System.Windows.Forms.ComboBox();
            this.cmbDireccion = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.clientedstBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NuevoCliente = new System.Windows.Forms.Button();
            this.lblNumeroFactura = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgProductos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalleVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientedstBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::GerizimZZ.Properties.Resources.logoComprimido;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1315, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Imprimir
            // 
            this.Imprimir.DocumentName = "Factura";
            this.Imprimir.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // cmbPago
            // 
            this.cmbPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPago.FormattingEnabled = true;
            this.cmbPago.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta ",
            "Credito"});
            this.cmbPago.Location = new System.Drawing.Point(146, 33);
            this.cmbPago.Name = "cmbPago";
            this.cmbPago.Size = new System.Drawing.Size(121, 26);
            this.cmbPago.TabIndex = 7;
            // 
            // delivery
            // 
            this.delivery.AutoSize = true;
            this.delivery.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.delivery.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.delivery.ForeColor = System.Drawing.Color.DarkGreen;
            this.delivery.Location = new System.Drawing.Point(12, 27);
            this.delivery.Name = "delivery";
            this.delivery.Size = new System.Drawing.Size(73, 22);
            this.delivery.TabIndex = 9;
            this.delivery.Text = "Delivery";
            this.delivery.UseVisualStyleBackColor = true;
            this.delivery.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // facturaLbl
            // 
            this.facturaLbl.AutoSize = true;
            this.facturaLbl.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.facturaLbl.ForeColor = System.Drawing.Color.DarkBlue;
            this.facturaLbl.Location = new System.Drawing.Point(906, 102);
            this.facturaLbl.Name = "facturaLbl";
            this.facturaLbl.Size = new System.Drawing.Size(98, 24);
            this.facturaLbl.TabIndex = 18;
            this.facturaLbl.Text = "Factura #";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(297, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 18);
            this.label5.TabIndex = 21;
            this.label5.Text = "Nombre del cliente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 18);
            this.label6.TabIndex = 22;
            this.label6.Text = "Forma de pago";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Garamond", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(25, 461);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 27);
            this.label7.TabIndex = 23;
            this.label7.Text = "Total";
            // 
            // btnCancelarVenta
            // 
            this.btnCancelarVenta.BackColor = System.Drawing.Color.LightGray;
            this.btnCancelarVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancelarVenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCancelarVenta.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancelarVenta.ForeColor = System.Drawing.Color.Blue;
            this.btnCancelarVenta.Location = new System.Drawing.Point(0, 68);
            this.btnCancelarVenta.Name = "btnCancelarVenta";
            this.btnCancelarVenta.Size = new System.Drawing.Size(126, 69);
            this.btnCancelarVenta.TabIndex = 2;
            this.btnCancelarVenta.Text = "Cancelar Venta";
            this.btnCancelarVenta.UseVisualStyleBackColor = false;
            this.btnCancelarVenta.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnGenerarVenta
            // 
            this.btnGenerarVenta.BackColor = System.Drawing.Color.LightGray;
            this.btnGenerarVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGenerarVenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGenerarVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnGenerarVenta.Location = new System.Drawing.Point(0, 137);
            this.btnGenerarVenta.Name = "btnGenerarVenta";
            this.btnGenerarVenta.Size = new System.Drawing.Size(126, 69);
            this.btnGenerarVenta.TabIndex = 3;
            this.btnGenerarVenta.Text = "Generar Venta";
            this.btnGenerarVenta.UseVisualStyleBackColor = false;
            this.btnGenerarVenta.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgDetalleVenta
            // 
            this.dgDetalleVenta.AllowUserToAddRows = false;
            this.dgDetalleVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDetalleVenta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgDetalleVenta.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetalleVenta.Location = new System.Drawing.Point(906, 131);
            this.dgDetalleVenta.Name = "dgDetalleVenta";
            this.dgDetalleVenta.RowTemplate.Height = 25;
            this.dgDetalleVenta.Size = new System.Drawing.Size(353, 565);
            this.dgDetalleVenta.TabIndex = 16;
            this.dgDetalleVenta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDetalleVenta_CellContentClick_1);
            this.dgDetalleVenta.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgDetalleVenta_RowsAdded);
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataSource = typeof(GerizimZZ.Clases.Productos);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightGray;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button4.Location = new System.Drawing.Point(0, 273);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(126, 79);
            this.button4.TabIndex = 5;
            this.button4.Text = "Escanear Código";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblHora.Location = new System.Drawing.Point(373, 131);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(43, 18);
            this.lblHora.TabIndex = 33;
            this.lblHora.Text = "label3";
            this.lblHora.Click += new System.EventHandler(this.lblHora_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFecha.Location = new System.Drawing.Point(373, 108);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(55, 18);
            this.lblFecha.TabIndex = 34;
            this.lblFecha.Text = "label10";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCodigoCliente);
            this.groupBox1.Controls.Add(this.lblCodCliente);
            this.groupBox1.Controls.Add(this.cmbCliente);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbPago);
            this.groupBox1.Location = new System.Drawing.Point(161, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(739, 113);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese todos los datos";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblCodigoCliente
            // 
            this.lblCodigoCliente.AutoSize = true;
            this.lblCodigoCliente.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCodigoCliente.ForeColor = System.Drawing.Color.Blue;
            this.lblCodigoCliente.Location = new System.Drawing.Point(438, 71);
            this.lblCodigoCliente.Name = "lblCodigoCliente";
            this.lblCodigoCliente.Size = new System.Drawing.Size(24, 18);
            this.lblCodigoCliente.TabIndex = 25;
            this.lblCodigoCliente.Text = "00";
            this.lblCodigoCliente.Visible = false;
            // 
            // lblCodCliente
            // 
            this.lblCodCliente.AutoSize = true;
            this.lblCodCliente.Location = new System.Drawing.Point(297, 71);
            this.lblCodCliente.Name = "lblCodCliente";
            this.lblCodCliente.Size = new System.Drawing.Size(102, 18);
            this.lblCodCliente.TabIndex = 24;
            this.lblCodCliente.Text = "Código Cliente";
            this.lblCodCliente.Visible = false;
            // 
            // cmbCliente
            // 
            this.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(438, 36);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(287, 26);
            this.cmbCliente.TabIndex = 8;
            this.cmbCliente.SelectedIndexChanged += new System.EventHandler(this.cmbCliente_SelectedIndexChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.btnNuevaDireccion);
            this.groupBox2.Controls.Add(this.btnNuevoTelefono);
            this.groupBox2.Controls.Add(this.cmbNumero);
            this.groupBox2.Controls.Add(this.cmbDireccion);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.delivery);
            this.groupBox2.Location = new System.Drawing.Point(161, 283);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(739, 110);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion De Envio";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GerizimZZ.Properties.Resources.The_Importance_of_Delivery_Services_during_COVID_19_1024x682;
            this.pictureBox2.Location = new System.Drawing.Point(14, 54);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(79, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // btnNuevaDireccion
            // 
            this.btnNuevaDireccion.Location = new System.Drawing.Point(569, 60);
            this.btnNuevaDireccion.Name = "btnNuevaDireccion";
            this.btnNuevaDireccion.Size = new System.Drawing.Size(126, 35);
            this.btnNuevaDireccion.TabIndex = 13;
            this.btnNuevaDireccion.Text = "Otra dirección";
            this.btnNuevaDireccion.UseVisualStyleBackColor = true;
            this.btnNuevaDireccion.Visible = false;
            this.btnNuevaDireccion.Click += new System.EventHandler(this.btnNuevaDireccion_Click);
            // 
            // btnNuevoTelefono
            // 
            this.btnNuevoTelefono.Location = new System.Drawing.Point(569, 20);
            this.btnNuevoTelefono.Name = "btnNuevoTelefono";
            this.btnNuevoTelefono.Size = new System.Drawing.Size(126, 35);
            this.btnNuevoTelefono.TabIndex = 12;
            this.btnNuevoTelefono.Text = "Otro Teléfono";
            this.btnNuevoTelefono.UseVisualStyleBackColor = true;
            this.btnNuevoTelefono.Visible = false;
            this.btnNuevoTelefono.Click += new System.EventHandler(this.btnNuevoTelefono_Click);
            // 
            // cmbNumero
            // 
            this.cmbNumero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNumero.FormattingEnabled = true;
            this.cmbNumero.Location = new System.Drawing.Point(221, 25);
            this.cmbNumero.Name = "cmbNumero";
            this.cmbNumero.Size = new System.Drawing.Size(178, 26);
            this.cmbNumero.TabIndex = 10;
            // 
            // cmbDireccion
            // 
            this.cmbDireccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDireccion.FormattingEnabled = true;
            this.cmbDireccion.Location = new System.Drawing.Point(221, 60);
            this.cmbDireccion.Name = "cmbDireccion";
            this.cmbDireccion.Size = new System.Drawing.Size(306, 26);
            this.cmbDireccion.TabIndex = 11;
            this.cmbDireccion.SelectedIndexChanged += new System.EventHandler(this.cmbDireccion_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(117, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 18);
            this.label10.TabIndex = 18;
            this.label10.Text = "Dirección";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Teléfono";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightGray;
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button3.Location = new System.Drawing.Point(0, 206);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 67);
            this.button3.TabIndex = 4;
            this.button3.Text = "Actualizar Información";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // clientedstBindingSource
            // 
            this.clientedstBindingSource.DataSource = typeof(GerizimZZ.Clientedst);
            this.clientedstBindingSource.Position = 0;
            // 
            // NuevoCliente
            // 
            this.NuevoCliente.BackColor = System.Drawing.Color.LightGray;
            this.NuevoCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.NuevoCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.NuevoCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.NuevoCliente.Location = new System.Drawing.Point(0, 0);
            this.NuevoCliente.Name = "NuevoCliente";
            this.NuevoCliente.Size = new System.Drawing.Size(126, 68);
            this.NuevoCliente.TabIndex = 1;
            this.NuevoCliente.Text = "Nuevo Cliente";
            this.NuevoCliente.UseVisualStyleBackColor = false;
            this.NuevoCliente.Click += new System.EventHandler(this.NuevoCliente_Click);
            // 
            // lblNumeroFactura
            // 
            this.lblNumeroFactura.AutoSize = true;
            this.lblNumeroFactura.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNumeroFactura.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblNumeroFactura.Location = new System.Drawing.Point(1010, 102);
            this.lblNumeroFactura.Name = "lblNumeroFactura";
            this.lblNumeroFactura.Size = new System.Drawing.Size(30, 24);
            this.lblNumeroFactura.TabIndex = 39;
            this.lblNumeroFactura.Text = "00";
            this.lblNumeroFactura.Click += new System.EventHandler(this.lblNumeroFactura_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btnGenerarVenta);
            this.panel1.Controls.Add(this.btnCancelarVenta);
            this.panel1.Controls.Add(this.NuevoCliente);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(126, 637);
            this.panel1.TabIndex = 40;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(0, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 79);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ayuda";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.lblTotal.Location = new System.Drawing.Point(3, 527);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(120, 48);
            this.lblTotal.TabIndex = 41;
            this.lblTotal.Text = "L 00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(161, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 21);
            this.label1.TabIndex = 41;
            this.label1.Text = "Fecha y hora actuales";
            // 
            // dgProductos
            // 
            this.dgProductos.AllowUserToAddRows = false;
            this.dgProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgProductos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductos.Location = new System.Drawing.Point(161, 453);
            this.dgProductos.Name = "dgProductos";
            this.dgProductos.RowTemplate.Height = 25;
            this.dgProductos.Size = new System.Drawing.Size(725, 243);
            this.dgProductos.TabIndex = 15;
            this.dgProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProductos_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.ForestGreen;
            this.label2.Location = new System.Drawing.Point(161, 415);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 24);
            this.label2.TabIndex = 43;
            this.label2.Text = "Productos";
            // 
            // frmDetalleVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1315, 724);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgProductos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblNumeroFactura);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.facturaLbl);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.dgDetalleVenta);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDetalleVenta";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerizim | Detalle de venta";
            this.Load += new System.EventHandler(this.DetalleVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalleVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientedstBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private PrintPreviewDialog printPreviewDialog1;
        private ComboBox cmbPago;
        private CheckBox delivery;
        private Label facturaLbl;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnCancelarVenta;
        private Button btnGenerarVenta;
        private EventHandler button1_Click;
        public DataGridView dgDetalleVenta;
        private Button button4;
        private BindingSource productosBindingSource;
        public System.Drawing.Printing.PrintDocument Imprimir;
        private Label lblHora;
        private Label lblFecha;
        private System.Windows.Forms.Timer timer1;
        private GroupBox groupBox1;
        private ErrorProvider errorProvider1;
        private GroupBox groupBox2;
        private Label label3;
        private Label label10;
        private Button button3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private ComboBox cmbCliente;
        private BindingSource clientedstBindingSource;
        private Label lblCodCliente;
        private Button NuevoCliente;
        private Label lblNumeroFactura;
        private Label lblCodigoCliente;
        private Panel panel1;
        private Label lblTotal;
        private ComboBox cmbDireccion;
        private ComboBox cmbNumero;
        private Button btnNuevoTelefono;
        private Button btnNuevaDireccion;
        private Label label1;
        public DataGridView dgProductos;
        private Label label2;
        private Button button1;
        private PictureBox pictureBox2;
    }
}