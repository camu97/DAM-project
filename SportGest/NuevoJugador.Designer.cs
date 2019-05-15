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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbComentarios = new System.Windows.Forms.TextBox();
            this.tbNacimiento = new System.Windows.Forms.TextBox();
            this.cbEquipos = new System.Windows.Forms.ComboBox();
            this.sportGestDataSet = new SportGest.SportGestDataSet();
            this.btnAñadirJugador = new System.Windows.Forms.Button();
            this.cbPosicion = new System.Windows.Forms.ComboBox();
            this.tbNick = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.equiposTableAdapter = new SportGest.SportGestDataSetTableAdapters.EquiposTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.jugadoresTableAdapter1 = new SportGest.SportGestDataSetTableAdapters.JugadoresTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sportGestDataSet)).BeginInit();
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
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha de nacimiento:";
            this.toolTip1.SetToolTip(this.label2, "Formato: dd/mm/aaaa");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Posición:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Equipo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Comentarios:";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(65, 18);
            this.tbNombre.MaxLength = 50;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(139, 20);
            this.tbNombre.TabIndex = 5;
            this.toolTip1.SetToolTip(this.tbNombre, "Máximo 50 caracteres");
            // 
            // tbComentarios
            // 
            this.tbComentarios.Location = new System.Drawing.Point(15, 114);
            this.tbComentarios.MaxLength = 300;
            this.tbComentarios.Multiline = true;
            this.tbComentarios.Name = "tbComentarios";
            this.tbComentarios.Size = new System.Drawing.Size(320, 53);
            this.tbComentarios.TabIndex = 6;
            this.toolTip1.SetToolTip(this.tbComentarios, "Máximo 300 caracteres");
            // 
            // tbNacimiento
            // 
            this.tbNacimiento.Location = new System.Drawing.Point(124, 44);
            this.tbNacimiento.MaxLength = 10;
            this.tbNacimiento.Name = "tbNacimiento";
            this.tbNacimiento.Size = new System.Drawing.Size(80, 20);
            this.tbNacimiento.TabIndex = 8;
            this.tbNacimiento.Tag = "dd/mm/aaaa";
            this.toolTip1.SetToolTip(this.tbNacimiento, "Formato: dd/mm/aaaa");
            // 
            // cbEquipos
            // 
            this.cbEquipos.FormattingEnabled = true;
            this.cbEquipos.Location = new System.Drawing.Point(61, 71);
            this.cbEquipos.Name = "cbEquipos";
            this.cbEquipos.Size = new System.Drawing.Size(132, 21);
            this.cbEquipos.TabIndex = 9;
            // 
            // sportGestDataSet
            // 
            this.sportGestDataSet.DataSetName = "SportGestDataSet";
            this.sportGestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAñadirJugador
            // 
            this.btnAñadirJugador.Location = new System.Drawing.Point(141, 183);
            this.btnAñadirJugador.Name = "btnAñadirJugador";
            this.btnAñadirJugador.Size = new System.Drawing.Size(75, 23);
            this.btnAñadirJugador.TabIndex = 10;
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
            this.cbPosicion.TabIndex = 11;
            // 
            // tbNick
            // 
            this.tbNick.Location = new System.Drawing.Point(260, 18);
            this.tbNick.MaxLength = 20;
            this.tbNick.Name = "tbNick";
            this.tbNick.Size = new System.Drawing.Size(75, 20);
            this.tbNick.TabIndex = 12;
            this.toolTip1.SetToolTip(this.tbNick, "Máximo 20 caracteres");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(211, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Nick:";
            // 
            // equiposTableAdapter
            // 
            this.equiposTableAdapter.ClearBeforeFill = true;
            // 
            // tbNumero
            // 
            this.tbNumero.Location = new System.Drawing.Point(264, 44);
            this.tbNumero.MaxLength = 2;
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(27, 20);
            this.tbNumero.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(211, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Número:";
            // 
            // jugadoresTableAdapter1
            // 
            this.jugadoresTableAdapter1.ClearBeforeFill = true;
            // 
            // NuevoJugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 219);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbNumero);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbNick);
            this.Controls.Add(this.cbPosicion);
            this.Controls.Add(this.btnAñadirJugador);
            this.Controls.Add(this.cbEquipos);
            this.Controls.Add(this.tbNacimiento);
            this.Controls.Add(this.tbComentarios);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NuevoJugador";
            this.Text = "Jugador";
            this.Load += new System.EventHandler(this.NuevoJugador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sportGestDataSet)).EndInit();
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
        private System.Windows.Forms.TextBox tbComentarios;
        private System.Windows.Forms.TextBox tbNacimiento;
        private System.Windows.Forms.ComboBox cbEquipos;
        private System.Windows.Forms.Button btnAñadirJugador;
        private System.Windows.Forms.ComboBox cbPosicion;
        private System.Windows.Forms.TextBox tbNick;
        private System.Windows.Forms.Label label6;
        private SportGestDataSet sportGestDataSet;
        private SportGestDataSetTableAdapters.EquiposTableAdapter equiposTableAdapter;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.Label label7;
        private SportGestDataSetTableAdapters.JugadoresTableAdapter jugadoresTableAdapter1;
    }
}