using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gerenciamentoFunc
{
    public class Gerente : Funcionario
    {
        public decimal Bonus {  get; set; }
        public decimal Impostos { get; set; }

        public Gerente(string nome, int idade, string cargo, decimal salario,
            string formaPagamento, string metEntrPag, decimal bonus, decimal impostos) 
            : base(nome, idade, cargo, salario, formaPagamento, metEntrPag)
        {
            Bonus = bonus;
            Impostos = impostos;
            
        }

        public override decimal CalcularSalario()
        {
            return Salario + Bonus - Impostos;  
        }
    
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Bonus: {Bonus}, Impostos: {Impostos}");
            Console.WriteLine($"Salário final: {CalcularSalario()}");
        }
 
            






    }
}
