using System;
class Imposto
{
    public virtual void valeAlimentacao(double salario)
    {
        Console.WriteLine("Desconto do vale alimentação: " + (salario * 0.1));
    }
    public void valeTransporte(double salario)
    {
        Console.WriteLine("Desconto padrão do vale transporte: " + (salario *0.06));
    }
}