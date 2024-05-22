using System;
namespace CalcularIMC
{
    class Program
    {
    
        static void Main(string[] args)
        {
            Pessoa obj = new Pessoa();
            obj.altura = 1.74;
            obj.peso = 82;
            obj.resultado();

        }
    }

}