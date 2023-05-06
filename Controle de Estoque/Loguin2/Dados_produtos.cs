using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Loguin2;

namespace Loguin2
{
    class Dados_produtos
    {

       public Produto criar_produto(string nome, string descricao, double preco, int quantidade, int numero_produto)
        {
            Produto produto = new Produto();
            produto.nome = nome;
            produto.descricão_produto = descricao;
            produto.preco_produto = preco;
            produto.quantidade_produto = quantidade;
            produto.num_produto = numero_produto;
            return produto;
        }

        public void printar_dados_produto(Produto produto)
        {
            Console.WriteLine("Nome do Produto: " + produto.nome);
            Console.WriteLine("Descrição do protudo: " + produto.descricão_produto);
            Console.WriteLine("Valor do produto: " + produto.preco_produto);
            Console.WriteLine("Estoque do produto: " + produto.quantidade_produto);
            Console.WriteLine("Numero do produto: " + produto.num_produto);
        }
    }
}
