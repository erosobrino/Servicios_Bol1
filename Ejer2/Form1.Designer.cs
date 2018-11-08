namespace Ejer2
{
    partial class Processes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Processes));
            this.tbText = new System.Windows.Forms.TextBox();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.btProcess = new System.Windows.Forms.Button();
            this.btInfo = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.btKill = new System.Windows.Forms.Button();
            this.btRun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbText
            // 
            this.tbText.Font = new System.Drawing.Font("Courier New", 10F);
            this.tbText.Location = new System.Drawing.Point(35, 12);
            this.tbText.Multiline = true;
            this.tbText.Name = "tbText";
            this.tbText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbText.Size = new System.Drawing.Size(852, 281);
            this.tbText.TabIndex = 0;
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(177, 358);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(142, 22);
            this.tbPath.TabIndex = 1;
            // 
            // btProcess
            // 
            this.btProcess.Location = new System.Drawing.Point(35, 333);
            this.btProcess.Name = "btProcess";
            this.btProcess.Size = new System.Drawing.Size(136, 72);
            this.btProcess.TabIndex = 2;
            this.btProcess.Text = "View Processes";
            this.btProcess.UseVisualStyleBackColor = true;
            this.btProcess.Click += new System.EventHandler(this.btProcess_Click);
            // 
            // btInfo
            // 
            this.btInfo.Location = new System.Drawing.Point(325, 333);
            this.btInfo.Name = "btInfo";
            this.btInfo.Size = new System.Drawing.Size(136, 72);
            this.btInfo.TabIndex = 3;
            this.btInfo.Text = "Process Info";
            this.btInfo.UseVisualStyleBackColor = true;
            this.btInfo.Click += new System.EventHandler(this.btInfo_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(467, 333);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(136, 72);
            this.btClose.TabIndex = 4;
            this.btClose.Text = "Close Process";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btKill
            // 
            this.btKill.Location = new System.Drawing.Point(609, 333);
            this.btKill.Name = "btKill";
            this.btKill.Size = new System.Drawing.Size(136, 72);
            this.btKill.TabIndex = 5;
            this.btKill.Text = "Kill Process";
            this.btKill.UseVisualStyleBackColor = true;
            this.btKill.Click += new System.EventHandler(this.btKill_Click);
            // 
            // btRun
            // 
            this.btRun.Location = new System.Drawing.Point(751, 333);
            this.btRun.Name = "btRun";
            this.btRun.Size = new System.Drawing.Size(136, 72);
            this.btRun.TabIndex = 6;
            this.btRun.Text = "Run App";
            this.btRun.UseVisualStyleBackColor = true;
            this.btRun.Click += new System.EventHandler(this.btRun_Click);
            // 
            // Processes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 450);
            this.Controls.Add(this.btRun);
            this.Controls.Add(this.btKill);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btInfo);
            this.Controls.Add(this.btProcess);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.tbText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Processes";
            this.Text = "Processes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Button btProcess;
        private System.Windows.Forms.Button btInfo;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btKill;
        private System.Windows.Forms.Button btRun;
    }
}

