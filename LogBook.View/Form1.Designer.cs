namespace LogBook.View
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diáriosDeBordoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diárioDeBordoPorTurmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diárioDeBordoPorAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.relatórioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(573, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunosToolStripMenuItem,
            this.diáriosDeBordoToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // relatórioToolStripMenuItem
            // 
            this.relatórioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.diárioDeBordoPorTurmaToolStripMenuItem,
            this.diárioDeBordoPorAlunoToolStripMenuItem});
            this.relatórioToolStripMenuItem.Name = "relatórioToolStripMenuItem";
            this.relatórioToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.relatórioToolStripMenuItem.Text = "Relatório";
            // 
            // alunosToolStripMenuItem
            // 
            this.alunosToolStripMenuItem.Name = "alunosToolStripMenuItem";
            this.alunosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.alunosToolStripMenuItem.Text = "Alunos";
            this.alunosToolStripMenuItem.Click += new System.EventHandler(this.alunosToolStripMenuItem_Click);
            // 
            // diáriosDeBordoToolStripMenuItem
            // 
            this.diáriosDeBordoToolStripMenuItem.Name = "diáriosDeBordoToolStripMenuItem";
            this.diáriosDeBordoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.diáriosDeBordoToolStripMenuItem.Text = "Diários de Bordo";
            this.diáriosDeBordoToolStripMenuItem.Click += new System.EventHandler(this.diáriosDeBordoToolStripMenuItem_Click);
            // 
            // diárioDeBordoPorTurmaToolStripMenuItem
            // 
            this.diárioDeBordoPorTurmaToolStripMenuItem.Name = "diárioDeBordoPorTurmaToolStripMenuItem";
            this.diárioDeBordoPorTurmaToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.diárioDeBordoPorTurmaToolStripMenuItem.Text = "Diário de bordo por turma";
            this.diárioDeBordoPorTurmaToolStripMenuItem.Click += new System.EventHandler(this.diárioDeBordoPorTurmaToolStripMenuItem_Click);
            // 
            // diárioDeBordoPorAlunoToolStripMenuItem
            // 
            this.diárioDeBordoPorAlunoToolStripMenuItem.Name = "diárioDeBordoPorAlunoToolStripMenuItem";
            this.diárioDeBordoPorAlunoToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.diárioDeBordoPorAlunoToolStripMenuItem.Text = "Diário de bordo por Aluno";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 397);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Administrador do Sistema";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diáriosDeBordoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diárioDeBordoPorTurmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diárioDeBordoPorAlunoToolStripMenuItem;
    }
}

