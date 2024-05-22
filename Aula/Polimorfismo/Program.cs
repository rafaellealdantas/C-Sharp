using System;
namespace Polimorfismo
{
    class Program
    {
        static void Main(string[]args)
        {
            Imposto gerente = new Gerente();
            gerente.valeAlimentacao(5000);
            gerente.valeTransporte(5000);

            Imposto atendente = new Atendente();
            atendente.valeAlimentacao(2000);
            atendente.valeTransporte(2000);

            Imposto estagiario = new Estagiario();
            estagiario.valeAlimentacao(1000);
            estagiario.valeTransporte(1000);
        }
    }
}