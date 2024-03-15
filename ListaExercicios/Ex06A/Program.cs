//criar um vetor
Console.WriteLine();
int[] vetor = new int[100];
Random aleatorio = new Random();


for(int i = 0; i < vetor.Length; i++)
{
    vetor[i] = aleatorio.Next(vetor.Length);      
}

for(int i = 0; i < vetor.Length - 1; i++)
{
    if (vetor[i] > vetor[i + 1])
    {
        int aux = vetor [i];
        vetor[i] = vetor[i + 1];
        vetor [i + 1] = aux;
    }
}


for(int i = 0; i < vetor.Length; i++)
{
    Console.Write(vetor[i] + " ");
}
