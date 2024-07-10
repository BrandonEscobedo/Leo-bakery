namespace PUNTO_DE_VENTA
{
    partial class usuarios
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usuarios));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgv_listado = new System.Windows.Forms.DataGridView();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Panel_Iconos = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblid_usuarios = new System.Windows.Forms.Label();
            this.lbl_nombre_icono = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_anuncio = new System.Windows.Forms.Label();
            this.icono = new System.Windows.Forms.PictureBox();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.btn_guardar = new System.Windows.Forms.ToolStripMenuItem();
            this.guardar_cambios = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_puesto = new System.Windows.Forms.ComboBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtnombre_apellidos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listado)).BeginInit();
            this.panel5.SuspendLayout();
            this.Panel_Iconos.SuspendLayout();
            this.panel4.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icono)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(156)))), ((int)(((byte)(214)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1241, 68);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1085, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 68);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 68);
            this.label1.TabIndex = 1;
            this.label1.Text = "USUARIOS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtbuscar);
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1241, 59);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscar.Location = new System.Drawing.Point(42, 16);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(277, 26);
            this.txtbuscar.TabIndex = 0;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 18);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(39, 26);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.AutoToolTip = true;
            this.toolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem2.Image")));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(28, 22);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.AutoToolTip = true;
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(28, 22);
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1068, 127);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(173, 641);
            this.panel3.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(27, 326);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Agregar usuarios ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 223);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dgv_listado
            // 
            this.dgv_listado.AllowUserToAddRows = false;
            this.dgv_listado.AllowUserToResizeRows = false;
            this.dgv_listado.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_listado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_listado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_listado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.delete});
            this.dgv_listado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_listado.EnableHeadersVisualStyles = false;
            this.dgv_listado.Location = new System.Drawing.Point(0, 127);
            this.dgv_listado.Name = "dgv_listado";
            this.dgv_listado.ReadOnly = true;
            this.dgv_listado.RowHeadersVisible = false;
            this.dgv_listado.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_listado.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.dgv_listado.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dgv_listado.RowTemplate.Height = 30;
            this.dgv_listado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_listado.Size = new System.Drawing.Size(1068, 641);
            this.dgv_listado.TabIndex = 3;
            this.dgv_listado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_listado_CellClick);
            this.dgv_listado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_listado_CellContentClick);
            this.dgv_listado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_listado_CellDoubleClick);
            // 
            // delete
            // 
            this.delete.HeaderText = "";
            this.delete.Image = ((System.Drawing.Image)(resources.GetObject("delete.Image")));
            this.delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.Panel_Iconos);
            this.panel5.Controls.Add(this.lbl_anuncio);
            this.panel5.Controls.Add(this.icono);
            this.panel5.Controls.Add(this.btn_regresar);
            this.panel5.Controls.Add(this.menuStrip2);
            this.panel5.Controls.Add(this.txt_puesto);
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Controls.Add(this.txt_correo);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.txt_password);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.txt_usuario);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.txtnombre_apellidos);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(5, 127);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1060, 510);
            this.panel5.TabIndex = 4;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // Panel_Iconos
            // 
            this.Panel_Iconos.BackColor = System.Drawing.Color.White;
            this.Panel_Iconos.Controls.Add(this.panel4);
            this.Panel_Iconos.Controls.Add(this.flowLayoutPanel1);
            this.Panel_Iconos.Location = new System.Drawing.Point(601, 16);
            this.Panel_Iconos.Name = "Panel_Iconos";
            this.Panel_Iconos.Size = new System.Drawing.Size(339, 237);
            this.Panel_Iconos.TabIndex = 5;
            this.Panel_Iconos.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Iconos_Paint);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblid_usuarios);
            this.panel4.Controls.Add(this.lbl_nombre_icono);
            this.panel4.Location = new System.Drawing.Point(767, 437);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 10);
            this.panel4.TabIndex = 18;
            // 
            // lblid_usuarios
            // 
            this.lblid_usuarios.AutoSize = true;
            this.lblid_usuarios.Location = new System.Drawing.Point(21, 28);
            this.lblid_usuarios.Name = "lblid_usuarios";
            this.lblid_usuarios.Size = new System.Drawing.Size(58, 22);
            this.lblid_usuarios.TabIndex = 16;
            this.lblid_usuarios.Text = "label7";
            this.lblid_usuarios.Click += new System.EventHandler(this.label7_Click);
            // 
            // lbl_nombre_icono
            // 
            this.lbl_nombre_icono.AutoSize = true;
            this.lbl_nombre_icono.Location = new System.Drawing.Point(59, 39);
            this.lbl_nombre_icono.Name = "lbl_nombre_icono";
            this.lbl_nombre_icono.Size = new System.Drawing.Size(58, 22);
            this.lbl_nombre_icono.TabIndex = 5;
            this.lbl_nombre_icono.Text = "label7";
            this.lbl_nombre_icono.Click += new System.EventHandler(this.lbl_nombre_icono_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.flowLayoutPanel1.Controls.Add(this.panel10);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 10);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(281, 237);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.label8);
            this.panel10.Controls.Add(this.pictureBox2);
            this.panel10.Location = new System.Drawing.Point(3, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(273, 223);
            this.panel10.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(232, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "click para insertar imagen";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-3, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(253, 170);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lbl_anuncio
            // 
            this.lbl_anuncio.BackColor = System.Drawing.Color.Gray;
            this.lbl_anuncio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_anuncio.Location = new System.Drawing.Point(636, 24);
            this.lbl_anuncio.Name = "lbl_anuncio";
            this.lbl_anuncio.Size = new System.Drawing.Size(244, 149);
            this.lbl_anuncio.TabIndex = 5;
            this.lbl_anuncio.Text = "Elije un Icono";
            this.lbl_anuncio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_anuncio.Click += new System.EventHandler(this.lbl_anuncio_Click);
            // 
            // icono
            // 
            this.icono.Location = new System.Drawing.Point(657, 24);
            this.icono.Name = "icono";
            this.icono.Size = new System.Drawing.Size(223, 149);
            this.icono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icono.TabIndex = 15;
            this.icono.TabStop = false;
            this.icono.Click += new System.EventHandler(this.icono_Click);
            // 
            // btn_regresar
            // 
            this.btn_regresar.BackColor = System.Drawing.Color.Silver;
            this.btn_regresar.FlatAppearance.BorderSize = 0;
            this.btn_regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_regresar.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_regresar.Location = new System.Drawing.Point(356, 296);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(126, 49);
            this.btn_regresar.TabIndex = 14;
            this.btn_regresar.Text = "Regresar";
            this.btn_regresar.UseVisualStyleBackColor = false;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.Color.Silver;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_guardar,
            this.guardar_cambios});
            this.menuStrip2.Location = new System.Drawing.Point(55, 296);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(284, 49);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // btn_guardar
            // 
            this.btn_guardar.AutoToolTip = true;
            this.btn_guardar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(93, 45);
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // guardar_cambios
            // 
            this.guardar_cambios.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.guardar_cambios.Name = "guardar_cambios";
            this.guardar_cambios.Size = new System.Drawing.Size(162, 45);
            this.guardar_cambios.Text = "Actualizar datos";
            this.guardar_cambios.Click += new System.EventHandler(this.guardar_cambios_Click);
            // 
            // txt_puesto
            // 
            this.txt_puesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_puesto.FormattingEnabled = true;
            this.txt_puesto.Items.AddRange(new object[] {
            "Cajero",
            "Administrador",
            "Repartidor"});
            this.txt_puesto.Location = new System.Drawing.Point(206, 224);
            this.txt_puesto.Name = "txt_puesto";
            this.txt_puesto.Size = new System.Drawing.Size(238, 28);
            this.txt_puesto.TabIndex = 13;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Gray;
            this.panel9.Location = new System.Drawing.Point(206, 179);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(238, 1);
            this.panel9.TabIndex = 12;
            // 
            // txt_correo
            // 
            this.txt_correo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_correo.Location = new System.Drawing.Point(206, 146);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(238, 27);
            this.txt_correo.TabIndex = 11;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Gray;
            this.panel8.Location = new System.Drawing.Point(206, 139);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(238, 1);
            this.panel8.TabIndex = 10;
            // 
            // txt_password
            // 
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_password.Location = new System.Drawing.Point(206, 106);
            this.txt_password.MaxLength = 10;
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(238, 27);
            this.txt_password.TabIndex = 9;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Gray;
            this.panel7.Location = new System.Drawing.Point(206, 99);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(238, 1);
            this.panel7.TabIndex = 8;
            // 
            // txt_usuario
            // 
            this.txt_usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_usuario.Location = new System.Drawing.Point(206, 64);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(238, 27);
            this.txt_usuario.TabIndex = 7;
            this.txt_usuario.TextChanged += new System.EventHandler(this.txt_usuario_TextChanged);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gray;
            this.panel6.Location = new System.Drawing.Point(206, 57);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(238, 1);
            this.panel6.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(147, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Rol:";
            // 
            // txtnombre_apellidos
            // 
            this.txtnombre_apellidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnombre_apellidos.Location = new System.Drawing.Point(206, 19);
            this.txtnombre_apellidos.Name = "txtnombre_apellidos";
            this.txtnombre_apellidos.Size = new System.Drawing.Size(238, 27);
            this.txtnombre_apellidos.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombres y Apellidos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "Correo electronico:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Usuario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Contraseña:";
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            this.ofd.FileOk += new System.ComponentModel.CancelEventHandler(this.ofd_FileOk);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // usuarios
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1241, 768);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.dgv_listado);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "usuarios";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.usuarios_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listado)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.Panel_Iconos.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icono)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgv_listado;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.DataGridViewImageColumn delete;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel Panel_Iconos;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lbl_anuncio;
        private System.Windows.Forms.PictureBox icono;
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem btn_guardar;
        private System.Windows.Forms.ToolStripMenuItem guardar_cambios;
        private System.Windows.Forms.ComboBox txt_puesto;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtnombre_apellidos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblid_usuarios;
        private System.Windows.Forms.Label lbl_nombre_icono;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

