namespace FiltratoImagenes
{
    partial class imgOriginal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirImagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imgResultado = new System.Windows.Forms.PictureBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.imgOriginal2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textmin = new System.Windows.Forms.TextBox();
            this.txtmax = new System.Windows.Forms.TextBox();
            this.lbltipo = new System.Windows.Forms.Label();
            this.lblseleccione = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.histogramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.originalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgResultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOriginal2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1283, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirImagenToolStripMenuItem,
            this.histogramaToolStripMenuItem});
            this.archivoToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(88, 25);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirImagenToolStripMenuItem
            // 
            this.abrirImagenToolStripMenuItem.Name = "abrirImagenToolStripMenuItem";
            this.abrirImagenToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.abrirImagenToolStripMenuItem.Text = "Abrir imagen";
            this.abrirImagenToolStripMenuItem.Click += new System.EventHandler(this.abrirImagenToolStripMenuItem_Click);
            // 
            // imgResultado
            // 
            this.imgResultado.BackColor = System.Drawing.SystemColors.ControlLight;
            this.imgResultado.Location = new System.Drawing.Point(655, 112);
            this.imgResultado.Name = "imgResultado";
            this.imgResultado.Size = new System.Drawing.Size(595, 511);
            this.imgResultado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgResultado.TabIndex = 2;
            this.imgResultado.TabStop = false;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Location = new System.Drawing.Point(415, 46);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(213, 33);
            this.btnFiltrar.TabIndex = 3;
            this.btnFiltrar.Text = "Ecualizar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 626);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Imagen original";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(656, 626);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Imagen resultante";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(415, 588);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 33);
            this.button1.TabIndex = 8;
            this.button1.Text = "Escala de Grises";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // imgOriginal2
            // 
            this.imgOriginal2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.imgOriginal2.Location = new System.Drawing.Point(35, 113);
            this.imgOriginal2.Name = "imgOriginal2";
            this.imgOriginal2.Size = new System.Drawing.Size(595, 511);
            this.imgOriginal2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgOriginal2.TabIndex = 9;
            this.imgOriginal2.TabStop = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(35, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 33);
            this.button2.TabIndex = 10;
            this.button2.Text = "Expandir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textmin
            // 
            this.textmin.Location = new System.Drawing.Point(35, 85);
            this.textmin.Name = "textmin";
            this.textmin.Size = new System.Drawing.Size(100, 22);
            this.textmin.TabIndex = 11;
            this.textmin.Text = "0";
            // 
            // txtmax
            // 
            this.txtmax.Location = new System.Drawing.Point(141, 85);
            this.txtmax.Name = "txtmax";
            this.txtmax.Size = new System.Drawing.Size(100, 22);
            this.txtmax.TabIndex = 12;
            this.txtmax.Text = "240";
            // 
            // lbltipo
            // 
            this.lbltipo.AutoSize = true;
            this.lbltipo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltipo.Location = new System.Drawing.Point(233, 11);
            this.lbltipo.Name = "lbltipo";
            this.lbltipo.Size = new System.Drawing.Size(125, 23);
            this.lbltipo.TabIndex = 13;
            this.lbltipo.Text = "Sin imagen..";
            this.lbltipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblseleccione
            // 
            this.lblseleccione.AutoSize = true;
            this.lblseleccione.BackColor = System.Drawing.Color.Transparent;
            this.lblseleccione.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblseleccione.Location = new System.Drawing.Point(207, 337);
            this.lblseleccione.Name = "lblseleccione";
            this.lblseleccione.Size = new System.Drawing.Size(242, 23);
            this.lblseleccione.TabIndex = 14;
            this.lblseleccione.Text = "Seleccione una imagen";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbltipo);
            this.panel1.Location = new System.Drawing.Point(655, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 45);
            this.panel1.TabIndex = 15;
            // 
            // histogramaToolStripMenuItem
            // 
            this.histogramaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.originalToolStripMenuItem,
            this.resultanteToolStripMenuItem});
            this.histogramaToolStripMenuItem.Name = "histogramaToolStripMenuItem";
            this.histogramaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.histogramaToolStripMenuItem.Text = "Histograma";
            // 
            // originalToolStripMenuItem
            // 
            this.originalToolStripMenuItem.Name = "originalToolStripMenuItem";
            this.originalToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.originalToolStripMenuItem.Text = "Original";
            this.originalToolStripMenuItem.Click += new System.EventHandler(this.originalToolStripMenuItem_Click);
            // 
            // resultanteToolStripMenuItem
            // 
            this.resultanteToolStripMenuItem.Name = "resultanteToolStripMenuItem";
            this.resultanteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.resultanteToolStripMenuItem.Text = "Resultante";
            this.resultanteToolStripMenuItem.Click += new System.EventHandler(this.resultanteToolStripMenuItem_Click);
            // 
            // imgOriginal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 659);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblseleccione);
            this.Controls.Add(this.txtmax);
            this.Controls.Add(this.textmin);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.imgResultado);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.imgOriginal2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "imgOriginal";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgResultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOriginal2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirImagenToolStripMenuItem;
        private System.Windows.Forms.PictureBox imgResultado;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox imgOriginal2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textmin;
        private System.Windows.Forms.TextBox txtmax;
        private System.Windows.Forms.Label lbltipo;
        private System.Windows.Forms.Label lblseleccione;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem histogramaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem originalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resultanteToolStripMenuItem;
    }
}

