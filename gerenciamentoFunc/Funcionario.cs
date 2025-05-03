using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gerenciamentoFunc
{
    public abstract class Funcionario
    {
        public string Nome {  get; set; }
        public int Idade { get; set; }
        public string Cargo { get; set; }
        public decimal Salario { get; set; }
        public string FormaPagamento { get; set; } //(Pix, Débito em Conta, Dinheiro)
        public string MetodoEntregaPagamento { get; set; } // (Automático, Manual)

        
        public Funcionario(string nome, int idade, string cargo, decimal salario,
            string formaPagamento, string metEntrPag)
        {
            Nome = nome;
            Idade = idade;
            Cargo = cargo;
            Salario = salario;
            FormaPagamento = formaPagamento;
            MetodoEntregaPagamento = metEntrPag;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Nome: {Nome}, Cargo: {Cargo}, Salario: {Salario}," +
                $"Forma de pagamento Pix, debito em conta ou Dinheiro?{FormaPagamento} " +
                $"metodo de entrega/pagamento: {MetodoEntregaPagamento}");
        }

        public abstract decimal CalcularSalario();
    }
}
