using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loguin2
{
    class Produto
    {
        public string nome;
        public int num_produto;
        public double preco_produto;
        public string descricão_produto;
        public int quantidade_produto;


        //Função 

        public void atualizar_preco(double preco)
        {
            this.preco_produto = preco;
        }


        public int aumentar_produto( int qtd)
        {
           this.quantidade_produto = this.quantidade_produto + qtd;
            return this.quantidade_produto;
        }

        public bool diminuir_produto( int qtd)
        { 
            if (this.quantidade_produto >= qtd)
            {
                this.quantidade_produto = this.quantidade_produto - qtd;
                return true;
            }
            else
            {
                return false;
            }            
        }

        public void printar_dados()
        {
            Console.WriteLine("Numero: " + this.num_produto);
            Console.WriteLine("Nome " + this.nome);
            Console.WriteLine("Preço " + this.preco_produto);
            Console.WriteLine("Descrição " + this.descricão_produto);
            Console.WriteLine("QUantidade em Estoque " + this.quantidade_produto);

        }
    }
}
