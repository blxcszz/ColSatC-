using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginTXT
{
    class Objeto
    {
        public static List<Objeto> listaObjetos = new List<Objeto>();
        public String nome;
        public String descricao;
        public int precoAquisicao;
        public String dataAquisicao;
        public String localizacao;
        public String senha;

        // impõe uma regra para construção de objetos a partir da classe
        public Objeto(String nome, String descricao, int precoAquisicao, String dataAquisicao, String localizacao, String senha) {
            this.nome = nome;
            this.descricao = descricao;
            this.precoAquisicao = precoAquisicao;
            this.dataAquisicao = dataAquisicao;
            this.localizacao = localizacao;
            this.senha = senha;
            
            listaObjetos.Add(this);
        }
    }
}
