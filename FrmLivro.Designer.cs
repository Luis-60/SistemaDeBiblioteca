namespace AulaAEDB01.Windows
{
    partial class FrmLivro
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
            LblNome = new Label();
            LblCodigo = new Label();
            TxtNomeL = new TextBox();
            TxtCodigoL = new TextBox();
            GrdItensL = new DataGridView();
            CodigoL = new DataGridViewTextBoxColumn();
            NomeL = new DataGridViewTextBoxColumn();
            Edição = new DataGridViewTextBoxColumn();
            Descrição = new DataGridViewTextBoxColumn();
            Editora = new DataGridViewTextBoxColumn();
            Autor = new DataGridViewTextBoxColumn();
            Idioma = new DataGridViewTextBoxColumn();
            QtdPag = new DataGridViewTextBoxColumn();
            BtnAlterarL = new DataGridViewButtonColumn();
            BtnExcluirL = new DataGridViewButtonColumn();
            BtnFecharL = new Button();
            BtnSalvarL = new Button();
            LblIsbn = new Label();
            TxtISBN = new TextBox();
            label1 = new Label();
            TxtDescricao = new TextBox();
            CboEditora = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            CboAutor = new ComboBox();
            label4 = new Label();
            CboIdioma = new ComboBox();
            label5 = new Label();
            TxtEdicao = new TextBox();
            label6 = new Label();
            TxtPag = new TextBox();
            label7 = new Label();
            CboGenero = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)GrdItensL).BeginInit();
            SuspendLayout();
            // 
            // LblNome
            // 
            LblNome.AutoSize = true;
            LblNome.Location = new Point(36, 99);
            LblNome.Name = "LblNome";
            LblNome.Size = new Size(50, 20);
            LblNome.TabIndex = 27;
            LblNome.Text = "Nome";
            // 
            // LblCodigo
            // 
            LblCodigo.AutoSize = true;
            LblCodigo.Location = new Point(36, 23);
            LblCodigo.Name = "LblCodigo";
            LblCodigo.Size = new Size(58, 20);
            LblCodigo.TabIndex = 26;
            LblCodigo.Text = "Código";
            // 
            // TxtNomeL
            // 
            TxtNomeL.Location = new Point(36, 133);
            TxtNomeL.MaxLength = 100;
            TxtNomeL.Name = "TxtNomeL";
            TxtNomeL.Size = new Size(347, 27);
            TxtNomeL.TabIndex = 25;
            // 
            // TxtCodigoL
            // 
            TxtCodigoL.Enabled = false;
            TxtCodigoL.Location = new Point(36, 59);
            TxtCodigoL.MaxLength = 4;
            TxtCodigoL.Name = "TxtCodigoL";
            TxtCodigoL.Size = new Size(125, 27);
            TxtCodigoL.TabIndex = 24;
            // 
            // GrdItensL
            // 
            GrdItensL.AllowUserToAddRows = false;
            GrdItensL.AllowUserToDeleteRows = false;
            GrdItensL.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GrdItensL.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrdItensL.Columns.AddRange(new DataGridViewColumn[] { CodigoL, NomeL, Edição, Descrição, Editora, Autor, Idioma, QtdPag, BtnAlterarL, BtnExcluirL });
            GrdItensL.Location = new Point(403, 1);
            GrdItensL.Name = "GrdItensL";
            GrdItensL.RowHeadersWidth = 51;
            GrdItensL.Size = new Size(1305, 705);
            GrdItensL.TabIndex = 23;
            // 
            // CodigoL
            // 
            CodigoL.DataPropertyName = "CodigoL";
            CodigoL.HeaderText = "Codigo";
            CodigoL.MinimumWidth = 6;
            CodigoL.Name = "CodigoL";
            CodigoL.Width = 125;
            // 
            // NomeL
            // 
            NomeL.DataPropertyName = "NomeL";
            NomeL.HeaderText = "Nome";
            NomeL.MinimumWidth = 6;
            NomeL.Name = "NomeL";
            NomeL.Width = 125;
            // 
            // Edição
            // 
            Edição.DataPropertyName = "Edicao";
            Edição.HeaderText = "Edição";
            Edição.MinimumWidth = 6;
            Edição.Name = "Edição";
            Edição.Width = 125;
            // 
            // Descrição
            // 
            Descrição.DataPropertyName = "Descricao";
            Descrição.HeaderText = "Descrição";
            Descrição.MinimumWidth = 6;
            Descrição.Name = "Descrição";
            Descrição.Width = 125;
            // 
            // Editora
            // 
            Editora.DataPropertyName = "Editora";
            Editora.HeaderText = "Editora";
            Editora.MinimumWidth = 6;
            Editora.Name = "Editora";
            Editora.Width = 125;
            // 
            // Autor
            // 
            Autor.DataPropertyName = "Autor";
            Autor.HeaderText = "Autor";
            Autor.MinimumWidth = 6;
            Autor.Name = "Autor";
            Autor.Width = 125;
            // 
            // Idioma
            // 
            Idioma.DataPropertyName = "Idioma";
            Idioma.HeaderText = "Idioma";
            Idioma.MinimumWidth = 6;
            Idioma.Name = "Idioma";
            Idioma.Width = 125;
            // 
            // QtdPag
            // 
            QtdPag.DataPropertyName = "QtdPag";
            QtdPag.HeaderText = "QtdPag";
            QtdPag.MinimumWidth = 6;
            QtdPag.Name = "QtdPag";
            QtdPag.Width = 125;
            // 
            // BtnAlterarL
            // 
            BtnAlterarL.DataPropertyName = "BtnAlterarL";
            BtnAlterarL.HeaderText = "Alterar";
            BtnAlterarL.MinimumWidth = 6;
            BtnAlterarL.Name = "BtnAlterarL";
            BtnAlterarL.Width = 125;
            // 
            // BtnExcluirL
            // 
            BtnExcluirL.DataPropertyName = "BtnExcluirL";
            BtnExcluirL.HeaderText = "Excluir";
            BtnExcluirL.MinimumWidth = 6;
            BtnExcluirL.Name = "BtnExcluirL";
            BtnExcluirL.Width = 125;
            // 
            // BtnFecharL
            // 
            BtnFecharL.Location = new Point(213, 648);
            BtnFecharL.Name = "BtnFecharL";
            BtnFecharL.Size = new Size(156, 34);
            BtnFecharL.TabIndex = 22;
            BtnFecharL.Text = "&Fechar";
            BtnFecharL.UseVisualStyleBackColor = true;
            // 
            // BtnSalvarL
            // 
            BtnSalvarL.Location = new Point(31, 648);
            BtnSalvarL.Name = "BtnSalvarL";
            BtnSalvarL.Size = new Size(156, 34);
            BtnSalvarL.TabIndex = 21;
            BtnSalvarL.Text = "&Salvar";
            BtnSalvarL.UseVisualStyleBackColor = true;
            BtnSalvarL.Click += BtnSalvarL_Click;
            // 
            // LblIsbn
            // 
            LblIsbn.AutoSize = true;
            LblIsbn.Location = new Point(36, 179);
            LblIsbn.Name = "LblIsbn";
            LblIsbn.Size = new Size(41, 20);
            LblIsbn.TabIndex = 29;
            LblIsbn.Text = "ISBN";
            // 
            // TxtISBN
            // 
            TxtISBN.Location = new Point(36, 213);
            TxtISBN.MaxLength = 100;
            TxtISBN.Name = "TxtISBN";
            TxtISBN.Size = new Size(347, 27);
            TxtISBN.TabIndex = 28;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 254);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 31;
            label1.Text = "Descrição";
            // 
            // TxtDescricao
            // 
            TxtDescricao.Location = new Point(36, 288);
            TxtDescricao.MaxLength = 255;
            TxtDescricao.Multiline = true;
            TxtDescricao.Name = "TxtDescricao";
            TxtDescricao.Size = new Size(347, 92);
            TxtDescricao.TabIndex = 30;
            // 
            // CboEditora
            // 
            CboEditora.FormattingEnabled = true;
            CboEditora.Location = new Point(36, 433);
            CboEditora.Name = "CboEditora";
            CboEditora.Size = new Size(151, 28);
            CboEditora.TabIndex = 32;
            CboEditora.SelectedIndexChanged += CboEditora_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 400);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 33;
            label2.Text = "Editora";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(203, 400);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 35;
            label3.Text = "Autor";
            // 
            // CboAutor
            // 
            CboAutor.FormattingEnabled = true;
            CboAutor.Location = new Point(203, 433);
            CboAutor.Name = "CboAutor";
            CboAutor.Size = new Size(180, 28);
            CboAutor.TabIndex = 34;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 480);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 37;
            label4.Text = "Idioma";
            // 
            // CboIdioma
            // 
            CboIdioma.FormattingEnabled = true;
            CboIdioma.Location = new Point(36, 513);
            CboIdioma.Name = "CboIdioma";
            CboIdioma.Size = new Size(151, 28);
            CboIdioma.TabIndex = 36;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 568);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 39;
            label5.Text = "Edição";
            // 
            // TxtEdicao
            // 
            TxtEdicao.Location = new Point(33, 593);
            TxtEdicao.MaxLength = 100;
            TxtEdicao.Name = "TxtEdicao";
            TxtEdicao.Size = new Size(128, 27);
            TxtEdicao.TabIndex = 38;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(203, 568);
            label6.Name = "label6";
            label6.Size = new Size(162, 20);
            label6.TabIndex = 41;
            label6.Text = "Quantidade de Páginas";
            // 
            // TxtPag
            // 
            TxtPag.Location = new Point(203, 593);
            TxtPag.MaxLength = 100;
            TxtPag.Name = "TxtPag";
            TxtPag.Size = new Size(68, 27);
            TxtPag.TabIndex = 40;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(203, 480);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 43;
            label7.Text = "Genero";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CboGenero
            // 
            CboGenero.FormattingEnabled = true;
            CboGenero.Location = new Point(203, 513);
            CboGenero.Name = "CboGenero";
            CboGenero.Size = new Size(180, 28);
            CboGenero.TabIndex = 42;
            // 
            // FrmLivro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1711, 706);
            Controls.Add(label7);
            Controls.Add(CboGenero);
            Controls.Add(label6);
            Controls.Add(TxtPag);
            Controls.Add(label5);
            Controls.Add(TxtEdicao);
            Controls.Add(label4);
            Controls.Add(CboIdioma);
            Controls.Add(label3);
            Controls.Add(CboAutor);
            Controls.Add(label2);
            Controls.Add(CboEditora);
            Controls.Add(label1);
            Controls.Add(TxtDescricao);
            Controls.Add(LblIsbn);
            Controls.Add(TxtISBN);
            Controls.Add(LblNome);
            Controls.Add(LblCodigo);
            Controls.Add(TxtNomeL);
            Controls.Add(TxtCodigoL);
            Controls.Add(GrdItensL);
            Controls.Add(BtnFecharL);
            Controls.Add(BtnSalvarL);
            Name = "FrmLivro";
            Text = "Cadastro de Livros";
            Activated += FrmLivro_Activated;
            FormClosed += FrmLivro_FormClosed;
            Load += FrmLivro_Load;
            ((System.ComponentModel.ISupportInitialize)GrdItensL).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblNome;
        private Label LblCodigo;
        private TextBox TxtNomeL;
        private TextBox TxtCodigoL;
        private DataGridView GrdItensL;
        private Button BtnFecharL;
        private Button BtnSalvarL;
        private Label LblIsbn;
        private TextBox TxtISBN;
        private Label label1;
        private TextBox TxtDescricao;
        private ComboBox CboEditora;
        private Label label2;
        private Label label3;
        private ComboBox CboAutor;
        private Label label4;
        private ComboBox CboIdioma;
        private Label label5;
        private TextBox TxtEdicao;
        private Label label6;
        private TextBox TxtPag;
        private Label label7;
        private ComboBox CboGenero;
        private DataGridViewTextBoxColumn CodigoL;
        private DataGridViewTextBoxColumn NomeL;
        private DataGridViewTextBoxColumn Edição;
        private DataGridViewTextBoxColumn Descrição;
        private DataGridViewTextBoxColumn Editora;
        private DataGridViewTextBoxColumn Autor;
        private DataGridViewTextBoxColumn Idioma;
        private DataGridViewTextBoxColumn QtdPag;
        private DataGridViewButtonColumn BtnAlterarL;
        private DataGridViewButtonColumn BtnExcluirL;
        private BindingSource editoraBindingSource;
        private BindingSource autorBindingSource;
    }
}