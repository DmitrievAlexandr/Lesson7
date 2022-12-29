//  Напишите программу, которая на вход принимает элемент в двумерном массиве, 
//и возвращает индекс этого элемента или же указание, что такого элемента нет. 
//Если элементов несколько, то выводим позицию каждого. Двумерный массив задаётся 
//на ваш выбор.
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

Console.WriteLine("Введите количество строк m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов n");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите искомое число k");
int k = Convert.ToInt32(Console.ReadLine());
int[,] array2d = new int[m, n];
Random random = new Random();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array2d[i, j] = random.Next(1, 10);
        Console.Write(array2d[i, j] + " ");
    }
    Console.WriteLine();
}

int count = 0;
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (array2d[i, j] == k)
        {
            count++;
            Console.WriteLine($"индекс искомого элемента [{i},{j}]");
        }
    }
}
if (count == 0)
    Console.WriteLine("Этого числа в массиве нет");
