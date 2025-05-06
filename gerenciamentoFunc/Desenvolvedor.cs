using System;

namespace gerenciamentoFunc
{
    internal class Desenvolvedor : Funcionario
    {
        public int HorasExtras { get; set; }
        public decimal ValorPorHorasExtras { get; set; }

        public Desenvolvedor(string nome, int idade, string cargo,
            decimal salario, string formaPagamento, string metEntrPag,
            int horasExtras, decimal valorPorHorasExtras, decimal impostos)
            : base(nome, idade, cargo, salario, formaPagamento, metEntrPag, impostos)
        {
            HorasExtras = horasExtras;
            ValorPorHorasExtras = valorPorHorasExtras;
        }

        public override decimal CalcularImpostos()
        {
           decimal salarioTotal = Salario + (HorasExtras * ValorPorHorasExtras);
            Impostos = salarioTotal * 0.10m;
            return Impostos;
        }

        public override decimal CalcularSalario()
        {

            decimal salarioTotal = Salario + (HorasExtras * ValorPorHorasExtras);
            decimal salarioLiquido = salarioTotal - CalcularImpostos();
            return salarioLiquido;
        }


        public override string EntregarPagamento()
        {
            return $"O pagamento será entregue de forma: {MetodoEntregaPagamento}";
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Horas Extras: {HorasExtras}, Valor por Hora Extra: {ValorPorHorasExtras:C}");
            Console.WriteLine($"Impostos calculados: {CalcularImpostos():C}");
            Console.WriteLine($"Salário final: {CalcularSalario():C}");
            Console.WriteLine(EntregarPagamento());
        }
    }
}
