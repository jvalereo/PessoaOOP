using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula10
{
    class Pessoa
    {
        //declarando os atributos, campos,variaveis da class pessoa

        public string nome;
        public string sobrenome;
        public string sexo;
        public int idade;
        public float peso;
        public string pais;


        //declarando os métodos / função  da classe do pessoa

        public void Acorda()
        {
            Console.WriteLine("Acorda de manhã");
        }

        public void Anda()
        {
            Console.WriteLine("Caminha pela ruas");
        }

        public void Come()
        {
            Console.WriteLine("Come alimentos");
        }

        public void Dormi()
        {
            Console.WriteLine("Dormi a noite");
        }

        //fim da classe pessoa
    }
}
