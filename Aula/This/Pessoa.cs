using System;

class Pessoa
{
    private string nome = "Graci";

    public Pessoa(string nome)
    {
        Console.WriteLine(nome);
        Console.WriteLine(this.nome);
    }
}