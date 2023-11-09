using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Code made by Gabriel 11E

namespace Carrinho_de_Compras
{
    partial class Form1 : Form
    {
        Produto[] produtos = new Produto[10]; // Array para representar os produtos disponíveis
        string[] carrinho = new string[10]; // Array para representar os produtos selecionados
        int indiceCarrinho = 0;

        public Form1()
        {
            InitializeComponent();
            comboBoxCategoria.Items.Add("Hardware");
            comboBoxCategoria.Items.Add("Software");

            // Inicialize os produtos com seus preços
            produtos[0] = new Produto("Monitor 4K", 200.00m);
            produtos[1] = new Produto("Teclado Mecânico", 30.00m);
            produtos[2] = new Produto("Rato Gamer", 15.00m);
            produtos[3] = new Produto("Impressora Laser", 150.00m);
            produtos[4] = new Produto("Windows 10", 10.00m);
            produtos[5] = new Produto("Windows 11", 10.00m);
            produtos[6] = new Produto("Linux Ubuntu", 0.00m);
            produtos[7] = new Produto("Office 2022", 20.00m);
            produtos[8] = new Produto("Visual Studio", 0.00m);

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void comboBoxCategoria_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string categoriaSelecionada = comboBoxCategoria.SelectedItem.ToString();

            // Lógica para carregar os produtos da categoria selecionada
            listBoxProdutos.Items.Clear();

            foreach (Produto produto in produtos)
            {
                if (produto != null)
                {
                    if ((categoriaSelecionada == "Hardware" && (produto.Nome.Contains("Monitor") || produto.Nome.Contains("Teclado") || produto.Nome.Contains("Rato") || produto.Nome.Contains("Impressora"))) ||
                        (categoriaSelecionada == "Software" && (produto.Nome.Contains("Windows 10") || produto.Nome.Contains("Windows 11") || produto.Nome.Contains("Linux Ubuntu") || produto.Nome.Contains("Office 2022") || produto.Nome.Contains("Visual Studio"))))
                    {
                        listBoxProdutos.Items.Add($"{produto.Nome} (€{produto.Valor})");

                    }
                }
            }
        }

        private void btnAdicionarAoCarrinho_Click_1(object sender, EventArgs e)
        {
            if (listBoxProdutos.SelectedItem != null)
            {
                string produtoSelecionado = listBoxProdutos.SelectedItem.ToString();
                carrinho[indiceCarrinho] = produtoSelecionado;
                indiceCarrinho++;

                AtualizarListBoxCarrinho();
            }
            else
            {
                listBoxCarrinho.Text = "Nenhum produto selecionado";
            }
        }

        private void AtualizarListBoxCarrinho()
        {
            listBoxCarrinho.Items.Clear();

            foreach (string produto in carrinho)
            {
                if (produto != null)
                {
                    listBoxCarrinho.Items.Add(produto);
                }
            }
        }

        private void btnRemoverDoCarrinho_Click(object sender, EventArgs e)
        {
            if (listBoxCarrinho.SelectedItem != null)
            {
                carrinho[listBoxCarrinho.SelectedIndex] = null;
                AtualizarListBoxCarrinho();
            }
            else
            {
                listBoxCarrinho.Items.Clear();
            }

        }

        private void btnLimparCarrinho_Click(object sender, EventArgs e)
        {
            carrinho = new string[10]; // Cria um novo array vazio
            indiceCarrinho = 0; // Reseta o índice
            listBoxCarrinho.Items.Clear(); // Limpa a ListBox
        }

        private void btnCheckOut_Click_1(object sender, EventArgs e)
        {
            decimal total = CalcularTotal();

            // Exibe a caixa de diálogo com o total a pagar
            MessageBox.Show($"Total a pagar: €{total}", "Check Out");

            // Limpa o carrinho após o Check Out
            carrinho = new string[10];
            indiceCarrinho = 0;
            AtualizarListBoxCarrinho();
        }

        private decimal CalcularTotal()
        {
            decimal total = 0;

            foreach (string produto in carrinho)
            {
                if (produto != null)
                {
                    string nomeProduto = produto.Substring(0, produto.IndexOf('(') - 1);
                    Produto produtoEncontrado = produtos.FirstOrDefault(p => p.Nome == nomeProduto);

                    if (produtoEncontrado != null)
                    {
                        total += produtoEncontrado.Valor;
                    }
                }
            }

            return total;
        }
    }

    public class Produto
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }

        public Produto(string nome, decimal valor)
        {
            Nome = nome;
            Valor = valor;
        }
    }

}


