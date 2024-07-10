
namespace PUNTO_DE_VENTA.presentacion.remota
{
    partial class caja_remota
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
            this.label7 = new System.Windows.Forms.Label();
            this.txtnombre_caja = new System.Windows.Forms.TextBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btnsiguiente = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_cancelar);
            this.panel1.Controls.Add(this.btnsiguiente);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtnombre_caja);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 123);
            this.panel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "Caja:";
            // 
            // txtnombre_caja
            // 
            this.txtnombre_caja.BackColor = System.Drawing.Color.White;
            this.txtnombre_caja.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre_caja.Location = new System.Drawing.Point(70, 12);
            this.txtnombre_caja.Multiline = true;
            this.txtnombre_caja.Name = "txtnombre_caja";
            this.txtnombre_caja.Size = new System.Drawing.Size(409, 31);
            this.txtnombre_caja.TabIndex = 11;
            this.txtnombre_caja.Text = "Nombre de Caja";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Red;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Location = new System.Drawing.Point(380, 70);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(99, 41);
            this.btn_cancelar.TabIndex = 14;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btnsiguiente
            // 
            this.btnsiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnsiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsiguiente.ForeColor = System.Drawing.Color.White;
            this.btnsiguiente.Location = new System.Drawing.Point(271, 70);
            this.btnsiguiente.Name = "btnsiguiente";
            this.btnsiguiente.Size = new System.Drawing.Size(103, 41);
            this.btnsiguiente.TabIndex = 13;
            this.btnsiguiente.Text = "Siguiente ";
            this.btnsiguiente.UseVisualStyleBackColor = false;
            this.btnsiguiente.Click += new System.EventHandler(this.btnsiguiente_Click);
            // 
            // caja_remota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(545, 195);
            this.Controls.Add(this.panel1);
            this.Name = "caja_remota";
            this.Text = "caja_remota";
            this.Load += new System.EventHandler(this.caja_remota_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtnombre_caja;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btnsiguiente;
    }
}