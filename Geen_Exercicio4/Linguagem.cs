using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geen_Exercicio4
{
    class Linguagem
    {
        public int Ano { get; set; }
        public string Nome { get; set; }
        public string DesenvolvedorChefe { get; set; }
        public string Predecessores { get; set; }

        List<Linguagem> Linguagens = new List<Linguagem>();
        public Linguagem(int ano, string nome, string desenvolvedorChefe, string predecessores)
        {
            Ano = ano;
            Nome = nome;
            DesenvolvedorChefe = desenvolvedorChefe;
            Predecessores = predecessores;
        }

        public void AdicionarLinguagem()
        {

        }
        public void RemoverLinguagem()
        {

        }
        public Linguagem BuscarLinguagemPorNome(string nome)
        {

        }
        public Linguagem BuscarLinguagemPorAno(int ano)
        {

        }
        public Linguagem BuscarLinguagemPorDesenvolvedor(string desenvolvedorChefe)
        {

        }
        public Linguagem BuscarLinguagemPorPredecessor(string nomePredecessor)
        {

        }
    }
}
