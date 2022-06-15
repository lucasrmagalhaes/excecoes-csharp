using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            CarregarContas();
            // Metodo();
            Console.ReadLine();
        }

        private static void CarregarContas()
        {
            LeitorDeArquivo leitor = new LeitorDeArquivo("contas.txt");
            leitor.LerProximaLinha();
            leitor.LerProximaLinha();
            leitor.LerProximaLinha();

            leitor.Fechar();
        }

        private static void Metodo()
        {
            try
            {
                TestaDivisao(2);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ocorreu um erro! Não é possível dividir um número por 0!");
            }
        }

        private static void TestaDivisao(int divisor)
        {
            int resultado = Dividir(10, divisor);

            // Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado + ".");
        }

        private static int Dividir(int numero, int divisor)
        {
            try
            {
                return numero / divisor;
            }
            catch
            {
                Console.WriteLine("Exceção com número = " + numero + " e divisor = " + divisor);
                throw;
            }
        }
    }
}
