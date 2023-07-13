// Напишите программу, которая принимает на вход число (N) и выдает таблицу квадратов чисел

void Square(int N)
{
Console.Write($"{N} -> ");
for (int i = 1;i < N; i++)
{
    Console.Write(Math.Pow(i, 2) + ", ");
}
Console.WriteLine(N*N + ". ");
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int N = GetInfo("Введите значение: ");
Square (N);