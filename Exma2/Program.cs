Console.Write("Введи количество элементов в массиве: ");
int numbrElements = Convert.ToInt32(Console.ReadLine()); 

int RandomNumbers(int numbrElements, int min, int max)
{
    int[] randomNumbers = new int[numbrElements];
    int sumElements = 0;
    Console.Write("Массив: ");

    for (int i = 0; i <randomNumbers.Length; i++ )
    {
        randomNumbers[i] = new Random().Next(min, max);

        Console.Write(randomNumbers[i] + " ");

        if (i % 2 != 1)
        {
        sumElements = sumElements + randomNumbers[i];
        }
    }
    return sumElements;
}

int randomNumbers =  RandomNumbers(numbrElements, 1, 10);

Console.WriteLine($"\nСумма элементов, стоящих на нечётных позициях:" + randomNumbers);
