using System;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            float numeroDeFuncionarios, horaDeTrabalho, valorDaHora, salarioDoFuncionario;

           
         
            Console.WriteLine("Numero de Funcionários:");
            numeroDeFuncionarios = float.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Valor da Hora:");
            valorDaHora = float.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Salário do Funcionário:");
            salarioDoFuncionario = float.Parse(Console.ReadLine());
           

            Console.WriteLine();
            Console.WriteLine(salarioDoFuncionario.ToString("f2"));
        }
    }
}
