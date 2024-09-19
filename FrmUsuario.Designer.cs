namespace AulaAEDB01.Windows
{
    partial class FrmUsuario
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
            LblCodigoI = new Label();
            TxtCodigoU = new TextBox();
            GrdItensI = new DataGridView();
            CodigoU = new DataGridViewTextBoxColumn();
            NomeU = new DataGridViewTextBoxColumn();
            Senha = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            BtnAlterarU = new DataGridViewButtonColumn();
            BtnExcluirU = new DataGridViewButtonColumn();
            BtnFecharI = new Button();
            BtnSalvarI = new Button();
            CboTipo = new ComboBox();
            label1 = new Label();
            LblNomeI = new Label();
            TxtNomeU = new TextBox();
            label2 = new Label();
            TxtEmail = new TextBox();
            label3 = new Label();
            TxtSenha = new TextBox();
            ((System.ComponentModel.ISupportInitialize)GrdItensI).BeginInit();
            SuspendLayout();
            // 
            // LblCodigoI
            // 
            LblCodigoI.AutoSize = true;
            LblCodigoI.Location = new Point(36, 23);
            LblCodigoI.Name = "LblCodigoI";
            LblCodigoI.Size = new Size(58, 20);
            LblCodigoI.TabIndex = 26;
            LblCodigoI.Text = "Código";
            // 
            // TxtCodigoU
            // 
            TxtCodigoU.Enabled = false;
            TxtCodigoU.Location = new Point(36, 59);
            TxtCodigoU.MaxLength = 4;
            TxtCodigoU.Name = "TxtCodigoU";
            TxtCodigoU.Size = new Size(125, 27);
            TxtCodigoU.TabIndex = 24;
            // 
            // GrdItensI
            // 
            GrdItensI.AllowUserToAddRows = false;
            GrdItensI.AllowUserToDeleteRows = false;
            GrdItensI.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GrdItensI.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrdItensI.Columns.AddRange(new DataGridViewColumn[] { CodigoU, NomeU, Senha, Email, Tipo, BtnAlterarU, BtnExcluirU });
            GrdItensI.Location = new Point(3, 219);
            GrdItensI.Name = "GrdItensI";
            GrdItensI.RowHeadersWidth = 51;
            GrdItensI.Size = new Size(932, 261);
            GrdItensI.TabIndex = 23;
            GrdItensI.CellContentClick += GrdItensI_CellContentClick;
            // 
            // CodigoU
            // 
            CodigoU.DataPropertyName = "CodigoU";
            CodigoU.HeaderText = "Codigo";
            CodigoU.MinimumWidth = 50;
            CodigoU.Name = "CodigoU";
            CodigoU.Width = 125;
            // 
            // NomeU
            // 
            NomeU.DataPropertyName = "NomeU";
            NomeU.HeaderText = "Nome";
            NomeU.MinimumWidth = 6;
            NomeU.Name = "NomeU";
            NomeU.Width = 125;
            // 
            // Senha
            // 
            Senha.DataPropertyName = "Senha";
            Senha.HeaderText = "Senha";
            Senha.MinimumWidth = 6;
            Senha.Name = "Senha";
            Senha.Width = 125;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.Width = 125;
            // 
            // Tipo
            // 
            Tipo.HeaderText = "Tipo";
            Tipo.MinimumWidth = 6;
            Tipo.Name = "Tipo";
            Tipo.Width = 125;
            // 
            // BtnAlterarU
            // 
            BtnAlterarU.DataPropertyName = "BtnAlterarU";
            BtnAlterarU.HeaderText = "Alterar";
            BtnAlterarU.MinimumWidth = 6;
            BtnAlterarU.Name = "BtnAlterarU";
            BtnAlterarU.Width = 125;
            // 
            // BtnExcluirU
            // 
            BtnExcluirU.DataPropertyName = "BtnExcluirU";
            BtnExcluirU.HeaderText = "Excluir";
            BtnExcluirU.MinimumWidth = 6;
            BtnExcluirU.Name = "BtnExcluirU";
            BtnExcluirU.Width = 125;
            // 
            // BtnFecharI
            // 
            BtnFecharI.Location = new Point(770, 80);
            BtnFecharI.Name = "BtnFecharI";
            BtnFecharI.Size = new Size(156, 34);
            BtnFecharI.TabIndex = 22;
            BtnFecharI.Text = "&Fechar";
            BtnFecharI.UseVisualStyleBackColor = true;
            // 
            // BtnSalvarI
            // 
            BtnSalvarI.Location = new Point(770, 23);
            BtnSalvarI.Name = "BtnSalvarI";
            BtnSalvarI.Size = new Size(156, 34);
            BtnSalvarI.TabIndex = 21;
            BtnSalvarI.Text = "&Salvar";
            BtnSalvarI.UseVisualStyleBackColor = true;
            // 
            // CboTipo
            // 
            CboTipo.FormattingEnabled = true;
            CboTipo.Location = new Point(36, 150);
            CboTipo.Name = "CboTipo";
            CboTipo.Size = new Size(125, 28);
            CboTipo.TabIndex = 28;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 117);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 29;
            label1.Text = "Tipo";
            // 
            // LblNomeI
            // 
            LblNomeI.AutoSize = true;
            LblNomeI.Location = new Point(177, 23);
            LblNomeI.Name = "LblNomeI";
            LblNomeI.Size = new Size(50, 20);
            LblNomeI.TabIndex = 27;
            LblNomeI.Text = "Nome";
            // 
            // TxtNomeU
            // 
            TxtNomeU.Location = new Point(177, 59);
            TxtNomeU.MaxLength = 100;
            TxtNomeU.Name = "TxtNomeU";
            TxtNomeU.Size = new Size(566, 27);
            TxtNomeU.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(177, 115);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 31;
            label2.Text = "Email";
            // 
            // TxtEmail
            // 
            TxtEmail.Location = new Point(177, 151);
            TxtEmail.MaxLength = 100;
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(304, 27);
            TxtEmail.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(515, 115);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 33;
            label3.Text = "Senha";
            // 
            // TxtSenha
            // 
            TxtSenha.Location = new Point(515, 151);
            TxtSenha.MaxLength = 100;
            TxtSenha.Name = "TxtSenha";
            TxtSenha.Size = new Size(228, 27);
            TxtSenha.TabIndex = 32;
            // 
            // FrmUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 503);
            Controls.Add(label3);
            Controls.Add(TxtSenha);
            Controls.Add(label2);
            Controls.Add(TxtEmail);
            Controls.Add(label1);
            Controls.Add(CboTipo);
            Controls.Add(LblNomeI);
            Controls.Add(LblCodigoI);
            Controls.Add(TxtNomeU);
            Controls.Add(TxtCodigoU);
            Controls.Add(GrdItensI);
            Controls.Add(BtnFecharI);
            Controls.Add(BtnSalvarI);
            Name = "FrmUsuario";
            Text = "FrmUsuario";
            Load += FrmUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)GrdItensI).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label LblCodigoI;
        private TextBox TxtCodigoU;
        private DataGridView GrdItensI;
        private Button BtnFecharI;
        private Button BtnSalvarI;
        private ComboBox CboTipo;
        private Label label1;
        private Label LblNomeI;
        private TextBox TxtNomeU;
        private Label label2;
        private TextBox TxtEmail;
        private Label label3;
        private TextBox TxtSenha;
        private DataGridViewTextBoxColumn CodigoU;
        private DataGridViewTextBoxColumn NomeU;
        private DataGridViewTextBoxColumn Senha;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewButtonColumn BtnAlterarU;
        private DataGridViewButtonColumn BtnExcluirU;
    }
}