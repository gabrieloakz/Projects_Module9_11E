﻿namespace Calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxNumero1 = new System.Windows.Forms.TextBox();
            this.textBoxNumero2 = new System.Windows.Forms.TextBox();
            this.buttonSoma = new System.Windows.Forms.Button();
            this.buttonDivisao = new System.Windows.Forms.Button();
            this.buttonMultiplicacao = new System.Windows.Forms.Button();
            this.buttonSubtracao = new System.Windows.Forms.Button();
            this.textBoxResultado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNumero1
            // 
            this.textBoxNumero1.Location = new System.Drawing.Point(239, 111);
            this.textBoxNumero1.Multiline = true;
            this.textBoxNumero1.Name = "textBoxNumero1";
            this.textBoxNumero1.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumero1.TabIndex = 0;
            // 
            // textBoxNumero2
            // 
            this.textBoxNumero2.Location = new System.Drawing.Point(240, 161);
            this.textBoxNumero2.Multiline = true;
            this.textBoxNumero2.Name = "textBoxNumero2";
            this.textBoxNumero2.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumero2.TabIndex = 1;
            // 
            // buttonSoma
            // 
            this.buttonSoma.Location = new System.Drawing.Point(249, 214);
            this.buttonSoma.Name = "buttonSoma";
            this.buttonSoma.Size = new System.Drawing.Size(75, 23);
            this.buttonSoma.TabIndex = 2;
            this.buttonSoma.Text = "+";
            this.buttonSoma.UseVisualStyleBackColor = true;
            this.buttonSoma.Click += new System.EventHandler(this.buttonSoma_Click);
            // 
            // buttonDivisao
            // 
            this.buttonDivisao.Location = new System.Drawing.Point(330, 243);
            this.buttonDivisao.Name = "buttonDivisao";
            this.buttonDivisao.Size = new System.Drawing.Size(75, 23);
            this.buttonDivisao.TabIndex = 3;
            this.buttonDivisao.Text = "/";
            this.buttonDivisao.UseVisualStyleBackColor = true;
            this.buttonDivisao.Click += new System.EventHandler(this.buttonDivisao_Click);
            // 
            // buttonMultiplicacao
            // 
            this.buttonMultiplicacao.Location = new System.Drawing.Point(249, 243);
            this.buttonMultiplicacao.Name = "buttonMultiplicacao";
            this.buttonMultiplicacao.Size = new System.Drawing.Size(75, 23);
            this.buttonMultiplicacao.TabIndex = 4;
            this.buttonMultiplicacao.Text = "x";
            this.buttonMultiplicacao.UseVisualStyleBackColor = true;
            this.buttonMultiplicacao.Click += new System.EventHandler(this.buttonMultiplicacao_Click);
            // 
            // buttonSubtracao
            // 
            this.buttonSubtracao.Location = new System.Drawing.Point(330, 214);
            this.buttonSubtracao.Name = "buttonSubtracao";
            this.buttonSubtracao.Size = new System.Drawing.Size(75, 23);
            this.buttonSubtracao.TabIndex = 5;
            this.buttonSubtracao.Text = "-";
            this.buttonSubtracao.UseVisualStyleBackColor = true;
            this.buttonSubtracao.Click += new System.EventHandler(this.buttonSubtracao_Click);
            // 
            // textBoxResultado
            // 
            this.textBoxResultado.Location = new System.Drawing.Point(177, 306);
            this.textBoxResultado.Multiline = true;
            this.textBoxResultado.Name = "textBoxResultado";
            this.textBoxResultado.Size = new System.Drawing.Size(100, 20);
            this.textBoxResultado.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 43);
            this.label1.TabIndex = 8;
            this.label1.Text = "Calculadora do Gabriel";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "1) Insira o 1º Número:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "2) Insira o 2º Número:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "3) Escolha a operação:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(67, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "4) Resultado:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(283, 304);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(105, 23);
            this.buttonLimpar.TabIndex = 13;
            this.buttonLimpar.Text = "Limpar e Reiniciar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Calculadora.Properties.Resources.istockphoto_1307856898_612x612;
            this.pictureBox1.Location = new System.Drawing.Point(437, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(351, 216);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxResultado);
            this.Controls.Add(this.buttonSubtracao);
            this.Controls.Add(this.buttonMultiplicacao);
            this.Controls.Add(this.buttonDivisao);
            this.Controls.Add(this.buttonSoma);
            this.Controls.Add(this.textBoxNumero2);
            this.Controls.Add(this.textBoxNumero1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNumero1;
        private System.Windows.Forms.TextBox textBoxNumero2;
        private System.Windows.Forms.Button buttonSoma;
        private System.Windows.Forms.Button buttonDivisao;
        private System.Windows.Forms.Button buttonMultiplicacao;
        private System.Windows.Forms.Button buttonSubtracao;
        private System.Windows.Forms.TextBox textBoxResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

