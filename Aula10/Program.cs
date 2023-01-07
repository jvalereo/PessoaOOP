using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Treinamento - Aula 10, Programação Orientação ao Objeto
            //Inserindo dados, tipo string , int, float
            //Jonas Valereo - Técnico em Informática 

            //declarando o objeto pessoa da class pessoa

            Pessoa pessoa = new Pessoa();

            Console.WriteLine("Digite o seu nome: ");
            pessoa.nome = Console.ReadLine();
            Console.WriteLine("Digite o seu sobrenome: ");
            pessoa.sobrenome = Console.ReadLine();
            Console.WriteLine("Digite o seu sexo: ");
            pessoa.sexo = Console.ReadLine();
            Console.WriteLine("Digite o sua idade: ");
            pessoa.idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o seu peso: ");
            pessoa.peso = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o seu pais: ");
            pessoa.pais = Console.ReadLine();

            //imprimir saida de dados no console, e método WhriteLine, concatenação
            Console.WriteLine(" ");
            Console.WriteLine("Nome: " + pessoa.nome);
            Console.WriteLine("Sobrenome: " + pessoa.sobrenome);
            Console.WriteLine("Sexo: " + pessoa.sexo);
            Console.WriteLine("Idade: " + pessoa.idade);
            Console.WriteLine("Peso: " + pessoa.peso.ToString("F2", CultureInfo.InvariantCulture) + " Kg");
            Console.WriteLine("Pais: " + pessoa.pais);
            Console.WriteLine(" ");

            //chamando o método da class pessoa e imprimindo
            Console.WriteLine("----------------------");
            pessoa.Acorda();
            pessoa.Anda();
            pessoa.Come();
            pessoa.Dormi();

            //saida do aplicativo console, método Readkey, Retorna o valor da tecla pressionada

            Console.ReadKey();

            //fim do programa

        }
    }
}
