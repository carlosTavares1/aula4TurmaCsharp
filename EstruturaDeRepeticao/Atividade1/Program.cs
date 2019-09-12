using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;

            for(int i = 0; i < 10; i = i + 2)
            {
                Console.WriteLine("Informe seu nome: ");
                nome = Console.ReadLine();
            }

            Console.WriteLine("Testando meu exe");
            Console.ReadKey();
        }
    }
}
