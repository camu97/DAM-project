namespace SportGest
{
    partial class NuevoJugador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoJugador));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbObservaciones = new System.Windows.Forms.TextBox();
            this.tbNacimiento = new System.Windows.Forms.TextBox();
            this.cbEquipos = new System.Windows.Forms.ComboBox();
            this.btnAñadirJugador = new System.Windows.Forms.Button();
            this.cbPosicion = new System.Windows.Forms.ComboBox();
            this.tbNick = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            this.toolTip1.SetToolTip(this.label1, "Nombre de jugador(a)");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha de nacimiento:";
            this.toolTip1.SetToolTip(this.label2, "Fecha de nacimiento\\r\\nFormato: dd/mm/aaaa");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Posición:";
            this.toolTip1.SetToolTip(this.label3, "Seleccionar su posición habitual");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Equipo:";
            this.toolTip1.SetToolTip(this.label4, "Seleccionar equipo en el que juega");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Observaciones:";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(65, 18);
            this.tbNombre.MaxLength = 50;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(139, 20);
            this.tbNombre.TabIndex = 0;
            this.toolTip1.SetToolTip(this.tbNombre, "Nombre de jugador(a)");
            // 
            // tbObservaciones
            // 
            this.tbObservaciones.Location = new System.Drawing.Point(15, 114);
            this.tbObservaciones.MaxLength = 300;
            this.tbObservaciones.Multiline = true;
            this.tbObservaciones.Name = "tbObservaciones";
            this.tbObservaciones.Size = new System.Drawing.Size(320, 53);
            this.tbObservaciones.TabIndex = 6;
            this.toolTip1.SetToolTip(this.tbObservaciones, "Observaciones sobre el jugador\\r\\nMáximo 300 caracteres");
            // 
            // tbNacimiento
            // 
            this.tbNacimiento.Location = new System.Drawing.Point(124, 44);
            this.tbNacimiento.MaxLength = 10;
            this.tbNacimiento.Name = "tbNacimiento";
            this.tbNacimiento.Size = new System.Drawing.Size(80, 20);
            this.tbNacimiento.TabIndex = 2;
            this.tbNacimiento.Tag = "dd/mm/aaaa";
            this.toolTip1.SetToolTip(this.tbNacimiento, "Fecha de nacimiento\\r\\nFormato: dd/mm/aaaa");
            // 
            // cbEquipos
            // 
            this.cbEquipos.FormattingEnabled = true;
            this.cbEquipos.Location = new System.Drawing.Point(61, 71);
            this.cbEquipos.Name = "cbEquipos";
            this.cbEquipos.Size = new System.Drawing.Size(132, 21);
            this.cbEquipos.TabIndex = 4;
            this.toolTip1.SetToolTip(this.cbEquipos, "Seleccionar equipo en el que juega");
            // 
            // btnAñadirJugador
            // 
            this.btnAñadirJugador.Location = new System.Drawing.Point(141, 183);
            this.btnAñadirJugador.Name = "btnAñadirJugador";
            this.btnAñadirJugador.Size = new System.Drawing.Size(75, 23);
            this.btnAñadirJugador.TabIndex = 7;
            this.btnAñadirJugador.Text = "Añadir";
            this.btnAñadirJugador.UseVisualStyleBackColor = true;
            this.btnAñadirJugador.Click += new System.EventHandler(this.btnAñadirJugador_Click);
            // 
            // cbPosicion
            // 
            this.cbPosicion.FormattingEnabled = true;
            this.cbPosicion.Location = new System.Drawing.Point(255, 70);
            this.cbPosicion.Name = "cbPosicion";
            this.cbPosicion.Size = new System.Drawing.Size(80, 21);
            this.cbPosicion.TabIndex = 5;
            this.toolTip1.SetToolTip(this.cbPosicion, "Seleccionar su posición habitual");
            // 
            // tbNick
            // 
            this.tbNick.Location = new System.Drawing.Point(260, 18);
            this.tbNick.MaxLength = 20;
            this.tbNick.Name = "tbNick";
            this.tbNick.Size = new System.Drawing.Size(75, 20);
            this.tbNick.TabIndex = 1;
            this.toolTip1.SetToolTip(this.tbNick, "Nick de jugador(a)");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(211, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Nick:";
            this.toolTip1.SetToolTip(this.label6, "Nick de jugador(a)");
            // 
            // tbNumero
            // 
            this.tbNumero.Location = new System.Drawing.Point(264, 44);
            this.tbNumero.MaxLength = 2;
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(27, 20);
            this.tbNumero.TabIndex = 3;
            this.toolTip1.SetToolTip(this.tbNumero, "Número de jugador(a)");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(211, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Número:";
            this.toolTip1.SetToolTip(this.label7, "Número de jugador(a)");
            // 
            // NuevoJugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(347, 219);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbNumero);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbNick);
            this.Controls.Add(this.cbPosicion);
            this.Controls.Add(this.btnAñadirJugador);
            this.Controls.Add(this.cbEquipos);
            this.Controls.Add(this.tbNacimiento);
            this.Controls.Add(this.tbObservaciones);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NuevoJugador";
            this.ShowInTaskbar = false;
            this.Text = "Jugador";
            this.Load += new System.EventHandler(this.NuevoJugador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbObservaciones;
        private System.Windows.Forms.TextBox tbNacimiento;
        private System.Windows.Forms.ComboBox cbEquipos;
        private System.Windows.Forms.Button btnAñadirJugador;
        private System.Windows.Forms.ComboBox cbPosicion;
        private System.Windows.Forms.TextBox tbNick;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.Label label7;
    }
}