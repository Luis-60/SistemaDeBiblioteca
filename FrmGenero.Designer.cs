namespace AulaAEDB01.Windows
{
    partial class FrmGenero
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
            TxtCodigo = new TextBox();
            TxtNome = new TextBox();
            LblCodigo = new Label();
            LblNome = new Label();
            toolTip1 = new ToolTip(components);
            BtnSalvar = new Button();
            BtnFechar = new Button();
            GrdItens = new DataGridView();
            Código = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            BtnAlterar = new DataGridViewButtonColumn();
            BtnExcluir = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)GrdItens).BeginInit();
            SuspendLayout();
            // 
            // TxtCodigo
            // 
            TxtCodigo.Enabled = false;
            TxtCodigo.Location = new Point(35, 54);
            TxtCodigo.MaxLength = 4;
            TxtCodigo.Name = "TxtCodigo";
            TxtCodigo.Size = new Size(125, 27);
            TxtCodigo.TabIndex = 0;
            toolTip1.SetToolTip(TxtCodigo, "Código númerico do Gênero");
            TxtCodigo.TextChanged += TxtCodigo_TextChanged;
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(176, 54);
            TxtNome.MaxLength = 50;
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(456, 27);
            TxtNome.TabIndex = 1;
            toolTip1.SetToolTip(TxtNome, "Nome do Gênero");
            // 
            // LblCodigo
            // 
            LblCodigo.AutoSize = true;
            LblCodigo.Location = new Point(35, 18);
            LblCodigo.Name = "LblCodigo";
            LblCodigo.Size = new Size(58, 20);
            LblCodigo.TabIndex = 2;
            LblCodigo.Text = "Código";
            // 
            // LblNome
            // 
            LblNome.AutoSize = true;
            LblNome.Location = new Point(176, 18);
            LblNome.Name = "LblNome";
            LblNome.Size = new Size(50, 20);
            LblNome.TabIndex = 3;
            LblNome.Text = "Nome";
            // 
            // toolTip1
            // 
            toolTip1.IsBalloon = true;
            // 
            // BtnSalvar
            // 
            BtnSalvar.Location = new Point(35, 105);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(156, 34);
            BtnSalvar.TabIndex = 4;
            BtnSalvar.Text = "&Salvar";
            BtnSalvar.UseVisualStyleBackColor = true;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // BtnFechar
            // 
            BtnFechar.Location = new Point(226, 105);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.Size = new Size(156, 34);
            BtnFechar.TabIndex = 5;
            BtnFechar.Text = "&Fechar";
            BtnFechar.UseVisualStyleBackColor = true;
            BtnFechar.Click += BtnFechar_Click;
            // 
            // GrdItens
            // 
            GrdItens.AllowUserToAddRows = false;
            GrdItens.AllowUserToDeleteRows = false;
            GrdItens.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GrdItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrdItens.Columns.AddRange(new DataGridViewColumn[] { Código, Nome, BtnAlterar, BtnExcluir });
            GrdItens.Location = new Point(2, 156);
            GrdItens.Name = "GrdItens";
            GrdItens.RowHeadersWidth = 51;
            GrdItens.Size = new Size(794, 266);
            GrdItens.TabIndex = 6;
            GrdItens.CellClick += GrdItens_CellClick;
            GrdItens.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // Código
            // 
            Código.DataPropertyName = "Codigo";
            Código.HeaderText = "Codigo";
            Código.MinimumWidth = 6;
            Código.Name = "Código";
            Código.Width = 125;
            // 
            // Nome
            // 
            Nome.DataPropertyName = "Nome";
            Nome.HeaderText = "Nome";
            Nome.MinimumWidth = 6;
            Nome.Name = "Nome";
            Nome.Width = 125;
            // 
            // BtnAlterar
            // 
            BtnAlterar.HeaderText = "Alterar";
            BtnAlterar.MinimumWidth = 6;
            BtnAlterar.Name = "BtnAlterar";
            BtnAlterar.Width = 125;
            // 
            // BtnExcluir
            // 
            BtnExcluir.HeaderText = "Excluir";
            BtnExcluir.MinimumWidth = 6;
            BtnExcluir.Name = "BtnExcluir";
            BtnExcluir.Width = 125;
            // 
            // FrmGenero
            // 
            AcceptButton = BtnSalvar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 428);
            Controls.Add(GrdItens);
            Controls.Add(BtnFechar);
            Controls.Add(BtnSalvar);
            Controls.Add(LblNome);
            Controls.Add(LblCodigo);
            Controls.Add(TxtNome);
            Controls.Add(TxtCodigo);
            Name = "FrmGenero";
            Text = "Cadastro de Genero";
            Activated += FrmGenero_Activated;
            FormClosed += FrmGenero_FormClosed;
            Load += FrmGenero_Load;
            ((System.ComponentModel.ISupportInitialize)GrdItens).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtCodigo;
        private TextBox TxtNome;
        private Label LblCodigo;
        private Label LblNome;
        private ToolTip toolTip1;
        private Button BtnSalvar;
        private Button BtnFechar;
        private DataGridView GrdItens;
        private DataGridViewTextBoxColumn Código;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewButtonColumn BtnAlterar;
        private DataGridViewButtonColumn BtnExcluir;
    }
}