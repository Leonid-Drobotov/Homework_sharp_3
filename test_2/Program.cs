//Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

string Border(int quarter)
{
if (quarter==1) return "X > 0, Y > 0";
if (quarter==2) return "X < 0, Y > 0";
if (quarter==3) return "X < 0, Y < 0";
if (quarter==4) return "X > 0, Y < 0";
return "Прийми таблетки";
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int quarter = GetInfo("Введите номер четверти: ");
Console.WriteLine($"Для данной четверти границы значений {Border(quarter)}");