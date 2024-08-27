namespace PruebaQr
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmdGenerarQr = new System.Windows.Forms.Button();
            this.cmdLeerQr = new System.Windows.Forms.Button();
            this.txtQr = new System.Windows.Forms.TextBox();
            this.txtBarras = new System.Windows.Forms.TextBox();
            this.cmdLeerBarras = new System.Windows.Forms.Button();
            this.cmdGenerarBarras = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(50, 188);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 181);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cmdGenerarQr
            // 
            this.cmdGenerarQr.Location = new System.Drawing.Point(50, 25);
            this.cmdGenerarQr.Name = "cmdGenerarQr";
            this.cmdGenerarQr.Size = new System.Drawing.Size(107, 38);
            this.cmdGenerarQr.TabIndex = 1;
            this.cmdGenerarQr.Text = "Generar Qr";
            this.cmdGenerarQr.UseVisualStyleBackColor = true;
            this.cmdGenerarQr.Click += new System.EventHandler(this.cmdGenerarQr_Click);
            // 
            // cmdLeerQr
            // 
            this.cmdLeerQr.Location = new System.Drawing.Point(175, 25);
            this.cmdLeerQr.Name = "cmdLeerQr";
            this.cmdLeerQr.Size = new System.Drawing.Size(109, 38);
            this.cmdLeerQr.TabIndex = 2;
            this.cmdLeerQr.Text = "Leer Qr";
            this.cmdLeerQr.UseVisualStyleBackColor = true;
            this.cmdLeerQr.Click += new System.EventHandler(this.cmdLeerQr_Click);
            // 
            // txtQr
            // 
            this.txtQr.Location = new System.Drawing.Point(50, 69);
            this.txtQr.Name = "txtQr";
            this.txtQr.Size = new System.Drawing.Size(234, 20);
            this.txtQr.TabIndex = 3;
            // 
            // txtBarras
            // 
            this.txtBarras.Location = new System.Drawing.Point(380, 69);
            this.txtBarras.Name = "txtBarras";
            this.txtBarras.Size = new System.Drawing.Size(234, 20);
            this.txtBarras.TabIndex = 7;
            // 
            // cmdLeerBarras
            // 
            this.cmdLeerBarras.Location = new System.Drawing.Point(505, 25);
            this.cmdLeerBarras.Name = "cmdLeerBarras";
            this.cmdLeerBarras.Size = new System.Drawing.Size(109, 38);
            this.cmdLeerBarras.TabIndex = 6;
            this.cmdLeerBarras.Text = "Leer Barras";
            this.cmdLeerBarras.UseVisualStyleBackColor = true;
            this.cmdLeerBarras.Click += new System.EventHandler(this.cmdLeerBarras_Click);
            // 
            // cmdGenerarBarras
            // 
            this.cmdGenerarBarras.Location = new System.Drawing.Point(380, 25);
            this.cmdGenerarBarras.Name = "cmdGenerarBarras";
            this.cmdGenerarBarras.Size = new System.Drawing.Size(107, 38);
            this.cmdGenerarBarras.TabIndex = 5;
            this.cmdGenerarBarras.Text = "Generar Barras";
            this.cmdGenerarBarras.UseVisualStyleBackColor = true;
            this.cmdGenerarBarras.Click += new System.EventHandler(this.cmdGenerarBarras_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(380, 188);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(234, 181);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBarras);
            this.Controls.Add(this.cmdLeerBarras);
            this.Controls.Add(this.cmdGenerarBarras);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtQr);
            this.Controls.Add(this.cmdLeerQr);
            this.Controls.Add(this.cmdGenerarQr);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cmdGenerarQr;
        private System.Windows.Forms.Button cmdLeerQr;
        private System.Windows.Forms.TextBox txtQr;
        private System.Windows.Forms.TextBox txtBarras;
        private System.Windows.Forms.Button cmdLeerBarras;
        private System.Windows.Forms.Button cmdGenerarBarras;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

