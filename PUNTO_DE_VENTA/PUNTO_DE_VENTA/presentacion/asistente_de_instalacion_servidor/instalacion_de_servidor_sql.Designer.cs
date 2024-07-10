
namespace PUNTO_DE_VENTA.presentacion.asistente_de_instalacion_servidor
{
    partial class instalacion_de_servidor_sql
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(instalacion_de_servidor_sql));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_usuario_crear = new System.Windows.Forms.TextBox();
            this.txtargumentos = new System.Windows.Forms.TextBox();
            this.lblmili = new System.Windows.Forms.Label();
            this.txtscript = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblminutos = new System.Windows.Forms.Label();
            this.lblsegundos = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtnombre_sevidor = new System.Windows.Forms.TextBox();
            this.txteliminarbase = new System.Windows.Forms.TextBox();
            this.script = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.txtnombre_base = new System.Windows.Forms.TextBox();
            this.txtinstancia = new System.Windows.Forms.TextBox();
            this.panel_instalar = new System.Windows.Forms.Panel();
            this.panel_btn_instalar = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel_instalando = new System.Windows.Forms.Panel();
            this.lbluscando = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mil = new System.Windows.Forms.Label();
            this.seg = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer_crear_ini = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel_instalar.SuspendLayout();
            this.panel_btn_instalar.SuspendLayout();
            this.panel_instalando.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(554, 51);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(53, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(275, 31);
            this.label13.TabIndex = 4;
            this.label13.Text = "Instalador de servidor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(446, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 26);
            this.label1.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txt_usuario);
            this.panel5.Controls.Add(this.txt_usuario_crear);
            this.panel5.Controls.Add(this.txtargumentos);
            this.panel5.Controls.Add(this.lblmili);
            this.panel5.Controls.Add(this.txtscript);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.lblminutos);
            this.panel5.Controls.Add(this.lblsegundos);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.txtnombre_sevidor);
            this.panel5.Controls.Add(this.txteliminarbase);
            this.panel5.Controls.Add(this.script);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.txtcontraseña);
            this.panel5.Controls.Add(this.txtnombre_base);
            this.panel5.Controls.Add(this.txtinstancia);
            this.panel5.Location = new System.Drawing.Point(598, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 10);
            this.panel5.TabIndex = 3;
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(253, 81);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(100, 20);
            this.txt_usuario.TabIndex = 15;
            this.txt_usuario.Text = "user_db";
            // 
            // txt_usuario_crear
            // 
            this.txt_usuario_crear.Location = new System.Drawing.Point(172, 387);
            this.txt_usuario_crear.Multiline = true;
            this.txt_usuario_crear.Name = "txt_usuario_crear";
            this.txt_usuario_crear.Size = new System.Drawing.Size(10, 12);
            this.txt_usuario_crear.TabIndex = 14;
            this.txt_usuario_crear.Text = resources.GetString("txt_usuario_crear.Text");
            // 
            // txtargumentos
            // 
            this.txtargumentos.Location = new System.Drawing.Point(21, 368);
            this.txtargumentos.Multiline = true;
            this.txtargumentos.Name = "txtargumentos";
            this.txtargumentos.Size = new System.Drawing.Size(14, 10);
            this.txtargumentos.TabIndex = 4;
            this.txtargumentos.Text = resources.GetString("txtargumentos.Text");
            // 
            // lblmili
            // 
            this.lblmili.AutoSize = true;
            this.lblmili.Location = new System.Drawing.Point(311, 333);
            this.lblmili.Name = "lblmili";
            this.lblmili.Size = new System.Drawing.Size(19, 13);
            this.lblmili.TabIndex = 8;
            this.lblmili.Text = "00";
            // 
            // txtscript
            // 
            this.txtscript.Location = new System.Drawing.Point(78, 264);
            this.txtscript.Multiline = true;
            this.txtscript.Name = "txtscript";
            this.txtscript.Size = new System.Drawing.Size(10, 10);
            this.txtscript.TabIndex = 12;
            this.txtscript.Text = resources.GetString("txtscript.Text");
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 203);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "nombre servidor";
            // 
            // lblminutos
            // 
            this.lblminutos.AutoSize = true;
            this.lblminutos.Location = new System.Drawing.Point(199, 333);
            this.lblminutos.Name = "lblminutos";
            this.lblminutos.Size = new System.Drawing.Size(19, 13);
            this.lblminutos.TabIndex = 7;
            this.lblminutos.Text = "00";
            // 
            // lblsegundos
            // 
            this.lblsegundos.AutoSize = true;
            this.lblsegundos.Location = new System.Drawing.Point(250, 333);
            this.lblsegundos.Name = "lblsegundos";
            this.lblsegundos.Size = new System.Drawing.Size(19, 13);
            this.lblsegundos.TabIndex = 6;
            this.lblsegundos.Text = "00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(134, 290);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "label10";
            // 
            // txtnombre_sevidor
            // 
            this.txtnombre_sevidor.Location = new System.Drawing.Point(115, 203);
            this.txtnombre_sevidor.Name = "txtnombre_sevidor";
            this.txtnombre_sevidor.Size = new System.Drawing.Size(133, 20);
            this.txtnombre_sevidor.TabIndex = 9;
            this.txtnombre_sevidor.Text = ".";
            // 
            // txteliminarbase
            // 
            this.txteliminarbase.Location = new System.Drawing.Point(253, 228);
            this.txteliminarbase.Multiline = true;
            this.txteliminarbase.Name = "txteliminarbase";
            this.txteliminarbase.Size = new System.Drawing.Size(229, 85);
            this.txteliminarbase.TabIndex = 8;
            this.txteliminarbase.Text = "alter database daaa set single_user with rollback immediate drop database daaa";
            // 
            // script
            // 
            this.script.Location = new System.Drawing.Point(106, 164);
            this.script.Name = "script";
            this.script.Size = new System.Drawing.Size(100, 20);
            this.script.TabIndex = 7;
            this.script.Text = "Script";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "nombre script";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "contraseña ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "base ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "nombre instancia";
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.Location = new System.Drawing.Point(106, 94);
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.Size = new System.Drawing.Size(100, 20);
            this.txtcontraseña.TabIndex = 2;
            this.txtcontraseña.Text = "jb&db$Z10";
            // 
            // txtnombre_base
            // 
            this.txtnombre_base.Location = new System.Drawing.Point(106, 132);
            this.txtnombre_base.Name = "txtnombre_base";
            this.txtnombre_base.Size = new System.Drawing.Size(100, 20);
            this.txtnombre_base.TabIndex = 1;
            this.txtnombre_base.Text = "base_datos";
            // 
            // txtinstancia
            // 
            this.txtinstancia.Location = new System.Drawing.Point(115, 53);
            this.txtinstancia.Name = "txtinstancia";
            this.txtinstancia.Size = new System.Drawing.Size(100, 20);
            this.txtinstancia.TabIndex = 0;
            this.txtinstancia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel_instalar
            // 
            this.panel_instalar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_instalar.Controls.Add(this.panel_btn_instalar);
            this.panel_instalar.Location = new System.Drawing.Point(79, 55);
            this.panel_instalar.Name = "panel_instalar";
            this.panel_instalar.Size = new System.Drawing.Size(385, 363);
            this.panel_instalar.TabIndex = 1;
            // 
            // panel_btn_instalar
            // 
            this.panel_btn_instalar.Controls.Add(this.label5);
            this.panel_btn_instalar.Location = new System.Drawing.Point(55, 49);
            this.panel_btn_instalar.Name = "panel_btn_instalar";
            this.panel_btn_instalar.Size = new System.Drawing.Size(331, 231);
            this.panel_btn_instalar.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(304, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Buscando servidores instalados...";
            // 
            // panel_instalando
            // 
            this.panel_instalando.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_instalando.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_instalando.Controls.Add(this.lbluscando);
            this.panel_instalando.Controls.Add(this.label12);
            this.panel_instalando.Controls.Add(this.label4);
            this.panel_instalando.Controls.Add(this.pictureBox1);
            this.panel_instalando.Controls.Add(this.label3);
            this.panel_instalando.Controls.Add(this.label2);
            this.panel_instalando.Controls.Add(this.mil);
            this.panel_instalando.Controls.Add(this.seg);
            this.panel_instalando.ForeColor = System.Drawing.Color.White;
            this.panel_instalando.Location = new System.Drawing.Point(59, 55);
            this.panel_instalando.Name = "panel_instalando";
            this.panel_instalando.Size = new System.Drawing.Size(406, 390);
            this.panel_instalando.TabIndex = 0;
            // 
            // lbluscando
            // 
            this.lbluscando.AutoSize = true;
            this.lbluscando.BackColor = System.Drawing.Color.Red;
            this.lbluscando.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluscando.Location = new System.Drawing.Point(3, 3);
            this.lbluscando.Name = "lbluscando";
            this.lbluscando.Size = new System.Drawing.Size(64, 17);
            this.lbluscando.TabIndex = 2;
            this.lbluscando.Text = "instancia";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(42, 225);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 22);
            this.label12.TabIndex = 5;
            this.label12.Text = "Tiempo actual:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tiempo estimado: 6 minutos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(131, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(328, 64);
            this.label3.TabIndex = 1;
            this.label3.Text = "No cierre esta venta, se cerrara automaticamente cuando este todo listo";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "INSTALANDO SERVIDOR";
            // 
            // mil
            // 
            this.mil.AutoSize = true;
            this.mil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mil.Location = new System.Drawing.Point(213, 225);
            this.mil.Name = "mil";
            this.mil.Size = new System.Drawing.Size(27, 20);
            this.mil.TabIndex = 3;
            this.mil.Text = "00";
            // 
            // seg
            // 
            this.seg.AutoSize = true;
            this.seg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seg.Location = new System.Drawing.Point(175, 225);
            this.seg.Name = "seg";
            this.seg.Size = new System.Drawing.Size(27, 20);
            this.seg.TabIndex = 4;
            this.seg.Text = "00";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer_crear_ini
            // 
            this.timer_crear_ini.Interval = 10;
            this.timer_crear_ini.Tick += new System.EventHandler(this.timer_crear_ini_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // instalacion_de_servidor_sql
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(554, 509);
            this.Controls.Add(this.panel_instalando);
            this.Controls.Add(this.panel_instalar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "instalacion_de_servidor_sql";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "instalacion_de_servidor_sql";
            this.Load += new System.EventHandler(this.instalacion_de_servidor_sql_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel_instalar.ResumeLayout(false);
            this.panel_btn_instalar.ResumeLayout(false);
            this.panel_instalando.ResumeLayout(false);
            this.panel_instalando.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_instalar;
        private System.Windows.Forms.Panel panel_instalando;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel_btn_instalar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txteliminarbase;
        private System.Windows.Forms.TextBox script;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtcontraseña;
        private System.Windows.Forms.TextBox txtnombre_base;
        private System.Windows.Forms.TextBox txtinstancia;
        private System.Windows.Forms.TextBox txtnombre_sevidor;
        private System.Windows.Forms.TextBox txtscript;
        private System.Windows.Forms.Label lbluscando;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label seg;
        private System.Windows.Forms.Label mil;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtargumentos;
        private System.Windows.Forms.Timer timer_crear_ini;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblmili;
        private System.Windows.Forms.Label lblminutos;
        private System.Windows.Forms.Label lblsegundos;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_usuario_crear;
        private System.Windows.Forms.Label label13;
    }
}