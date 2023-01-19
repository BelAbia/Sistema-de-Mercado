namespace Sistema_de_Mercado
{
    partial class JanelaDeLista
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
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoBarrasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataVencimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Produto)).BeginInit();
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
            this.bt_Deletar.Click += new System.EventHandler(this.bt_Deletar_Click);
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
            this.bt_Novo.Click += new System.EventHandler(this.AoClicarBotaoNovo);
            // 
            // bt_Cancelar1
            // 
            this.bt_Cancelar1.Location = new System.Drawing.Point(131, 478);
            this.bt_Cancelar1.Name = "bt_Cancelar1";
            this.bt_Cancelar1.Size = new System.Drawing.Size(113, 38);
            this.bt_Cancelar1.TabIndex = 4;
            this.bt_Cancelar1.Text = "Cancelar";
            this.bt_Cancelar1.UseVisualStyleBackColor = true;
            this.bt_Cancelar1.Click += new System.EventHandler(this.AoClicarBotaoCancelar);
            // 
            // bt_OK
            // 
            this.bt_OK.Location = new System.Drawing.Point(12, 478);
            this.bt_OK.Name = "bt_OK";
            this.bt_OK.Size = new System.Drawing.Size(113, 38);
            this.bt_OK.TabIndex = 5;
            this.bt_OK.Text = "OK";
            this.bt_OK.UseVisualStyleBackColor = true;
            this.bt_OK.Click += new System.EventHandler(this.AoClicarBotaoOk);
            // 
            // dgv_Produto
            // 
            this.dgv_Produto.AllowUserToOrderColumns = true;
            this.dgv_Produto.AutoGenerateColumns = false;
            this.dgv_Produto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Produto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.codigoBarrasDataGridViewTextBoxColumn,
            this.dataVencimentoDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1});
            this.dgv_Produto.DataSource = this.produtoBindingSource;
            this.dgv_Produto.Location = new System.Drawing.Point(1, 2);
            this.dgv_Produto.Name = "dgv_Produto";
            this.dgv_Produto.RowHeadersWidth = 51;
            this.dgv_Produto.RowTemplate.Height = 29;
            this.dgv_Produto.Size = new System.Drawing.Size(803, 470);
            this.dgv_Produto.TabIndex = 6;
            this.dgv_Produto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Produto_CellClick);
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DataCadastro";
            this.dataGridViewTextBoxColumn1.HeaderText = "Data de Cadastro";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataSource = typeof(Sistema_de_Mercado.Produto);
            // 
            // JanelaDeLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(805, 528);
            this.Controls.Add(this.dgv_Produto);
            this.Controls.Add(this.bt_OK);
            this.Controls.Add(this.bt_Cancelar1);
            this.Controls.Add(this.bt_Novo);
            this.Controls.Add(this.bt_Atualizar);
            this.Controls.Add(this.bt_Deletar);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "JanelaDeLista";
            this.Text = "Tela Inicial";
            this.Load += new System.EventHandler(this.JanelaDeLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Produto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button bt_Deletar;
        private Button bt_Atualizar;
        private Button bt_Novo;
        private Button bt_Cancelar1;
        private Button bt_OK;
        public DataGridView dgv_Produto;
        private DataGridViewTextBoxColumn dataCadastroDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codigoBarrasDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataVencimentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private BindingSource produtoBindingSource;
    }
}