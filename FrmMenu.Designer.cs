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
            MnuSair = new ToolStripMenuItem();
            aulasToolStripMenuItem = new ToolStripMenuItem();
            MnuAula01 = new ToolStripMenuItem();
            MnuSuspenso = new ContextMenuStrip(components);
            MnSGenero = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripSeparator();
            MnSAutor = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            LblDisplay = new ToolStripStatusLabel();
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
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MnuGenero, toolStripMenuItem1, MnuAutor, toolStripMenuItem2, MnuSair });
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(82, 24);
            cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // MnuGenero
            // 
            MnuGenero.Name = "MnuGenero";
            MnuGenero.Size = new Size(140, 26);
            MnuGenero.Text = "&Gênero";
            MnuGenero.Click += MnuGenero_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(137, 6);
            // 
            // MnuAutor
            // 
            MnuAutor.Name = "MnuAutor";
            MnuAutor.Size = new Size(140, 26);
            MnuAutor.Text = "&Autor";
            MnuAutor.Click += MnuAutor_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(137, 6);
            // 
            // MnuSair
            // 
            MnuSair.Name = "MnuSair";
            MnuSair.Size = new Size(140, 26);
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
            MnuSuspenso.Items.AddRange(new ToolStripItem[] { MnSGenero, toolStripMenuItem3, MnSAutor });
            MnuSuspenso.Name = "contextMenuStrip1";
            MnuSuspenso.Size = new Size(127, 58);
            // 
            // MnSGenero
            // 
            MnSGenero.Name = "MnSGenero";
            MnSGenero.Size = new Size(126, 24);
            MnSGenero.Text = "&Gênero";
            MnSGenero.Click += MnSGenero_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(123, 6);
            // 
            // MnSAutor
            // 
            MnSAutor.Name = "MnSAutor";
            MnSAutor.Size = new Size(126, 24);
            MnSAutor.Text = "&Autor";
            MnSAutor.Click += MnSAutor_Click;
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
    }
}