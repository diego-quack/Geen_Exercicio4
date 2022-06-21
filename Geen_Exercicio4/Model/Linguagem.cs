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
                Console.WriteLine();
            }
        }
        public static void BuscarLinguagemPorNome(List<Linguagem> listaDeLinguagens, string nome)
        {
            var dados = from linguagem in listaDeLinguagens
                        where linguagem.Nome.StartsWith(nome)
                        select linguagem;

            foreach (var linguagem in dados)
            {
                Console.WriteLine(linguagem);
                Console.WriteLine();
            }
        }
        public static void BuscarLinguagemPorAno(List<Linguagem> listaDeLinguagens, int ano)
        {
            var dados = from linguagem in listaDeLinguagens
                        where linguagem.Ano.Equals(ano)
                        select linguagem;

            foreach (var linguagem in dados)
            {
                Console.WriteLine(linguagem);
                Console.WriteLine();
            }
        }
        public static void BuscarLinguagemPorDesenvolvedor(List<Linguagem> listaDeLinguagens, string desenvolvedor)
        {
            var dados = from linguagem in listaDeLinguagens
                        where linguagem.DesenvolvedorChefe.Contains(desenvolvedor)
                        select linguagem;

            foreach (var linguagem in dados)
            {
                Console.WriteLine(linguagem);
                Console.WriteLine();
            }
        }
        public static void BuscarLinguagemPorPredecessor(List<Linguagem> listaDeLinguagens, string predecessor)
        {
            var dados = from linguagem in listaDeLinguagens
                        where linguagem.Predecessores.Contains(predecessor)
                        select linguagem;

            foreach (var linguagem in dados)
            {
                Console.WriteLine(linguagem);
                Console.WriteLine();
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
