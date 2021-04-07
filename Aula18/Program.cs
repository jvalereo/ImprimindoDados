using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula18
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Treinamento - Aula18 , inseri dados , tipo string, 
             int, double, float , concatenação */
            //Jonas Valereo - Ténico em informática

            //Declarando as variaveis tipo, string , int, double, float

            string nome = "Rafael";
            string sobrenome = "rodrigues";
            int idade = 20;
            double peso = 50.50d;
            string cidade = "São Paulo";
            string estado = "São Paulo";
            string cep = "08005-850";
            string pais = "Brasil";


           //imprimir saida de dados no console, e método WhriteLine

            Console.WriteLine("Informações Dados");
            Console.WriteLine();
            Console.WriteLine(nome);
            Console.WriteLine(sobrenome);
            Console.WriteLine(idade.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(peso.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(cidade);
            Console.WriteLine(estado);
            Console.WriteLine(cep);
            Console.WriteLine(pais);

            // saida do aplicativo console, método Readkey, Retorna o valor da tecla pressionada

            Console.ReadKey();

            //Fim do programa

        }
    }
}
