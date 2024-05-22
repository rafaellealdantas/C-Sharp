using System;

class Colaborador : Pessoa
{
    private double salario;

    private void mensagemColaborador()
    {
        Console.WriteLine("salário: " + salario);
    }

    public Colaborador(string nome, int idade, double salario)
    {
        this.nome = nome;       
        this.idade  = idade;
        this.salario = salario;
        mensagemPessoa();
        mensagemColaborador();
    }
}