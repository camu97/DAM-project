namespace SportGest
{
    partial class HistorialPartidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistorialPartidos));
            this.tbDescripción = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblObjectivo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblEquipo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listPartidos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.volverAlMenúPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCambios = new System.Windows.Forms.Label();
            this.lblEstilo = new System.Windows.Forms.Label();
            this.lblPosicionamiento = new System.Windows.Forms.Label();
            this.partidosAdapter = new SportGest.SportGestDataSetTableAdapters.PartidosTableAdapter();
            this.cbEquipo = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbDescripción
            // 
            this.tbDescripción.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescripción.Location = new System.Drawing.Point(12, 116);
            this.tbDescripción.Multiline = true;
            this.tbDescripción.Name = "tbDescripción";
            this.tbDescripción.ReadOnly = true;
            this.tbDescripción.Size = new System.Drawing.Size(421, 82);
            this.tbDescripción.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Observaciones del encuentro:";
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Location = new System.Drawing.Point(363, 55);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(13, 13);
            this.lblDuracion.TabIndex = 31;
            this.lblDuracion.Text = "_";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(304, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Rival:";
            // 
            // lblObjectivo
            // 
            this.lblObjectivo.AutoSize = true;
            this.lblObjectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObjectivo.Location = new System.Drawing.Point(228, 33);
            this.lblObjectivo.Name = "lblObjectivo";
            this.lblObjectivo.Size = new System.Drawing.Size(14, 13);
            this.lblObjectivo.TabIndex = 29;
            this.lblObjectivo.Text = "_";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(154, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Resultado:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(217, 55);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(13, 13);
            this.lblCategoria.TabIndex = 27;
            this.lblCategoria.Text = "_";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(60, 34);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(13, 13);
            this.lblFecha.TabIndex = 26;
            this.lblFecha.Text = "_";
            // 
            // lblEquipo
            // 
            this.lblEquipo.AutoSize = true;
            this.lblEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipo.Location = new System.Drawing.Point(60, 55);
            this.lblEquipo.Name = "lblEquipo";
            this.lblEquipo.Size = new System.Drawing.Size(14, 13);
            this.lblEquipo.TabIndex = 25;
            this.lblEquipo.Text = "_";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Categoría:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Equipo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Fecha:";
            // 
            // listPartidos
            // 
            this.listPartidos.FormattingEnabled = true;
            this.listPartidos.Location = new System.Drawing.Point(12, 234);
            this.listPartidos.Name = "listPartidos";
            this.listPartidos.Size = new System.Drawing.Size(424, 238);
            this.listPartidos.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Partidos:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.volverAlMenúPrincipalToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(444, 24);
            this.menuStrip1.TabIndex = 38;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // volverAlMenúPrincipalToolStripMenuItem
            // 
            this.volverAlMenúPrincipalToolStripMenuItem.Name = "volverAlMenúPrincipalToolStripMenuItem";
            this.volverAlMenúPrincipalToolStripMenuItem.Size = new System.Drawing.Size(146, 20);
            this.volverAlMenúPrincipalToolStripMenuItem.Text = "Volver al menú principal";
            this.volverAlMenúPrincipalToolStripMenuItem.Click += new System.EventHandler(this.volverAlMenúPrincipalToolStripMenuItem_Click);
            // 
            // lblCambios
            // 
            this.lblCambios.AutoSize = true;
            this.lblCambios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCambios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCambios.Location = new System.Drawing.Point(9, 77);
            this.lblCambios.Name = "lblCambios";
            this.lblCambios.Size = new System.Drawing.Size(49, 15);
            this.lblCambios.TabIndex = 39;
            this.lblCambios.Text = "Titulares";
            this.lblCambios.Click += new System.EventHandler(this.lblTitulares_Click);
            // 
            // lblEstilo
            // 
            this.lblEstilo.AutoSize = true;
            this.lblEstilo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEstilo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEstilo.Location = new System.Drawing.Point(154, 77);
            this.lblEstilo.Name = "lblEstilo";
            this.lblEstilo.Size = new System.Drawing.Size(34, 15);
            this.lblEstilo.TabIndex = 40;
            this.lblEstilo.Text = "Estilo";
            this.lblEstilo.Click += new System.EventHandler(this.lblEstilo_Click);
            // 
            // lblPosicionamiento
            // 
            this.lblPosicionamiento.AutoSize = true;
            this.lblPosicionamiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPosicionamiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPosicionamiento.Location = new System.Drawing.Point(304, 77);
            this.lblPosicionamiento.Name = "lblPosicionamiento";
            this.lblPosicionamiento.Size = new System.Drawing.Size(86, 15);
            this.lblPosicionamiento.TabIndex = 41;
            this.lblPosicionamiento.Text = "Posicionamiento";
            this.lblPosicionamiento.Click += new System.EventHandler(this.lblPosicionamiento_Click);
            // 
            // partidosAdapter
            // 
            this.partidosAdapter.ClearBeforeFill = true;
            // 
            // cbEquipo
            // 
            this.cbEquipo.FormattingEnabled = true;
            this.cbEquipo.Location = new System.Drawing.Point(63, 207);
            this.cbEquipo.Name = "cbEquipo";
            this.cbEquipo.Size = new System.Drawing.Size(121, 21);
            this.cbEquipo.TabIndex = 42;
            this.cbEquipo.SelectedIndexChanged += new System.EventHandler(this.cbEquipo_SelectedIndexChanged);
            // 
            // HistorialPartidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 480);
            this.Controls.Add(this.cbEquipo);
            this.Controls.Add(this.lblPosicionamiento);
            this.Controls.Add(this.lblEstilo);
            this.Controls.Add(this.lblCambios);
            this.Controls.Add(this.tbDescripción);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblDuracion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblObjectivo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblEquipo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listPartidos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HistorialPartidos";
            this.Text = "Historial de partidos";
            this.Load += new System.EventHandler(this.HistorialPartidos_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbDescripción;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblObjectivo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblEquipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listPartidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem volverAlMenúPrincipalToolStripMenuItem;
        private System.Windows.Forms.Label lblCambios;
        private System.Windows.Forms.Label lblEstilo;
        private System.Windows.Forms.Label lblPosicionamiento;
        private SportGestDataSetTableAdapters.PartidosTableAdapter partidosAdapter;
        private System.Windows.Forms.ComboBox cbEquipo;
    }
}