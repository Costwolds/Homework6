// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите несколько чисел через пробел");

int Result()
{
int [] array= Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i]> 0)
    {
        sum++;
    }
}
return sum;
}

Console.WriteLine();

int calculateNumber= Result();

Console.WriteLine($"количество значений больше 0 = {calculateNumber}");







    