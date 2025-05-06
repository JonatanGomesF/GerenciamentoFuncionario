﻿//using System;
//using System.Collections.Generic;

//namespace gerenciamentoFunc
//{
//    internal class Program
//    {
//        static List<Funcionario> funcionarios = new List<Funcionario>();

//        static void Main(string[] args)
//        {
//            while (true)
//            {
//                Console.Clear();
//                Console.WriteLine("==== Sistema de Gerenciamento de Funcionários ====");
//                Console.WriteLine("1 - Adicionar Gerente");
//                Console.WriteLine("2 - Adicionar Desenvolvedor");
//                Console.WriteLine("3 - Adicionar Estagiário");
//                Console.WriteLine("4 - Mostrar todos os funcionários");
//                Console.WriteLine("0 - Sair");
//                Console.Write("Escolha uma opção: ");
//                string opcao = Console.ReadLine();

//                switch (opcao)
//                {
//                    case "1":
//                        AdicionarGerente();
//                        break;
//                    case "2":
//                        AdicionarDesenvolvedor();
//                        break;
//                    case "3":
//                        AdicionarEstagiario();
//                        break;
//                    case "4":
//                        MostrarFuncionarios();
//                        break;
//                    case "0":
//                        return;
//                    default:
//                        Console.WriteLine("Opção inválida.");
//                        break;
//                }

//                Console.WriteLine("Pressione ENTER para continuar...");
//                Console.ReadLine();
//            }
//        }

//        static void AdicionarGerente()
//        {
//            Console.Write("Nome: ");
//            string nome = Console.ReadLine();
//            Console.Write("Idade: ");
//            int idade = int.Parse(Console.ReadLine());
//            Console.Write("Cargo: ");
//            string cargo = Console.ReadLine();
//            Console.Write("Salário: ");
//            decimal salario = decimal.Parse(Console.ReadLine());
//            Console.Write("Forma de pagamento: ");
//            string formaPag = Console.ReadLine();
//            Console.Write("Método de entrega do pagamento: ");
//            string metEntrPag = Console.ReadLine();
//            Console.Write("Bônus: ");
//            decimal bonus = decimal.Parse(Console.ReadLine());

//            var gerente = new Gerente(nome, idade, cargo, salario, formaPag, metEntrPag, bonus, 0);
//            funcionarios.Add(gerente);
//            Console.WriteLine("Gerente adicionado com sucesso!");
//        }

//        static void AdicionarDesenvolvedor()
//        {
//            Console.Write("Nome: ");
//            string nome = Console.ReadLine();
//            Console.Write("Idade: ");
//            int idade = int.Parse(Console.ReadLine());
//            Console.Write("Cargo: ");
//            string cargo = Console.ReadLine();
//            Console.Write("Salário: ");
//            decimal salario = decimal.Parse(Console.ReadLine());
//            Console.Write("Forma de pagamento: ");
//            string formaPag = Console.ReadLine();
//            Console.Write("Método de entrega do pagamento: ");
//            string metEntrPag = Console.ReadLine();
//            Console.Write("Horas extras: ");
//            int horasExtras = int.Parse(Console.ReadLine());
//            Console.Write("Valor por hora extra: ");
//            decimal valorPorHora = decimal.Parse(Console.ReadLine());

//            var dev = new Desenvolvedor(nome, idade, cargo, salario, formaPag, metEntrPag, horasExtras, valorPorHora, 0);
//            funcionarios.Add(dev);
//            Console.WriteLine("Desenvolvedor adicionado com sucesso!");
//        }

//        static void AdicionarEstagiario()
//        {
//            Console.Write("Nome: ");
//            string nome = Console.ReadLine();
//            Console.Write("Idade: ");
//            int idade = int.Parse(Console.ReadLine());
//            Console.Write("Cargo: ");
//            string cargo = Console.ReadLine();
//            Console.Write("Salário: ");
//            decimal salario = decimal.Parse(Console.ReadLine());
//            Console.Write("Forma de pagamento: ");
//            string formaPag = Console.ReadLine();
//            Console.Write("Método de entrega do pagamento: ");
//            string metEntrPag = Console.ReadLine();

//            var est = new Estagiario(nome, idade, cargo, salario, formaPag, metEntrPag, 0);
//            funcionarios.Add(est);
//            Console.WriteLine("Estagiário adicionado com sucesso!");
//        }

//        static void MostrarFuncionarios()
//        {
//            Console.Clear();
//            Console.WriteLine("==== Funcionários Cadastrados ====\n");
//            foreach (var f in funcionarios)
//            {
//                f.DisplayInfo();
//                Console.WriteLine("--------------------------");
//            }
//        }
//    }
//}





namespace gerenciamentoFunc
{
    internal class Program
    {
        static List<Funcionario> funcionarios = new List <Funcionario>();
        static void Main(string[] args)
        {

            Gerente gerente = new ("Jonatan", 29, 
                "Gerente de projetos na IBM", 10000m, "pix",
                "automatico", 2000, 0.275m); 

            Desenvolvedor dev = new ("Jonatan", 29,
              "desenvolvedor C# na IBM", 8000m, "Dinheiro", "automatico", 10, 50, 0.1m);

            Estagiario joao = new ("joao", 34,
                "Frontend na IBM", 6000m, "pix", "manual", 0m);

            funcionarios.Add(gerente);
            funcionarios.Add(dev);
            funcionarios.Add(joao);
            foreach (var f in funcionarios)
            {
                f.DisplayInfo();
                Console.WriteLine("--------------------------");

                Console.ReadLine(); 
            }
        }
    }
}
