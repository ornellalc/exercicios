namespace exercicio_lista
{
    partial class exercicio6
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
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;

            radioButton1.Location = new Point(237, 93);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(87, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Amarelo";
            radioButton1.Location = new Point(113, 132);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(68, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Verde";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(238, 123);

            radioButton2.Location = new Point(113, 174);

            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(59, 24);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Azul";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(238, 153);
            radioButton3.Location = new Point(113, 221);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(62, 24);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Rosa";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(236, 56);
            label1.Name = "label1";
            label1.Size = new Size(134, 20);
            label1.TabIndex = 3;
            label1.Text = "Selecione uma cor:";
            label1.Location = new Point(112, 86);
            label1.Name = "label1";
            label1.Size = new Size(224, 20);
            label1.TabIndex = 3;
            label1.Text = "Selecione uma cor para o fundo:";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(652, 365);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Exercício 7";
            button1.Location = new Point(635, 379);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Exercicio 7";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // exercicio6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Name = "exercicio6";
            Text = "exercicio6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Label label1;
        private Button button1;
    }
}