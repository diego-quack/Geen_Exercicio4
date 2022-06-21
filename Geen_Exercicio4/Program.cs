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

            Linguagem.AdicionarLinguagem(listaDeLinguagens, new Linguagem
            {
                Ano = 2000,
                Nome = "X",
                DesenvolvedorChefe = "Diego",
                Predecessores = "x"
            });

            //Linguagem.RemoverLinguagem(listaDeLinguagens, "Go");

            /*Linguagem.BuscarLinguagemPorNome(listaDeLinguagens, "AMOS");
            Linguagem.BuscarLinguagemPorAno(listaDeLinguagens, 1991);
            Linguagem.BuscarLinguagemPorDesenvolvedor(listaDeLinguagens, "Yuki");
            Linguagem.BuscarLinguagemPorPredecessor(listaDeLinguagens, "Oberon");*/

            Linguagem.Imprimir(listaDeLinguagens);
        }
    }
}
