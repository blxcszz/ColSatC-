using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaPrimeiraAPI1.Controllers
{
    public class bandeira
    {
        public static List<bandeira> listaBandeira = new List<bandeira>();
        public String nome_Bandeira;

        public bandeira(String nome_bandeira)
        {
            this.nome_Bandeira = nome_bandeira;
            listaBandeira.Add(this);
        }

    }
}
