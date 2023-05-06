using System;
using Loguin2;


namespace login2
{
    class Program
    {
        static void Main(string[] args)
        {

            tela tela = new tela();
            Acesso login = new Acesso();
            Acesso login2 = new Acesso();
            Produto produto = new Produto();
            Dados_produtos dados = new Dados_produtos();
            int contador = 0;



            string lg = "";
            string sh = "";
            bool control;

            tela.apresentarCabecalho();



            Console.Write("informe o seu login: ");
            lg = Console.ReadLine();

            Console.Write("informe a sua senha: ");
            sh = Console.ReadLine();

            tela.rodaPe();
            tela.continuar();

            Console.Clear();

     


            produto = dados.criar_produto("Bana", "produto radiotivo", 6.00, 50, 1);

            control = login2.entrar(lg, sh);

            if (control == true)
            {
                
               while (contador != 5)
                {
                    tela.apresentarCabecalho();
                    contador = tela.apresentar_menu();
                    Console.WriteLine("Você digitou " + contador);
                    tela.rodaPe();
                    tela.continuar();
                    Console.Clear();
                    tela.apresentar_escolha(produto, contador);
                }

            }
            else
            {
                tela.apresentarCabecalho();
                Console.WriteLine("acesso negado");
                tela.rodaPe();
                tela.continuar();
            }

            tela.rodaPe();
            tela.continuar();



        }


    }
}

