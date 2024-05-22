using System;

namespace Aula01
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa obj = new Pessoa();
            obj.nome = "Rafael";
            obj.idade = 25;
            obj.mensagem();
        }
    }
}