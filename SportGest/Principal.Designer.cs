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
            this.itemSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.tbLeerNotas = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNuevoPartido
            // 
            this.btnNuevoPartido.BackColor = System.Drawing.SystemColors.Control;
            this.btnNuevoPartido.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNuevoPartido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoPartido.Location = new System.Drawing.Point(28, 37);
            this.btnNuevoPartido.Name = "btnNuevoPartido";
            this.btnNuevoPartido.Size = new System.Drawing.Size(177, 35);
            this.btnNuevoPartido.TabIndex = 2;
            this.btnNuevoPartido.Text = "Nuevo &partido";
            this.btnNuevoPartido.UseVisualStyleBackColor = false;
            this.btnNuevoPartido.Click += new System.EventHandler(this.btnNuevoPartido_Click);
            // 
            // btnGestionEquipo
            // 
            this.btnGestionEquipo.BackColor = System.Drawing.SystemColors.Control;
            this.btnGestionEquipo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGestionEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionEquipo.Location = new System.Drawing.Point(28, 125);
            this.btnGestionEquipo.Name = "btnGestionEquipo";
            this.btnGestionEquipo.Size = new System.Drawing.Size(177, 35);
            this.btnGestionEquipo.TabIndex = 3;
            this.btnGestionEquipo.Text = "&Gestión de equipo";
            this.btnGestionEquipo.UseVisualStyleBackColor = false;
            this.btnGestionEquipo.Click += new System.EventHandler(this.btnGestionEquipo_Click);
            // 
            // btnHistorial
            // 
            this.btnHistorial.BackColor = System.Drawing.SystemColors.Control;
            this.btnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnHistorial.Location = new System.Drawing.Point(700, 27);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(102, 23);
            this.btnHistorial.TabIndex = 4;
            this.btnHistorial.Text = "&Historial********";
            this.btnHistorial.UseVisualStyleBackColor = false;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // btnNuevoEntrenamiento
            // 
            this.btnNuevoEntrenamiento.BackColor = System.Drawing.SystemColors.Control;
            this.btnNuevoEntrenamiento.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNuevoEntrenamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoEntrenamiento.Location = new System.Drawing.Point(28, 81);
            this.btnNuevoEntrenamiento.Name = "btnNuevoEntrenamiento";
            this.btnNuevoEntrenamiento.Size = new System.Drawing.Size(177, 35);
            this.btnNuevoEntrenamiento.TabIndex = 5;
            this.btnNuevoEntrenamiento.Text = "Nuevo &entrenamiento";
            this.btnNuevoEntrenamiento.UseVisualStyleBackColor = false;
            this.btnNuevoEntrenamiento.Click += new System.EventHandler(this.btnNuevoEntrenamiento_Click);
            // 
            // calendar
            // 
            this.calendar.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.calendar.Location = new System.Drawing.Point(241, 151);
            this.calendar.MaxSelectionCount = 1;
            this.calendar.Name = "calendar";
            this.calendar.ShowToday = false;
            this.calendar.TabIndex = 5;
            // 
            // ListaMensajes
            // 
            this.ListaMensajes.BackColor = System.Drawing.SystemColors.Control;
            this.ListaMensajes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaMensajes.FormattingEnabled = true;
            this.ListaMensajes.ItemHeight = 16;
            this.ListaMensajes.Location = new System.Drawing.Point(468, 53);
            this.ListaMensajes.Name = "ListaMensajes";
            this.ListaMensajes.Size = new System.Drawing.Size(334, 180);
            this.ListaMensajes.TabIndex = 7;
            this.ListaMensajes.SelectedIndexChanged += new System.EventHandler(this.ListaMensajes_SelectedIndexChanged);
            // 
            // tbNuevaNota
            // 
            this.tbNuevaNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNuevaNota.Location = new System.Drawing.Point(28, 177);
            this.tbNuevaNota.Multiline = true;
            this.tbNuevaNota.Name = "tbNuevaNota";
            this.tbNuevaNota.Size = new System.Drawing.Size(177, 105);
            this.tbNuevaNota.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Location = new System.Drawing.Point(247, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nueva nota: ";
            // 
            // btnAñadirNota
            // 
            this.btnAñadirNota.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAñadirNota.Location = new System.Drawing.Point(28, 288);
            this.btnAñadirNota.Name = "btnAñadirNota";
            this.btnAñadirNota.Size = new System.Drawing.Size(177, 25);
            this.btnAñadirNota.TabIndex = 12;
            this.btnAñadirNota.Text = "Añadir";
            this.btnAñadirNota.UseVisualStyleBackColor = true;
            this.btnAñadirNota.Click += new System.EventHandler(this.btnAñadirNota_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(465, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Lista de notas:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Pristina", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblName.Location = new System.Drawing.Point(211, 37);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(251, 85);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "SportGest";
            this.lblName.UseMnemonic = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemSalir,
            this.itemSobre});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(817, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // itemSalir
            // 
            this.itemSalir.Name = "itemSalir";
            this.itemSalir.Size = new System.Drawing.Size(41, 20);
            this.itemSalir.Text = "Salir";
            this.itemSalir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // itemSobre
            // 
            this.itemSobre.Name = "itemSobre";
            this.itemSobre.Size = new System.Drawing.Size(58, 20);
            this.itemSobre.Text = "Sobre...";
            this.itemSobre.Click += new System.EventHandler(this.itemSobre_Click);
            // 
            // tbLeerNotas
            // 
            this.tbLeerNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLeerNotas.Location = new System.Drawing.Point(468, 239);
            this.tbLeerNotas.Multiline = true;
            this.tbLeerNotas.Name = "tbLeerNotas";
            this.tbLeerNotas.ReadOnly = true;
            this.tbLeerNotas.Size = new System.Drawing.Size(334, 74);
            this.tbLeerNotas.TabIndex = 16;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(817, 332);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbLeerNotas);
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
        private System.Windows.Forms.ToolStripMenuItem itemSobre;
        private System.Windows.Forms.ToolStripMenuItem itemSalir;
        private System.Windows.Forms.TextBox tbLeerNotas;
    }
}

