using System;

namespace Calculadora
{
    class Program
    {
        private static Calculadora calculadora = new Calculadora();
        private static void Main(string[] args)
        {
            while (true)
            {
                menu();
            }
        }
        private static void menu()
        {
            Console.Clear();
            Console.WriteLine("Digite 1 para fazer novos cálculos");
            Console.WriteLine("Digite 2 para visualizar o histórico de cálculos");
            var opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1": realizarCalculo(); break;
                case "2": mostrarHistorico(); break;
                default: break;
            }
            Console.ReadKey();
        }
        private static void mostrarHistorico()
        {
            Console.WriteLine(calculadora.MostrarHistorico());
        }
        private static void realizarCalculo()
        {
            Console.WriteLine("Digite o primeiro número");
            var num1 = Console.ReadLine();
            Console.WriteLine("Digite o segundo número");
            var num2 = Console.ReadLine();
            Console.WriteLine("Digite o código do operador da operação");
            Console.WriteLine("1 para adição");
            Console.WriteLine("2 para subtração");
            Console.WriteLine("3 para multiplicação");
            Console.WriteLine("4 para divisão");

            var op = Console.ReadLine();

            Console.WriteLine(calculadora.Calcular(num1, num2, op));
        }
    }
}