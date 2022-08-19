using System;
using System.Globalization;

namespace ImpostoDeRenda
{
    class Program
    {
        static void Main(string[] args)
        {
            var salario = Tela.SalarioDoHabitante();
            var valor = new Imposto();
            Tela.ImpostoASerPago(valor.PorcentagemDoImposto(salario));
        }
    }
}
