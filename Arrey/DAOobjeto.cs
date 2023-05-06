using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Objeto
{
    class DAOobjeto
    {
        public List<Objeto> listarObjetos(List<Objeto> lista)
        {
            List<Objeto> listaObjeto = new List<Objeto>();
            Objeto pilha = new Objeto("pilha", 21, "bagulho que guarda energia viado", 1);
            Objeto bola = new Objeto("bola", 31, "bagulho que quica", 2);
            Objeto pairulito = new Objeto("pairulito", 41, "bagulho apenas um show ", 3);
            Objeto teclado = new Objeto("teclado", 51, "bagulho que digita", 4);

            lista.Add(pilha);
            lista.Add(bola);
            lista.Add(pairulito);
            lista.Add(teclado);


            return lista;
        }
    }
}
