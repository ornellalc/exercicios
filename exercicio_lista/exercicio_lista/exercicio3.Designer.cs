namespace exercicio_lista
{
    partial class exercicio3
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
            valor1 = new TextBox();
            valor2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            resultado = new Label();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            button5 = new Button();
            SuspendLayout();
            // 
            // valor1
            // 
            valor1.Location = new Point(213, 57);
            valor1.Name = "valor1";
            valor1.Size = new Size(125, 27);
            valor1.TabIndex = 0;
            // 
            // valor2
            // 
            valor2.Location = new Point(213, 102);
            valor2.Name = "valor2";
            valor2.Size = new Size(125, 27);
            valor2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(59, 219);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(213, 219);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(59, 272);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 4;
            button3.Text = "x";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(213, 272);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 5;
            button4.Text = " ÷";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // resultado
            // 
            resultado.AutoSize = true;
            resultado.Location = new Point(374, 80);
            resultado.Name = "resultado";
            resultado.Size = new Size(159, 20);
            resultado.TabIndex = 6;
            resultado.Text = "resultado da operação";
            resultado.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 60);
            label2.Name = "label2";
            label2.Size = new Size(127, 20);
            label2.TabIndex = 7;
            label2.Text = "Insira um numero:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 105);
            label3.Name = "label3";
            label3.Size = new Size(127, 20);
            label3.TabIndex = 8;
            label3.Text = "Insira um numero:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 175);
            label1.Name = "label1";
            label1.Size = new Size(162, 20);
            label1.TabIndex = 9;
            label1.Text = "Escolha uma operação:";
            label1.Click += label1_Click_1;
            // 
            // button5
            // 
            button5.Location = new Point(665, 381);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 10;
            button5.Text = "Exercicio 4";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // exercicio3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(resultado);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(valor2);
            Controls.Add(valor1);
            Name = "exercicio3";
            Text = "exercicio3";
            Load += exercicio3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox valor1;
        private TextBox valor2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label resultado;
        private Label label2;
        private Label label3;
        private Label label1;
        private Button button5;
    }
}