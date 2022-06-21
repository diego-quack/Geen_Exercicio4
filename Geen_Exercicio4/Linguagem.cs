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

        public Linguagem()
        {
        }

        public Linguagem(int ano, string nome, string desenvolvedorChefe, string predecessores)
        {
            Ano = ano;
            Nome = nome;
            DesenvolvedorChefe = desenvolvedorChefe;
            Predecessores = predecessores;
        }
        /*
        public void Imprimir()
        {
            var resultado = from linguagem in Linguagens select linguagem;
            foreach(var linguagem in resultado)
            {
                Console.WriteLine($"Nome: {linguagem.Nome} " +
                                  $"Ano de criação: {linguagem.Ano} " +
                                  $"Desenvolvedor Chefe {linguagem.Predecessores} " +
                                  $"Predecessores: {linguagem.DesenvolvedorChefe}");
            }
        }
        */
        /*
        public void AdicionarLinguagem()
        {

        }
        public void RemoverLinguagem()
        {
            Linguagem linguagem = new Linguagem();
            Linguagens.Remove(linguagem);
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

        }*/
    }
}
