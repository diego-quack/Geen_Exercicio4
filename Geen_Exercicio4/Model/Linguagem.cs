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

        public static void AdicionarLinguagem(List<Linguagem> listaDeLinguagens, Linguagem novaLinguagem)
        {
            listaDeLinguagens.Add(novaLinguagem);
        }
        public static void RemoverLinguagem(List<Linguagem> listaDeLinguagens, int index)
        {
            listaDeLinguagens.Remove(listaDeLinguagens[index]);
        }
        public static void Imprimir(List<Linguagem> listaDeLinguagens)
        {
            var resultado = from linguagem in listaDeLinguagens select linguagem;
            foreach (var linguagem in resultado)
            {
                Console.WriteLine(linguagem);
            }
        }
        public static void BuscarLinguagemPorNome(List<Linguagem> listaDeLinguagens, string nome)
        {
            var dados = listaDeLinguagens.Where(lg => lg.Nome.StartsWith(nome)).DefaultIfEmpty();

            foreach (var linguagem in dados)
            {
                Console.WriteLine(linguagem);
            }
        }
        public static void BuscarLinguagemPorAno(List<Linguagem> listaDeLinguagens, int ano)
        {
            var dados = listaDeLinguagens.Where(lg => lg.Ano.Equals(ano)).DefaultIfEmpty();

            foreach (var linguagem in dados)
            {
                Console.WriteLine(linguagem);
            }
        }
        public static void BuscarLinguagemPorDesenvolvedor(List<Linguagem> listaDeLinguagens, string desenvolvedor)
        {
            var dados = listaDeLinguagens.Where(lg => lg.DesenvolvedorChefe.Contains(desenvolvedor)).DefaultIfEmpty();

            foreach (var linguagem in dados)
            {
                Console.WriteLine(linguagem);
            }
        }
        public static void BuscarLinguagemPorPredecessor(List<Linguagem> listaDeLinguagens, string predecessor)
        {
            var dados = listaDeLinguagens.Where(lg => lg.Predecessores.Contains(predecessor)).DefaultIfEmpty();

            foreach (var linguagem in dados)
            {
                Console.WriteLine(linguagem);
            }
        }
        public override string ToString()
        {
            return $"Nome: {Nome} \n" +
                   $"Ano de criação: {Ano} \n" +
                   $"Desenvolvedor Chefe: {DesenvolvedorChefe} \n" +
                   $"Predecessores: {Predecessores} \n";
        }
    }
}
