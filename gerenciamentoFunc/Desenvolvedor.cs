using System;

namespace gerenciamentoFunc
{
    internal class Desenvolvedor : Funcionario
    {
        private int HorasExtras { get; set; }
        private decimal ValorPorHorasExtras { get; set; }

        public Desenvolvedor(string nome, int idade, string cargo,
            decimal salario, string formaPagamento, string metEntrPag,
            int horasExtras, decimal valorPorHorasExtras, decimal impostos)
            : base(nome, idade, cargo, salario, formaPagamento, metEntrPag, impostos)
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

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Horas Extras: {HorasExtras}, Valor por Hora Extra: {ValorPorHorasExtras:C}");
            Console.WriteLine($"Impostos: {CalcularImpostos():C}");
            Console.WriteLine($"Salário final: {CalcularSalario():C}");
        }

    }
}
