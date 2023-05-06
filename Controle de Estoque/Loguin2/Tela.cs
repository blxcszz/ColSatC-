using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Loguin2;

namespace login2
{
    class tela
    {

        
        public void apresentarCabecalho()
        {
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("------------- > Sistema de Controle de Estoque < ---------------");
            Console.WriteLine("----------------------------------------------------------------");
        }

        public void rodaPe()
        {
            Console.WriteLine("---------------------- > Fim da Pagina < -----------------------");
        }

        public void continuar()
        {
            Console.WriteLine("aperte enter para continuar");
            Console.ReadLine();
        }

        public int apresentar_menu()
        {

            Console.WriteLine("Escolha uma das opções a seguir");
            Console.WriteLine("(1) - Apresentar dados do produto");
            Console.WriteLine("(2) - Aumentar estoque do produto");
            Console.WriteLine("(3) - Diminuir estoque do produto");
            Console.WriteLine("(4) - Editar produto");
            Console.WriteLine("(5) - Fechar programa");
            Console.Write("Digite a opção desejada: ");
            int opc = Convert.ToInt32(Console.ReadLine());
            return opc;
        }

        public void apresentar_escolha(Produto produto, int opcao)
        {
            apresentarCabecalho();
            switch (opcao)
            {
                case 1:
                    produto.printar_dados();
                    break;
                case 2:
                    Console.Write("informe a quantidade que será adicionada: ");
                    int qtdalme = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Quantidade adicionada : " + qtdalme);
                    Console.WriteLine("Antes : " + produto.quantidade_produto);
                    produto.aumentar_produto(qtdalme);
                    produto.printar_dados();
                    break;
                case 3:
                    Console.Write("informe a quantidade que será retirada: ");
                    int qtddin = Convert.ToInt32(Console.ReadLine());
                    produto.diminuir_produto(qtddin);
                    break;
                case 4:
                    produto.printar_dados();
                    break;
                default:
                    break;

            }

            rodaPe();
            continuar();
            Console.Clear();
        }
    }
}
