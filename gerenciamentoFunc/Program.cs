namespace gerenciamentoFunc
{
    internal class Program
    {
        static List<Funcionario> funcionarios = new List<Funcionario>();
        static void Main(string[] args)
        {

            Gerente gerente = new Gerente("Jonatan", 29, 
                "Gerente de projetos na IBM", 10000m, "pix",
                "automatico", 2000, 0275);

            Desenvolvedor dev = new Desenvolvedor("Jonatan", 29,
              "desenvolvedor C# na IBM", 8000m, "Dinheiro", "automatico", 50, 0.1m);

            Estagiario joao = new Estagiario("joao", 34,
                "Frontend na IBM", 6000m, "pix", "manual", 0m);

            funcionarios.Add(gerente);
            funcionarios.Add(dev);
            funcionarios.Add(joao);
            foreach (var f in funcionarios)
            {
                Console.WriteLine(f);
            }
        }
    }
}
