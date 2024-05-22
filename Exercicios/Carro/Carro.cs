using System;
namespace Carro
{
    class Carro
    {
        private string marca;
        private string modelo;
        private int ano;

        public void mensagem()
        {
            Console.WriteLine("qual a marca do carro: ");
            marca = Console.ReadLine();
            
            Console.WriteLine("qual o modelo do carro: ");
            modelo = Console.ReadLine();
            
            Console.WriteLine("qual o ano do carro: ");
            ano = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(marca + modelo + ano);
        }



    }
}