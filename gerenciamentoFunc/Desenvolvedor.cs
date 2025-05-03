using System;

namespace gerenciamentoFunc
{
    internal class Desenvolvedor : Funcionario
    {
        private int HorasExtras { get; set; }
        private decimal ValorPorHorasExtras { get; set; }

        public Desenvolvedor(string nome, int idade, string cargo,
            decimal salario, string formaPagamento, string metEntrPag,
            int horasExtras, decimal valorPorHorasExtras)
            : base(nome, idade, cargo, salario, formaPagamento, metEntrPag)
        {
            HorasExtras = horasExtras;
            ValorPorHorasExtras = valorPorHorasExtras;
        }

        public override decimal CalcularSalario()
        {
            return Salario + (HorasExtras * ValorPorHorasExtras) - CalcularImpostos();
        }

        public override decimal CalcularImpostos()
        {
            return Salario * 0.10m; // 10% de imposto
        }

        public override string EntregarPagamento()
        {
            return $"O pagamento será entregue de forma: {MetodoEntregaPagamento}";
        }
    }
}
