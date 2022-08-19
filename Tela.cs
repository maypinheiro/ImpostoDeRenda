using System;
using System.Globalization;

namespace ImpostoDeRenda
{
    class Tela
    {
        public static  Salario SalarioDoHabitante()
        {
            Salario salario = new Salario();
            Console.Write("Informe o sálario: ");
            salario.ValorDoSalario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            return salario;
        }

        public static void ImpostoASerPago(double impostoTotal)
        {
            var imposto = impostoTotal;
            if (imposto == 0.0)
                Console.WriteLine("Isento");
            else
                Console.WriteLine("Imposto R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
