namespace PUNTO_DE_VENTA.modulos
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer_cargando = new System.Windows.Forms.Timer(this.components);
            this.titulo = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pb_cargando = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_usuarios = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_num1 = new System.Windows.Forms.Button();
            this.btn_num2 = new System.Windows.Forms.Button();
            this.btn_num3 = new System.Windows.Forms.Button();
            this.btn_num4 = new System.Windows.Forms.Button();
            this.btn_num5 = new System.Windows.Forms.Button();
            this.btn_num6 = new System.Windows.Forms.Button();
            this.btn_num7 = new System.Windows.Forms.Button();
            this.btn_num8 = new System.Windows.Forms.Button();
            this.btn_num9 = new System.Windows.Forms.Button();
            this.btn_borrar_todo = new System.Windows.Forms.Button();
            this.btn_num0 = new System.Windows.Forms.Button();
            this.btn_borrar_caracter = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ms_ver = new System.Windows.Forms.MenuStrip();
            this.btn_ver = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_no_ver = new System.Windows.Forms.ToolStripMenuItem();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txt_login_password = new System.Windows.Forms.TextBox();
            this.btninicar_sesion = new System.Windows.Forms.Button();
            this.btn_cambiar_usuario = new System.Windows.Forms.Button();
            this.pb_licencia = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.datalistado_detalle_cierre_de_caja = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.lblpermiso_caja = new System.Windows.Forms.Label();
            this.lblnombre_cajero = new System.Windows.Forms.Label();
            this.lbl_usuario_inicio_caja = new System.Windows.Forms.Label();
            this.dgv_validar_movimientos = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.dgv_listado = new System.Windows.Forms.DataGridView();
            this.lbl_login = new System.Windows.Forms.Label();
            this.lblapertura_de_caja = new System.Windows.Forms.Label();
            this.lbl_id_usuario = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblrol = new System.Windows.Forms.Label();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.lblserial = new System.Windows.Forms.TextBox();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.lblidcaja = new System.Windows.Forms.Label();
            this.lblcajatexto = new System.Windows.Forms.Label();
            this.lblserialcaja = new System.Windows.Forms.Label();
            this.btn_licencia = new System.Windows.Forms.Label();
            this.panel_login = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_cargando)).BeginInit();
            this.panel_usuarios.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.ms_ver.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_licencia)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datalistado_detalle_cierre_de_caja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_validar_movimientos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.panel_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer_cargando
            // 
            this.timer_cargando.Interval = 200;
            this.timer_cargando.Tick += new System.EventHandler(this.timer_cargando_Tick);
            // 
            // titulo
            // 
            this.titulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(402, 26);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(43, 20);
            this.titulo.TabIndex = 0;
            this.titulo.Text = "titulo";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.titulo);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(976, 56);
            this.panel4.TabIndex = 5;
            // 
            // pb_cargando
            // 
            this.pb_cargando.BackColor = System.Drawing.Color.White;
            this.pb_cargando.Image = ((System.Drawing.Image)(resources.GetObject("pb_cargando.Image")));
            this.pb_cargando.Location = new System.Drawing.Point(510, 260);
            this.pb_cargando.Name = "pb_cargando";
            this.pb_cargando.Size = new System.Drawing.Size(271, 202);
            this.pb_cargando.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_cargando.TabIndex = 9;
            this.pb_cargando.TabStop = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(666, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "¿Quien esta iniciando sesion?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 40);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(666, 425);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.Click += new System.EventHandler(this.flowLayoutPanel1_Click);
            // 
            // panel_usuarios
            // 
            this.panel_usuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_usuarios.Controls.Add(this.flowLayoutPanel1);
            this.panel_usuarios.Controls.Add(this.label1);
            this.panel_usuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_usuarios.Location = new System.Drawing.Point(144, 25);
            this.panel_usuarios.Name = "panel_usuarios";
            this.panel_usuarios.Size = new System.Drawing.Size(666, 465);
            this.panel_usuarios.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(645, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Inicio de Sesion";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btn_num1);
            this.flowLayoutPanel2.Controls.Add(this.btn_num2);
            this.flowLayoutPanel2.Controls.Add(this.btn_num3);
            this.flowLayoutPanel2.Controls.Add(this.btn_num4);
            this.flowLayoutPanel2.Controls.Add(this.btn_num5);
            this.flowLayoutPanel2.Controls.Add(this.btn_num6);
            this.flowLayoutPanel2.Controls.Add(this.btn_num7);
            this.flowLayoutPanel2.Controls.Add(this.btn_num8);
            this.flowLayoutPanel2.Controls.Add(this.btn_num9);
            this.flowLayoutPanel2.Controls.Add(this.btn_borrar_todo);
            this.flowLayoutPanel2.Controls.Add(this.btn_num0);
            this.flowLayoutPanel2.Controls.Add(this.btn_borrar_caracter);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(183, 149);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(311, 375);
            this.flowLayoutPanel2.TabIndex = 1;
            this.flowLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel2_Paint);
            // 
            // btn_num1
            // 
            this.btn_num1.BackColor = System.Drawing.Color.DarkGray;
            this.btn_num1.FlatAppearance.BorderSize = 0;
            this.btn_num1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_num1.Location = new System.Drawing.Point(3, 3);
            this.btn_num1.Name = "btn_num1";
            this.btn_num1.Size = new System.Drawing.Size(97, 87);
            this.btn_num1.TabIndex = 0;
            this.btn_num1.Text = "1";
            this.btn_num1.UseVisualStyleBackColor = false;
            this.btn_num1.Click += new System.EventHandler(this.btn_num1_Click);
            // 
            // btn_num2
            // 
            this.btn_num2.BackColor = System.Drawing.Color.DarkGray;
            this.btn_num2.FlatAppearance.BorderSize = 0;
            this.btn_num2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_num2.Location = new System.Drawing.Point(106, 3);
            this.btn_num2.Name = "btn_num2";
            this.btn_num2.Size = new System.Drawing.Size(97, 87);
            this.btn_num2.TabIndex = 1;
            this.btn_num2.Text = "2";
            this.btn_num2.UseVisualStyleBackColor = false;
            this.btn_num2.Click += new System.EventHandler(this.btn_num2_Click);
            // 
            // btn_num3
            // 
            this.btn_num3.BackColor = System.Drawing.Color.DarkGray;
            this.btn_num3.FlatAppearance.BorderSize = 0;
            this.btn_num3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_num3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_num3.Location = new System.Drawing.Point(209, 3);
            this.btn_num3.Name = "btn_num3";
            this.btn_num3.Size = new System.Drawing.Size(97, 87);
            this.btn_num3.TabIndex = 2;
            this.btn_num3.Text = "3";
            this.btn_num3.UseVisualStyleBackColor = false;
            this.btn_num3.Click += new System.EventHandler(this.btn_num3_Click);
            // 
            // btn_num4
            // 
            this.btn_num4.BackColor = System.Drawing.Color.DarkGray;
            this.btn_num4.FlatAppearance.BorderSize = 0;
            this.btn_num4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_num4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_num4.Location = new System.Drawing.Point(3, 96);
            this.btn_num4.Name = "btn_num4";
            this.btn_num4.Size = new System.Drawing.Size(97, 87);
            this.btn_num4.TabIndex = 3;
            this.btn_num4.Text = "4";
            this.btn_num4.UseVisualStyleBackColor = false;
            this.btn_num4.Click += new System.EventHandler(this.btn_num4_Click);
            // 
            // btn_num5
            // 
            this.btn_num5.BackColor = System.Drawing.Color.DarkGray;
            this.btn_num5.FlatAppearance.BorderSize = 0;
            this.btn_num5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_num5.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_num5.Location = new System.Drawing.Point(106, 96);
            this.btn_num5.Name = "btn_num5";
            this.btn_num5.Size = new System.Drawing.Size(97, 87);
            this.btn_num5.TabIndex = 4;
            this.btn_num5.Text = "5";
            this.btn_num5.UseVisualStyleBackColor = false;
            this.btn_num5.Click += new System.EventHandler(this.btn_num5_Click);
            // 
            // btn_num6
            // 
            this.btn_num6.BackColor = System.Drawing.Color.DarkGray;
            this.btn_num6.FlatAppearance.BorderSize = 0;
            this.btn_num6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_num6.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_num6.Location = new System.Drawing.Point(209, 96);
            this.btn_num6.Name = "btn_num6";
            this.btn_num6.Size = new System.Drawing.Size(97, 87);
            this.btn_num6.TabIndex = 5;
            this.btn_num6.Text = "6";
            this.btn_num6.UseVisualStyleBackColor = false;
            this.btn_num6.Click += new System.EventHandler(this.btn_num6_Click);
            // 
            // btn_num7
            // 
            this.btn_num7.BackColor = System.Drawing.Color.DarkGray;
            this.btn_num7.FlatAppearance.BorderSize = 0;
            this.btn_num7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_num7.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_num7.Location = new System.Drawing.Point(3, 189);
            this.btn_num7.Name = "btn_num7";
            this.btn_num7.Size = new System.Drawing.Size(97, 87);
            this.btn_num7.TabIndex = 6;
            this.btn_num7.Text = "7";
            this.btn_num7.UseVisualStyleBackColor = false;
            this.btn_num7.Click += new System.EventHandler(this.btn_num7_Click);
            // 
            // btn_num8
            // 
            this.btn_num8.BackColor = System.Drawing.Color.DarkGray;
            this.btn_num8.FlatAppearance.BorderSize = 0;
            this.btn_num8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_num8.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_num8.Location = new System.Drawing.Point(106, 189);
            this.btn_num8.Name = "btn_num8";
            this.btn_num8.Size = new System.Drawing.Size(97, 87);
            this.btn_num8.TabIndex = 7;
            this.btn_num8.Text = "8";
            this.btn_num8.UseVisualStyleBackColor = false;
            this.btn_num8.Click += new System.EventHandler(this.btn_num8_Click);
            // 
            // btn_num9
            // 
            this.btn_num9.BackColor = System.Drawing.Color.DarkGray;
            this.btn_num9.FlatAppearance.BorderSize = 0;
            this.btn_num9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_num9.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_num9.Location = new System.Drawing.Point(209, 189);
            this.btn_num9.Name = "btn_num9";
            this.btn_num9.Size = new System.Drawing.Size(97, 87);
            this.btn_num9.TabIndex = 8;
            this.btn_num9.Text = "9";
            this.btn_num9.UseVisualStyleBackColor = false;
            this.btn_num9.Click += new System.EventHandler(this.btn_num9_Click);
            // 
            // btn_borrar_todo
            // 
            this.btn_borrar_todo.BackColor = System.Drawing.Color.DarkGray;
            this.btn_borrar_todo.FlatAppearance.BorderSize = 0;
            this.btn_borrar_todo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_borrar_todo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_borrar_todo.Location = new System.Drawing.Point(3, 282);
            this.btn_borrar_todo.Name = "btn_borrar_todo";
            this.btn_borrar_todo.Size = new System.Drawing.Size(97, 87);
            this.btn_borrar_todo.TabIndex = 9;
            this.btn_borrar_todo.Text = "BORRAR";
            this.btn_borrar_todo.UseVisualStyleBackColor = false;
            this.btn_borrar_todo.Click += new System.EventHandler(this.btn_borrar_todo_Click);
            // 
            // btn_num0
            // 
            this.btn_num0.BackColor = System.Drawing.Color.DarkGray;
            this.btn_num0.FlatAppearance.BorderSize = 0;
            this.btn_num0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_num0.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_num0.Location = new System.Drawing.Point(106, 282);
            this.btn_num0.Name = "btn_num0";
            this.btn_num0.Size = new System.Drawing.Size(97, 87);
            this.btn_num0.TabIndex = 10;
            this.btn_num0.Text = "0";
            this.btn_num0.UseVisualStyleBackColor = false;
            this.btn_num0.Click += new System.EventHandler(this.btn_num0_Click);
            // 
            // btn_borrar_caracter
            // 
            this.btn_borrar_caracter.BackColor = System.Drawing.Color.DarkGray;
            this.btn_borrar_caracter.FlatAppearance.BorderSize = 0;
            this.btn_borrar_caracter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_borrar_caracter.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_borrar_caracter.Location = new System.Drawing.Point(209, 282);
            this.btn_borrar_caracter.Name = "btn_borrar_caracter";
            this.btn_borrar_caracter.Size = new System.Drawing.Size(97, 87);
            this.btn_borrar_caracter.TabIndex = 11;
            this.btn_borrar_caracter.Text = "<--";
            this.btn_borrar_caracter.UseVisualStyleBackColor = false;
            this.btn_borrar_caracter.Click += new System.EventHandler(this.btn_borrar_caracter_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ms_ver);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.txt_login_password);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(645, 100);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // ms_ver
            // 
            this.ms_ver.AutoSize = false;
            this.ms_ver.BackColor = System.Drawing.Color.White;
            this.ms_ver.Dock = System.Windows.Forms.DockStyle.None;
            this.ms_ver.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ms_ver.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_ver,
            this.btn_no_ver});
            this.ms_ver.Location = new System.Drawing.Point(420, 33);
            this.ms_ver.Name = "ms_ver";
            this.ms_ver.Size = new System.Drawing.Size(75, 40);
            this.ms_ver.TabIndex = 9;
            this.ms_ver.Text = "menuStrip2";
            // 
            // btn_ver
            // 
            this.btn_ver.AutoToolTip = true;
            this.btn_ver.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btn_ver.Image = ((System.Drawing.Image)(resources.GetObject("btn_ver.Image")));
            this.btn_ver.Name = "btn_ver";
            this.btn_ver.Size = new System.Drawing.Size(28, 36);
            this.btn_ver.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_no_ver
            // 
            this.btn_no_ver.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btn_no_ver.Image = ((System.Drawing.Image)(resources.GetObject("btn_no_ver.Image")));
            this.btn_no_ver.Name = "btn_no_ver";
            this.btn_no_ver.Size = new System.Drawing.Size(28, 36);
            this.btn_no_ver.Click += new System.EventHandler(this.btn_no_ver_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gray;
            this.panel6.Location = new System.Drawing.Point(183, 72);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(225, 1);
            this.panel6.TabIndex = 8;
            // 
            // txt_login_password
            // 
            this.txt_login_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_login_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_login_password.Location = new System.Drawing.Point(183, 37);
            this.txt_login_password.Multiline = true;
            this.txt_login_password.Name = "txt_login_password";
            this.txt_login_password.PasswordChar = '*';
            this.txt_login_password.Size = new System.Drawing.Size(225, 33);
            this.txt_login_password.TabIndex = 7;
            this.txt_login_password.TextChanged += new System.EventHandler(this.txt_login_password_TextChanged);
            // 
            // btninicar_sesion
            // 
            this.btninicar_sesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(69)))), ((int)(((byte)(49)))));
            this.btninicar_sesion.FlatAppearance.BorderSize = 0;
            this.btninicar_sesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninicar_sesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninicar_sesion.ForeColor = System.Drawing.Color.White;
            this.btninicar_sesion.Location = new System.Drawing.Point(183, 528);
            this.btninicar_sesion.Margin = new System.Windows.Forms.Padding(1);
            this.btninicar_sesion.Name = "btninicar_sesion";
            this.btninicar_sesion.Size = new System.Drawing.Size(311, 50);
            this.btninicar_sesion.TabIndex = 3;
            this.btninicar_sesion.Text = "Iniciar sesion";
            this.btninicar_sesion.UseVisualStyleBackColor = false;
            this.btninicar_sesion.Click += new System.EventHandler(this.btninicar_sesion_Click);
            // 
            // btn_cambiar_usuario
            // 
            this.btn_cambiar_usuario.BackColor = System.Drawing.Color.White;
            this.btn_cambiar_usuario.FlatAppearance.BorderSize = 0;
            this.btn_cambiar_usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cambiar_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cambiar_usuario.ForeColor = System.Drawing.Color.Black;
            this.btn_cambiar_usuario.Location = new System.Drawing.Point(186, 582);
            this.btn_cambiar_usuario.Name = "btn_cambiar_usuario";
            this.btn_cambiar_usuario.Size = new System.Drawing.Size(308, 36);
            this.btn_cambiar_usuario.TabIndex = 4;
            this.btn_cambiar_usuario.Text = "Cambiar de Usuario";
            this.btn_cambiar_usuario.UseVisualStyleBackColor = false;
            // 
            // pb_licencia
            // 
            this.pb_licencia.Image = ((System.Drawing.Image)(resources.GetObject("pb_licencia.Image")));
            this.pb_licencia.Location = new System.Drawing.Point(186, 614);
            this.pb_licencia.Name = "pb_licencia";
            this.pb_licencia.Size = new System.Drawing.Size(45, 27);
            this.pb_licencia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_licencia.TabIndex = 5;
            this.pb_licencia.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.datalistado_detalle_cierre_de_caja);
            this.panel1.Controls.Add(this.lblpermiso_caja);
            this.panel1.Controls.Add(this.lblnombre_cajero);
            this.panel1.Controls.Add(this.lbl_usuario_inicio_caja);
            this.panel1.Controls.Add(this.dgv_validar_movimientos);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.dgv_listado);
            this.panel1.Controls.Add(this.lbl_login);
            this.panel1.Controls.Add(this.lblapertura_de_caja);
            this.panel1.Controls.Add(this.lbl_id_usuario);
            this.panel1.Controls.Add(this.lblnombre);
            this.panel1.Controls.Add(this.lblrol);
            this.panel1.Controls.Add(this.dgv2);
            this.panel1.Controls.Add(this.lblserial);
            this.panel1.Controls.Add(this.dgv1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblidcaja);
            this.panel1.Controls.Add(this.lblcajatexto);
            this.panel1.Controls.Add(this.lblserialcaja);
            this.panel1.Location = new System.Drawing.Point(38, 500);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(98, 81);
            this.panel1.TabIndex = 13;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(17, 183);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 12);
            this.panel2.TabIndex = 621;
            // 
            // datalistado_detalle_cierre_de_caja
            // 
            this.datalistado_detalle_cierre_de_caja.AllowUserToAddRows = false;
            this.datalistado_detalle_cierre_de_caja.AllowUserToResizeRows = false;
            this.datalistado_detalle_cierre_de_caja.BackgroundColor = System.Drawing.Color.White;
            this.datalistado_detalle_cierre_de_caja.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datalistado_detalle_cierre_de_caja.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.datalistado_detalle_cierre_de_caja.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datalistado_detalle_cierre_de_caja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datalistado_detalle_cierre_de_caja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewImageColumn4});
            this.datalistado_detalle_cierre_de_caja.EnableHeadersVisualStyles = false;
            this.datalistado_detalle_cierre_de_caja.Location = new System.Drawing.Point(159, 328);
            this.datalistado_detalle_cierre_de_caja.Name = "datalistado_detalle_cierre_de_caja";
            this.datalistado_detalle_cierre_de_caja.ReadOnly = true;
            this.datalistado_detalle_cierre_de_caja.RowHeadersVisible = false;
            this.datalistado_detalle_cierre_de_caja.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datalistado_detalle_cierre_de_caja.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datalistado_detalle_cierre_de_caja.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.datalistado_detalle_cierre_de_caja.RowTemplate.Height = 30;
            this.datalistado_detalle_cierre_de_caja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datalistado_detalle_cierre_de_caja.Size = new System.Drawing.Size(246, 38);
            this.datalistado_detalle_cierre_de_caja.TabIndex = 620;
            // 
            // dataGridViewImageColumn4
            // 
            this.dataGridViewImageColumn4.HeaderText = "";
            this.dataGridViewImageColumn4.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn4.Image")));
            this.dataGridViewImageColumn4.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn4.Name = "dataGridViewImageColumn4";
            this.dataGridViewImageColumn4.ReadOnly = true;
            // 
            // lblpermiso_caja
            // 
            this.lblpermiso_caja.AutoSize = true;
            this.lblpermiso_caja.Location = new System.Drawing.Point(43, 390);
            this.lblpermiso_caja.Name = "lblpermiso_caja";
            this.lblpermiso_caja.Size = new System.Drawing.Size(81, 13);
            this.lblpermiso_caja.TabIndex = 21;
            this.lblpermiso_caja.Text = "permiso de caja";
            // 
            // lblnombre_cajero
            // 
            this.lblnombre_cajero.AutoSize = true;
            this.lblnombre_cajero.Location = new System.Drawing.Point(49, 353);
            this.lblnombre_cajero.Name = "lblnombre_cajero";
            this.lblnombre_cajero.Size = new System.Drawing.Size(74, 13);
            this.lblnombre_cajero.TabIndex = 20;
            this.lblnombre_cajero.Text = "nombre cajero";
            // 
            // lbl_usuario_inicio_caja
            // 
            this.lbl_usuario_inicio_caja.AutoSize = true;
            this.lbl_usuario_inicio_caja.Location = new System.Drawing.Point(43, 317);
            this.lbl_usuario_inicio_caja.Name = "lbl_usuario_inicio_caja";
            this.lbl_usuario_inicio_caja.Size = new System.Drawing.Size(27, 13);
            this.lbl_usuario_inicio_caja.TabIndex = 19;
            this.lbl_usuario_inicio_caja.Text = "caja";
            // 
            // dgv_validar_movimientos
            // 
            this.dgv_validar_movimientos.AllowUserToAddRows = false;
            this.dgv_validar_movimientos.AllowUserToResizeRows = false;
            this.dgv_validar_movimientos.BackgroundColor = System.Drawing.Color.White;
            this.dgv_validar_movimientos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_validar_movimientos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_validar_movimientos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_validar_movimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_validar_movimientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewImageColumn3});
            this.dgv_validar_movimientos.EnableHeadersVisualStyles = false;
            this.dgv_validar_movimientos.Location = new System.Drawing.Point(89, 241);
            this.dgv_validar_movimientos.Name = "dgv_validar_movimientos";
            this.dgv_validar_movimientos.ReadOnly = true;
            this.dgv_validar_movimientos.RowHeadersVisible = false;
            this.dgv_validar_movimientos.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_validar_movimientos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.dgv_validar_movimientos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dgv_validar_movimientos.RowTemplate.Height = 30;
            this.dgv_validar_movimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_validar_movimientos.Size = new System.Drawing.Size(113, 60);
            this.dgv_validar_movimientos.TabIndex = 18;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.HeaderText = "";
            this.dataGridViewImageColumn3.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn3.Image")));
            this.dataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.ReadOnly = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(139, 24);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(113, 29);
            this.progressBar1.TabIndex = 8;
            // 
            // dgv_listado
            // 
            this.dgv_listado.AllowUserToAddRows = false;
            this.dgv_listado.AllowUserToResizeRows = false;
            this.dgv_listado.BackgroundColor = System.Drawing.Color.White;
            this.dgv_listado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_listado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_listado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listado.ColumnHeadersVisible = false;
            this.dgv_listado.EnableHeadersVisualStyles = false;
            this.dgv_listado.Location = new System.Drawing.Point(242, 196);
            this.dgv_listado.Name = "dgv_listado";
            this.dgv_listado.ReadOnly = true;
            this.dgv_listado.RowHeadersVisible = false;
            this.dgv_listado.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_listado.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.dgv_listado.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dgv_listado.RowTemplate.Height = 30;
            this.dgv_listado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_listado.Size = new System.Drawing.Size(163, 98);
            this.dgv_listado.TabIndex = 4;
            this.dgv_listado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_listado_CellContentClick);
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Location = new System.Drawing.Point(97, 181);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(29, 13);
            this.lbl_login.TabIndex = 7;
            this.lbl_login.Text = "login";
            // 
            // lblapertura_de_caja
            // 
            this.lblapertura_de_caja.AutoSize = true;
            this.lblapertura_de_caja.Location = new System.Drawing.Point(156, 190);
            this.lblapertura_de_caja.Name = "lblapertura_de_caja";
            this.lblapertura_de_caja.Size = new System.Drawing.Size(46, 13);
            this.lblapertura_de_caja.TabIndex = 10;
            this.lblapertura_de_caja.Text = "apertura";
            // 
            // lbl_id_usuario
            // 
            this.lbl_id_usuario.AutoSize = true;
            this.lbl_id_usuario.Location = new System.Drawing.Point(49, 209);
            this.lbl_id_usuario.Name = "lbl_id_usuario";
            this.lbl_id_usuario.Size = new System.Drawing.Size(41, 13);
            this.lbl_id_usuario.TabIndex = 17;
            this.lbl_id_usuario.Text = "usuario";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(49, 181);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(42, 13);
            this.lblnombre.TabIndex = 16;
            this.lblnombre.Text = "nombre";
            // 
            // lblrol
            // 
            this.lblrol.AutoSize = true;
            this.lblrol.Location = new System.Drawing.Point(49, 196);
            this.lblrol.Name = "lblrol";
            this.lblrol.Size = new System.Drawing.Size(18, 13);
            this.lblrol.TabIndex = 15;
            this.lblrol.Text = "rol";
            // 
            // dgv2
            // 
            this.dgv2.AllowUserToAddRows = false;
            this.dgv2.BackgroundColor = System.Drawing.Color.White;
            this.dgv2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewImageColumn2});
            this.dgv2.EnableHeadersVisualStyles = false;
            this.dgv2.GridColor = System.Drawing.Color.White;
            this.dgv2.Location = new System.Drawing.Point(9, 118);
            this.dgv2.Name = "dgv2";
            this.dgv2.ReadOnly = true;
            this.dgv2.RowHeadersVisible = false;
            this.dgv2.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv2.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.dgv2.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dgv2.RowTemplate.Height = 30;
            this.dgv2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv2.Size = new System.Drawing.Size(117, 60);
            this.dgv2.TabIndex = 14;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            // 
            // lblserial
            // 
            this.lblserial.Location = new System.Drawing.Point(3, 92);
            this.lblserial.Name = "lblserial";
            this.lblserial.Size = new System.Drawing.Size(100, 20);
            this.lblserial.TabIndex = 13;
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToResizeRows = false;
            this.dgv1.BackgroundColor = System.Drawing.Color.White;
            this.dgv1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.EnableHeadersVisualStyles = false;
            this.dgv1.Location = new System.Drawing.Point(150, 118);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.RowHeadersVisible = false;
            this.dgv1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.dgv1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dgv1.RowTemplate.Height = 30;
            this.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv1.Size = new System.Drawing.Size(113, 60);
            this.dgv1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "label3";
            // 
            // lblidcaja
            // 
            this.lblidcaja.AutoSize = true;
            this.lblidcaja.Location = new System.Drawing.Point(61, 403);
            this.lblidcaja.Name = "lblidcaja";
            this.lblidcaja.Size = new System.Drawing.Size(35, 13);
            this.lblidcaja.TabIndex = 11;
            this.lblidcaja.Text = "idcaja";
            // 
            // lblcajatexto
            // 
            this.lblcajatexto.AutoSize = true;
            this.lblcajatexto.Location = new System.Drawing.Point(46, 40);
            this.lblcajatexto.Name = "lblcajatexto";
            this.lblcajatexto.Size = new System.Drawing.Size(50, 13);
            this.lblcajatexto.TabIndex = 12;
            this.lblcajatexto.Text = "cajatexto";
            // 
            // lblserialcaja
            // 
            this.lblserialcaja.AutoSize = true;
            this.lblserialcaja.Location = new System.Drawing.Point(49, 448);
            this.lblserialcaja.Name = "lblserialcaja";
            this.lblserialcaja.Size = new System.Drawing.Size(31, 13);
            this.lblserialcaja.TabIndex = 8;
            this.lblserialcaja.Text = "serial";
            this.lblserialcaja.Click += new System.EventHandler(this.lblserial1_Click);
            // 
            // btn_licencia
            // 
            this.btn_licencia.AutoSize = true;
            this.btn_licencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_licencia.Location = new System.Drawing.Point(237, 621);
            this.btn_licencia.Name = "btn_licencia";
            this.btn_licencia.Size = new System.Drawing.Size(60, 17);
            this.btn_licencia.TabIndex = 6;
            this.btn_licencia.Text = "Licencia";
            // 
            // panel_login
            // 
            this.panel_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_login.Controls.Add(this.btn_licencia);
            this.panel_login.Controls.Add(this.pb_licencia);
            this.panel_login.Controls.Add(this.btn_cambiar_usuario);
            this.panel_login.Controls.Add(this.btninicar_sesion);
            this.panel_login.Controls.Add(this.panel3);
            this.panel_login.Controls.Add(this.pb_cargando);
            this.panel_login.Controls.Add(this.flowLayoutPanel2);
            this.panel_login.Controls.Add(this.label2);
            this.panel_login.Location = new System.Drawing.Point(133, 28);
            this.panel_login.Name = "panel_login";
            this.panel_login.Size = new System.Drawing.Size(645, 671);
            this.panel_login.TabIndex = 1;
            this.panel_login.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(976, 749);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel_login);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel_usuarios);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "login";
            this.Text = "iniciar sesion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.login_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_cargando)).EndInit();
            this.panel_usuarios.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ms_ver.ResumeLayout(false);
            this.ms_ver.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_licencia)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datalistado_detalle_cierre_de_caja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_validar_movimientos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.panel_login.ResumeLayout(false);
            this.panel_login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer_cargando;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pb_cargando;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel_usuarios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btn_num1;
        private System.Windows.Forms.Button btn_num2;
        private System.Windows.Forms.Button btn_num3;
        private System.Windows.Forms.Button btn_num4;
        private System.Windows.Forms.Button btn_num5;
        private System.Windows.Forms.Button btn_num6;
        private System.Windows.Forms.Button btn_num7;
        private System.Windows.Forms.Button btn_num8;
        private System.Windows.Forms.Button btn_num9;
        private System.Windows.Forms.Button btn_borrar_todo;
        private System.Windows.Forms.Button btn_num0;
        private System.Windows.Forms.Button btn_borrar_caracter;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MenuStrip ms_ver;
        private System.Windows.Forms.ToolStripMenuItem btn_ver;
        private System.Windows.Forms.ToolStripMenuItem btn_no_ver;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txt_login_password;
        private System.Windows.Forms.Button btninicar_sesion;
        private System.Windows.Forms.Button btn_cambiar_usuario;
        private System.Windows.Forms.PictureBox pb_licencia;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView datalistado_detalle_cierre_de_caja;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn4;
        private System.Windows.Forms.Label lblpermiso_caja;
        private System.Windows.Forms.Label lblnombre_cajero;
        private System.Windows.Forms.Label lbl_usuario_inicio_caja;
        private System.Windows.Forms.DataGridView dgv_validar_movimientos;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.DataGridView dgv_listado;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Label lblapertura_de_caja;
        private System.Windows.Forms.Label lbl_id_usuario;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblrol;
        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.TextBox lblserial;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblidcaja;
        private System.Windows.Forms.Label lblcajatexto;
        private System.Windows.Forms.Label lblserialcaja;
        private System.Windows.Forms.Label btn_licencia;
        private System.Windows.Forms.Panel panel_login;
    }
}