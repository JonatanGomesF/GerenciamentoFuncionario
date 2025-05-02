using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gerenciamentoFunc
{
    public class Gerente : Funcionario
    {
        public int Bonus {  get; set; }

        public Gerente(string nome, int idade, string cargo, decimal salario,
            string formaPagamento, string metEntrPag, int bonus) 
            : base(nome, idade, cargo, salario, formaPagamento, metEntrPag)
        {
            Bonus = bonus;
        }
    
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Bonus: {Bonus}");
        }
 
      






    }
}
