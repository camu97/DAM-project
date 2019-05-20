namespace SportGest
{
    partial class NuevoEquipo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoEquipo));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbLiga = new System.Windows.Forms.TextBox();
            this.tbObservaciones = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAñadirEquipo = new System.Windows.Forms.Button();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre equipo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Categoría:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Liga:";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(100, 17);
            this.tbNombre.MaxLength = 50;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(190, 20);
            this.tbNombre.TabIndex = 0;
            // 
            // tbLiga
            // 
            this.tbLiga.Location = new System.Drawing.Point(48, 72);
            this.tbLiga.MaxLength = 50;
            this.tbLiga.Name = "tbLiga";
            this.tbLiga.Size = new System.Drawing.Size(242, 20);
            this.tbLiga.TabIndex = 2;
            // 
            // tbObservaciones
            // 
            this.tbObservaciones.Location = new System.Drawing.Point(15, 143);
            this.tbObservaciones.Multiline = true;
            this.tbObservaciones.Name = "tbObservaciones";
            this.tbObservaciones.Size = new System.Drawing.Size(344, 59);
            this.tbObservaciones.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Observaciones:";
            // 
            // btnAñadirEquipo
            // 
            this.btnAñadirEquipo.Location = new System.Drawing.Point(145, 218);
            this.btnAñadirEquipo.Name = "btnAñadirEquipo";
            this.btnAñadirEquipo.Size = new System.Drawing.Size(75, 23);
            this.btnAñadirEquipo.TabIndex = 5;
            this.btnAñadirEquipo.Text = "Añadir equipo";
            this.btnAñadirEquipo.UseVisualStyleBackColor = true;
            this.btnAñadirEquipo.Click += new System.EventHandler(this.btnAñadirEquipo_Click);
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Items.AddRange(new object[] {
            "MINIS",
            "PREBENJAMIN",
            "BENJAMIN",
            "ALEVIN",
            "INFANTIL",
            "CADETE",
            "JUVENIL",
            "SENIOR",
            "FEMENINO"});
            this.cbCategoria.Location = new System.Drawing.Point(75, 43);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(145, 21);
            this.cbCategoria.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Número de jugadores:";
            // 
            // tbNumero
            // 
            this.tbNumero.Location = new System.Drawing.Point(129, 100);
            this.tbNumero.MaxLength = 2;
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(24, 20);
            this.tbNumero.TabIndex = 3;
            // 
            // NuevoEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(371, 251);
            this.Controls.Add(this.tbNumero);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.btnAñadirEquipo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbObservaciones);
            this.Controls.Add(this.tbLiga);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NuevoEquipo";
            this.ShowInTaskbar = false;
            this.Text = "Equipo";
            this.Load += new System.EventHandler(this.NuevoEquipo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbLiga;
        private System.Windows.Forms.TextBox tbObservaciones;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAñadirEquipo;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNumero;
    }
}