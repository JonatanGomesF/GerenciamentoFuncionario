using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gerenciamentoFunc
{
    public abstract class Funcionario(string nome, int idade, string cargo, decimal salario,
        string formaPagamento, string metEntrPag, decimal impostos)
    {
        public string Nome { get; set; } = nome;
        public int Idade { get; set; } = idade;
        public string Cargo { get; set; } = cargo;
        public decimal Salario { get; set; } = salario;
        public string FormaPagamento { get; set; } = formaPagamento;
        public string MetodoEntregaPagamento { get; set; } = metEntrPag;

        public decimal Impostos { get; set; } = impostos;

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Nome: {Nome}, Cargo: {Cargo}, Salario: {Salario}," +
                $"Forma de pagamento Pix, debito em conta ou Dinheiro?{FormaPagamento} " +
                $"metodo de entrega/pagamento: {MetodoEntregaPagamento}," +
                $"impostos: {Impostos}");
        }
        public override string ToString()
        {
            return $"Nome: {Nome}, Idade: {Idade}, Cargo: {Cargo}, Salário: {Salario:C}, Forma de Pagamento: {FormaPagamento}, Método de Entrada: {MetodoEntregaPagamento}";
        }

        public abstract decimal CalcularSalario();
        public virtual decimal CalcularImpostos()
        {
            return CalcularImpostos();
        }

        public virtual string EntregarPagamento()
        {
            return MetodoEntregaPagamento;
                }
    }
}
