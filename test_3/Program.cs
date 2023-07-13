double Distance(int XA, int YA, int XB, int YB)
{
double distance = Math.Sqrt(Math.Pow(XB - XA,2)+Math.Pow(YB - YA,2));
return distance;
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int coordX_A = GetInfo("Введите координату X точки A : ");
int coordY_A = GetInfo("Введите координату Y точки A : ");
int coordX_B = GetInfo("Введите координату X точки B : ");
int coordY_B = GetInfo("Введите координату Y точки B : ");


Console.WriteLine($"Расстояние между точками на плоскости составляет: {Distance(coordX_A, coordY_A, coordX_B, coordY_B)}");
