namespace Ejer6
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.player1 = new System.Windows.Forms.Label();
            this.player2 = new System.Windows.Forms.Label();
            this.lbRand1 = new System.Windows.Forms.Label();
            this.lbRand2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbColor = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.player2.TabIndex = 3;
            this.player2.Text = "Player 2";
            // 
            // lbRand1
            // 
            this.lbRand1.AutoSize = true;
            this.lbRand1.Location = new System.Drawing.Point(154, 32);
            this.lbRand1.Name = "lbRand1";
            this.lbRand1.Size = new System.Drawing.Size(16, 17);
            this.lbRand1.TabIndex = 1;
            this.lbRand1.Text = "0";
            // 
            // lbRand2
            // 
            this.lbRand2.AutoSize = true;
            this.lbRand2.Location = new System.Drawing.Point(154, 72);
            this.lbRand2.Name = "lbRand2";
            this.lbRand2.Size = new System.Drawing.Size(16, 17);
            this.lbRand2.TabIndex = 4;
            this.lbRand2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Points";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(65, 109);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(123, 132);
            this.textBox1.TabIndex = 6;
            this.textBox1.TabStop = false;
            // 
            // tbColor
            // 
            this.tbColor.Location = new System.Drawing.Point(231, 24);
            this.tbColor.Name = "tbColor";
            this.tbColor.ReadOnly = true;
            this.tbColor.Size = new System.Drawing.Size(60, 60);
            this.tbColor.TabIndex = 2;
            this.tbColor.TabStop = false;
            this.tbColor.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 7;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 271);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbColor);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbRand2);
            this.Controls.Add(this.lbRand1);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.player1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Juego_FormClosing);
            this.Load += new System.EventHandler(this.Juego_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label player1;
        private System.Windows.Forms.Label player2;
        private System.Windows.Forms.Label lbRand1;
        private System.Windows.Forms.Label lbRand2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox tbColor;
        private System.Windows.Forms.Label label1;
    }
}

