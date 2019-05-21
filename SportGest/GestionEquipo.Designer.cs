namespace SportGest
{
    partial class GestionEquipo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionEquipo));
            this.listJugadores = new System.Windows.Forms.ListBox();
            this.contextMenuJugadores = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listEquipos = new System.Windows.Forms.ListBox();
            this.contextMenuEquipos = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNacimiento = new System.Windows.Forms.Label();
            this.lblPosicion = new System.Windows.Forms.Label();
            this.tbObservaciones = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Jugadores = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nuevoEquipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoEquipoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoJugadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atrásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.contextMenuJugadores.SuspendLayout();
            this.contextMenuEquipos.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listJugadores
            // 
            this.listJugadores.ContextMenuStrip = this.contextMenuJugadores;
            this.listJugadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listJugadores.FormattingEnabled = true;
            this.listJugadores.ItemHeight = 20;
            this.listJugadores.Location = new System.Drawing.Point(12, 48);
            this.listJugadores.Name = "listJugadores";
            this.listJugadores.Size = new System.Drawing.Size(176, 304);
            this.listJugadores.TabIndex = 1;
            this.listJugadores.SelectedIndexChanged += new System.EventHandler(this.listJugadores_SelectedIndexChanged);
            // 
            // contextMenuJugadores
            // 
            this.contextMenuJugadores.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarToolStripMenuItem,
            this.borrarToolStripMenuItem});
            this.contextMenuJugadores.Name = "contextMenuStrip1";
            this.contextMenuJugadores.Size = new System.Drawing.Size(107, 48);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarJugador_Click);
            // 
            // borrarToolStripMenuItem
            // 
            this.borrarToolStripMenuItem.Name = "borrarToolStripMenuItem";
            this.borrarToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.borrarToolStripMenuItem.Text = "Borrar";
            this.borrarToolStripMenuItem.Click += new System.EventHandler(this.btnBorrarJugador_Click);
            // 
            // listEquipos
            // 
            this.listEquipos.ContextMenuStrip = this.contextMenuEquipos;
            this.listEquipos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listEquipos.FormattingEnabled = true;
            this.listEquipos.ItemHeight = 20;
            this.listEquipos.Location = new System.Drawing.Point(211, 228);
            this.listEquipos.Name = "listEquipos";
            this.listEquipos.Size = new System.Drawing.Size(224, 124);
            this.listEquipos.TabIndex = 0;
            this.listEquipos.SelectedIndexChanged += new System.EventHandler(this.listEquipos_SelectedIndexChanged);
            // 
            // contextMenuEquipos
            // 
            this.contextMenuEquipos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.contextMenuEquipos.Name = "contextMenuStrip1";
            this.contextMenuEquipos.Size = new System.Drawing.Size(107, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(106, 22);
            this.toolStripMenuItem1.Text = "Editar";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.editarEquipo_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(106, 22);
            this.toolStripMenuItem2.Text = "Borrar";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.borrarEquipo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha de nacimiento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Posición:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(207, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Observaciones:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(260, 35);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(15, 16);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "_";
            // 
            // lblNacimiento
            // 
            this.lblNacimiento.AutoSize = true;
            this.lblNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNacimiento.Location = new System.Drawing.Point(322, 64);
            this.lblNacimiento.Name = "lblNacimiento";
            this.lblNacimiento.Size = new System.Drawing.Size(15, 16);
            this.lblNacimiento.TabIndex = 8;
            this.lblNacimiento.Text = "_";
            // 
            // lblPosicion
            // 
            this.lblPosicion.AutoSize = true;
            this.lblPosicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosicion.Location = new System.Drawing.Point(260, 91);
            this.lblPosicion.Name = "lblPosicion";
            this.lblPosicion.Size = new System.Drawing.Size(15, 16);
            this.lblPosicion.TabIndex = 9;
            this.lblPosicion.Text = "_";
            // 
            // tbObservaciones
            // 
            this.tbObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbObservaciones.Location = new System.Drawing.Point(210, 137);
            this.tbObservaciones.Multiline = true;
            this.tbObservaciones.Name = "tbObservaciones";
            this.tbObservaciones.ReadOnly = true;
            this.tbObservaciones.Size = new System.Drawing.Size(224, 65);
            this.tbObservaciones.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(208, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Equipos";
            // 
            // Jugadores
            // 
            this.Jugadores.AutoSize = true;
            this.Jugadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jugadores.Location = new System.Drawing.Point(9, 32);
            this.Jugadores.Name = "Jugadores";
            this.Jugadores.Size = new System.Drawing.Size(65, 13);
            this.Jugadores.TabIndex = 12;
            this.Jugadores.Text = "Jugadores";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoEquipoToolStripMenuItem,
            this.atrásToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(447, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nuevoEquipoToolStripMenuItem
            // 
            this.nuevoEquipoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoEquipoToolStripMenuItem1,
            this.nuevoJugadorToolStripMenuItem});
            this.nuevoEquipoToolStripMenuItem.Name = "nuevoEquipoToolStripMenuItem";
            this.nuevoEquipoToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.nuevoEquipoToolStripMenuItem.Text = "Nuevo";
            // 
            // nuevoEquipoToolStripMenuItem1
            // 
            this.nuevoEquipoToolStripMenuItem1.Name = "nuevoEquipoToolStripMenuItem1";
            this.nuevoEquipoToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.nuevoEquipoToolStripMenuItem1.Size = new System.Drawing.Size(191, 22);
            this.nuevoEquipoToolStripMenuItem1.Text = "Nuevo equipo";
            this.nuevoEquipoToolStripMenuItem1.Click += new System.EventHandler(this.nuevoEquipo_Click);
            // 
            // nuevoJugadorToolStripMenuItem
            // 
            this.nuevoJugadorToolStripMenuItem.Name = "nuevoJugadorToolStripMenuItem";
            this.nuevoJugadorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.J)));
            this.nuevoJugadorToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.nuevoJugadorToolStripMenuItem.Text = "Nuevo jugador";
            this.nuevoJugadorToolStripMenuItem.Click += new System.EventHandler(this.nuevoJugador_Click);
            // 
            // atrásToolStripMenuItem
            // 
            this.atrásToolStripMenuItem.Name = "atrásToolStripMenuItem";
            this.atrásToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.atrásToolStripMenuItem.Text = "Cerrar";
            this.atrásToolStripMenuItem.Click += new System.EventHandler(this.atrás_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(342, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Número: ";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(392, 91);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(15, 16);
            this.lblNumero.TabIndex = 15;
            this.lblNumero.Text = "_";
            // 
            // GestionEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(447, 368);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Jugadores);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbObservaciones);
            this.Controls.Add(this.lblPosicion);
            this.Controls.Add(this.lblNacimiento);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listEquipos);
            this.Controls.Add(this.listJugadores);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "GestionEquipo";
            this.ShowInTaskbar = false;
            this.Text = "Gestión de equipo";
            this.Load += new System.EventHandler(this.GestionEquipo_Load);
            this.contextMenuJugadores.ResumeLayout(false);
            this.contextMenuEquipos.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listJugadores;
        private System.Windows.Forms.ListBox listEquipos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNacimiento;
        private System.Windows.Forms.Label lblPosicion;
        private System.Windows.Forms.TextBox tbObservaciones;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Jugadores;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevoEquipoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoEquipoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nuevoJugadorToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.ToolStripMenuItem atrásToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuJugadores;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuEquipos;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}