using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geen_Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Linguagem> listaDeLinguagens = new List<Linguagem>()
            {
                new Linguagem{Ano = 1990, Nome = "AMOS BASIC", DesenvolvedorChefe = "François Lionet, Constantin Sotiropoulos", Predecessores = "STO BASIC"},
                new Linguagem{Ano = 1991, Nome = "Visual Basic", DesenvolvedorChefe = "Alan Cooper", Predecessores = "QuickBasic"},
                new Linguagem{Ano = 1995, Nome = "Ruby", DesenvolvedorChefe = "Yukihiro Matsumoto", Predecessores = "Smalltalk, Perl"},
                new Linguagem{Ano = 2009, Nome = "Go", DesenvolvedorChefe = "Google", Predecessores = "C; Oberon, Limbo; Smalltalk"},
            };

            BuscarLinguagemPorNome(listaDeLinguagens, "AMOS");
            BuscarLinguagemPorAno(listaDeLinguagens, 1991);
            BuscarLinguagemPorDesenvolvedor(listaDeLinguagens, "Yuki");
            BuscarLinguagemPorPredecessor(listaDeLinguagens, "Oberon");
        }

        static void AdicionarLinguagem(List<Linguagem> listaDeLinguagens)
        {

        }
        static void Imprimir(List<Linguagem> listaDeLinguagens)
        {
            var resultado = from linguagem in listaDeLinguagens select linguagem;
            foreach (var linguagem in resultado)
            {
                Console.WriteLine($"Nome: {linguagem.Nome} \n" +
                                  $"Ano de criação: {linguagem.Ano} \n" +
                                  $"Desenvolvedor Chefe: {linguagem.DesenvolvedorChefe} \n" +
                                  $"Predecessores: {linguagem.Predecessores}");
                                  Console.WriteLine();
            }
        }
        static void BuscarLinguagemPorNome(List<Linguagem> listaDeLinguagens, string nome)
        {
            var dados = from linguagem in listaDeLinguagens
                        where linguagem.Nome.StartsWith(nome)
                        select linguagem;

            foreach(var linguagem in dados)
            {
                Console.WriteLine($"Nome: {linguagem.Nome} \n" +
                                  $"Ano de criação: {linguagem.Ano} \n" +
                                  $"Desenvolvedor Chefe: {linguagem.DesenvolvedorChefe} \n" +
                                  $"Predecessores: {linguagem.Predecessores}");
                Console.WriteLine();
            }
        }
        static void BuscarLinguagemPorAno(List<Linguagem> listaDeLinguagens, int ano)
        {
            var dados = from linguagem in listaDeLinguagens
                        where linguagem.Ano.Equals(ano)
                        select linguagem;

            foreach (var linguagem in dados)
            {
                Console.WriteLine($"Nome: {linguagem.Nome} \n" +
                                  $"Ano de criação: {linguagem.Ano} \n" +
                                  $"Desenvolvedor Chefe: {linguagem.DesenvolvedorChefe} \n" +
                                  $"Predecessores: {linguagem.Predecessores}");
                Console.WriteLine();
            }
        }
        static void BuscarLinguagemPorDesenvolvedor(List<Linguagem> listaDeLinguagens, string desenvolvedor)
        {
            var dados = from linguagem in listaDeLinguagens
                        where linguagem.DesenvolvedorChefe.Contains(desenvolvedor)
                        select linguagem;

            foreach (var linguagem in dados)
            {
                Console.WriteLine($"Nome: {linguagem.Nome} \n" +
                                  $"Ano de criação: {linguagem.Ano} \n" +
                                  $"Desenvolvedor Chefe: {linguagem.DesenvolvedorChefe} \n" +
                                  $"Predecessores: {linguagem.Predecessores}");
                Console.WriteLine();
            }
        }
        static void BuscarLinguagemPorPredecessor(List<Linguagem> listaDeLinguagens, string predecessor)
        {
            var dados = from linguagem in listaDeLinguagens
                        where linguagem.Predecessores.Contains(predecessor)
                        select linguagem;

            foreach (var linguagem in dados)
            {
                Console.WriteLine($"Nome: {linguagem.Nome} \n" +
                                  $"Ano de criação: {linguagem.Ano} \n" +
                                  $"Desenvolvedor Chefe: {linguagem.DesenvolvedorChefe} \n" +
                                  $"Predecessores: {linguagem.Predecessores}");
                Console.WriteLine();
            }
        }
    }
}
