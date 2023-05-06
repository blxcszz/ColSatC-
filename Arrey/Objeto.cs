using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Objeto
{
    class Objeto
    {
        public int codigo;
        public String nome;
        public String descricao;
        public int valaqui;


        public Objeto(String nome, int valaqui, String descricao, int codigo)
        {
            this.nome = nome;
            this.valaqui = valaqui;            
            this.descricao = descricao;
            this.codigo = codigo;
        }
    }
}
