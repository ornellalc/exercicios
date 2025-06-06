namespace projeto
{
    partial class exercicio11
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
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.formulário1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formulário1ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.formulário2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(646, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Exercicio 12";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formulário1ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // formulário1ToolStripMenuItem
            // 
            this.formulário1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formulário1ToolStripMenuItem1,
            this.formulário2ToolStripMenuItem});
            this.formulário1ToolStripMenuItem.Name = "formulário1ToolStripMenuItem";
            this.formulário1ToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.formulário1ToolStripMenuItem.Text = "Menu";
            // 
            // formulário1ToolStripMenuItem1
            // 
            this.formulário1ToolStripMenuItem1.Name = "formulário1ToolStripMenuItem1";
            this.formulário1ToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.formulário1ToolStripMenuItem1.Text = "Formulário 1";
            this.formulário1ToolStripMenuItem1.Click += new System.EventHandler(this.formulário1ToolStripMenuItem1_Click);
            // 
            // formulário2ToolStripMenuItem
            // 
            this.formulário2ToolStripMenuItem.Name = "formulário2ToolStripMenuItem";
            this.formulário2ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.formulário2ToolStripMenuItem.Text = "Formulário 2";
            this.formulário2ToolStripMenuItem.Click += new System.EventHandler(this.formulário2ToolStripMenuItem_Click);
            // 
            // exercicio11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "exercicio11";
            this.Text = "exercicio11";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem formulário1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formulário1ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem formulário2ToolStripMenuItem;
    }
}