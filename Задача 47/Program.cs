//Задайте двумерный массив (вручную) размером m×n, заполненный 
//вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9,


Console.WriteLine("Введите количество строк m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов n");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите {n} числа  и поставьте запятую, повторить {m} раза ");
string text = Console.ReadLine();
var element = text.Split(",") 
                  .Select(item => item.Split("").Select(s => Convert.ToDouble(s)))
                  .ToArray();

Console.WriteLine($"Массив: ");
for (int i = 0; i < element.Length; i++)
{
    Console.WriteLine(string.Join(' ', element[i]));
}
