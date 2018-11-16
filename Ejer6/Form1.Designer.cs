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
            this.tbColor = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // player1
            // 
            this.player1.AutoSize = true;
            this.player1.Location = new System.Drawing.Point(62, 32);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(60, 17);
            this.player1.TabIndex = 0;
            this.player1.Text = "Player 1";
            // 
            // player2
            // 
            this.player2.AutoSize = true;
            this.player2.Location = new System.Drawing.Point(62, 72);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(60, 17);
            this.player2.TabIndex = 2;
            this.player2.Text = "Player 2";
            // 
            // lbAlea1
            // 
            this.lbAlea1.AutoSize = true;
            this.lbAlea1.Location = new System.Drawing.Point(154, 32);
            this.lbAlea1.Name = "lbAlea1";
            this.lbAlea1.Size = new System.Drawing.Size(16, 17);
            this.lbAlea1.TabIndex = 1;
            this.lbAlea1.Text = "0";
            // 
            // lbAlea2
            // 
            this.lbAlea2.AutoSize = true;
            this.lbAlea2.Location = new System.Drawing.Point(154, 72);
            this.lbAlea2.Name = "lbAlea2";
            this.lbAlea2.Size = new System.Drawing.Size(16, 17);
            this.lbAlea2.TabIndex = 3;
            this.lbAlea2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Points";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(127, 113);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(123, 375);
            this.textBox1.TabIndex = 5;
            // 
            // tbColor
            // 
            this.tbColor.Location = new System.Drawing.Point(231, 24);
            this.tbColor.Name = "tbColor";
            this.tbColor.Size = new System.Drawing.Size(60, 60);
            this.tbColor.TabIndex = 6;
            this.tbColor.Text = "";
            // 
            // Juego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 545);
            this.Controls.Add(this.tbColor);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbAlea2);
            this.Controls.Add(this.lbAlea1);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.player1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Juego";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Juego";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Juego_FormClosing);
            this.Load += new System.EventHandler(this.Juego_Load);
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
        private System.Windows.Forms.RichTextBox tbColor;
    }
}

