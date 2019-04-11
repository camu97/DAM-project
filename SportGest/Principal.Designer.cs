namespace SportGest
{
    partial class Principal
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
            this.Salir = new System.Windows.Forms.Button();
            this.btnNuevoPartido = new System.Windows.Forms.Button();
            this.btnGestionEquipo = new System.Windows.Forms.Button();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.btnNuevoEntrenamiento = new System.Windows.Forms.Button();
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.ListaMensajes = new System.Windows.Forms.ListBox();
            this.tbNuevaNota = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAñadirNota = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.creacónDeEjerciciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoEjercicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Salir
            // 
            this.Salir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Salir.BackColor = System.Drawing.SystemColors.Control;
            this.Salir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Salir.Location = new System.Drawing.Point(756, 391);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(61, 23);
            this.Salir.TabIndex = 0;
            this.Salir.Text = "&Exit";
            this.Salir.UseVisualStyleBackColor = false;
            this.Salir.Click += new System.EventHandler(this.Exit_Click);
            // 
            // btnNuevoPartido
            // 
            this.btnNuevoPartido.BackColor = System.Drawing.SystemColors.Control;
            this.btnNuevoPartido.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNuevoPartido.Location = new System.Drawing.Point(10, 102);
            this.btnNuevoPartido.Name = "btnNuevoPartido";
            this.btnNuevoPartido.Size = new System.Drawing.Size(165, 50);
            this.btnNuevoPartido.TabIndex = 2;
            this.btnNuevoPartido.Text = "&Nuevo &partido";
            this.btnNuevoPartido.UseVisualStyleBackColor = false;
            // 
            // btnGestionEquipo
            // 
            this.btnGestionEquipo.BackColor = System.Drawing.SystemColors.Control;
            this.btnGestionEquipo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGestionEquipo.Location = new System.Drawing.Point(232, 171);
            this.btnGestionEquipo.Name = "btnGestionEquipo";
            this.btnGestionEquipo.Size = new System.Drawing.Size(165, 50);
            this.btnGestionEquipo.TabIndex = 3;
            this.btnGestionEquipo.Text = "&Gestión de equipo";
            this.btnGestionEquipo.UseVisualStyleBackColor = false;
            // 
            // btnHistorial
            // 
            this.btnHistorial.BackColor = System.Drawing.SystemColors.Control;
            this.btnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnHistorial.Location = new System.Drawing.Point(10, 171);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(165, 50);
            this.btnHistorial.TabIndex = 4;
            this.btnHistorial.Text = "&Historial********";
            this.btnHistorial.UseVisualStyleBackColor = false;
            // 
            // btnNuevoEntrenamiento
            // 
            this.btnNuevoEntrenamiento.BackColor = System.Drawing.SystemColors.Control;
            this.btnNuevoEntrenamiento.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNuevoEntrenamiento.Location = new System.Drawing.Point(232, 102);
            this.btnNuevoEntrenamiento.Name = "btnNuevoEntrenamiento";
            this.btnNuevoEntrenamiento.Size = new System.Drawing.Size(165, 50);
            this.btnNuevoEntrenamiento.TabIndex = 5;
            this.btnNuevoEntrenamiento.Text = "&Nuevo &entrenamiento";
            this.btnNuevoEntrenamiento.UseVisualStyleBackColor = false;
            // 
            // calendar
            // 
            this.calendar.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.calendar.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.calendar.Location = new System.Drawing.Point(9, 233);
            this.calendar.MaxSelectionCount = 1;
            this.calendar.Name = "calendar";
            this.calendar.ShowToday = false;
            this.calendar.TabIndex = 5;
            // 
            // ListaMensajes
            // 
            this.ListaMensajes.BackColor = System.Drawing.SystemColors.Control;
            this.ListaMensajes.FormattingEnabled = true;
            this.ListaMensajes.Location = new System.Drawing.Point(457, 128);
            this.ListaMensajes.Name = "ListaMensajes";
            this.ListaMensajes.Size = new System.Drawing.Size(360, 134);
            this.ListaMensajes.TabIndex = 7;
            // 
            // tbNuevaNota
            // 
            this.tbNuevaNota.Location = new System.Drawing.Point(457, 301);
            this.tbNuevaNota.Multiline = true;
            this.tbNuevaNota.Name = "tbNuevaNota";
            this.tbNuevaNota.Size = new System.Drawing.Size(303, 50);
            this.tbNuevaNota.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Location = new System.Drawing.Point(461, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nueva nota: ";
            // 
            // btnAñadirNota
            // 
            this.btnAñadirNota.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAñadirNota.Location = new System.Drawing.Point(766, 301);
            this.btnAñadirNota.Name = "btnAñadirNota";
            this.btnAñadirNota.Size = new System.Drawing.Size(51, 50);
            this.btnAñadirNota.TabIndex = 12;
            this.btnAñadirNota.Text = "Añadir";
            this.btnAñadirNota.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(454, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Lista de notas:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Pristina", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblName.Location = new System.Drawing.Point(311, 36);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(193, 63);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "SportGest";
            this.lblName.UseMnemonic = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creacónDeEjerciciosToolStripMenuItem,
            this.salirToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(829, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // creacónDeEjerciciosToolStripMenuItem
            // 
            this.creacónDeEjerciciosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoEjercicioToolStripMenuItem});
            this.creacónDeEjerciciosToolStripMenuItem.Name = "creacónDeEjerciciosToolStripMenuItem";
            this.creacónDeEjerciciosToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.creacónDeEjerciciosToolStripMenuItem.Text = "Ejercicios";
            // 
            // nuevoEjercicioToolStripMenuItem
            // 
            this.nuevoEjercicioToolStripMenuItem.Name = "nuevoEjercicioToolStripMenuItem";
            this.nuevoEjercicioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevoEjercicioToolStripMenuItem.Text = "Nuevo ejercicio";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.sobreToolStripMenuItem.Text = "Sobre...";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(829, 426);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAñadirNota);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNuevaNota);
            this.Controls.Add(this.ListaMensajes);
            this.Controls.Add(this.calendar);
            this.Controls.Add(this.btnNuevoEntrenamiento);
            this.Controls.Add(this.btnHistorial);
            this.Controls.Add(this.btnGestionEquipo);
            this.Controls.Add(this.btnNuevoPartido);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SportGest";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Button btnNuevoPartido;
        private System.Windows.Forms.Button btnGestionEquipo;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.Button btnNuevoEntrenamiento;
        private System.Windows.Forms.MonthCalendar calendar;
        private System.Windows.Forms.ListBox ListaMensajes;
        private System.Windows.Forms.TextBox tbNuevaNota;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAñadirNota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem creacónDeEjerciciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoEjercicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

