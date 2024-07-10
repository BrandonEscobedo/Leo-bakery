
namespace PUNTO_DE_VENTA.presentacion.form_cargando
{
    partial class formulario_cargando
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formulario_cargando));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblnombre_usuario = new System.Windows.Forms.Label();
            this.cpb_cargando = new CircularProgressBar.CircularProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1324, 100);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 500);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(689, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 76);
            this.label1.TabIndex = 2;
            this.label1.Text = "BIENVENIDO";
            // 
            // lblnombre_usuario
            // 
            this.lblnombre_usuario.AutoSize = true;
            this.lblnombre_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre_usuario.Location = new System.Drawing.Point(754, 232);
            this.lblnombre_usuario.Name = "lblnombre_usuario";
            this.lblnombre_usuario.Size = new System.Drawing.Size(155, 46);
            this.lblnombre_usuario.TabIndex = 3;
            this.lblnombre_usuario.Text = "nombre";
            // 
            // cpb_cargando
            // 
            this.cpb_cargando.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cpb_cargando.AnimationSpeed = 500;
            this.cpb_cargando.BackColor = System.Drawing.Color.Transparent;
            this.cpb_cargando.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold);
            this.cpb_cargando.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cpb_cargando.InnerColor = System.Drawing.Color.White;
            this.cpb_cargando.InnerMargin = 2;
            this.cpb_cargando.InnerWidth = -1;
            this.cpb_cargando.Location = new System.Drawing.Point(782, 331);
            this.cpb_cargando.MarqueeAnimationSpeed = 2000;
            this.cpb_cargando.Name = "cpb_cargando";
            this.cpb_cargando.OuterColor = System.Drawing.Color.Gray;
            this.cpb_cargando.OuterMargin = -25;
            this.cpb_cargando.OuterWidth = 26;
            this.cpb_cargando.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cpb_cargando.ProgressWidth = 25;
            this.cpb_cargando.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.cpb_cargando.Size = new System.Drawing.Size(163, 168);
            this.cpb_cargando.StartAngle = 270;
            this.cpb_cargando.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.cpb_cargando.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpb_cargando.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.cpb_cargando.SubscriptText = "";
            this.cpb_cargando.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpb_cargando.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cpb_cargando.SuperscriptText = "%";
            this.cpb_cargando.TabIndex = 627;
            this.cpb_cargando.Text = "0";
            this.cpb_cargando.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.cpb_cargando.Value = 68;
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 30;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // formulario_cargando
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1324, 573);
            this.Controls.Add(this.cpb_cargando);
            this.Controls.Add(this.lblnombre_usuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formulario_cargando";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formulario_cargando";
            this.Load += new System.EventHandler(this.formulario_cargando_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblnombre_usuario;
        private CircularProgressBar.CircularProgressBar cpb_cargando;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}