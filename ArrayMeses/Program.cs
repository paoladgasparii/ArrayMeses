using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMeses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] mes = { "JANEIRO", "FEVEREIRO", "MARÇO", "ABRIL", "MAIO", "JUNHO", "JULHO", "AGOSTO", "SETEMBRO", "OUTUBRO", "NOVEMBRO", "DEZEMBRO" };

            Console.WriteLine("Digite o número do mês (1 a 12): ");

            int i = int.Parse(Console.ReadLine());

            Console.WriteLine("O mês selecionado foi: " + mes[i-1]);

            Console.ReadKey();
        }
    }
}
