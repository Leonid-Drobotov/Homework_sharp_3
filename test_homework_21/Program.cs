double Distance_3D(int XA, int YA, int ZA, int XB, int YB, int ZB)
{
double distance = Math.Sqrt(Math.Pow(XB - XA,2)+Math.Pow(YB - YA,2)+Math.Pow(ZB - ZA,2));
return Math.Round(distance,2);
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int coordX_A = GetInfo("Введите координату X точки A : ");
int coordY_A = GetInfo("Введите координату Y точки A : ");
int coordZ_A = GetInfo("Введите координату Z точки A : ");
int coordX_B = GetInfo("Введите координату X точки B : ");
int coordY_B = GetInfo("Введите координату Y точки B : ");
int coordZ_B = GetInfo("Введите координату Z точки B : ");

Console.WriteLine($"Расстояние между точками в пространстве составляет: {Distance_3D(coordX_A, coordY_A, coordZ_A, coordX_B, coordY_B, coordZ_B)}");

