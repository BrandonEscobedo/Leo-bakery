
namespace PUNTO_DE_VENTA.presentacion.Menu_principal
{
    partial class granel
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
            this.lbl_producto = new System.Windows.Forms.Label();
            this.lbl_cantidad_aumentar = new System.Windows.Forms.Label();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.txt_importe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_precio_unidad = new System.Windows.Forms.Label();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_producto
            // 
            this.lbl_producto.AutoSize = true;
            this.lbl_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_producto.Location = new System.Drawing.Point(28, 9);
            this.lbl_producto.Name = "lbl_producto";
            this.lbl_producto.Size = new System.Drawing.Size(161, 40);
            this.lbl_producto.TabIndex = 0;
            this.lbl_producto.Text = "Producto";
            // 
            // lbl_cantidad_aumentar
            // 
            this.lbl_cantidad_aumentar.AutoSize = true;
            this.lbl_cantidad_aumentar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidad_aumentar.Location = new System.Drawing.Point(49, 58);
            this.lbl_cantidad_aumentar.Name = "lbl_cantidad_aumentar";
            this.lbl_cantidad_aumentar.Size = new System.Drawing.Size(29, 31);
            this.lbl_cantidad_aumentar.TabIndex = 1;
            this.lbl_cantidad_aumentar.Text = "0";
            this.lbl_cantidad_aumentar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.BackColor = System.Drawing.Color.White;
            this.txt_cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad.Location = new System.Drawing.Point(35, 142);
            this.txt_cantidad.Multiline = true;
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(196, 39);
            this.txt_cantidad.TabIndex = 2;
            this.txt_cantidad.TextChanged += new System.EventHandler(this.txt_cantidad_TextChanged);
            // 
            // txt_importe
            // 
            this.txt_importe.BackColor = System.Drawing.Color.White;
            this.txt_importe.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_importe.Location = new System.Drawing.Point(257, 142);
            this.txt_importe.Multiline = true;
            this.txt_importe.Name = "txt_importe";
            this.txt_importe.Size = new System.Drawing.Size(196, 39);
            this.txt_importe.TabIndex = 3;
            this.txt_importe.TextChanged += new System.EventHandler(this.txt_importe_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cantidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(265, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Importe actual";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Precio por unidad:";
            // 
            // lbl_precio_unidad
            // 
            this.lbl_precio_unidad.AutoSize = true;
            this.lbl_precio_unidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precio_unidad.Location = new System.Drawing.Point(268, 212);
            this.lbl_precio_unidad.Name = "lbl_precio_unidad";
            this.lbl_precio_unidad.Size = new System.Drawing.Size(29, 31);
            this.lbl_precio_unidad.TabIndex = 7;
            this.lbl_precio_unidad.Text = "0";
            this.lbl_precio_unidad.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_precio_unidad.Click += new System.EventHandler(this.lbl_precio_unidad_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.Lime;
            this.btn_agregar.FlatAppearance.BorderSize = 0;
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.Location = new System.Drawing.Point(472, 108);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(98, 44);
            this.btn_agregar.TabIndex = 8;
            this.btn_agregar.Text = "agregar";
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Red;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Location = new System.Drawing.Point(472, 164);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(98, 44);
            this.btn_cancelar.TabIndex = 9;
            this.btn_cancelar.Text = "cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // granel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(604, 292);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.lbl_precio_unidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_importe);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.lbl_cantidad_aumentar);
            this.Controls.Add(this.lbl_producto);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "granel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "granel";
            this.Load += new System.EventHandler(this.granel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_producto;
        private System.Windows.Forms.Label lbl_cantidad_aumentar;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.TextBox txt_importe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_precio_unidad;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_cancelar;
    }
}