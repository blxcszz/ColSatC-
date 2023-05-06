using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaPrimeiraAPI1.Controllers
{
    public class jogadores
    {
        public static List<jogadores> listaJogadores = new List<jogadores>();
        public String nome_Jogador;

        public jogadores(String nome_Jogador)
        {
            this.nome_Jogador = nome_Jogador;
            listaJogadores.Add(this);

        }
    }
}
