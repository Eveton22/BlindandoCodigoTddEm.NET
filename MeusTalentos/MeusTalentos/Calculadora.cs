using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MeusTalentos
{
    public class Calculadora
    {
        private List<string> listahistorico;
        private string data;

        public Calculadora(string data, List<string> lista)
        {
            listahistorico = lista;
            this.data = data;
        }


         public Calculadora()
        {
            listahistorico = new List<string>();
        }

        public int somar(int val1, int val2)
        {
            int res = val1 + val2;

            listahistorico.Insert(0, "resultado: " + res);

            return res;
        }


        public int subtrair(int val1, int val2)
        {
            int res = val1 - val2;
            listahistorico.Insert(0, "Resultado " + res);
            return res;
        }


        public int multiplicar(int val1, int val2)
        {
            int resultado = val1 * val2;
            listahistorico.Insert(0, "Resultado " + resultado);
            return resultado;
        }

        public double dividir(int val1, int val2)
        {
            double res = val1 / val2;
            listahistorico.Insert(0, "Resultado " + res);

            return res;
        }

        public List<string> historico()
        {

            listahistorico.RemoveRange(3, listahistorico.Count - 3);
            return listahistorico;
        }


    }
}
