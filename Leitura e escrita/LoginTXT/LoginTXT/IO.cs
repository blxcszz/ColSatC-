using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LoginTXT
{
    class IO
    {
        static private String endDoc = @"C:\Users\tecnico\Desktop\Bruno 3°\Objeto.txt";

        public void escrever(String mensagem) {
            using (StreamWriter sw = new StreamWriter(endDoc))
            {
                sw.WriteLine(mensagem);
                sw.Close();
            }
        }

        public String ler() {
            String dados;
            String resultado = "";
            using (StreamReader sr = new StreamReader(endDoc))
            {
                // sr.ReadLine();
                while ((dados = sr.ReadLine()) != null)
                {
                    resultado = resultado + " " + dados;
                }
                sr.Close();
            }
            return resultado;
        }
    }
}
