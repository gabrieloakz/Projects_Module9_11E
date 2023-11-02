using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carrinho_de_Compras
{
    public partial class Form1 : Form
    {
        // Array para representar os produtos selecionados
        string[] carrinho = new string[10];
        int indiceCarrinho = 0;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void comboBoxCategoria_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string categoriaSelecionada = comboBoxCategoria.SelectedItem.ToString();


            // Lógica para carregar os produtos da categoria selecionada
            if (categoriaSelecionada == "Hardware")
            {
                // Carrega os produtos de hardware
                listBoxProdutos.Items.Clear();
                listBoxProdutos.Items.Add("- Monitor");
                listBoxProdutos.Items.Add("- Teclado");
                listBoxProdutos.Items.Add("- Rato");
                listBoxProdutos.Items.Add("- Impressora");
            }
            else if (categoriaSelecionada == "Software")
            {
                // Carrega os produtos de software
                listBoxProdutos.Items.Clear();
                listBoxProdutos.Items.Add("- Windows 10");
                listBoxProdutos.Items.Add("- Windows 11");
                listBoxProdutos.Items.Add("- Linux Ubuntu");
                listBoxProdutos.Items.Add("- Office 2022");
                listBoxProdutos.Items.Add("- Visual Studio");
            }
        }

        private void btnAdicionarAoCarrinho_Click_1(object sender, EventArgs e)
        {
            if (listBoxProdutos.SelectedItem != null)
            {
                string produtoSelecionado = listBoxProdutos.SelectedItem.ToString();
                carrinho[indiceCarrinho] = produtoSelecionado;
                indiceCarrinho++;

                AtualizarListBoxProdutosSelecionados();
            }
            else
            {
                listBoxProdutosSelecionados.Text = "Nenhum produto selecionado";
            }
        }

        private void AtualizarListBoxProdutosSelecionados()
        {
            listBoxProdutosSelecionados.Items.Clear();

            foreach (string produto in carrinho)
            {
                if (produto != null)
                {
                    listBoxProdutosSelecionados.Items.Add(produto);
                }
            }
        }

    }
}


