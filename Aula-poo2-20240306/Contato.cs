using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_poo2_20240306
{
    internal class Contato
    {
        public string nome { get; set; }
        public string telefone { get; set; }

        public Contato(string nome, string telefone)
        {
            this.nome = nome;
            this.telefone = telefone;
        }

        public override string ToString()
        {
            return "Nome:" + nome + "\nTelefone:" + telefone;
        }
    }
}
