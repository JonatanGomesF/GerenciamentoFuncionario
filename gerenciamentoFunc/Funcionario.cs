﻿namespace gerenciamentoFunc
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cargo { get; set; }
        public decimal Salario { get; set; }
        public string FormaPagamento { get; set; }
        public string MetodoEntregaPagamento { get; set; }
        public decimal Impostos { get; set; }

        public Funcionario(string nome, int idade, string cargo, decimal salario,
            string formaPagamento, string metEntrPag, decimal impostos)
        {
            Nome = nome;
            Idade = idade;
            Cargo = cargo;
            Salario = salario;
            FormaPagamento = formaPagamento;
            MetodoEntregaPagamento = metEntrPag;
            Impostos = impostos;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}, Cargo: {Cargo}, Salário Base: {Salario:C}");
            Console.WriteLine($"Forma de pagamento: {FormaPagamento}, Entrega: {MetodoEntregaPagamento}");
        }

        public abstract decimal CalcularSalario();
        public virtual decimal CalcularImpostos()
        {
            return 0;
        }
      
       

        public virtual string EntregarPagamento()
        {
            return $"O pagamento será entregue via: {MetodoEntregaPagamento}";
        }
    }
}
