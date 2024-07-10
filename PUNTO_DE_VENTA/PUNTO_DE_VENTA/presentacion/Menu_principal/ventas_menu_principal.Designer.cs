namespace PUNTO_DE_VENTA.presentacion.Menu_principal
{
    partial class ventas_menu_principal
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
            this.btn_cerrar_turno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_cerrar_turno
            // 
            this.btn_cerrar_turno.Location = new System.Drawing.Point(278, 145);
            this.btn_cerrar_turno.Name = "btn_cerrar_turno";
            this.btn_cerrar_turno.Size = new System.Drawing.Size(247, 132);
            this.btn_cerrar_turno.TabIndex = 0;
            this.btn_cerrar_turno.Text = "Cerrar turno";
            this.btn_cerrar_turno.UseVisualStyleBackColor = true;
            this.btn_cerrar_turno.Click += new System.EventHandler(this.btn_cerrar_turno_Click);
            // 
            // ventas_menu_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_cerrar_turno);
            this.Name = "ventas_menu_principal";
            this.Text = "ventas_menu_principal";
            this.Load += new System.EventHandler(this.ventas_menu_principal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_cerrar_turno;
    }
}