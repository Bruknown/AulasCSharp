using System;

namespace AulaExercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo ret = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retangulo: ");
            Console.WriteLine("Entre a largura: ");
            ret.Largura = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre a altura: ");
            ret.Altura = double.Parse(Console.ReadLine());
            Console.WriteLine("AREA: " + ret.Area().ToString() + "m^2");
            Console.WriteLine("PERÍMETRO: " + ret.Perimetro().ToString());
            Console.WriteLine("DIAGONAL: " + ret.Diagonal().ToString());

            Console.WriteLine("PROXIMO EXERCICIO");

            Funcionario func = new Funcionario();
            Console.WriteLine("Registre novo funcionário: ");
            Console.WriteLine("Nome: ");
            func.Nome = Console.ReadLine();

            Console.WriteLine("Salario: ");
            func.SalarioBruto = double.Parse(Console.ReadLine());

            Console.WriteLine("Imposto: ");
            func.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine("Funcionário: " + func);

            Console.WriteLine("Digite o salario a aumentar: ");
            double porcentagem = double.Parse(Console.ReadLine());
            func.AumentarSalario(porcentagem);

            Console.WriteLine("Funcionário: " + func);

            Console.WriteLine("PROXIMO EXERCICIO");

            Aluno alu = new Aluno();

            Console.WriteLine("Informe o aluno: ");

            Console.WriteLine("Nome: ");
            alu.Nome = Console.ReadLine();
            
            Console.WriteLine("nota 1: ");
            alu.Nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("nota 2: ");
            alu.Nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("nota 3: ");
            alu.Nota3 = double.Parse(Console.ReadLine());

            double notaFinal = alu.CalcularNota(alu.Nota1, alu.Nota2, alu.Nota3);

            Console.WriteLine("NOTA FINAL: " + notaFinal);
            Console.WriteLine("Status: " + alu.Aprovar(notaFinal));

        }
    }
}
