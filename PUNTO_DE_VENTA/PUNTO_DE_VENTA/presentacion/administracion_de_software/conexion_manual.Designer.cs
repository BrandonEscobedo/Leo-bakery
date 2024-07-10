namespace PUNTO_DE_VENTA.presentacion.administracion_de_software
{
    partial class conexion_manual
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtcnstring = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.datalistado = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.datalistado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ingrese la cadena de conexion local";
            // 
            // txtcnstring
            // 
            this.txtcnstring.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcnstring.Location = new System.Drawing.Point(192, 86);
            this.txtcnstring.Multiline = true;
            this.txtcnstring.Name = "txtcnstring";
            this.txtcnstring.Size = new System.Drawing.Size(421, 125);
            this.txtcnstring.TabIndex = 1;
            this.txtcnstring.TextChanged += new System.EventHandler(this.txtcnstring_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(216, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "btn_guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // datalistado
            // 
            this.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datalistado.Location = new System.Drawing.Point(427, 222);
            this.datalistado.Name = "datalistado";
            this.datalistado.Size = new System.Drawing.Size(240, 150);
            this.datalistado.TabIndex = 3;
            // 
            // conexion_manual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.datalistado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtcnstring);
            this.Controls.Add(this.label1);
            this.Name = "conexion_manual";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.conexion_manual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datalistado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcnstring;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView datalistado;
    }
}