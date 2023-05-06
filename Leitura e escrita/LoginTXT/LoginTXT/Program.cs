using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace LoginTXT
{
    class Program
    {
        // recuperei o endereço do documento txt.
        static void Main(string[] args)
        {
            IO acesso = new IO();

            // converte Json em objetos C#
            String objetos = acesso.ler();
            List<Objeto> lista = JsonConvert.DeserializeObject<List<Objeto>>(objetos);

            //criando uma coleção
            foreach (Objeto f in lista) {
                Console.WriteLine("O nome do objeto é: " +f.nome);
                Console.WriteLine("A descrição do objeto é: " + f.descricao);
                Console.WriteLine("O valor de aquisição do objeto é: " + f.precoAquisicao);
                Console.WriteLine("O valor de aquisição do objeto é: " + f.dataAquisicao);
                Console.WriteLine("O valor de aquisição do objeto é: " + f.localizacao);
                Console.WriteLine("-------------");
            }

            
            //Converte objetos C# em JSON
            String JsonLista = JsonConvert.SerializeObject(lista);
            acesso.escrever(JsonLista);

            // obtendo a lista de funcionários
            List<Objeto> listaob = objetos.listaObjeto;


            //acesso.escrever(JsonLista);
            String Objeto = acesso.ler();

            




        }
     }
}
