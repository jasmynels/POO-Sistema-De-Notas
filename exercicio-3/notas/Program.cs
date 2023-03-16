using System;
using Course;
namespace Notas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Aluno aluno;
            aluno = new Aluno();
            Console.WriteLine("Insira as informações do aluno a baixo: ");
            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            Console.Write("Nota 1: ");
            aluno.A = int.Parse(Console.ReadLine());
            Console.Write("Nota 2: ");
            aluno.B = int.Parse(Console.ReadLine());
            Console.Write("Nota 3: ");
            aluno.C = int.Parse(Console.ReadLine());
            aluno.ResultadoFinal(aluno.A, aluno.B, aluno.C);

        }
    }
}