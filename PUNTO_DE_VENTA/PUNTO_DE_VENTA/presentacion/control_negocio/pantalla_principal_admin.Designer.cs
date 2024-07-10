
namespace PUNTO_DE_VENTA.presentacion.control_negocio
{
    partial class pantalla_principal_admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pantalla_principal_admin));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.ic_picture = new FontAwesome.Sharp.IconPictureBox();
            this.timer_cargando = new System.Windows.Forms.Timer(this.components);
            this.panel_menu = new System.Windows.Forms.Panel();
            this.btn_configuracion = new FontAwesome.Sharp.IconButton();
            this.btn_vender = new FontAwesome.Sharp.IconButton();
            this.bt_produc = new FontAwesome.Sharp.IconButton();
            this.btn_reportes = new FontAwesome.Sharp.IconButton();
            this.btn_usuarios = new FontAwesome.Sharp.IconButton();
            this.btn_clientes = new FontAwesome.Sharp.IconButton();
            this.bt_principal = new FontAwesome.Sharp.IconButton();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel_form = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dgv_productos_stock = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.chart_productos_mv = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_tganancias = new System.Windows.Forms.Label();
            this.lbl_tventas = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.chart_ventas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_actual = new System.Windows.Forms.Button();
            this.panel_filtros = new System.Windows.Forms.Panel();
            this.dt_fi = new System.Windows.Forms.DateTimePicker();
            this.dt_ff = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_filtros = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ic_picture)).BeginInit();
            this.panel_menu.SuspendLayout();
            this.panel_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel_form.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos_stock)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_productos_mv)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_ventas)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel_filtros.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(8)))), ((int)(((byte)(19)))));
            this.panel1.Controls.Add(this.lbl_titulo);
            this.panel1.Controls.Add(this.ic_picture);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1249, 89);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(0)))), ((int)(((byte)(57)))));
            this.lbl_titulo.Location = new System.Drawing.Point(161, 21);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(257, 31);
            this.lbl_titulo.TabIndex = 1;
            this.lbl_titulo.Text = "Panel Administrador";
            // 
            // ic_picture
            // 
            this.ic_picture.BackColor = System.Drawing.Color.Transparent;
            this.ic_picture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(0)))), ((int)(((byte)(57)))));
            this.ic_picture.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.ic_picture.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(0)))), ((int)(((byte)(57)))));
            this.ic_picture.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ic_picture.IconSize = 64;
            this.ic_picture.Location = new System.Drawing.Point(51, 12);
            this.ic_picture.Name = "ic_picture";
            this.ic_picture.Size = new System.Drawing.Size(86, 64);
            this.ic_picture.TabIndex = 0;
            this.ic_picture.TabStop = false;
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(21)))), ((int)(((byte)(33)))));
            this.panel_menu.Controls.Add(this.btn_configuracion);
            this.panel_menu.Controls.Add(this.btn_vender);
            this.panel_menu.Controls.Add(this.bt_produc);
            this.panel_menu.Controls.Add(this.btn_reportes);
            this.panel_menu.Controls.Add(this.btn_usuarios);
            this.panel_menu.Controls.Add(this.btn_clientes);
            this.panel_menu.Controls.Add(this.bt_principal);
            this.panel_menu.Controls.Add(this.panel_logo);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_menu.Location = new System.Drawing.Point(1249, 0);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(229, 843);
            this.panel_menu.TabIndex = 2;
            // 
            // btn_configuracion
            // 
            this.btn_configuracion.BackColor = System.Drawing.Color.Transparent;
            this.btn_configuracion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_configuracion.FlatAppearance.BorderSize = 0;
            this.btn_configuracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_configuracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_configuracion.ForeColor = System.Drawing.Color.Silver;
            this.btn_configuracion.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.btn_configuracion.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(0)))), ((int)(((byte)(57)))));
            this.btn_configuracion.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btn_configuracion.IconSize = 37;
            this.btn_configuracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_configuracion.Location = new System.Drawing.Point(0, 509);
            this.btn_configuracion.Name = "btn_configuracion";
            this.btn_configuracion.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btn_configuracion.Size = new System.Drawing.Size(229, 64);
            this.btn_configuracion.TabIndex = 7;
            this.btn_configuracion.Text = "Configuracion";
            this.btn_configuracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_configuracion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_configuracion.UseVisualStyleBackColor = false;
            this.btn_configuracion.Click += new System.EventHandler(this.btn_configuracion_Click);
            // 
            // btn_vender
            // 
            this.btn_vender.BackColor = System.Drawing.Color.Transparent;
            this.btn_vender.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_vender.FlatAppearance.BorderSize = 0;
            this.btn_vender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_vender.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vender.ForeColor = System.Drawing.Color.Silver;
            this.btn_vender.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btn_vender.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(0)))), ((int)(((byte)(57)))));
            this.btn_vender.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btn_vender.IconSize = 37;
            this.btn_vender.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_vender.Location = new System.Drawing.Point(0, 445);
            this.btn_vender.Name = "btn_vender";
            this.btn_vender.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btn_vender.Size = new System.Drawing.Size(229, 64);
            this.btn_vender.TabIndex = 6;
            this.btn_vender.Text = "Vender en caja";
            this.btn_vender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_vender.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_vender.UseVisualStyleBackColor = false;
            this.btn_vender.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // bt_produc
            // 
            this.bt_produc.BackColor = System.Drawing.Color.Transparent;
            this.bt_produc.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_produc.FlatAppearance.BorderSize = 0;
            this.bt_produc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_produc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_produc.ForeColor = System.Drawing.Color.Silver;
            this.bt_produc.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.bt_produc.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(0)))), ((int)(((byte)(57)))));
            this.bt_produc.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.bt_produc.IconSize = 37;
            this.bt_produc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_produc.Location = new System.Drawing.Point(0, 381);
            this.bt_produc.Name = "bt_produc";
            this.bt_produc.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.bt_produc.Size = new System.Drawing.Size(229, 64);
            this.bt_produc.TabIndex = 5;
            this.bt_produc.Text = "Productos";
            this.bt_produc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_produc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_produc.UseVisualStyleBackColor = false;
            this.bt_produc.Click += new System.EventHandler(this.bt_produc_Click);
            // 
            // btn_reportes
            // 
            this.btn_reportes.BackColor = System.Drawing.Color.Transparent;
            this.btn_reportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_reportes.FlatAppearance.BorderSize = 0;
            this.btn_reportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reportes.ForeColor = System.Drawing.Color.Silver;
            this.btn_reportes.IconChar = FontAwesome.Sharp.IconChar.File;
            this.btn_reportes.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(0)))), ((int)(((byte)(57)))));
            this.btn_reportes.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btn_reportes.IconSize = 37;
            this.btn_reportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reportes.Location = new System.Drawing.Point(0, 317);
            this.btn_reportes.Name = "btn_reportes";
            this.btn_reportes.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btn_reportes.Size = new System.Drawing.Size(229, 64);
            this.btn_reportes.TabIndex = 4;
            this.btn_reportes.Text = "Reportes";
            this.btn_reportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_reportes.UseVisualStyleBackColor = false;
            this.btn_reportes.Click += new System.EventHandler(this.btn_reportes_Click);
            // 
            // btn_usuarios
            // 
            this.btn_usuarios.BackColor = System.Drawing.Color.Transparent;
            this.btn_usuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_usuarios.FlatAppearance.BorderSize = 0;
            this.btn_usuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_usuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_usuarios.ForeColor = System.Drawing.Color.Silver;
            this.btn_usuarios.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btn_usuarios.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(0)))), ((int)(((byte)(57)))));
            this.btn_usuarios.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btn_usuarios.IconSize = 37;
            this.btn_usuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_usuarios.Location = new System.Drawing.Point(0, 253);
            this.btn_usuarios.Name = "btn_usuarios";
            this.btn_usuarios.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btn_usuarios.Size = new System.Drawing.Size(229, 64);
            this.btn_usuarios.TabIndex = 3;
            this.btn_usuarios.Text = "Empleados";
            this.btn_usuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_usuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_usuarios.UseVisualStyleBackColor = false;
            this.btn_usuarios.Click += new System.EventHandler(this.btn_usuarios_Click);
            // 
            // btn_clientes
            // 
            this.btn_clientes.BackColor = System.Drawing.Color.Transparent;
            this.btn_clientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_clientes.FlatAppearance.BorderSize = 0;
            this.btn_clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clientes.ForeColor = System.Drawing.Color.Silver;
            this.btn_clientes.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btn_clientes.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(0)))), ((int)(((byte)(57)))));
            this.btn_clientes.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btn_clientes.IconSize = 37;
            this.btn_clientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clientes.Location = new System.Drawing.Point(0, 189);
            this.btn_clientes.Name = "btn_clientes";
            this.btn_clientes.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btn_clientes.Size = new System.Drawing.Size(229, 64);
            this.btn_clientes.TabIndex = 2;
            this.btn_clientes.Text = "Clientes";
            this.btn_clientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_clientes.UseVisualStyleBackColor = false;
            this.btn_clientes.Click += new System.EventHandler(this.btn_clientes_Click);
            // 
            // bt_principal
            // 
            this.bt_principal.BackColor = System.Drawing.Color.Transparent;
            this.bt_principal.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_principal.FlatAppearance.BorderSize = 0;
            this.bt_principal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_principal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_principal.ForeColor = System.Drawing.Color.Silver;
            this.bt_principal.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.bt_principal.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(0)))), ((int)(((byte)(57)))));
            this.bt_principal.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.bt_principal.IconSize = 37;
            this.bt_principal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_principal.Location = new System.Drawing.Point(0, 125);
            this.bt_principal.Name = "bt_principal";
            this.bt_principal.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.bt_principal.Size = new System.Drawing.Size(229, 64);
            this.bt_principal.TabIndex = 1;
            this.bt_principal.Text = "Dashborad";
            this.bt_principal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_principal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_principal.UseVisualStyleBackColor = false;
            this.bt_principal.Click += new System.EventHandler(this.btn_productos_Click);
            // 
            // panel_logo
            // 
            this.panel_logo.Controls.Add(this.pictureBox2);
            this.panel_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_logo.ForeColor = System.Drawing.Color.Silver;
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(229, 125);
            this.panel_logo.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(229, 125);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel_form
            // 
            this.panel_form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.panel_form.Controls.Add(this.panel6);
            this.panel_form.Controls.Add(this.panel3);
            this.panel_form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_form.Location = new System.Drawing.Point(110, 89);
            this.panel_form.Name = "panel_form";
            this.panel_form.Size = new System.Drawing.Size(1029, 754);
            this.panel_form.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 420);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1029, 334);
            this.panel6.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.Controls.Add(this.dgv_productos_stock);
            this.panel8.Controls.Add(this.label5);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(562, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(467, 331);
            this.panel8.TabIndex = 4;
            // 
            // dgv_productos_stock
            // 
            this.dgv_productos_stock.AllowUserToAddRows = false;
            this.dgv_productos_stock.AllowUserToDeleteRows = false;
            this.dgv_productos_stock.AllowUserToResizeColumns = false;
            this.dgv_productos_stock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_productos_stock.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.dgv_productos_stock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_productos_stock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_productos_stock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(0)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_productos_stock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_productos_stock.ColumnHeadersHeight = 24;
            this.dgv_productos_stock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_productos_stock.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_productos_stock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_productos_stock.EnableHeadersVisualStyles = false;
            this.dgv_productos_stock.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(19)))), ((int)(((byte)(35)))));
            this.dgv_productos_stock.Location = new System.Drawing.Point(0, 45);
            this.dgv_productos_stock.MultiSelect = false;
            this.dgv_productos_stock.Name = "dgv_productos_stock";
            this.dgv_productos_stock.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_productos_stock.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_productos_stock.RowHeadersVisible = false;
            this.dgv_productos_stock.RowTemplate.Height = 35;
            this.dgv_productos_stock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_productos_stock.Size = new System.Drawing.Size(467, 286);
            this.dgv_productos_stock.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(467, 45);
            this.label5.TabIndex = 6;
            this.label5.Text = "Productos con stock bajo";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.chart_productos_mv);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(562, 334);
            this.panel7.TabIndex = 3;
            // 
            // chart_productos_mv
            // 
            this.chart_productos_mv.BackColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisX.MajorTickMark.LineWidth = 0;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisY.MajorTickMark.LineWidth = 0;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart_productos_mv.ChartAreas.Add(chartArea1);
            this.chart_productos_mv.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chart_productos_mv.Legends.Add(legend1);
            this.chart_productos_mv.Location = new System.Drawing.Point(0, 0);
            this.chart_productos_mv.Name = "chart_productos_mv";
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            series1.BackSecondaryColor = System.Drawing.Color.Brown;
            series1.BorderColor = System.Drawing.Color.Transparent;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Color = System.Drawing.Color.Magenta;
            series1.IsValueShownAsLabel = true;
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.MarkerColor = System.Drawing.Color.Red;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "Series1";
            series1.YValuesPerPoint = 2;
            this.chart_productos_mv.Series.Add(series1);
            this.chart_productos_mv.Size = new System.Drawing.Size(562, 334);
            this.chart_productos_mv.TabIndex = 0;
            this.chart_productos_mv.Text = "gei";
            title1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Bottom;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.White;
            title1.Name = "Title1";
            title1.Text = "5 Productos mas vendidos";
            this.chart_productos_mv.Titles.Add(title1);
            this.chart_productos_mv.Click += new System.EventHandler(this.chart_productos_mv_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbl_tganancias);
            this.panel3.Controls.Add(this.lbl_tventas);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1029, 420);
            this.panel3.TabIndex = 1;
            // 
            // lbl_tganancias
            // 
            this.lbl_tganancias.AutoSize = true;
            this.lbl_tganancias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tganancias.ForeColor = System.Drawing.Color.LightGray;
            this.lbl_tganancias.Location = new System.Drawing.Point(797, 207);
            this.lbl_tganancias.Name = "lbl_tganancias";
            this.lbl_tganancias.Size = new System.Drawing.Size(20, 24);
            this.lbl_tganancias.TabIndex = 5;
            this.lbl_tganancias.Text = "0";
            // 
            // lbl_tventas
            // 
            this.lbl_tventas.AutoSize = true;
            this.lbl_tventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tventas.ForeColor = System.Drawing.Color.LightGray;
            this.lbl_tventas.Location = new System.Drawing.Point(797, 140);
            this.lbl_tventas.Name = "lbl_tventas";
            this.lbl_tventas.Size = new System.Drawing.Size(20, 24);
            this.lbl_tventas.TabIndex = 4;
            this.lbl_tventas.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(787, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Total de ganancias";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(787, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total de ventas";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.chart_ventas);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 77);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(732, 343);
            this.panel5.TabIndex = 2;
            // 
            // chart_ventas
            // 
            this.chart_ventas.BackColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea2.AxisX.MajorTickMark.LineWidth = 0;
            chartArea2.AxisY.IsLabelAutoFit = false;
            chartArea2.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisY.LineColor = System.Drawing.Color.DimGray;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea2.AxisY.MajorTickMark.LineWidth = 0;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chart_ventas.ChartAreas.Add(chartArea2);
            this.chart_ventas.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend2.ForeColor = System.Drawing.Color.White;
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.chart_ventas.Legends.Add(legend2);
            this.chart_ventas.Location = new System.Drawing.Point(0, 0);
            this.chart_ventas.Name = "chart_ventas";
            series2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            series2.BackSecondaryColor = System.Drawing.Color.Brown;
            series2.BorderColor = System.Drawing.Color.Transparent;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series2.Color = System.Drawing.Color.Magenta;
            series2.IsValueShownAsLabel = true;
            series2.LabelForeColor = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.LegendText = "Monto total";
            series2.MarkerColor = System.Drawing.Color.Red;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.Name = "Series1";
            series2.YValuesPerPoint = 2;
            this.chart_ventas.Series.Add(series2);
            this.chart_ventas.Size = new System.Drawing.Size(732, 343);
            this.chart_ventas.TabIndex = 0;
            this.chart_ventas.Text = "gei";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_actual);
            this.panel4.Controls.Add(this.panel_filtros);
            this.panel4.Controls.Add(this.cb_filtros);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1029, 77);
            this.panel4.TabIndex = 1;
            // 
            // btn_actual
            // 
            this.btn_actual.Location = new System.Drawing.Point(33, 12);
            this.btn_actual.Name = "btn_actual";
            this.btn_actual.Size = new System.Drawing.Size(117, 44);
            this.btn_actual.TabIndex = 6;
            this.btn_actual.Text = "Fecha actual";
            this.btn_actual.UseVisualStyleBackColor = true;
            this.btn_actual.Click += new System.EventHandler(this.btn_actual_Click);
            // 
            // panel_filtros
            // 
            this.panel_filtros.Controls.Add(this.dt_fi);
            this.panel_filtros.Controls.Add(this.dt_ff);
            this.panel_filtros.Controls.Add(this.label1);
            this.panel_filtros.Controls.Add(this.label2);
            this.panel_filtros.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_filtros.Location = new System.Drawing.Point(409, 0);
            this.panel_filtros.Name = "panel_filtros";
            this.panel_filtros.Size = new System.Drawing.Size(620, 77);
            this.panel_filtros.TabIndex = 5;
            this.panel_filtros.Visible = false;
            // 
            // dt_fi
            // 
            this.dt_fi.CalendarTrailingForeColor = System.Drawing.Color.White;
            this.dt_fi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_fi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_fi.Location = new System.Drawing.Point(109, 20);
            this.dt_fi.Name = "dt_fi";
            this.dt_fi.Size = new System.Drawing.Size(200, 27);
            this.dt_fi.TabIndex = 0;
            this.dt_fi.ValueChanged += new System.EventHandler(this.dt_fi_ValueChanged);
            // 
            // dt_ff
            // 
            this.dt_ff.CalendarTitleBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dt_ff.CalendarTitleForeColor = System.Drawing.Color.Transparent;
            this.dt_ff.CalendarTrailingForeColor = System.Drawing.Color.White;
            this.dt_ff.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_ff.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_ff.Location = new System.Drawing.Point(411, 20);
            this.dt_ff.Name = "dt_ff";
            this.dt_ff.Size = new System.Drawing.Size(200, 27);
            this.dt_ff.TabIndex = 1;
            this.dt_ff.ValueChanged += new System.EventHandler(this.dt_ff_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(43, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Desde:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(315, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hasta:";
            // 
            // cb_filtros
            // 
            this.cb_filtros.AutoSize = true;
            this.cb_filtros.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cb_filtros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_filtros.ForeColor = System.Drawing.Color.White;
            this.cb_filtros.Location = new System.Drawing.Point(317, 24);
            this.cb_filtros.Name = "cb_filtros";
            this.cb_filtros.Size = new System.Drawing.Size(71, 24);
            this.cb_filtros.TabIndex = 4;
            this.cb_filtros.Text = "Filtros";
            this.cb_filtros.UseVisualStyleBackColor = true;
            this.cb_filtros.CheckedChanged += new System.EventHandler(this.cb_filtros_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(110, 754);
            this.panel2.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1139, 89);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(110, 754);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // pantalla_principal_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1478, 843);
            this.Controls.Add(this.panel_form);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "pantalla_principal_admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "pantalla_principal_admin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.pantalla_principal_admin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ic_picture)).EndInit();
            this.panel_menu.ResumeLayout(false);
            this.panel_logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel_form.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos_stock)).EndInit();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_productos_mv)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_ventas)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel_filtros.ResumeLayout(false);
            this.panel_filtros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer_cargando;
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Panel panel_logo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private FontAwesome.Sharp.IconPictureBox ic_picture;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Panel panel_form;
        private FontAwesome.Sharp.IconButton bt_produc;
        private FontAwesome.Sharp.IconButton btn_reportes;
        private FontAwesome.Sharp.IconButton btn_usuarios;
        private FontAwesome.Sharp.IconButton btn_clientes;
        private FontAwesome.Sharp.IconButton bt_principal;
        private FontAwesome.Sharp.IconButton btn_vender;
        private FontAwesome.Sharp.IconButton btn_configuracion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dt_ff;
        private System.Windows.Forms.DateTimePicker dt_fi;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_ventas;
        private System.Windows.Forms.CheckBox cb_filtros;
        private System.Windows.Forms.Panel panel_filtros;
        private System.Windows.Forms.Button btn_actual;
        private System.Windows.Forms.Label lbl_tganancias;
        private System.Windows.Forms.Label lbl_tventas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_productos_mv;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DataGridView dgv_productos_stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label label5;
    }
}