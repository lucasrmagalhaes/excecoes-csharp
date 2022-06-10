using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            // ContaCorrente conta = new ContaCorrente(7480, 874250);
            // Console.WriteLine(ContaCorrente.TaxaOperacao);

            Metodo();

            Console.ReadLine();
        }

        private static void Metodo()
        {
            TestaDivisao(2);
        }

        private static void TestaDivisao(int divisor)
        {
            int resultado = Dividir(10, divisor);

            Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
        }

        private static int Dividir(int numero, int divisor)
        {
            return numero / divisor;
        }

        /*
         * Dividir
         * TestaDivisao
         * Metodo
         * Main
        */
    }
}
