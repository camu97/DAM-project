namespace SportGest
{
    partial class Historial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Historial));
            this.label1 = new System.Windows.Forms.Label();
            this.listSesiones = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblEquipo = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblObjectivo = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbDescripción = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCalentamiento = new System.Windows.Forms.Label();
            this.lblPrincipal = new System.Windows.Forms.Label();
            this.lblCalma = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.entrenamientoAdapter = new SportGest.SportGestDataSetTableAdapters.EntrenamientosTableAdapter();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sesiones:";
            // 
            // listSesiones
            // 
            this.listSesiones.FormattingEnabled = true;
            this.listSesiones.Location = new System.Drawing.Point(16, 214);
            this.listSesiones.Name = "listSesiones";
            this.listSesiones.Size = new System.Drawing.Size(424, 264);
            this.listSesiones.TabIndex = 2;
            this.listSesiones.SelectedIndexChanged += new System.EventHandler(this.listSesiones_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Equipo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Categoría:";
            // 
            // lblEquipo
            // 
            this.lblEquipo.AutoSize = true;
            this.lblEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipo.Location = new System.Drawing.Point(63, 40);
            this.lblEquipo.Name = "lblEquipo";
            this.lblEquipo.Size = new System.Drawing.Size(14, 13);
            this.lblEquipo.TabIndex = 6;
            this.lblEquipo.Text = "_";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(63, 19);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(13, 13);
            this.lblFecha.TabIndex = 7;
            this.lblFecha.Text = "_";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(220, 40);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(13, 13);
            this.lblCategoria.TabIndex = 8;
            this.lblCategoria.Text = "_";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(171, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Objetivo:";
            // 
            // lblObjectivo
            // 
            this.lblObjectivo.AutoSize = true;
            this.lblObjectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObjectivo.Location = new System.Drawing.Point(226, 18);
            this.lblObjectivo.Name = "lblObjectivo";
            this.lblObjectivo.Size = new System.Drawing.Size(14, 13);
            this.lblObjectivo.TabIndex = 10;
            this.lblObjectivo.Text = "_";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(307, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Duración:";
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Location = new System.Drawing.Point(366, 40);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(13, 13);
            this.lblDuracion.TabIndex = 12;
            this.lblDuracion.Text = "_";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Decripción:";
            // 
            // tbDescripción
            // 
            this.tbDescripción.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescripción.Location = new System.Drawing.Point(77, 61);
            this.tbDescripción.Multiline = true;
            this.tbDescripción.Name = "tbDescripción";
            this.tbDescripción.ReadOnly = true;
            this.tbDescripción.Size = new System.Drawing.Size(363, 41);
            this.tbDescripción.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Fases";
            // 
            // lblCalentamiento
            // 
            this.lblCalentamiento.AutoSize = true;
            this.lblCalentamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalentamiento.Location = new System.Drawing.Point(16, 147);
            this.lblCalentamiento.Name = "lblCalentamiento";
            this.lblCalentamiento.Size = new System.Drawing.Size(87, 13);
            this.lblCalentamiento.TabIndex = 16;
            this.lblCalentamiento.Text = "Calentamiento";
            this.lblCalentamiento.Click += new System.EventHandler(this.lblCalentamiento_Click);
            // 
            // lblPrincipal
            // 
            this.lblPrincipal.AutoSize = true;
            this.lblPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrincipal.Location = new System.Drawing.Point(140, 147);
            this.lblPrincipal.Name = "lblPrincipal";
            this.lblPrincipal.Size = new System.Drawing.Size(89, 13);
            this.lblPrincipal.TabIndex = 17;
            this.lblPrincipal.Text = "Parte principal";
            this.lblPrincipal.Click += new System.EventHandler(this.lblPrincipal_Click);
            // 
            // lblCalma
            // 
            this.lblCalma.AutoSize = true;
            this.lblCalma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalma.Location = new System.Drawing.Point(270, 147);
            this.lblCalma.Name = "lblCalma";
            this.lblCalma.Size = new System.Drawing.Size(105, 13);
            this.lblCalma.TabIndex = 18;
            this.lblCalma.Text = "Vuelta a la calma";
            this.lblCalma.Click += new System.EventHandler(this.lblCalma_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(273, 491);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Volver al menú principal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // entrenamientoAdapter
            // 
            this.entrenamientoAdapter.ClearBeforeFill = true;
            // 
            // Historial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(461, 526);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblCalma);
            this.Controls.Add(this.lblPrincipal);
            this.Controls.Add(this.lblCalentamiento);
            this.Controls.Add(this.label8);
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
            this.Controls.Add(this.listSesiones);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Historial";
            this.Text = "History";
            this.Load += new System.EventHandler(this.Historial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listSesiones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblEquipo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label label5;
        private SportGestDataSetTableAdapters.EntrenamientosTableAdapter entrenamientoAdapter;
        private System.Windows.Forms.Label lblObjectivo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbDescripción;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCalentamiento;
        private System.Windows.Forms.Label lblPrincipal;
        private System.Windows.Forms.Label lblCalma;
        private System.Windows.Forms.Button button1;
    }
}