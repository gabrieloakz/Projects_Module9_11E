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
            this.btnAdicionarAoCarrinho = new System.Windows.Forms.Button();
            this.labelCarrinho = new System.Windows.Forms.Label();
            this.listBoxCarrinho = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemoverDoCarrinho = new System.Windows.Forms.Button();
            this.btnLimparCarrinho = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.SystemColors.Info;
            this.lblTitulo.Font = new System.Drawing.Font("Agency FB", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Red;
            this.lblTitulo.Location = new System.Drawing.Point(-1, 9);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(1066, 115);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "WORTEN DO BIEL";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Location = new System.Drawing.Point(198, 188);
            this.comboBoxCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(207, 33);
            this.comboBoxCategoria.TabIndex = 1;
            this.comboBoxCategoria.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategoria_SelectedIndexChanged_1);
            // 
            // listBoxProdutos
            // 
            this.listBoxProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxProdutos.FormattingEnabled = true;
            this.listBoxProdutos.ItemHeight = 20;
            this.listBoxProdutos.Location = new System.Drawing.Point(198, 233);
            this.listBoxProdutos.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxProdutos.Name = "listBoxProdutos";
            this.listBoxProdutos.Size = new System.Drawing.Size(207, 84);
            this.listBoxProdutos.TabIndex = 2;
            // 
            // btnAdicionarAoCarrinho
            // 
            this.btnAdicionarAoCarrinho.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdicionarAoCarrinho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAdicionarAoCarrinho.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarAoCarrinho.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAdicionarAoCarrinho.Location = new System.Drawing.Point(198, 326);
            this.btnAdicionarAoCarrinho.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdicionarAoCarrinho.Name = "btnAdicionarAoCarrinho";
            this.btnAdicionarAoCarrinho.Size = new System.Drawing.Size(207, 36);
            this.btnAdicionarAoCarrinho.TabIndex = 3;
            this.btnAdicionarAoCarrinho.Text = "Adicionar ao Carrinho";
            this.btnAdicionarAoCarrinho.UseVisualStyleBackColor = false;
            this.btnAdicionarAoCarrinho.Click += new System.EventHandler(this.btnAdicionarAoCarrinho_Click_1);
            // 
            // labelCarrinho
            // 
            this.labelCarrinho.AutoSize = true;
            this.labelCarrinho.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCarrinho.ForeColor = System.Drawing.SystemColors.MenuText;
            this.labelCarrinho.Location = new System.Drawing.Point(524, 154);
            this.labelCarrinho.Name = "labelCarrinho";
            this.labelCarrinho.Size = new System.Drawing.Size(170, 18);
            this.labelCarrinho.TabIndex = 4;
            this.labelCarrinho.Text = "Carrinho de Compras";
            // 
            // listBoxCarrinho
            // 
            this.listBoxCarrinho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCarrinho.FormattingEnabled = true;
            this.listBoxCarrinho.ItemHeight = 20;
            this.listBoxCarrinho.Location = new System.Drawing.Point(527, 188);
            this.listBoxCarrinho.Name = "listBoxCarrinho";
            this.listBoxCarrinho.Size = new System.Drawing.Size(227, 124);
            this.listBoxCarrinho.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(195, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "- Oque deseja comprar?";
            // 
            // btnRemoverDoCarrinho
            // 
            this.btnRemoverDoCarrinho.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRemoverDoCarrinho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRemoverDoCarrinho.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverDoCarrinho.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnRemoverDoCarrinho.Location = new System.Drawing.Point(527, 326);
            this.btnRemoverDoCarrinho.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoverDoCarrinho.Name = "btnRemoverDoCarrinho";
            this.btnRemoverDoCarrinho.Size = new System.Drawing.Size(227, 36);
            this.btnRemoverDoCarrinho.TabIndex = 7;
            this.btnRemoverDoCarrinho.Text = "Remover Produto ";
            this.btnRemoverDoCarrinho.UseVisualStyleBackColor = false;
            this.btnRemoverDoCarrinho.Click += new System.EventHandler(this.btnRemoverDoCarrinho_Click);
            // 
            // btnLimparCarrinho
            // 
            this.btnLimparCarrinho.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLimparCarrinho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLimparCarrinho.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparCarrinho.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnLimparCarrinho.Location = new System.Drawing.Point(527, 370);
            this.btnLimparCarrinho.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimparCarrinho.Name = "btnLimparCarrinho";
            this.btnLimparCarrinho.Size = new System.Drawing.Size(227, 36);
            this.btnLimparCarrinho.TabIndex = 8;
            this.btnLimparCarrinho.Text = "Limpar Carrinho";
            this.btnLimparCarrinho.UseVisualStyleBackColor = false;
            this.btnLimparCarrinho.Click += new System.EventHandler(this.btnLimparCarrinho_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCheckOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCheckOut.Location = new System.Drawing.Point(198, 370);
            this.btnCheckOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(207, 36);
            this.btnCheckOut.TabIndex = 9;
            this.btnCheckOut.Text = "Finalizar Compra";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1036, 513);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnLimparCarrinho);
            this.Controls.Add(this.btnRemoverDoCarrinho);
            this.Controls.Add(this.listBoxProdutos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxCarrinho);
            this.Controls.Add(this.labelCarrinho);
            this.Controls.Add(this.btnAdicionarAoCarrinho);
            this.Controls.Add(this.comboBoxCategoria);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
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
        private System.Windows.Forms.Button btnAdicionarAoCarrinho;
        private System.Windows.Forms.Label labelCarrinho;
        private System.Windows.Forms.ListBox listBoxCarrinho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRemoverDoCarrinho;
        private System.Windows.Forms.Button btnLimparCarrinho;
        private System.Windows.Forms.Button btnCheckOut;
    }
}

