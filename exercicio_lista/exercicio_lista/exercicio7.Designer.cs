namespace exercicio_lista
{
    partial class exercicio7
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(138, 67);

            label1.Location = new Point(92, 50);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 0;
            label1.Text = "Insira seu CPF:";
            // 
            // textBox1
            // 

            textBox1.Location = new Point(142, 106);

            textBox1.Location = new Point(100, 85);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            textBox1.Leave += textBox1_Leave;
            // 
            // button1
            // 
            button1.Location = new Point(680, 387);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.Location = new Point(659, 376);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Exercicio 8";
 
            button1.UseVisualStyleBackColor = true;
         
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // exercicio7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "exercicio7";
            Text = "exercicio7";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private ErrorProvider errorProvider1;
    }
}