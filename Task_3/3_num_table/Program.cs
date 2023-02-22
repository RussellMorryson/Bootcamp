/*Упрощенный вариант представления таблицы умножения
без формирвоания массива*/

int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    for (int j = 1; j <= n; j++)
    {
        Console.Write(i*j+"\t");
    }
    Console.WriteLine();
}