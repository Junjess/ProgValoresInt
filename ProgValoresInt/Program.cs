int[] vetor = { -5, 3, 4, 5, 9, 6, 10, -2, 11, 1, 2, 6, 7, 8, 0, -6 };
maiorValor(vetor);
menorValor(vetor);
mediaValor(vetor);
tresMaiores(vetor);
valoresNegativos(vetor);
imprimir(vetor);
removerItem(vetor);
static void maiorValor(int[] vetor)
{
    int Valormaior = -999999999;
    for (int i = 0; i < vetor.Length; i++)
    {
        if (vetor[i] > Valormaior)
        {
            Valormaior = vetor[i];

        }
    }
    Console.WriteLine(Valormaior);
    Console.WriteLine("-----------------");
}
static void menorValor(int[] vetor)
{
    int Valormenor = 99999999;
    for (int i = 0; i < vetor.Length; i++)
    {
        if (vetor[i] < Valormenor)
        {
            Valormenor = vetor[i];
        }
    }
    Console.WriteLine(Valormenor);
    Console.WriteLine("-----------------");
}
static void mediaValor(int[] vetor)
{
    int valorMedia = 0;
    for (int i = 0; i < vetor.Length; i++)
    {
        valorMedia = valorMedia + vetor[i];
    }
    valorMedia = valorMedia / vetor.Length;
    Console.WriteLine(valorMedia);
    Console.WriteLine("-----------------");
}
static void tresMaiores(int[] vetor)
{
        Array.Sort(vetor);
        Array.Reverse(vetor);
        for(int i = 0; i < 3; i++)
        {
            Console.WriteLine(vetor[i]);
        }
    Console.WriteLine("-----------------");
}
static void valoresNegativos(int[] vetor)
{
    Array.Sort(vetor);
    for(int i = 0;i < vetor.Length; i++)
    {
        if (vetor[i] < 0)
        {
            Console.WriteLine(vetor[i]);
        }
    }
    Console.WriteLine("-----------------");
}
static void imprimir(int[] vetor)
{
   for(int i = 0;i<vetor.Length;i++)
    {
        Console.WriteLine(vetor[i]);
    }
    Console.WriteLine("-----------------");
}
static void removerItem(int[] vetor)
{
    int numToRemove = 4; //número a ser deletado
    vetor = vetor.Where(val => val != numToRemove).ToArray();
    for(int i = 0;i<vetor.Length;i++)
    {
        Console.WriteLine(vetor[i]);
    }
}
