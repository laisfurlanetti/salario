using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salario
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal salario;
            decimal porcentagem = 0;
            decimal num = 0;
            decimal resultado = 0;

            Console.Write("Digite seu salario: ");
            salario = Convert.ToDecimal(Console.ReadLine().Replace(",", "."));

            if (salario <= 280)
            {
                num = 20;
                porcentagem = (salario * num) / 100;
                resultado = SalarioAtual(porcentagem, salario);
            }

            if (salario >= 280 && salario < 700)
            {
                num = 15;
                porcentagem = (salario * num) / 100;
                resultado = SalarioAtual(porcentagem, salario);
            }

            if (salario >= 700 && salario < 1500)
            {
                num = 10;
                porcentagem = (salario * num) / 100;
                resultado = SalarioAtual(porcentagem, salario);
            }

            if (salario >= 1500)
            {
                num = 5;
                porcentagem = (salario * num) / 100;
                resultado = SalarioAtual(porcentagem, salario);
            }

            Console.WriteLine("Seu salario era de: R$ " + salario);
            Console.WriteLine("Seu percentual foi de " + num + "%");
            Console.WriteLine("Seu salario atual e de: R$" + resultado);
            Console.WriteLine("O aumento foi de: " + porcentagem);

            Console.ReadLine();

        }
        public static decimal SalarioAtual(decimal porcentagem, decimal salario)
        {
            decimal saldo;

            saldo = porcentagem + salario;
            return saldo;
        }
    }
}
