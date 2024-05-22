using System;

namespace Aula01
{
    class Pessoa
    {
        public int idade;
        public string nome;
        public void mensagem()
        {
            Console.WriteLine("oi" + nome + " você têm " + idade + " anos");
        }


    }
}