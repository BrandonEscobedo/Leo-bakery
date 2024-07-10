namespace PUNTO_DE_VENTA.presentacion.caja
{
    partial class apertura_de_caja
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.txt_efectivo = new System.Windows.Forms.TextBox();
            this.btn_omitir = new System.Windows.Forms.Button();
            this.btn_inicar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txt_efectivo);
            this.panel1.Controls.Add(this.btn_omitir);
            this.panel1.Controls.Add(this.btn_inicar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(50, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 188);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv1);
            this.panel2.Location = new System.Drawing.Point(396, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(33, 21);
            this.panel2.TabIndex = 15;
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
            this.dgv1.Location = new System.Drawing.Point(-25, 20);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.RowHeadersVisible = false;
            this.dgv1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.dgv1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dgv1.RowTemplate.Height = 30;
            this.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv1.Size = new System.Drawing.Size(113, 60);
            this.dgv1.TabIndex = 15;
            // 
            // txt_efectivo
            // 
            this.txt_efectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_efectivo.Location = new System.Drawing.Point(99, 79);
            this.txt_efectivo.Multiline = true;
            this.txt_efectivo.Name = "txt_efectivo";
            this.txt_efectivo.Size = new System.Drawing.Size(230, 41);
            this.txt_efectivo.TabIndex = 4;
            this.txt_efectivo.TextChanged += new System.EventHandler(this.txt_efectivo_TextChanged);
            this.txt_efectivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_efectivo_KeyPress);
            // 
            // btn_omitir
            // 
            this.btn_omitir.FlatAppearance.BorderSize = 0;
            this.btn_omitir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_omitir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_omitir.Location = new System.Drawing.Point(238, 126);
            this.btn_omitir.Name = "btn_omitir";
            this.btn_omitir.Size = new System.Drawing.Size(91, 32);
            this.btn_omitir.TabIndex = 3;
            this.btn_omitir.Text = "Omitir";
            this.btn_omitir.UseVisualStyleBackColor = true;
            this.btn_omitir.Click += new System.EventHandler(this.btn_omitir_Click);
            // 
            // btn_inicar
            // 
            this.btn_inicar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(69)))), ((int)(((byte)(49)))));
            this.btn_inicar.FlatAppearance.BorderSize = 0;
            this.btn_inicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inicar.ForeColor = System.Drawing.Color.White;
            this.btn_inicar.Location = new System.Drawing.Point(112, 126);
            this.btn_inicar.Name = "btn_inicar";
            this.btn_inicar.Size = new System.Drawing.Size(90, 32);
            this.btn_inicar.TabIndex = 2;
            this.btn_inicar.Text = "Iniciar";
            this.btn_inicar.UseVisualStyleBackColor = false;
            this.btn_inicar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(123, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "¿Efectivo en caja?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dinero en Caja";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // apertura_de_caja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 230);
            this.Controls.Add(this.panel1);
            this.Name = "apertura_de_caja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "apertura_de_caja";
            this.Load += new System.EventHandler(this.apertura_de_caja_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_inicar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_efectivo;
        private System.Windows.Forms.Button btn_omitir;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv1;
    }
}