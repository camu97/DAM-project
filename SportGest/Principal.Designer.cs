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
            this.btnHistorialEntrenamientos = new System.Windows.Forms.Button();
            this.btnNuevoEntrenamiento = new System.Windows.Forms.Button();
            this.ListaMensajes = new System.Windows.Forms.ListBox();
            this.tbNuevaNota = new System.Windows.Forms.TextBox();
            this.btnAñadirNota = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.itemSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.tbLeerNotas = new System.Windows.Forms.TextBox();
            this.btnEliminarNota = new System.Windows.Forms.Button();
            this.btnHistorialPartidos = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
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
            this.btnNuevoPartido.Location = new System.Drawing.Point(12, 167);
            this.btnNuevoPartido.Name = "btnNuevoPartido";
            this.btnNuevoPartido.Size = new System.Drawing.Size(192, 42);
            this.btnNuevoPartido.TabIndex = 1;
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
            this.btnGestionEquipo.Location = new System.Drawing.Point(12, 215);
            this.btnGestionEquipo.Name = "btnGestionEquipo";
            this.btnGestionEquipo.Size = new System.Drawing.Size(192, 42);
            this.btnGestionEquipo.TabIndex = 2;
            this.btnGestionEquipo.Text = "&Gestión de equipo";
            this.btnGestionEquipo.UseVisualStyleBackColor = false;
            this.btnGestionEquipo.Click += new System.EventHandler(this.btnGestionEquipo_Click);
            // 
            // btnHistorialEntrenamientos
            // 
            this.btnHistorialEntrenamientos.BackColor = System.Drawing.SystemColors.Control;
            this.btnHistorialEntrenamientos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHistorialEntrenamientos.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnHistorialEntrenamientos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHistorialEntrenamientos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHistorialEntrenamientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorialEntrenamientos.Location = new System.Drawing.Point(12, 263);
            this.btnHistorialEntrenamientos.Name = "btnHistorialEntrenamientos";
            this.btnHistorialEntrenamientos.Size = new System.Drawing.Size(192, 40);
            this.btnHistorialEntrenamientos.TabIndex = 3;
            this.btnHistorialEntrenamientos.Text = "&Historial de entrenamientos";
            this.btnHistorialEntrenamientos.UseVisualStyleBackColor = false;
            this.btnHistorialEntrenamientos.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // btnNuevoEntrenamiento
            // 
            this.btnNuevoEntrenamiento.BackColor = System.Drawing.SystemColors.Control;
            this.btnNuevoEntrenamiento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNuevoEntrenamiento.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnNuevoEntrenamiento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNuevoEntrenamiento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevoEntrenamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoEntrenamiento.Location = new System.Drawing.Point(12, 119);
            this.btnNuevoEntrenamiento.Name = "btnNuevoEntrenamiento";
            this.btnNuevoEntrenamiento.Size = new System.Drawing.Size(192, 42);
            this.btnNuevoEntrenamiento.TabIndex = 0;
            this.btnNuevoEntrenamiento.Text = "Nuevo &entrenamiento";
            this.btnNuevoEntrenamiento.UseVisualStyleBackColor = false;
            this.btnNuevoEntrenamiento.Click += new System.EventHandler(this.btnNuevoEntrenamiento_Click);
            // 
            // ListaMensajes
            // 
            this.ListaMensajes.BackColor = System.Drawing.SystemColors.Control;
            this.ListaMensajes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaMensajes.FormattingEnabled = true;
            this.ListaMensajes.ItemHeight = 16;
            this.ListaMensajes.Location = new System.Drawing.Point(222, 119);
            this.ListaMensajes.Name = "ListaMensajes";
            this.ListaMensajes.Size = new System.Drawing.Size(363, 148);
            this.ListaMensajes.TabIndex = 7;
            this.ListaMensajes.SelectedIndexChanged += new System.EventHandler(this.ListaMensajes_SelectedIndexChanged);
            // 
            // tbNuevaNota
            // 
            this.tbNuevaNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNuevaNota.Location = new System.Drawing.Point(12, 376);
            this.tbNuevaNota.MaxLength = 500;
            this.tbNuevaNota.Multiline = true;
            this.tbNuevaNota.Name = "tbNuevaNota";
            this.tbNuevaNota.Size = new System.Drawing.Size(516, 68);
            this.tbNuevaNota.TabIndex = 5;
            // 
            // btnAñadirNota
            // 
            this.btnAñadirNota.BackColor = System.Drawing.SystemColors.Control;
            this.btnAñadirNota.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAñadirNota.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnAñadirNota.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAñadirNota.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAñadirNota.Location = new System.Drawing.Point(534, 376);
            this.btnAñadirNota.Name = "btnAñadirNota";
            this.btnAñadirNota.Size = new System.Drawing.Size(59, 68);
            this.btnAñadirNota.TabIndex = 6;
            this.btnAñadirNota.Text = "Añadir nota";
            this.btnAñadirNota.UseVisualStyleBackColor = false;
            this.btnAñadirNota.Click += new System.EventHandler(this.btnAñadirNota_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Pristina", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblName.Location = new System.Drawing.Point(161, 24);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(251, 85);
            this.lblName.TabIndex = 0;
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
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // itemSalir
            // 
            this.itemSalir.Name = "itemSalir";
            this.itemSalir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.itemSalir.Size = new System.Drawing.Size(41, 20);
            this.itemSalir.Text = "&Salir";
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
            this.tbLeerNotas.Location = new System.Drawing.Point(222, 277);
            this.tbLeerNotas.Multiline = true;
            this.tbLeerNotas.Name = "tbLeerNotas";
            this.tbLeerNotas.ReadOnly = true;
            this.tbLeerNotas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbLeerNotas.Size = new System.Drawing.Size(294, 72);
            this.tbLeerNotas.TabIndex = 8;
            // 
            // btnEliminarNota
            // 
            this.btnEliminarNota.BackColor = System.Drawing.SystemColors.Control;
            this.btnEliminarNota.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEliminarNota.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnEliminarNota.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEliminarNota.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarNota.Location = new System.Drawing.Point(522, 277);
            this.btnEliminarNota.Name = "btnEliminarNota";
            this.btnEliminarNota.Size = new System.Drawing.Size(63, 72);
            this.btnEliminarNota.TabIndex = 9;
            this.btnEliminarNota.Text = "Eliminar nota";
            this.btnEliminarNota.UseVisualStyleBackColor = false;
            this.btnEliminarNota.Click += new System.EventHandler(this.btnEliminarNota_Click);
            // 
            // btnHistorialPartidos
            // 
            this.btnHistorialPartidos.BackColor = System.Drawing.SystemColors.Control;
            this.btnHistorialPartidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHistorialPartidos.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnHistorialPartidos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHistorialPartidos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHistorialPartidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorialPartidos.Location = new System.Drawing.Point(12, 309);
            this.btnHistorialPartidos.Name = "btnHistorialPartidos";
            this.btnHistorialPartidos.Size = new System.Drawing.Size(192, 40);
            this.btnHistorialPartidos.TabIndex = 4;
            this.btnHistorialPartidos.Text = "&Historial de partidos";
            this.btnHistorialPartidos.UseVisualStyleBackColor = false;
            this.btnHistorialPartidos.Click += new System.EventHandler(this.btnHistorialPartidos_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(605, 475);
            this.Controls.Add(this.btnHistorialPartidos);
            this.Controls.Add(this.btnEliminarNota);
            this.Controls.Add(this.tbLeerNotas);
            this.Controls.Add(this.btnAñadirNota);
            this.Controls.Add(this.tbNuevaNota);
            this.Controls.Add(this.ListaMensajes);
            this.Controls.Add(this.btnNuevoEntrenamiento);
            this.Controls.Add(this.btnHistorialEntrenamientos);
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
        private System.Windows.Forms.Button btnHistorialEntrenamientos;
        private System.Windows.Forms.Button btnNuevoEntrenamiento;
        private System.Windows.Forms.ListBox ListaMensajes;
        private System.Windows.Forms.TextBox tbNuevaNota;
        private System.Windows.Forms.Button btnAñadirNota;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem itemSobre;
        private System.Windows.Forms.ToolStripMenuItem itemSalir;
        private System.Windows.Forms.TextBox tbLeerNotas;
        private System.Windows.Forms.Button btnEliminarNota;
        private System.Windows.Forms.Button btnHistorialPartidos;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

