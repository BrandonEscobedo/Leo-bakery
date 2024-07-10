
namespace PUNTO_DE_VENTA.presentacion.caja
{
    partial class form_cajas
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
            this.buscar_movimientos_filtros_acumuladosTableAdapter1 = new PUNTO_DE_VENTA.bd_PVDataSetTableAdapters.buscar_movimientos_filtros_acumuladosTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_principal = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_e_p2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcaja = new System.Windows.Forms.TextBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnvolver = new System.Windows.Forms.Button();
            this.panel_e_p = new System.Windows.Forms.Panel();
            this.flp_secundarias = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel_e_p2.SuspendLayout();
            this.panel_e_p.SuspendLayout();
            this.SuspendLayout();
            // 
            // buscar_movimientos_filtros_acumuladosTableAdapter1
            // 
            this.buscar_movimientos_filtros_acumuladosTableAdapter1.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel_e_p);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel_principal);
            this.panel1.Controls.Add(this.flp_secundarias);
            this.panel1.Location = new System.Drawing.Point(25, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1231, 669);
            this.panel1.TabIndex = 0;
            // 
            // panel_principal
            // 
            this.panel_principal.BackColor = System.Drawing.Color.White;
            this.panel_principal.Location = new System.Drawing.Point(317, 28);
            this.panel_principal.Name = "panel_principal";
            this.panel_principal.Size = new System.Drawing.Size(250, 223);
            this.panel_principal.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Caja principal";
            // 
            // panel_e_p2
            // 
            this.panel_e_p2.Controls.Add(this.btnvolver);
            this.panel_e_p2.Controls.Add(this.btnguardar);
            this.panel_e_p2.Controls.Add(this.txtcaja);
            this.panel_e_p2.Controls.Add(this.label2);
            this.panel_e_p2.Location = new System.Drawing.Point(18, 14);
            this.panel_e_p2.Name = "panel_e_p2";
            this.panel_e_p2.Size = new System.Drawing.Size(282, 246);
            this.panel_e_p2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "NOMBRE DE LA CAJA";
            // 
            // txtcaja
            // 
            this.txtcaja.Location = new System.Drawing.Point(62, 68);
            this.txtcaja.Name = "txtcaja";
            this.txtcaja.Size = new System.Drawing.Size(181, 20);
            this.txtcaja.TabIndex = 5;
            this.txtcaja.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnguardar
            // 
            this.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardar.Location = new System.Drawing.Point(62, 123);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(171, 42);
            this.btnguardar.TabIndex = 6;
            this.btnguardar.Text = "guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnvolver
            // 
            this.btnvolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnvolver.Location = new System.Drawing.Point(62, 183);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(171, 42);
            this.btnvolver.TabIndex = 7;
            this.btnvolver.Text = "Volver";
            this.btnvolver.UseVisualStyleBackColor = true;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // panel_e_p
            // 
            this.panel_e_p.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_e_p.BackColor = System.Drawing.Color.White;
            this.panel_e_p.Controls.Add(this.panel_e_p2);
            this.panel_e_p.Location = new System.Drawing.Point(629, 3);
            this.panel_e_p.Name = "panel_e_p";
            this.panel_e_p.Size = new System.Drawing.Size(317, 265);
            this.panel_e_p.TabIndex = 1;
            this.panel_e_p.Visible = false;
            // 
            // flp_secundarias
            // 
            this.flp_secundarias.Location = new System.Drawing.Point(100, 372);
            this.flp_secundarias.Name = "flp_secundarias";
            this.flp_secundarias.Size = new System.Drawing.Size(1034, 248);
            this.flp_secundarias.TabIndex = 3;
            // 
            // form_cajas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1273, 720);
            this.Controls.Add(this.panel1);
            this.Name = "form_cajas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_cajas";
            this.Load += new System.EventHandler(this.form_cajas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_e_p2.ResumeLayout(false);
            this.panel_e_p2.PerformLayout();
            this.panel_e_p.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private bd_PVDataSetTableAdapters.buscar_movimientos_filtros_acumuladosTableAdapter buscar_movimientos_filtros_acumuladosTableAdapter1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flp_secundarias;
        private System.Windows.Forms.Panel panel_e_p;
        private System.Windows.Forms.Panel panel_e_p2;
        private System.Windows.Forms.Button btnvolver;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.TextBox txtcaja;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_principal;
    }
}