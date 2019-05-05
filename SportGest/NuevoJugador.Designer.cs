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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tbNacimiento = new System.Windows.Forms.TextBox();
            this.cbEquipos = new System.Windows.Forms.ComboBox();
            this.btnAñadirJugador = new System.Windows.Forms.Button();
            this.cbPosicion = new System.Windows.Forms.ComboBox();
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
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha de nacimiento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Posición:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Equipo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Comentarios:";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(65, 18);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(139, 20);
            this.tbNombre.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(15, 191);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(189, 65);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "tbObservaciones";
            // 
            // tbNacimiento
            // 
            this.tbNacimiento.Location = new System.Drawing.Point(124, 59);
            this.tbNacimiento.Name = "tbNacimiento";
            this.tbNacimiento.Size = new System.Drawing.Size(80, 20);
            this.tbNacimiento.TabIndex = 8;
            // 
            // cbEquipos
            // 
            this.cbEquipos.FormattingEnabled = true;
            this.cbEquipos.Location = new System.Drawing.Point(61, 135);
            this.cbEquipos.Name = "cbEquipos";
            this.cbEquipos.Size = new System.Drawing.Size(143, 21);
            this.cbEquipos.TabIndex = 9;
            // 
            // btnAñadirJugador
            // 
            this.btnAñadirJugador.Location = new System.Drawing.Point(74, 262);
            this.btnAñadirJugador.Name = "btnAñadirJugador";
            this.btnAñadirJugador.Size = new System.Drawing.Size(75, 23);
            this.btnAñadirJugador.TabIndex = 10;
            this.btnAñadirJugador.Text = "Añadir";
            this.btnAñadirJugador.UseVisualStyleBackColor = true;
            this.btnAñadirJugador.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbPosicion
            // 
            this.cbPosicion.FormattingEnabled = true;
            this.cbPosicion.Location = new System.Drawing.Point(65, 96);
            this.cbPosicion.Name = "cbPosicion";
            this.cbPosicion.Size = new System.Drawing.Size(139, 21);
            this.cbPosicion.TabIndex = 11;
            // 
            // NuevoJugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 294);
            this.Controls.Add(this.cbPosicion);
            this.Controls.Add(this.btnAñadirJugador);
            this.Controls.Add(this.cbEquipos);
            this.Controls.Add(this.tbNacimiento);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NuevoJugador";
            this.Text = "Nuevo jugador";
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
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox tbNacimiento;
        private System.Windows.Forms.ComboBox cbEquipos;
        private System.Windows.Forms.Button btnAñadirJugador;
        private System.Windows.Forms.ComboBox cbPosicion;
    }
}