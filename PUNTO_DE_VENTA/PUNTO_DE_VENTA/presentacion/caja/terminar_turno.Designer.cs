
namespace PUNTO_DE_VENTA.presentacion.caja
{
    partial class terminar_turno
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_esperado = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_efectivo = new System.Windows.Forms.TextBox();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_cerrar_turno = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_cerrar_turno);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbl_resultado);
            this.groupBox1.Controls.Add(this.txt_efectivo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbl_esperado);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 375);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Terminar turno ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Efectivo esperado en caja";
            // 
            // lbl_esperado
            // 
            this.lbl_esperado.AutoSize = true;
            this.lbl_esperado.Location = new System.Drawing.Point(256, 55);
            this.lbl_esperado.Name = "lbl_esperado";
            this.lbl_esperado.Size = new System.Drawing.Size(20, 24);
            this.lbl_esperado.TabIndex = 1;
            this.lbl_esperado.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Efectivo en caja:";
            // 
            // txt_efectivo
            // 
            this.txt_efectivo.Location = new System.Drawing.Point(165, 132);
            this.txt_efectivo.Name = "txt_efectivo";
            this.txt_efectivo.Size = new System.Drawing.Size(159, 29);
            this.txt_efectivo.TabIndex = 3;
            this.txt_efectivo.TextChanged += new System.EventHandler(this.txt_efectivo_TextChanged);
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Location = new System.Drawing.Point(129, 222);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(20, 24);
            this.lbl_resultado.TabIndex = 4;
            this.lbl_resultado.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Resultado";
            // 
            // btn_cerrar_turno
            // 
            this.btn_cerrar_turno.BackColor = System.Drawing.Color.Red;
            this.btn_cerrar_turno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar_turno.ForeColor = System.Drawing.Color.White;
            this.btn_cerrar_turno.Location = new System.Drawing.Point(27, 295);
            this.btn_cerrar_turno.Name = "btn_cerrar_turno";
            this.btn_cerrar_turno.Size = new System.Drawing.Size(162, 39);
            this.btn_cerrar_turno.TabIndex = 25;
            this.btn_cerrar_turno.Text = "terminar turno";
            this.btn_cerrar_turno.UseVisualStyleBackColor = false;
            this.btn_cerrar_turno.Click += new System.EventHandler(this.btn_cerrar_turno_Click);
            // 
            // terminar_turno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(410, 375);
            this.Controls.Add(this.groupBox1);
            this.Name = "terminar_turno";
            this.Text = "terminar_turno";
            this.Load += new System.EventHandler(this.terminar_turno_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_esperado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.TextBox txt_efectivo;
        private System.Windows.Forms.Button btn_cerrar_turno;
    }
}