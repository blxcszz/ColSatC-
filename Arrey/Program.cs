using System;
using System.Collections.Generic;

namespace Array_Objeto
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Objeto> objeto = new List<Objeto>();
            DAOobjeto dao = new DAOobjeto();
           

            bool key = false;
            int cb;
            String opc;
            int cont = 0;
            int repeticao = 5;

            objeto = dao.listarObjetos(objeto);
           

            Console.WriteLine("Você quer ver todas as informações ou apenas uma?");
            opc = Console.ReadLine();
            if (opc == "todas")
            {
               

            }
            if (opc == "apenas uma")
            {
                Console.Write("Informe o código do bagulho marreco: ");
                cb = Convert.ToInt32(Console.ReadLine());


                while (cont < objeto.Count)
                {
                    if (cb == objeto[cont].codigo)
                    {
                        key = true;
                        break;
                    }


                    cont++;
                }

                Console.Clear();

                if (key)
                {
                    Console.WriteLine("ACESSO PERMITIDO");
                    Console.WriteLine("");
                    Console.WriteLine("===========================");

                    Console.WriteLine("O nome do bagulho é: " + objeto[cont].nome);
                    Console.WriteLine("A descrição do bagulho é: " + objeto[cont].descricao);
                    Console.WriteLine("O código do bagulho é: " + objeto[cont].codigo);
                    Console.WriteLine("O valor de aquisição do bagulho é: " + objeto[cont].valaqui);

                    Console.WriteLine("===========================");
                }
                else
                {
                    Console.WriteLine("Acesso Negado");
                }
            }
            else
            {
                Console.WriteLine("Escreve direito vagabundo");
            }

            




        }
    }
}
