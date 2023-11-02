namespace Carrinho_de_Compras
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.listBoxProdutos = new System.Windows.Forms.ListBox();
            this.btnExibirProdutos = new System.Windows.Forms.Button();
            this.labelCarrinho = new System.Windows.Forms.Label();
            this.listBoxProdutosSelecionados = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.SystemColors.Info;
            this.lblTitulo.Font = new System.Drawing.Font("Agency FB", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Red;
            this.lblTitulo.Location = new System.Drawing.Point(45, 23);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(274, 59);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "WORTEN DO BIEL";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Items.AddRange(new object[] {
            "Hardware",
            "Software"});
            this.comboBoxCategoria.Location = new System.Drawing.Point(56, 133);
            this.comboBoxCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(160, 26);
            this.comboBoxCategoria.TabIndex = 1;
            this.comboBoxCategoria.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategoria_SelectedIndexChanged_1);
            // 
            // listBoxProdutos
            // 
            this.listBoxProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxProdutos.FormattingEnabled = true;
            this.listBoxProdutos.ItemHeight = 18;
            this.listBoxProdutos.Location = new System.Drawing.Point(55, 178);
            this.listBoxProdutos.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxProdutos.Name = "listBoxProdutos";
            this.listBoxProdutos.Size = new System.Drawing.Size(160, 112);
            this.listBoxProdutos.TabIndex = 2;
            // 
            // btnExibirProdutos
            // 
            this.btnExibirProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibirProdutos.Location = new System.Drawing.Point(55, 298);
            this.btnExibirProdutos.Margin = new System.Windows.Forms.Padding(4);
            this.btnExibirProdutos.Name = "btnExibirProdutos";
            this.btnExibirProdutos.Size = new System.Drawing.Size(161, 28);
            this.btnExibirProdutos.TabIndex = 3;
            this.btnExibirProdutos.Text = "ExibirProdutos";
            this.btnExibirProdutos.UseVisualStyleBackColor = true;
            this.btnExibirProdutos.Click += new System.EventHandler(this.btnExibirProdutos_Click);
            // 
            // labelCarrinho
            // 
            this.labelCarrinho.AutoSize = true;
            this.labelCarrinho.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCarrinho.Location = new System.Drawing.Point(53, 347);
            this.labelCarrinho.Name = "labelCarrinho";
            this.labelCarrinho.Size = new System.Drawing.Size(170, 18);
            this.labelCarrinho.TabIndex = 4;
            this.labelCarrinho.Text = "Carrinho de Compras";
            // 
            // listBoxProdutosSelecionados
            // 
            this.listBoxProdutosSelecionados.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxProdutosSelecionados.FormattingEnabled = true;
            this.listBoxProdutosSelecionados.ItemHeight = 18;
            this.listBoxProdutosSelecionados.Location = new System.Drawing.Point(55, 380);
            this.listBoxProdutosSelecionados.Name = "listBoxProdutosSelecionados";
            this.listBoxProdutosSelecionados.Size = new System.Drawing.Size(160, 94);
            this.listBoxProdutosSelecionados.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "- Oque deseja comprar?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxProdutosSelecionados);
            this.Controls.Add(this.labelCarrinho);
            this.Controls.Add(this.btnExibirProdutos);
            this.Controls.Add(this.listBoxProdutos);
            this.Controls.Add(this.comboBoxCategoria);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.ListBox listBoxProdutos;
        private System.Windows.Forms.Button btnExibirProdutos;
        private System.Windows.Forms.Label labelCarrinho;
        private System.Windows.Forms.ListBox listBoxProdutosSelecionados;
        private System.Windows.Forms.Label label1;
    }
}

