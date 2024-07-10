
namespace PUNTO_DE_VENTA.presentacion.asistente_de_instalacion_servidor
{
    partial class e_servidor_remoto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(e_servidor_remoto));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_todo = new System.Windows.Forms.Panel();
            this.dgv_usuarios_registrados = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_secundaria = new System.Windows.Forms.Button();
            this.btn_principal = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel_todo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios_registrados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1375, 81);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "PUNTO DE VENTA";
            // 
            // panel_todo
            // 
            this.panel_todo.Controls.Add(this.dgv_usuarios_registrados);
            this.panel_todo.Controls.Add(this.label3);
            this.panel_todo.Controls.Add(this.label2);
            this.panel_todo.Controls.Add(this.btn_secundaria);
            this.panel_todo.Controls.Add(this.btn_principal);
            this.panel_todo.Controls.Add(this.pictureBox1);
            this.panel_todo.Location = new System.Drawing.Point(198, 99);
            this.panel_todo.Name = "panel_todo";
            this.panel_todo.Size = new System.Drawing.Size(917, 518);
            this.panel_todo.TabIndex = 1;
            // 
            // dgv_usuarios_registrados
            // 
            this.dgv_usuarios_registrados.AllowUserToAddRows = false;
            this.dgv_usuarios_registrados.BackgroundColor = System.Drawing.Color.White;
            this.dgv_usuarios_registrados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_usuarios_registrados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_usuarios_registrados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_usuarios_registrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_usuarios_registrados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewImageColumn1});
            this.dgv_usuarios_registrados.EnableHeadersVisualStyles = false;
            this.dgv_usuarios_registrados.GridColor = System.Drawing.Color.White;
            this.dgv_usuarios_registrados.Location = new System.Drawing.Point(13, 77);
            this.dgv_usuarios_registrados.Name = "dgv_usuarios_registrados";
            this.dgv_usuarios_registrados.ReadOnly = true;
            this.dgv_usuarios_registrados.RowHeadersVisible = false;
            this.dgv_usuarios_registrados.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_usuarios_registrados.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.dgv_usuarios_registrados.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dgv_usuarios_registrados.RowTemplate.Height = 30;
            this.dgv_usuarios_registrados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_usuarios_registrados.Size = new System.Drawing.Size(100, 45);
            this.dgv_usuarios_registrados.TabIndex = 623;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(689, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 75);
            this.label3.TabIndex = 4;
            this.label3.Text = "Se conecta a la computadora principal ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(596, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 84);
            this.label2.TabIndex = 3;
            this.label2.Text = "Esta computadora debe estar encendida para que las computadoras secundarias funci" +
    "onen.\r\nSi esta apagada las demas no podran funcionar";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_secundaria
            // 
            this.btn_secundaria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(190)))), ((int)(((byte)(197)))));
            this.btn_secundaria.FlatAppearance.BorderSize = 0;
            this.btn_secundaria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_secundaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_secundaria.Location = new System.Drawing.Point(85, 335);
            this.btn_secundaria.Margin = new System.Windows.Forms.Padding(0);
            this.btn_secundaria.Name = "btn_secundaria";
            this.btn_secundaria.Size = new System.Drawing.Size(159, 63);
            this.btn_secundaria.TabIndex = 2;
            this.btn_secundaria.Text = "SECUNDARIA";
            this.btn_secundaria.UseVisualStyleBackColor = false;
            this.btn_secundaria.Click += new System.EventHandler(this.btn_secundaria_Click);
            // 
            // btn_principal
            // 
            this.btn_principal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(190)))), ((int)(((byte)(197)))));
            this.btn_principal.FlatAppearance.BorderSize = 0;
            this.btn_principal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_principal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_principal.Location = new System.Drawing.Point(221, 64);
            this.btn_principal.Margin = new System.Windows.Forms.Padding(0);
            this.btn_principal.Name = "btn_principal";
            this.btn_principal.Size = new System.Drawing.Size(164, 58);
            this.btn_principal.TabIndex = 1;
            this.btn_principal.Text = "PRINCIPAL";
            this.btn_principal.UseVisualStyleBackColor = false;
            this.btn_principal.Click += new System.EventHandler(this.btn_principal_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(140, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(744, 443);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // e_servidor_remoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1375, 701);
            this.Controls.Add(this.panel_todo);
            this.Controls.Add(this.panel1);
            this.Name = "e_servidor_remoto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.e_servidor_remoto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_todo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios_registrados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_todo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_secundaria;
        private System.Windows.Forms.Button btn_principal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgv_usuarios_registrados;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
    }
}