namespace AulaAEDB01.Windows
{
    partial class FrmIdioma
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
            LblNomeI = new Label();
            LblCodigoI = new Label();
            TxtNomeI = new TextBox();
            TxtCodigoI = new TextBox();
            GrdItensI = new DataGridView();
            CodigoI = new DataGridViewTextBoxColumn();
            NomeI = new DataGridViewTextBoxColumn();
            BtnAlterarI = new DataGridViewButtonColumn();
            BtnExcluirI = new DataGridViewButtonColumn();
            BtnFecharI = new Button();
            BtnSalvarI = new Button();
            ((System.ComponentModel.ISupportInitialize)GrdItensI).BeginInit();
            SuspendLayout();
            // 
            // LblNomeI
            // 
            LblNomeI.AutoSize = true;
            LblNomeI.Location = new Point(177, 23);
            LblNomeI.Name = "LblNomeI";
            LblNomeI.Size = new Size(50, 20);
            LblNomeI.TabIndex = 20;
            LblNomeI.Text = "Nome";
            // 
            // LblCodigoI
            // 
            LblCodigoI.AutoSize = true;
            LblCodigoI.Location = new Point(36, 23);
            LblCodigoI.Name = "LblCodigoI";
            LblCodigoI.Size = new Size(58, 20);
            LblCodigoI.TabIndex = 19;
            LblCodigoI.Text = "Código";
            // 
            // TxtNomeI
            // 
            TxtNomeI.Location = new Point(177, 59);
            TxtNomeI.MaxLength = 100;
            TxtNomeI.Name = "TxtNomeI";
            TxtNomeI.Size = new Size(566, 27);
            TxtNomeI.TabIndex = 18;
            // 
            // TxtCodigoI
            // 
            TxtCodigoI.Enabled = false;
            TxtCodigoI.Location = new Point(36, 59);
            TxtCodigoI.MaxLength = 4;
            TxtCodigoI.Name = "TxtCodigoI";
            TxtCodigoI.Size = new Size(125, 27);
            TxtCodigoI.TabIndex = 17;
            // 
            // GrdItensI
            // 
            GrdItensI.AllowUserToAddRows = false;
            GrdItensI.AllowUserToDeleteRows = false;
            GrdItensI.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GrdItensI.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrdItensI.Columns.AddRange(new DataGridViewColumn[] { CodigoI, NomeI, BtnAlterarI, BtnExcluirI });
            GrdItensI.Location = new Point(3, 161);
            GrdItensI.Name = "GrdItensI";
            GrdItensI.RowHeadersWidth = 51;
            GrdItensI.Size = new Size(794, 266);
            GrdItensI.TabIndex = 16;
            GrdItensI.CellContentClick += GrdItensI_CellClick;
            // 
            // CodigoI
            // 
            CodigoI.DataPropertyName = "CodigoI";
            CodigoI.HeaderText = "Codigo";
            CodigoI.MinimumWidth = 6;
            CodigoI.Name = "CodigoI";
            CodigoI.Width = 125;
            // 
            // NomeI
            // 
            NomeI.DataPropertyName = "NomeI";
            NomeI.HeaderText = "Nome";
            NomeI.MinimumWidth = 6;
            NomeI.Name = "NomeI";
            NomeI.Width = 125;
            // 
            // BtnAlterarI
            // 
            BtnAlterarI.DataPropertyName = "BtnAlterarI";
            BtnAlterarI.HeaderText = "Alterar";
            BtnAlterarI.MinimumWidth = 6;
            BtnAlterarI.Name = "BtnAlterarI";
            BtnAlterarI.Width = 125;
            // 
            // BtnExcluirI
            // 
            BtnExcluirI.DataPropertyName = "BtnExcluirI";
            BtnExcluirI.HeaderText = "Excluir";
            BtnExcluirI.MinimumWidth = 6;
            BtnExcluirI.Name = "BtnExcluirI";
            BtnExcluirI.Width = 125;
            // 
            // BtnFecharI
            // 
            BtnFecharI.Location = new Point(227, 110);
            BtnFecharI.Name = "BtnFecharI";
            BtnFecharI.Size = new Size(156, 34);
            BtnFecharI.TabIndex = 15;
            BtnFecharI.Text = "&Fechar";
            BtnFecharI.UseVisualStyleBackColor = true;
            BtnFecharI.Click += BtnFecharI_Click;
            // 
            // BtnSalvarI
            // 
            BtnSalvarI.Location = new Point(36, 110);
            BtnSalvarI.Name = "BtnSalvarI";
            BtnSalvarI.Size = new Size(156, 34);
            BtnSalvarI.TabIndex = 14;
            BtnSalvarI.Text = "&Salvar";
            BtnSalvarI.UseVisualStyleBackColor = true;
            BtnSalvarI.Click += BtnSalvarI_Click;
            // 
            // FrmIdioma
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblNomeI);
            Controls.Add(LblCodigoI);
            Controls.Add(TxtNomeI);
            Controls.Add(TxtCodigoI);
            Controls.Add(GrdItensI);
            Controls.Add(BtnFecharI);
            Controls.Add(BtnSalvarI);
            Name = "FrmIdioma";
            Text = "FrmIdioma";
            Activated += FrmIdioma_Activated;
            FormClosed += FrmIdioma_FormClosed;
            Load += FrmIdioma_Load;
            ((System.ComponentModel.ISupportInitialize)GrdItensI).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblNomeI;
        private Label LblCodigoI;
        private TextBox TxtNomeI;
        private TextBox TxtCodigoI;
        private DataGridView GrdItensI;
        private Button BtnFecharI;
        private Button BtnSalvarI;
        private DataGridViewTextBoxColumn CodigoI;
        private DataGridViewTextBoxColumn NomeI;
        private DataGridViewButtonColumn BtnAlterarI;
        private DataGridViewButtonColumn BtnExcluirI;
    }
}