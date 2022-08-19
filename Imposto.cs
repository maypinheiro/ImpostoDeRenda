
namespace ImpostoDeRenda
{
     public class Imposto
    {
        public  double PorcentagemDoImposto(Salario salarioParaImposto)
        {
            double salario = salarioParaImposto.ValorDoSalario;

            var primeiraFaixa = new[] { 0, 2000 };
            var segundaFaixa = new [] { 2000.01, 3000};
            var terceiraFaixa = new [] { 3000.01, 4500};

            double imposto;
            if (salario <= primeiraFaixa[1])
                imposto = 0.0;
            else if (salario <= segundaFaixa[1])
                imposto = (salario - 2000.0) * 0.08;
            else if (salario <= terceiraFaixa[1])
                imposto = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;
            else
                imposto = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            return imposto;

        }
    }
}
