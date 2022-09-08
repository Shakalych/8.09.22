double[] arrayNumbers = new double[20];
for (int i = 0; i < arrayNumbers.Length; i++ )
{
    arrayNumbers[i] = new Random().Next(1, 100);
    Console.Write(arrayNumbers[i] + " ");
}

double maxNumber = arrayNumbers[0];
double minNumber = arrayNumbers[0];

for (int i = 1; i < arrayNumbers.Length; i++)
{
    if (maxNumber < arrayNumbers[i])
    {
        maxNumber = arrayNumbers[i];
    }
    if (minNumber > arrayNumbers[i])
    {
        minNumber = arrayNumbers[i];
    }
}

double decision = maxNumber - minNumber;

Console.WriteLine($"||Разница максимального ({maxNumber}) и минимального({minNumber}) элементами: {decision}");
