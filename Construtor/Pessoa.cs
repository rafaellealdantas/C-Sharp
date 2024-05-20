using System;
class Pessoa
{
    public Pessoa()
    {
        Console.WriteLine("Construtor criado");
    }
    public Pessoa(string nome)
    {
        Console.WriteLine("Olá " + nome);
    }
}