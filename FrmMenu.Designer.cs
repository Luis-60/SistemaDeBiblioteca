namespace AulaAEDB01.Windows
{
    partial class FrmMenu
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
            menuStrip1 = new MenuStrip();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            MnuGenero = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            MnuAutor = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            MnuEditora = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripSeparator();
            MnuIdioma = new ToolStripMenuItem();
            toolStripMenuItem8 = new ToolStripSeparator();
            MnuLivro = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripSeparator();
            MnuSair = new ToolStripMenuItem();
            aulasToolStripMenuItem = new ToolStripMenuItem();
            MnuAula01 = new ToolStripMenuItem();
            MnuSuspenso = new ContextMenuStrip(components);
            MnSGenero = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripSeparator();
            MnSAutor = new ToolStripMenuItem();
            toolStripMenuItem6 = new ToolStripSeparator();
            MnSEditora = new ToolStripMenuItem();
            toolStripMenuItem7 = new ToolStripSeparator();
            MnSIdioma = new ToolStripMenuItem();
            toolStripMenuItem9 = new ToolStripSeparator();
            MnSLivro = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            LblDisplay = new ToolStripStatusLabel();
            MnuUsuario = new ToolStripMenuItem();
            toolStripMenuItem10 = new ToolStripSeparator();
            toolStripMenuItem11 = new ToolStripSeparator();
            MnSUsuario = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            MnuSuspenso.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem, aulasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MnuGenero, toolStripMenuItem1, MnuAutor, toolStripMenuItem2, MnuEditora, toolStripMenuItem4, MnuIdioma, toolStripMenuItem8, MnuLivro, toolStripMenuItem5, MnuUsuario, toolStripMenuItem10, MnuSair });
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(82, 24);
            cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // MnuGenero
            // 
            MnuGenero.Name = "MnuGenero";
            MnuGenero.Size = new Size(224, 26);
            MnuGenero.Text = "&Gênero";
            MnuGenero.Click += MnuGenero_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(221, 6);
            // 
            // MnuAutor
            // 
            MnuAutor.Name = "MnuAutor";
            MnuAutor.Size = new Size(224, 26);
            MnuAutor.Text = "&Autor";
            MnuAutor.Click += MnuAutor_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(221, 6);
            // 
            // MnuEditora
            // 
            MnuEditora.Name = "MnuEditora";
            MnuEditora.Size = new Size(224, 26);
            MnuEditora.Text = "&Editora";
            MnuEditora.Click += MnuEditora_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(221, 6);
            // 
            // MnuIdioma
            // 
            MnuIdioma.Name = "MnuIdioma";
            MnuIdioma.Size = new Size(224, 26);
            MnuIdioma.Text = "&Idioma";
            MnuIdioma.Click += MnuIdioma_Click;
            // 
            // toolStripMenuItem8
            // 
            toolStripMenuItem8.Name = "toolStripMenuItem8";
            toolStripMenuItem8.Size = new Size(221, 6);
            // 
            // MnuLivro
            // 
            MnuLivro.Name = "MnuLivro";
            MnuLivro.Size = new Size(224, 26);
            MnuLivro.Text = "&Livro";
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(221, 6);
            // 
            // MnuSair
            // 
            MnuSair.Name = "MnuSair";
            MnuSair.Size = new Size(224, 26);
            MnuSair.Text = "Sair";
            MnuSair.Click += MnuSair_Click;
            // 
            // aulasToolStripMenuItem
            // 
            aulasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MnuAula01 });
            aulasToolStripMenuItem.Name = "aulasToolStripMenuItem";
            aulasToolStripMenuItem.Size = new Size(59, 24);
            aulasToolStripMenuItem.Text = "Aulas";
            // 
            // MnuAula01
            // 
            MnuAula01.Name = "MnuAula01";
            MnuAula01.Size = new Size(138, 26);
            MnuAula01.Text = "Aula01";
            MnuAula01.Click += MnuAula01_Click;
            // 
            // MnuSuspenso
            // 
            MnuSuspenso.ImageScalingSize = new Size(20, 20);
            MnuSuspenso.Items.AddRange(new ToolStripItem[] { MnSGenero, toolStripMenuItem3, MnSAutor, toolStripMenuItem6, MnSEditora, toolStripMenuItem7, MnSIdioma, toolStripMenuItem9, MnSLivro, toolStripMenuItem11, MnSUsuario });
            MnuSuspenso.Name = "contextMenuStrip1";
            MnuSuspenso.Size = new Size(129, 178);
            // 
            // MnSGenero
            // 
            MnSGenero.Name = "MnSGenero";
            MnSGenero.Size = new Size(128, 24);
            MnSGenero.Text = "&Gênero";
            MnSGenero.Click += MnSGenero_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(125, 6);
            // 
            // MnSAutor
            // 
            MnSAutor.Name = "MnSAutor";
            MnSAutor.Size = new Size(128, 24);
            MnSAutor.Text = "&Autor";
            MnSAutor.Click += MnSAutor_Click;
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new Size(125, 6);
            // 
            // MnSEditora
            // 
            MnSEditora.Name = "MnSEditora";
            MnSEditora.Size = new Size(128, 24);
            MnSEditora.Text = "&Editora";
            MnSEditora.Click += MnSEditora_Click;
            // 
            // toolStripMenuItem7
            // 
            toolStripMenuItem7.Name = "toolStripMenuItem7";
            toolStripMenuItem7.Size = new Size(125, 6);
            // 
            // MnSIdioma
            // 
            MnSIdioma.Name = "MnSIdioma";
            MnSIdioma.Size = new Size(128, 24);
            MnSIdioma.Text = "&Idioma";
            // 
            // toolStripMenuItem9
            // 
            toolStripMenuItem9.Name = "toolStripMenuItem9";
            toolStripMenuItem9.Size = new Size(125, 6);
            // 
            // MnSLivro
            // 
            MnSLivro.Name = "MnSLivro";
            MnSLivro.Size = new Size(128, 24);
            MnSLivro.Text = "&Livro";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { LblDisplay });
            statusStrip1.Location = new Point(0, 426);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 24);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // LblDisplay
            // 
            LblDisplay.AutoSize = false;
            LblDisplay.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            LblDisplay.DisplayStyle = ToolStripItemDisplayStyle.Text;
            LblDisplay.Name = "LblDisplay";
            LblDisplay.Size = new Size(300, 18);
            // 
            // MnuUsuario
            // 
            MnuUsuario.Name = "MnuUsuario";
            MnuUsuario.Size = new Size(224, 26);
            MnuUsuario.Text = "&Usuário";
            MnuUsuario.Click += MnuUsuario_Click;
            // 
            // toolStripMenuItem10
            // 
            toolStripMenuItem10.Name = "toolStripMenuItem10";
            toolStripMenuItem10.Size = new Size(221, 6);
            // 
            // toolStripMenuItem11
            // 
            toolStripMenuItem11.Name = "toolStripMenuItem11";
            toolStripMenuItem11.Size = new Size(125, 6);
            // 
            // MnSUsuario
            // 
            MnSUsuario.Name = "MnSUsuario";
            MnSUsuario.Size = new Size(128, 24);
            MnSUsuario.Text = "&Usuario";
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ContextMenuStrip = MnuSuspenso;
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FrmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Biblioteca";
            WindowState = FormWindowState.Maximized;
            Load += FrmMenu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            MnuSuspenso.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem MnuSair;
        public MenuStrip menuStrip1;
        public ContextMenuStrip MnuSuspenso;
        public ToolStripMenuItem MnuGenero;
        public ToolStripMenuItem MnSGenero;
        private StatusStrip statusStrip1;
        public ToolStripStatusLabel LblDisplay;
        private ToolStripMenuItem aulasToolStripMenuItem;
        private ToolStripMenuItem MnuAula01;
        private ToolStripMenuItem MnuAutor;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem MnSAutor;
        private ToolStripMenuItem MnuEditora;
        private ToolStripSeparator toolStripMenuItem4;
        private ToolStripMenuItem MnuLivro;
        private ToolStripMenuItem MnuIdioma;
        private ToolStripSeparator toolStripMenuItem8;
        private ToolStripSeparator toolStripMenuItem5;
        private ToolStripSeparator toolStripMenuItem6;
        private ToolStripMenuItem MnSEditora;
        private ToolStripSeparator toolStripMenuItem7;
        private ToolStripMenuItem MnSIdioma;
        private ToolStripSeparator toolStripMenuItem9;
        private ToolStripMenuItem MnSLivro;
        private ToolStripMenuItem MnuUsuario;
        private ToolStripSeparator toolStripMenuItem10;
        private ToolStripSeparator toolStripMenuItem11;
        private ToolStripMenuItem MnSUsuario;
    }
}