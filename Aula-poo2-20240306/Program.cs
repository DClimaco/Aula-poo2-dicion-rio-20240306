using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_poo2_20240306
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AgendaTelefonica a = new AgendaTelefonica("Daniel");

            a.Inserir("Daniel", "00009999");
            Console.WriteLine(a.Tamanho());
            Console.WriteLine(a.Buscar("Daniel"));
            a.Inserir("Victor", "99990000");
            Console.WriteLine(a.Tamanho());
            a.Remover("Victor");
            Console.WriteLine(a.Tamanho());


        }
    }
}
