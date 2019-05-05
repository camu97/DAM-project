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
            this.btnSalir = new System.Windows.Forms.Button();
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
            this.itemNuevoEjercicio = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoEjercicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.SystemColors.Control;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSalir.Location = new System.Drawing.Point(756, 391);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(61, 23);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnNuevoPartido
            // 
            this.btnNuevoPartido.BackColor = System.Drawing.SystemColors.Control;
            this.btnNuevoPartido.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNuevoPartido.Location = new System.Drawing.Point(10, 102);
            this.btnNuevoPartido.Name = "btnNuevoPartido";
            this.btnNuevoPartido.Size = new System.Drawing.Size(165, 50);
            this.btnNuevoPartido.TabIndex = 2;
            this.btnNuevoPartido.Text = "Nuevo &partido";
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
            this.btnNuevoEntrenamiento.Text = "Nuevo &entrenamiento";
            this.btnNuevoEntrenamiento.UseVisualStyleBackColor = false;
            this.btnNuevoEntrenamiento.Click += new System.EventHandler(this.btnNuevoEntrenamiento_Click);
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
            this.btnAñadirNota.Click += new System.EventHandler(this.btnAñadirNota_Click);
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
            this.itemNuevoEjercicio,
            this.itemSalir,
            this.itemSobre});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(829, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // itemNuevoEjercicio
            // 
            this.itemNuevoEjercicio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoEjercicioToolStripMenuItem});
            this.itemNuevoEjercicio.Name = "itemNuevoEjercicio";
            this.itemNuevoEjercicio.Size = new System.Drawing.Size(68, 20);
            this.itemNuevoEjercicio.Text = "Ejercicios";
            // 
            // nuevoEjercicioToolStripMenuItem
            // 
            this.nuevoEjercicioToolStripMenuItem.Name = "nuevoEjercicioToolStripMenuItem";
            this.nuevoEjercicioToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.nuevoEjercicioToolStripMenuItem.Text = "Nuevo ejercicio";
            // 
            // itemSalir
            // 
            this.itemSalir.Name = "itemSalir";
            this.itemSalir.Size = new System.Drawing.Size(41, 20);
            this.itemSalir.Text = "Salir";
            this.itemSalir.Click += new System.EventHandler(this.itemSalir_Click);
            // 
            // itemSobre
            // 
            this.itemSobre.Name = "itemSobre";
            this.itemSobre.Size = new System.Drawing.Size(58, 20);
            this.itemSobre.Text = "Sobre...";
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
            this.Controls.Add(this.btnSalir);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
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
        private System.Windows.Forms.ToolStripMenuItem itemNuevoEjercicio;
        private System.Windows.Forms.ToolStripMenuItem nuevoEjercicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemSobre;
        private System.Windows.Forms.ToolStripMenuItem itemSalir;
    }
}

