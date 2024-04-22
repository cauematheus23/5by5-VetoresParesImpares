int[] numeros = new int[10];

for (int i = 0; i < 10; i++)
{
    Console.Write($"Digite o {i}° caracter: ");
    numeros[i] = int.Parse(Console.ReadLine());

}
Console.WriteLine();
Console.Write("Pares: ");

for (int i = 0; i < 10; i++)
{
    if (numeros[i] % 2 == 0)
    {
        Console.Write(numeros[i] + " ");
    }
}
Console.WriteLine();
Console.Write("Impares: ");
for (int i = 0; i < 10; i++)
{
    if (numeros[i] % 2 != 0)
    {
        Console.Write(numeros[i] + " ");
    }
}
Console.WriteLine();
for (int i = 0;i <10; i++)
{
    if (i == 0 || i == 9)
    {
        Console.Write(numeros[i] + " ");
    }
}
