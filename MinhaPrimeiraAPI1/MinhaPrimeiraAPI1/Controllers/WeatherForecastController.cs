using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MinhaPrimeiraAPI1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Principal : ControllerBase
    {
        [HttpGet]   // devolver alguma informação a requisição
        [Route("/selecao")]
        public String selecao()
        {

            selecoes listaSel = new selecoes();
            List<selecoes> selecoes = listaSel.listarSelecoes(listaSel.listarJogadores(), listaSel.listarBandeiras());

            String jsonLista = JsonConvert.SerializeObject(selecoes, Formatting.Indented);

            return jsonLista;


        }

        [HttpGet]   // devolver alguma informação a requisição
        [Route("/Grupos/{grupos}")]
        public String grupos(string grupos)
        {
            List<selecoes> ListaGrupo = new List<selecoes>();
            selecoes slc = new selecoes();
            List<selecoes> todasSelecoes = slc.listarSelecoes(slc.listarJogadores(), slc.listarBandeiras());

            foreach (selecoes selecao in todasSelecoes)
            {
                if( selecao.grupo == grupos)
                {
                    ListaGrupo.Add(selecao);
                }
            }
            String jsonLista2 = JsonConvert.SerializeObject(ListaGrupo, Formatting.Indented);
           

            return jsonLista2;
        }

        [HttpGet]   // devolver alguma informação a requisição
        [Route("/Continente/{continentes}")]

        public String continente(string continentes)
        {
            List<selecoes> ListaContinente = new List<selecoes>();
            selecoes slc = new selecoes();
            List<selecoes> todasSelecoes = slc.listarSelecoes(slc.listarJogadores(), slc.listarBandeiras());

            foreach (selecoes selecao in todasSelecoes)
            {
                if (selecao.continente == continentes)
                {
                    ListaContinente.Add(selecao);
                }
            }
            String jsonLista3 = JsonConvert.SerializeObject(ListaContinente, Formatting.Indented);


            return jsonLista3;
        }

    }


}

/*
       [HttpGet]   // devolver alguma informação a requisição
       [Route("/nome")]

       public String nome()
       {
           return "Gabriel";
       }

       [HttpGet]   // devolver alguma informação a requisição
       [Route("/sobreNome")]

       public String sobreNome()
       {
           return "Freitas";
       }
       */
