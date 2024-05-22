using System;
class Gerente : Imposto
{
    public override void valeAlimentacao(double salario)
    {
        Console.WriteLine("Desconto do gerente no vale alimentação: " + (salario * 0.15));
    }
}