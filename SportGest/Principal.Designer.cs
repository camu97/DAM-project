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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.btnNuevoPartido = new System.Windows.Forms.Button();
            this.btnGestionEquipo = new System.Windows.Forms.Button();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.btnNuevoEntrenamiento = new System.Windows.Forms.Button();
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.ListaMensajes = new System.Windows.Forms.ListBox();
            this.notasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sportGestDataSet = new SportGest.SportGestDataSet();
            this.tbNuevaNota = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAñadirNota = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.itemSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.tbLeerNotas = new System.Windows.Forms.TextBox();
            this.btnEliminarNota = new System.Windows.Forms.Button();
            this.notasTableAdapter = new SportGest.SportGestDataSetTableAdapters.NotasTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.notasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportGestDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNuevoPartido
            // 
            this.btnNuevoPartido.BackColor = System.Drawing.SystemColors.Control;
            this.btnNuevoPartido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNuevoPartido.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnNuevoPartido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNuevoPartido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevoPartido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoPartido.Location = new System.Drawing.Point(21, 119);
            this.btnNuevoPartido.Name = "btnNuevoPartido";
            this.btnNuevoPartido.Size = new System.Drawing.Size(192, 35);
            this.btnNuevoPartido.TabIndex = 2;
            this.btnNuevoPartido.Text = "Nuevo &partido";
            this.btnNuevoPartido.UseVisualStyleBackColor = false;
            this.btnNuevoPartido.Click += new System.EventHandler(this.btnNuevoPartido_Click);
            // 
            // btnGestionEquipo
            // 
            this.btnGestionEquipo.BackColor = System.Drawing.SystemColors.Control;
            this.btnGestionEquipo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGestionEquipo.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnGestionEquipo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGestionEquipo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGestionEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionEquipo.Location = new System.Drawing.Point(21, 207);
            this.btnGestionEquipo.Name = "btnGestionEquipo";
            this.btnGestionEquipo.Size = new System.Drawing.Size(192, 35);
            this.btnGestionEquipo.TabIndex = 3;
            this.btnGestionEquipo.Text = "&Gestión de equipo";
            this.btnGestionEquipo.UseVisualStyleBackColor = false;
            this.btnGestionEquipo.Click += new System.EventHandler(this.btnGestionEquipo_Click);
            // 
            // btnHistorial
            // 
            this.btnHistorial.BackColor = System.Drawing.SystemColors.Control;
            this.btnHistorial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHistorial.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnHistorial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorial.Location = new System.Drawing.Point(21, 248);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(192, 33);
            this.btnHistorial.TabIndex = 4;
            this.btnHistorial.Text = "&Historial";
            this.btnHistorial.UseVisualStyleBackColor = false;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // btnNuevoEntrenamiento
            // 
            this.btnNuevoEntrenamiento.BackColor = System.Drawing.SystemColors.Control;
            this.btnNuevoEntrenamiento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNuevoEntrenamiento.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnNuevoEntrenamiento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNuevoEntrenamiento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevoEntrenamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoEntrenamiento.Location = new System.Drawing.Point(21, 163);
            this.btnNuevoEntrenamiento.Name = "btnNuevoEntrenamiento";
            this.btnNuevoEntrenamiento.Size = new System.Drawing.Size(192, 35);
            this.btnNuevoEntrenamiento.TabIndex = 5;
            this.btnNuevoEntrenamiento.Text = "Nuevo &entrenamiento";
            this.btnNuevoEntrenamiento.UseVisualStyleBackColor = false;
            this.btnNuevoEntrenamiento.Click += new System.EventHandler(this.btnNuevoEntrenamiento_Click);
            // 
            // calendar
            // 
            this.calendar.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.calendar.Location = new System.Drawing.Point(21, 293);
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
            this.ListaMensajes.Location = new System.Drawing.Point(239, 245);
            this.ListaMensajes.Name = "ListaMensajes";
            this.ListaMensajes.Size = new System.Drawing.Size(346, 132);
            this.ListaMensajes.TabIndex = 7;
            this.ListaMensajes.SelectedIndexChanged += new System.EventHandler(this.ListaMensajes_SelectedIndexChanged);
            // 
            // notasBindingSource
            // 
            this.notasBindingSource.DataMember = "Notas";
            this.notasBindingSource.DataSource = this.sportGestDataSet;
            // 
            // sportGestDataSet
            // 
            this.sportGestDataSet.DataSetName = "SportGestDataSet";
            this.sportGestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbNuevaNota
            // 
            this.tbNuevaNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNuevaNota.Location = new System.Drawing.Point(239, 119);
            this.tbNuevaNota.Multiline = true;
            this.tbNuevaNota.Name = "tbNuevaNota";
            this.tbNuevaNota.Size = new System.Drawing.Size(346, 79);
            this.tbNuevaNota.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Location = new System.Drawing.Point(243, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nueva nota: ";
            // 
            // btnAñadirNota
            // 
            this.btnAñadirNota.BackColor = System.Drawing.SystemColors.Control;
            this.btnAñadirNota.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAñadirNota.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnAñadirNota.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAñadirNota.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAñadirNota.Location = new System.Drawing.Point(239, 204);
            this.btnAñadirNota.Name = "btnAñadirNota";
            this.btnAñadirNota.Size = new System.Drawing.Size(346, 22);
            this.btnAñadirNota.TabIndex = 12;
            this.btnAñadirNota.Text = "Añadir";
            this.btnAñadirNota.UseVisualStyleBackColor = false;
            this.btnAñadirNota.Click += new System.EventHandler(this.btnAñadirNota_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 229);
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
            this.lblName.Location = new System.Drawing.Point(174, 31);
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
            this.menuStrip1.Size = new System.Drawing.Size(605, 24);
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
            this.tbLeerNotas.Location = new System.Drawing.Point(239, 383);
            this.tbLeerNotas.Multiline = true;
            this.tbLeerNotas.Name = "tbLeerNotas";
            this.tbLeerNotas.ReadOnly = true;
            this.tbLeerNotas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbLeerNotas.Size = new System.Drawing.Size(289, 72);
            this.tbLeerNotas.TabIndex = 16;
            // 
            // btnEliminarNota
            // 
            this.btnEliminarNota.BackColor = System.Drawing.SystemColors.Control;
            this.btnEliminarNota.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEliminarNota.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnEliminarNota.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEliminarNota.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarNota.Location = new System.Drawing.Point(534, 383);
            this.btnEliminarNota.Name = "btnEliminarNota";
            this.btnEliminarNota.Size = new System.Drawing.Size(51, 72);
            this.btnEliminarNota.TabIndex = 17;
            this.btnEliminarNota.Text = "Eliminar nota";
            this.btnEliminarNota.UseVisualStyleBackColor = false;
            this.btnEliminarNota.Click += new System.EventHandler(this.btnEliminarNota_Click);
            // 
            // notasTableAdapter
            // 
            this.notasTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SportGest.Properties.Resources.opciones;
            this.pictureBox1.Location = new System.Drawing.Point(557, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(605, 475);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEliminarNota);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbLeerNotas);
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
            this.Controls.Add(this.lblName);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
            ((System.ComponentModel.ISupportInitialize)(this.notasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportGestDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button btnEliminarNota;
        private SportGestDataSet sportGestDataSet;
        private SportGestDataSetTableAdapters.NotasTableAdapter notasTableAdapter;
        private System.Windows.Forms.BindingSource notasBindingSource;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

