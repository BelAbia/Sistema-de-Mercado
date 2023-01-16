namespace Sistema_de_Mercado
{
    partial class Janela1
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
            this.components = new System.ComponentModel.Container();
            this.bt_Deletar = new System.Windows.Forms.Button();
            this.bt_Atualizar = new System.Windows.Forms.Button();
            this.bt_Novo = new System.Windows.Forms.Button();
            this.bt_Cancelar1 = new System.Windows.Forms.Button();
            this.bt_OK = new System.Windows.Forms.Button();
            this.dgv_Produto = new System.Windows.Forms.DataGridView();
            this.produtoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoBarrasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataVencimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCadastroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Produto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_Deletar
            // 
            this.bt_Deletar.Location = new System.Drawing.Point(665, 478);
            this.bt_Deletar.Name = "bt_Deletar";
            this.bt_Deletar.Size = new System.Drawing.Size(113, 38);
            this.bt_Deletar.TabIndex = 0;
            this.bt_Deletar.Text = "Deletar";
            this.bt_Deletar.UseVisualStyleBackColor = true;
            // 
            // bt_Atualizar
            // 
            this.bt_Atualizar.Location = new System.Drawing.Point(546, 478);
            this.bt_Atualizar.Name = "bt_Atualizar";
            this.bt_Atualizar.Size = new System.Drawing.Size(113, 38);
            this.bt_Atualizar.TabIndex = 2;
            this.bt_Atualizar.Text = "Atualizar";
            this.bt_Atualizar.UseVisualStyleBackColor = true;
            // 
            // bt_Novo
            // 
            this.bt_Novo.Location = new System.Drawing.Point(427, 478);
            this.bt_Novo.Name = "bt_Novo";
            this.bt_Novo.Size = new System.Drawing.Size(113, 38);
            this.bt_Novo.TabIndex = 3;
            this.bt_Novo.Text = "Novo";
            this.bt_Novo.UseVisualStyleBackColor = true;
            this.bt_Novo.Click += new System.EventHandler(this.bt_Cadastrar_Click);
            // 
            // bt_Cancelar1
            // 
            this.bt_Cancelar1.Location = new System.Drawing.Point(131, 478);
            this.bt_Cancelar1.Name = "bt_Cancelar1";
            this.bt_Cancelar1.Size = new System.Drawing.Size(113, 38);
            this.bt_Cancelar1.TabIndex = 4;
            this.bt_Cancelar1.Text = "Cancelar";
            this.bt_Cancelar1.UseVisualStyleBackColor = true;
            this.bt_Cancelar1.Click += new System.EventHandler(this.bt_Cancelar1_Click);
            // 
            // bt_OK
            // 
            this.bt_OK.Location = new System.Drawing.Point(12, 478);
            this.bt_OK.Name = "bt_OK";
            this.bt_OK.Size = new System.Drawing.Size(113, 38);
            this.bt_OK.TabIndex = 5;
            this.bt_OK.Text = "OK";
            this.bt_OK.UseVisualStyleBackColor = true;
            // 
            // dgv_Produto
            // 
            this.dgv_Produto.AutoGenerateColumns = false;
            this.dgv_Produto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Produto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.codigoBarrasDataGridViewTextBoxColumn,
            this.dataVencimentoDataGridViewTextBoxColumn,
            this.dataCadastroDataGridViewTextBoxColumn});
            this.dgv_Produto.DataSource = this.produtoBindingSource1;
            this.dgv_Produto.Location = new System.Drawing.Point(1, 2);
            this.dgv_Produto.Name = "dgv_Produto";
            this.dgv_Produto.RowHeadersWidth = 51;
            this.dgv_Produto.RowTemplate.Height = 29;
            this.dgv_Produto.Size = new System.Drawing.Size(803, 470);
            this.dgv_Produto.TabIndex = 6;
            this.dgv_Produto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Produto_CellContentClick);
            // 
            // produtoBindingSource1
            // 
            this.produtoBindingSource1.DataSource = typeof(Produto);
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataSource = typeof(Produto);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.Width = 125;
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "Marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.marcaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            this.marcaDataGridViewTextBoxColumn.Width = 125;
            // 
            // codigoBarrasDataGridViewTextBoxColumn
            // 
            this.codigoBarrasDataGridViewTextBoxColumn.DataPropertyName = "CodigoBarras";
            this.codigoBarrasDataGridViewTextBoxColumn.HeaderText = "Codigo de Barras";
            this.codigoBarrasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codigoBarrasDataGridViewTextBoxColumn.Name = "codigoBarrasDataGridViewTextBoxColumn";
            this.codigoBarrasDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataVencimentoDataGridViewTextBoxColumn
            // 
            this.dataVencimentoDataGridViewTextBoxColumn.DataPropertyName = "DataVencimento";
            this.dataVencimentoDataGridViewTextBoxColumn.HeaderText = "Data de Vencimento";
            this.dataVencimentoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataVencimentoDataGridViewTextBoxColumn.Name = "dataVencimentoDataGridViewTextBoxColumn";
            this.dataVencimentoDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataCadastroDataGridViewTextBoxColumn
            // 
            this.dataCadastroDataGridViewTextBoxColumn.DataPropertyName = "DataCadastro";
            this.dataCadastroDataGridViewTextBoxColumn.HeaderText = "Data de Cadastro";
            this.dataCadastroDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataCadastroDataGridViewTextBoxColumn.Name = "dataCadastroDataGridViewTextBoxColumn";
            this.dataCadastroDataGridViewTextBoxColumn.Width = 125;
            // 
            // Janela1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(804, 528);
            this.Controls.Add(this.dgv_Produto);
            this.Controls.Add(this.bt_OK);
            this.Controls.Add(this.bt_Cancelar1);
            this.Controls.Add(this.bt_Novo);
            this.Controls.Add(this.bt_Atualizar);
            this.Controls.Add(this.bt_Deletar);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Janela1";
            this.Text = "Tela Inicial";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Produto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button bt_Deletar;
        private Button bt_Atualizar;
        private Button bt_Novo;
        private Button bt_Cancelar1;
        private Button bt_OK;
        private BindingSource produtoBindingSource;
        public DataGridView dgv_Produto;
        private BindingSource produtoBindingSource1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codigoBarrasDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataVencimentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataCadastroDataGridViewTextBoxColumn;
    }
}