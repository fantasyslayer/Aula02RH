using System;
using Aula02RH.Models;
using Aula02RH.Models.Enuns;

namespace Aula02RH
{
        public class Program
    {
        static void Main(string[] args)
        {
            /*Funcionario f = new Funcionario();
            f.Id = 10;
            f.Nome = "Neymar";
            f.CPF = "12345678910";
            f.DataAdmissao = DateTime.Parse("01/01/2000");
            f.Salario = 1000.00M;
            f.TipoFuncionario = TipoFuncionarioEnum.Aprendiz;

            string mensagem = f.ExibirPeriodoExperiencia();
            Console.WriteLine(mensagem);*/

            Funcionario func = new Funcionario();

            Console.WriteLine("Digite o Id do Funcionario: ");
            func.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome do funcionario: ");
            func.Nome = Console.ReadLine();
            Console.WriteLine("DIgite o CPF: ");
            func.CPF = Console.ReadLine();
            Console.WriteLine("Digite a data de Admissão: ");
            func.DataAdmissao = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Salãrio: ");
            func.Salario = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Escolha o tipo De Funcionário\n1 - CLT.\n2 - Aprendiz.");
            int opcao= int.Parse(Console.ReadLine());
            func.TipoFuncionario = (opcao == 1) ? TipoFuncionarioEnum.CLT : TipoFuncionarioEnum.Aprendiz;
            
            func.ReajustarSalario();
            decimal valorDescontoVT = func.CalcularDescontoVT(6);

            Console.WriteLine("=============================");
            Console.WriteLine($"O salário rejustado é R$ {func.Salario} .\n");
            Console.WriteLine($"O Desconto no VT é R$ {valorDescontoVT} .\n");
            Console.WriteLine("=============================");    


        }
    }
}