
namespace PUNTO_DE_VENTA.presentacion.notificaciones
{
    partial class form_notificaciones
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
            this.panel_notificaciones = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel_notificaciones
            // 
            this.panel_notificaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_notificaciones.Location = new System.Drawing.Point(0, 0);
            this.panel_notificaciones.Name = "panel_notificaciones";
            this.panel_notificaciones.Size = new System.Drawing.Size(489, 548);
            this.panel_notificaciones.TabIndex = 0;
            // 
            // form_notificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(489, 548);
            this.Controls.Add(this.panel_notificaciones);
            this.Name = "form_notificaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_notificaciones";
            this.Load += new System.EventHandler(this.form_notificaciones_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_notificaciones;
    }
}