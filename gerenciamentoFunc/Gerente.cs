using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gerenciamentoFunc
{
    public class Gerente : Funcionario
    {
        private decimal Bonus {  get; set; }
        

        public Gerente(string nome, int idade, string cargo, decimal salario,
            string formaPagamento, string metEntrPag, decimal bonus, decimal impostos) 
            : base(nome, idade, cargo, salario, formaPagamento, metEntrPag, impostos)
        {
            Bonus = bonus;
           
            
        }

  
        public override decimal CalcularImpostos()
        {
            Impostos = (Salario + Bonus) * 0.275m;
            return Impostos;
        }

        public override decimal CalcularSalario()
        {

            decimal salarioTototal = Salario + Bonus;
            decimal salarioLiquido = salarioTototal - CalcularImpostos();
            return salarioLiquido;
        }

        public override string EntregarPagamento()
        {
            return $"O pagamento será entregue" +
                $" de forma: {MetodoEntregaPagamento}";
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Bonus: {Bonus}");
            Console.WriteLine($"Impostos calculados no Salario: {CalcularImpostos():C}");
            Console.WriteLine($"Salario Final: {CalcularSalario():C}");
        }
    }
}
