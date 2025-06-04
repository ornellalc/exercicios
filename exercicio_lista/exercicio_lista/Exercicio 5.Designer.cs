namespace exercicio_lista
{
    partial class Exercício_5
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
            btnremover = new Button();
            txtNome = new TextBox();
            produtos = new ListBox();
            btnAdd = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnremover
            // 
            btnremover.Location = new Point(282, 146);
            btnremover.Name = "btnremover";
            btnremover.Size = new Size(94, 29);
            btnremover.TabIndex = 0;
            btnremover.Text = "Remover";
            btnremover.UseVisualStyleBackColor = true;
            btnremover.Click += btnremover_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(340, 66);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(125, 27);
            txtNome.TabIndex = 1;
            // 
            // produtos
            // 
            produtos.FormattingEnabled = true;
            produtos.Location = new Point(340, 203);
            produtos.Name = "produtos";
            produtos.Size = new Size(150, 104);
            produtos.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(457, 146);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Adicionar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // button1
            // 
            button1.Location = new Point(647, 342);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Exercício 6";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Exercício_5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnAdd);
            Controls.Add(produtos);
            Controls.Add(txtNome);
            Controls.Add(btnremover);
            Name = "Exercício_5";
            Text = "Exercício_5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnremover;
        private TextBox txtNome;
        private ListBox produtos;
        private Button btnAdd;
        private Button button1;
    }
}