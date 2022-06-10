using System;

namespace ByteBank
{
    public class SaldoInsuficienteException : Exception
    {
        public SaldoInsuficienteException(string mensagem) : base(mensagem)
        {

        }
    }
}
