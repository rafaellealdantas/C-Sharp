using System;
namespace CalcularMedia
{
    class Aluno
    {
        public double num1 , num2;
        public string nome;

        // calcula média
        public double media()
        {
            return (num1 + num2) / 2;
        }

        // verifica se esta aprovado
        public string situacao()
        {
            return media() >= 7 ? "aprovado" : "reprovado";
        }

        // exibe a mensagem
        public void mensagem()
        {
            Console.WriteLine("o aluno " + nome + " está " + situacao() + " com a média: " + media());
        }
    }
}