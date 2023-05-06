using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login2
{
    internal class Acesso
    {
        public string login = "BOs";
        public string senha = "1";

        public bool entrar(string? lg, string? sh)
        {
            if (this.login == lg && this.senha == sh)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
