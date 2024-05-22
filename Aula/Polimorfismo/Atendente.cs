using System;
class Atendente : Imposto
{
        public override void valeAlimentacao(double salario)
    {
        Console.WriteLine("Desconto do atendente no vale alimentação: " + (salario * 0.12));
    }
}