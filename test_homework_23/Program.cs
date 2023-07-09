// Напишите программу, которая принимает на вход число (N) и выдает таблицу кубов чисел от 1 до N

void Cube(int N)
{
Console.Write($"{N} -> ");
for (int i = 1;i < N; i++)
{
    Console.Write(Math.Pow(i, 3) + ", ");
}
Console.WriteLine(Math.Pow(N,3) + ". ");
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int N = GetInfo("Введите значение: ");
Cube (N);
