int n = 5;
int [] array = new int [n]; //О(n)
for (int i = 0; i < array.Length; i++) 
    array[i] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("[" + string.Join(", ", array) + "]");

//Сложность алгоритма О(1)



//Какое количество действий или операций до получения результата