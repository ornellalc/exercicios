namespace exercicio_lista
{
    partial class exercicio5
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
            txtNome = new TextBox();
            Add = new Button();
            produtos = new ListBox();
            btnremover = new Button();
            label1 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(134, 104);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(150, 27);
            txtNome.TabIndex = 0;
            // 
            // Add
            // 
            Add.Location = new Point(402, 104);
            Add.Name = "Add";
            Add.Size = new Size(94, 29);
            Add.TabIndex = 1;
            Add.Text = "adicionar";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click_1;
            // 
            // produtos
            // 
            produtos.BackColor = SystemColors.Menu;
            produtos.ForeColor = Color.Black;
            produtos.FormattingEnabled = true;
            produtos.Location = new Point(134, 175);
            produtos.Name = "produtos";
            produtos.Size = new Size(150, 104);
            produtos.TabIndex = 2;
            // 
            // btnremover
            // 
            btnremover.Location = new Point(402, 192);
            btnremover.Name = "btnremover";
            btnremover.Size = new Size(94, 29);
            btnremover.TabIndex = 3;
            btnremover.Text = "remover";
            btnremover.UseVisualStyleBackColor = true;
            btnremover.Click += btnremover_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(134, 66);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 4;
            label1.Text = "digite aqui:";
            // 
            // button3
            // 
            button3.Location = new Point(671, 372);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 5;
            button3.Text = "Exercicio 6";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // exercicio5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(btnremover);
            Controls.Add(produtos);
            Controls.Add(Add);
            Controls.Add(txtNome);
            Name = "exercicio5";
            Text = " ";
            Load += exercicio5_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private Button Add;
        private ListBox produtos;
        private Button btnremover;
        private Label label1;
        private Button button3;
    }
}