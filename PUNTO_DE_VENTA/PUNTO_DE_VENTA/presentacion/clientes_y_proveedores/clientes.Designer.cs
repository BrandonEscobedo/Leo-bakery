
namespace PUNTO_DE_VENTA.presentacion.clientes_y_proveedores
{
    partial class clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(clientes));
            this.panel_clientes = new System.Windows.Forms.Panel();
            this.panel_t = new System.Windows.Forms.Panel();
            this.dgv_clientes = new System.Windows.Forms.DataGridView();
            this.eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel_ingresar_cliente = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bnt_guardar = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txt_tnumero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel19 = new System.Windows.Forms.Panel();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_if = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_clientes_eliminados = new System.Windows.Forms.Label();
            this.panel21 = new System.Windows.Forms.Panel();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.btn_agregar = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_clientes_activos = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ee = new System.Windows.Forms.DataGridViewImageColumn();
            this.e = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgv_ver_clientes = new System.Windows.Forms.DataGridView();
            this.panel_clientes.SuspendLayout();
            this.panel_t.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).BeginInit();
            this.panel_ingresar_cliente.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ver_clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_clientes
            // 
            this.panel_clientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_clientes.Controls.Add(this.panel_t);
            this.panel_clientes.Controls.Add(this.panel3);
            this.panel_clientes.Controls.Add(this.panel1);
            this.panel_clientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_clientes.Location = new System.Drawing.Point(0, 0);
            this.panel_clientes.Name = "panel_clientes";
            this.panel_clientes.Size = new System.Drawing.Size(1233, 715);
            this.panel_clientes.TabIndex = 0;
            // 
            // panel_t
            // 
            this.panel_t.Controls.Add(this.dgv_clientes);
            this.panel_t.Controls.Add(this.panel_ingresar_cliente);
            this.panel_t.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_t.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_t.Location = new System.Drawing.Point(0, 102);
            this.panel_t.Name = "panel_t";
            this.panel_t.Size = new System.Drawing.Size(1231, 611);
            this.panel_t.TabIndex = 18;
            this.panel_t.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // dgv_clientes
            // 
            this.dgv_clientes.AllowUserToAddRows = false;
            this.dgv_clientes.AllowUserToDeleteRows = false;
            this.dgv_clientes.BackgroundColor = System.Drawing.Color.White;
            this.dgv_clientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eliminar,
            this.editar});
            this.dgv_clientes.Location = new System.Drawing.Point(92, 475);
            this.dgv_clientes.Name = "dgv_clientes";
            this.dgv_clientes.ReadOnly = true;
            this.dgv_clientes.Size = new System.Drawing.Size(815, 119);
            this.dgv_clientes.TabIndex = 566;
            this.dgv_clientes.CellBorderStyleChanged += new System.EventHandler(this.dgv_clientes_CellBorderStyleChanged);
            this.dgv_clientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_clientes_CellClick);
            this.dgv_clientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_clientes_CellContentClick_1);
            this.dgv_clientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_clientes_CellDoubleClick);
            // 
            // eliminar
            // 
            this.eliminar.HeaderText = "";
            this.eliminar.Image = ((System.Drawing.Image)(resources.GetObject("eliminar.Image")));
            this.eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.eliminar.Name = "eliminar";
            this.eliminar.ReadOnly = true;
            // 
            // editar
            // 
            this.editar.HeaderText = "";
            this.editar.Image = ((System.Drawing.Image)(resources.GetObject("editar.Image")));
            this.editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.editar.Name = "editar";
            this.editar.ReadOnly = true;
            // 
            // panel_ingresar_cliente
            // 
            this.panel_ingresar_cliente.Controls.Add(this.flowLayoutPanel1);
            this.panel_ingresar_cliente.Controls.Add(this.groupBox2);
            this.panel_ingresar_cliente.Controls.Add(this.groupBox1);
            this.panel_ingresar_cliente.Location = new System.Drawing.Point(22, 0);
            this.panel_ingresar_cliente.Name = "panel_ingresar_cliente";
            this.panel_ingresar_cliente.Size = new System.Drawing.Size(995, 469);
            this.panel_ingresar_cliente.TabIndex = 562;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.bnt_guardar);
            this.flowLayoutPanel1.Controls.Add(this.btn_actualizar);
            this.flowLayoutPanel1.Controls.Add(this.btn_cancelar);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(70, 400);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(521, 51);
            this.flowLayoutPanel1.TabIndex = 563;
            // 
            // bnt_guardar
            // 
            this.bnt_guardar.BackColor = System.Drawing.Color.LightGray;
            this.bnt_guardar.FlatAppearance.BorderSize = 0;
            this.bnt_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_guardar.Location = new System.Drawing.Point(3, 3);
            this.bnt_guardar.Name = "bnt_guardar";
            this.bnt_guardar.Size = new System.Drawing.Size(165, 41);
            this.bnt_guardar.TabIndex = 2;
            this.bnt_guardar.Text = "Guardar";
            this.bnt_guardar.UseVisualStyleBackColor = false;
            this.bnt_guardar.Click += new System.EventHandler(this.bnt_guardar_Click);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.BackColor = System.Drawing.Color.LightGray;
            this.btn_actualizar.FlatAppearance.BorderSize = 0;
            this.btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actualizar.Location = new System.Drawing.Point(174, 3);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(165, 41);
            this.btn_actualizar.TabIndex = 3;
            this.btn_actualizar.Text = "Guardar Cambios";
            this.btn_actualizar.UseVisualStyleBackColor = false;
            this.btn_actualizar.Visible = false;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.LightGray;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Location = new System.Drawing.Point(345, 3);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(165, 41);
            this.btn_cancelar.TabIndex = 562;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.panel9);
            this.groupBox2.Controls.Add(this.txt_direccion);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.panel8);
            this.groupBox2.Controls.Add(this.txt_tnumero);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.panel19);
            this.groupBox2.Controls.Add(this.txt_nombre);
            this.groupBox2.Location = new System.Drawing.Point(60, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(832, 253);
            this.groupBox2.TabIndex = 561;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos generales.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 22);
            this.label4.TabIndex = 568;
            this.label4.Text = "Dirreccion:";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Gray;
            this.panel9.Location = new System.Drawing.Point(177, 204);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(650, 1);
            this.panel9.TabIndex = 567;
            // 
            // txt_direccion
            // 
            this.txt_direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_direccion.Location = new System.Drawing.Point(175, 172);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(652, 26);
            this.txt_direccion.TabIndex = 566;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 22);
            this.label3.TabIndex = 565;
            this.label3.Text = "Numero Telefonico:";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Gray;
            this.panel8.Location = new System.Drawing.Point(177, 142);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(650, 1);
            this.panel8.TabIndex = 564;
            // 
            // txt_tnumero
            // 
            this.txt_tnumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tnumero.Location = new System.Drawing.Point(177, 111);
            this.txt_tnumero.Name = "txt_tnumero";
            this.txt_tnumero.Size = new System.Drawing.Size(650, 26);
            this.txt_tnumero.TabIndex = 563;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 22);
            this.label2.TabIndex = 562;
            this.label2.Text = "Nombre:";
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.Color.Gray;
            this.panel19.Location = new System.Drawing.Point(175, 86);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(650, 1);
            this.panel19.TabIndex = 561;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(175, 54);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(650, 26);
            this.txt_nombre.TabIndex = 560;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_if);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(55, 311);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(837, 83);
            this.groupBox1.TabIndex = 560;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Facturacion.";
            // 
            // txt_if
            // 
            this.txt_if.Location = new System.Drawing.Point(185, 36);
            this.txt_if.Name = "txt_if";
            this.txt_if.Size = new System.Drawing.Size(561, 27);
            this.txt_if.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Identificacion fiscal:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbl_clientes_eliminados);
            this.panel3.Controls.Add(this.panel21);
            this.panel3.Controls.Add(this.txtbuscar);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.menuStrip1);
            this.panel3.Controls.Add(this.menuStrip2);
            this.panel3.Controls.Add(this.lbl_clientes_activos);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1231, 45);
            this.panel3.TabIndex = 17;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // lbl_clientes_eliminados
            // 
            this.lbl_clientes_eliminados.AutoSize = true;
            this.lbl_clientes_eliminados.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_clientes_eliminados.Location = new System.Drawing.Point(922, 16);
            this.lbl_clientes_eliminados.Name = "lbl_clientes_eliminados";
            this.lbl_clientes_eliminados.Size = new System.Drawing.Size(21, 22);
            this.lbl_clientes_eliminados.TabIndex = 26;
            this.lbl_clientes_eliminados.Text = "0";
            // 
            // panel21
            // 
            this.panel21.BackColor = System.Drawing.Color.Gray;
            this.panel21.Location = new System.Drawing.Point(11, 37);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(238, 1);
            this.panel21.TabIndex = 19;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscar.Location = new System.Drawing.Point(11, 5);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(238, 26);
            this.txtbuscar.TabIndex = 17;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(742, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 22);
            this.label8.TabIndex = 25;
            this.label8.Text = "Clientes eliminados";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(261, 6);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(39, 31);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.AutoToolTip = true;
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(28, 27);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.AutoToolTip = true;
            this.toolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem2.Image")));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(28, 27);
            // 
            // menuStrip2
            // 
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_agregar});
            this.menuStrip2.Location = new System.Drawing.Point(311, 3);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(175, 38);
            this.menuStrip2.TabIndex = 22;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // btn_agregar
            // 
            this.btn_agregar.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btn_agregar.Image = ((System.Drawing.Image)(resources.GetObject("btn_agregar.Image")));
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(145, 34);
            this.btn_agregar.Text = "Agregar clientes";
            this.btn_agregar.Click += new System.EventHandler(this.agregarClienteToolStripMenuItem_Click);
            // 
            // lbl_clientes_activos
            // 
            this.lbl_clientes_activos.AutoSize = true;
            this.lbl_clientes_activos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_clientes_activos.Location = new System.Drawing.Point(716, 16);
            this.lbl_clientes_activos.Name = "lbl_clientes_activos";
            this.lbl_clientes_activos.Size = new System.Drawing.Size(21, 22);
            this.lbl_clientes_activos.TabIndex = 24;
            this.lbl_clientes_activos.Text = "0";
            this.lbl_clientes_activos.Click += new System.EventHandler(this.lbl_clientes_activos_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(569, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 22);
            this.label6.TabIndex = 23;
            this.label6.Text = "Clientes activos:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(120)))), ((int)(((byte)(216)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1231, 57);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 55);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clientes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ee
            // 
            this.ee.HeaderText = "";
            this.ee.Image = ((System.Drawing.Image)(resources.GetObject("ee.Image")));
            this.ee.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ee.Name = "ee";
            this.ee.ReadOnly = true;
            // 
            // e
            // 
            this.e.HeaderText = "";
            this.e.Image = ((System.Drawing.Image)(resources.GetObject("e.Image")));
            this.e.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.e.Name = "e";
            this.e.ReadOnly = true;
            // 
            // dgv_ver_clientes
            // 
            this.dgv_ver_clientes.AllowUserToAddRows = false;
            this.dgv_ver_clientes.AllowUserToDeleteRows = false;
            this.dgv_ver_clientes.BackgroundColor = System.Drawing.Color.White;
            this.dgv_ver_clientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_ver_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ver_clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.e,
            this.ee});
            this.dgv_ver_clientes.Location = new System.Drawing.Point(146, 565);
            this.dgv_ver_clientes.Name = "dgv_ver_clientes";
            this.dgv_ver_clientes.ReadOnly = true;
            this.dgv_ver_clientes.Size = new System.Drawing.Size(918, 78);
            this.dgv_ver_clientes.TabIndex = 566;
            // 
            // clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1233, 715);
            this.Controls.Add(this.panel_clientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "clientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.clientes_Load);
            this.panel_clientes.ResumeLayout(false);
            this.panel_t.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).EndInit();
            this.panel_ingresar_cliente.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ver_clientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_clientes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem btn_agregar;
        private System.Windows.Forms.DataGridViewImageColumn e;
        private System.Windows.Forms.DataGridViewImageColumn ee;
        private System.Windows.Forms.DataGridView dgv_ver_clientes;
        private System.Windows.Forms.Panel panel_t;
        private System.Windows.Forms.Panel panel_ingresar_cliente;
        private System.Windows.Forms.DataGridView dgv_clientes;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button bnt_guardar;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txt_tnumero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_if;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewImageColumn eliminar;
        private System.Windows.Forms.DataGridViewImageColumn editar;
        private System.Windows.Forms.Label lbl_clientes_eliminados;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_clientes_activos;
        private System.Windows.Forms.Label label6;
    }
}