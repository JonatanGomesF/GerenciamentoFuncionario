using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gerenciamentoFunc
{
    internal class Estagiario : Funcionario
    {
        public Estagiario(string nome, int idade, string cargo,
            decimal salario, string formaPagamento, string metEntrPag,
            decimal impostos) 
            : base(nome, idade, cargo, salario, formaPagamento,
                  metEntrPag, impostos)
        { }

        public override decimal CalcularSalario()
        {
            return Salario;
        }

        public override string EntregarPagamento()
        {
            return $"O pagamento será entregue" +
                $" de forma: {MetodoEntregaPagamento}";
        }
    }
}
