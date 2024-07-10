namespace PUNTO_DE_VENTA.modulos.caja
{
    partial class cierre_de_caja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cierre_de_caja));
            this.button1 = new System.Windows.Forms.Button();
            this.lblserialcaja = new System.Windows.Forms.Label();
            this.lbl_id_caja = new System.Windows.Forms.Label();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(519, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 91);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cerrar turno";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblserialcaja
            // 
            this.lblserialcaja.AutoSize = true;
            this.lblserialcaja.Location = new System.Drawing.Point(383, 180);
            this.lblserialcaja.Name = "lblserialcaja";
            this.lblserialcaja.Size = new System.Drawing.Size(31, 13);
            this.lblserialcaja.TabIndex = 13;
            this.lblserialcaja.Text = "serial";
            // 
            // lbl_id_caja
            // 
            this.lbl_id_caja.AutoSize = true;
            this.lbl_id_caja.Location = new System.Drawing.Point(373, 163);
            this.lbl_id_caja.Name = "lbl_id_caja";
            this.lbl_id_caja.Size = new System.Drawing.Size(41, 13);
            this.lbl_id_caja.TabIndex = 12;
            this.lbl_id_caja.Text = "id_caja";
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
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewImageColumn1});
            this.dgv1.EnableHeadersVisualStyles = false;
            this.dgv1.Location = new System.Drawing.Point(344, 227);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.RowHeadersVisible = false;
            this.dgv1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.dgv1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dgv1.RowTemplate.Height = 30;
            this.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv1.Size = new System.Drawing.Size(276, 96);
            this.dgv1.TabIndex = 14;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            // 
            // dtpfecha
            // 
            this.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpfecha.Location = new System.Drawing.Point(214, 59);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(200, 20);
            this.dtpfecha.TabIndex = 15;
            // 
            // cierre_de_caja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpfecha);
            this.Controls.Add(this.lblserialcaja);
            this.Controls.Add(this.lbl_id_caja);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.button1);
            this.Name = "cierre_de_caja";
            this.Text = "cierre_de_caja";
            this.Load += new System.EventHandler(this.cierre_de_caja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblserialcaja;
        private System.Windows.Forms.Label lbl_id_caja;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DateTimePicker dtpfecha;
    }
}