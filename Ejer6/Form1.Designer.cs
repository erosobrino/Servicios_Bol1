namespace Ejer6
{
    partial class Juego
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Juego));
            this.player1 = new System.Windows.Forms.Label();
            this.player2 = new System.Windows.Forms.Label();
            this.lbAlea1 = new System.Windows.Forms.Label();
            this.lbAlea2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // player1
            // 
            this.player1.AutoSize = true;
            this.player1.Location = new System.Drawing.Point(170, 77);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(60, 17);
            this.player1.TabIndex = 0;
            this.player1.Text = "Player 1";
            // 
            // player2
            // 
            this.player2.AutoSize = true;
            this.player2.Location = new System.Drawing.Point(170, 117);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(60, 17);
            this.player2.TabIndex = 1;
            this.player2.Text = "Player 2";
            // 
            // lbAlea1
            // 
            this.lbAlea1.AutoSize = true;
            this.lbAlea1.Location = new System.Drawing.Point(262, 77);
            this.lbAlea1.Name = "lbAlea1";
            this.lbAlea1.Size = new System.Drawing.Size(16, 17);
            this.lbAlea1.TabIndex = 2;
            this.lbAlea1.Text = "0";
            // 
            // lbAlea2
            // 
            this.lbAlea2.AutoSize = true;
            this.lbAlea2.Location = new System.Drawing.Point(262, 117);
            this.lbAlea2.Name = "lbAlea2";
            this.lbAlea2.Size = new System.Drawing.Size(16, 17);
            this.lbAlea2.TabIndex = 3;
            this.lbAlea2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Points";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(235, 158);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(199, 375);
            this.textBox1.TabIndex = 7;
            // 
            // Juego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 545);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbAlea2);
            this.Controls.Add(this.lbAlea1);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.player1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Juego";
            this.Text = "Juego";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Juego_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label player1;
        private System.Windows.Forms.Label player2;
        private System.Windows.Forms.Label lbAlea1;
        private System.Windows.Forms.Label lbAlea2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
    }
}

