﻿namespace exercicio_lista
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            botao = new Button();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // botao
            // 
            botao.Location = new Point(246, 95);
            botao.Name = "botao";
            botao.Size = new Size(94, 29);
            botao.TabIndex = 0;
            botao.Text = "clique aqui";
            botao.UseVisualStyleBackColor = true;
            botao.Click += botao_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(374, 104);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 1;
            label1.Text = "mensagem";
            // 
            // button1
            // 
            button1.Location = new Point(578, 295);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Exercicio 2";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(botao);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button botao;
        private Label label1;
        private Button button1;
    }
}
