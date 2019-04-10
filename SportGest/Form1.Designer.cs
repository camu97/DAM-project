namespace SportGest
{
    partial class Form1
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
            this.Exit = new System.Windows.Forms.Button();
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnNewMatch = new System.Windows.Forms.Button();
            this.btnTeamManagement = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnNewSession = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.LightSlateGray;
            this.Exit.Location = new System.Drawing.Point(13, 316);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // btnOptions
            // 
            this.btnOptions.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnOptions.Location = new System.Drawing.Point(201, 316);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(75, 23);
            this.btnOptions.TabIndex = 1;
            this.btnOptions.Text = "Options";
            this.btnOptions.UseVisualStyleBackColor = false;
            // 
            // btnNewMatch
            // 
            this.btnNewMatch.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnNewMatch.Location = new System.Drawing.Point(58, 91);
            this.btnNewMatch.Name = "btnNewMatch";
            this.btnNewMatch.Size = new System.Drawing.Size(165, 50);
            this.btnNewMatch.TabIndex = 2;
            this.btnNewMatch.Text = "New match";
            this.btnNewMatch.UseVisualStyleBackColor = false;
            // 
            // btnTeamManagement
            // 
            this.btnTeamManagement.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnTeamManagement.Location = new System.Drawing.Point(58, 161);
            this.btnTeamManagement.Name = "btnTeamManagement";
            this.btnTeamManagement.Size = new System.Drawing.Size(165, 50);
            this.btnTeamManagement.TabIndex = 3;
            this.btnTeamManagement.Text = "Team management";
            this.btnTeamManagement.UseVisualStyleBackColor = false;
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnHistory.Location = new System.Drawing.Point(58, 231);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(165, 50);
            this.btnHistory.TabIndex = 4;
            this.btnHistory.Text = "History";
            this.btnHistory.UseVisualStyleBackColor = false;
            // 
            // btnNewSession
            // 
            this.btnNewSession.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnNewSession.Location = new System.Drawing.Point(58, 23);
            this.btnNewSession.Name = "btnNewSession";
            this.btnNewSession.Size = new System.Drawing.Size(165, 50);
            this.btnNewSession.TabIndex = 5;
            this.btnNewSession.Text = "New trainning session";
            this.btnNewSession.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(288, 351);
            this.Controls.Add(this.btnNewSession);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnTeamManagement);
            this.Controls.Add(this.btnNewMatch);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.Exit);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "|              SportGest                 |   ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Button btnNewMatch;
        private System.Windows.Forms.Button btnTeamManagement;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnNewSession;
    }
}

