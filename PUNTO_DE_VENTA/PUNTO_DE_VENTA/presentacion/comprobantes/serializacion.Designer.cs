
namespace PUNTO_DE_VENTA.presentacion.comprobantes
{
    partial class serializacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(serializacion));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.btn_agregar_comprobante = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv_comprobantes = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_factura = new System.Windows.Forms.Panel();
            this.txt_tipo_comprobante = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.cb_elegir_defecto = new System.Windows.Forms.CheckBox();
            this.txt_numerofin = new System.Windows.Forms.TextBox();
            this.txt_num_serie = new System.Windows.Forms.TextBox();
            this.txt_cantidad_de_ceros = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_comprobantes)).BeginInit();
            this.panel_factura.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(996, 88);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "CREACION DE COMPROBANTES";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Controls.Add(this.menuStrip2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(996, 46);
            this.panel2.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(312, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(199, 40);
            this.menuStrip1.TabIndex = 564;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(191, 36);
            this.toolStripMenuItem1.Text = "Eliminar comprobantes";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_agregar_comprobante});
            this.menuStrip2.Location = new System.Drawing.Point(113, 3);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(199, 40);
            this.menuStrip2.TabIndex = 23;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // btn_agregar_comprobante
            // 
            this.btn_agregar_comprobante.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btn_agregar_comprobante.Image = ((System.Drawing.Image)(resources.GetObject("btn_agregar_comprobante.Image")));
            this.btn_agregar_comprobante.Name = "btn_agregar_comprobante";
            this.btn_agregar_comprobante.Size = new System.Drawing.Size(185, 36);
            this.btn_agregar_comprobante.Text = "Agregar comprobante";
            this.btn_agregar_comprobante.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // dgv_comprobantes
            // 
            this.dgv_comprobantes.AllowUserToAddRows = false;
            this.dgv_comprobantes.AllowUserToDeleteRows = false;
            this.dgv_comprobantes.BackgroundColor = System.Drawing.Color.White;
            this.dgv_comprobantes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_comprobantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_comprobantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgv_comprobantes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_comprobantes.Location = new System.Drawing.Point(0, 134);
            this.dgv_comprobantes.Name = "dgv_comprobantes";
            this.dgv_comprobantes.ReadOnly = true;
            this.dgv_comprobantes.Size = new System.Drawing.Size(996, 733);
            this.dgv_comprobantes.TabIndex = 3;
            this.dgv_comprobantes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_comprobantes_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // panel_factura
            // 
            this.panel_factura.Controls.Add(this.txt_tipo_comprobante);
            this.panel_factura.Controls.Add(this.flowLayoutPanel1);
            this.panel_factura.Controls.Add(this.cb_elegir_defecto);
            this.panel_factura.Controls.Add(this.txt_numerofin);
            this.panel_factura.Controls.Add(this.txt_num_serie);
            this.panel_factura.Controls.Add(this.txt_cantidad_de_ceros);
            this.panel_factura.Controls.Add(this.pictureBox1);
            this.panel_factura.Location = new System.Drawing.Point(12, 157);
            this.panel_factura.Name = "panel_factura";
            this.panel_factura.Size = new System.Drawing.Size(1368, 653);
            this.panel_factura.TabIndex = 4;
            this.panel_factura.Visible = false;
            // 
            // txt_tipo_comprobante
            // 
            this.txt_tipo_comprobante.Location = new System.Drawing.Point(281, 144);
            this.txt_tipo_comprobante.Multiline = true;
            this.txt_tipo_comprobante.Name = "txt_tipo_comprobante";
            this.txt_tipo_comprobante.Size = new System.Drawing.Size(132, 22);
            this.txt_tipo_comprobante.TabIndex = 570;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn_guardar);
            this.flowLayoutPanel1.Controls.Add(this.btn_actualizar);
            this.flowLayoutPanel1.Controls.Add(this.btn_cancelar);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(716, 285);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(176, 145);
            this.flowLayoutPanel1.TabIndex = 564;
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.LightGray;
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Location = new System.Drawing.Point(3, 3);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(165, 41);
            this.btn_guardar.TabIndex = 2;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.bnt_guardar_Click);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.BackColor = System.Drawing.Color.LightGray;
            this.btn_actualizar.FlatAppearance.BorderSize = 0;
            this.btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actualizar.Location = new System.Drawing.Point(3, 50);
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
            this.btn_cancelar.Location = new System.Drawing.Point(3, 97);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(165, 41);
            this.btn_cancelar.TabIndex = 562;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // cb_elegir_defecto
            // 
            this.cb_elegir_defecto.AutoSize = true;
            this.cb_elegir_defecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_elegir_defecto.Location = new System.Drawing.Point(716, 498);
            this.cb_elegir_defecto.Name = "cb_elegir_defecto";
            this.cb_elegir_defecto.Size = new System.Drawing.Size(176, 28);
            this.cb_elegir_defecto.TabIndex = 568;
            this.cb_elegir_defecto.Text = "elegir por defecto";
            this.cb_elegir_defecto.UseVisualStyleBackColor = true;
            // 
            // txt_numerofin
            // 
            this.txt_numerofin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numerofin.Location = new System.Drawing.Point(665, 208);
            this.txt_numerofin.Name = "txt_numerofin";
            this.txt_numerofin.Size = new System.Drawing.Size(164, 29);
            this.txt_numerofin.TabIndex = 567;
            // 
            // txt_num_serie
            // 
            this.txt_num_serie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_num_serie.Location = new System.Drawing.Point(665, 111);
            this.txt_num_serie.Name = "txt_num_serie";
            this.txt_num_serie.Size = new System.Drawing.Size(174, 29);
            this.txt_num_serie.TabIndex = 566;
            // 
            // txt_cantidad_de_ceros
            // 
            this.txt_cantidad_de_ceros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad_de_ceros.Location = new System.Drawing.Point(665, 28);
            this.txt_cantidad_de_ceros.Name = "txt_cantidad_de_ceros";
            this.txt_cantidad_de_ceros.Size = new System.Drawing.Size(174, 29);
            this.txt_cantidad_de_ceros.TabIndex = 565;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(948, 678);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 569;
            this.pictureBox1.TabStop = false;
            // 
            // serializacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(996, 867);
            this.Controls.Add(this.panel_factura);
            this.Controls.Add(this.dgv_comprobantes);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "serializacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "serializacion";
            this.Load += new System.EventHandler(this.serializacion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_comprobantes)).EndInit();
            this.panel_factura.ResumeLayout(false);
            this.panel_factura.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv_comprobantes;
        private System.Windows.Forms.Panel panel_factura;
        private System.Windows.Forms.CheckBox cb_elegir_defecto;
        private System.Windows.Forms.TextBox txt_numerofin;
        private System.Windows.Forms.TextBox txt_num_serie;
        private System.Windows.Forms.TextBox txt_cantidad_de_ceros;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem btn_agregar_comprobante;
        private System.Windows.Forms.TextBox txt_tipo_comprobante;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}