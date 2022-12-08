// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
// между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координату Хa: ");
int Xa = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату Ya: ");
int Ya = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату Za: ");
int Za = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату Хb: ");
int Xb = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату Yb: ");
int Yb = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату Zb: ");
int Zb = int.Parse(Console.ReadLine()!);

double result = Math.Sqrt((Xa - Xb) * (Xa - Xb) + (Ya - Yb) * (Ya - Yb) + (Za - Zb) * (Za - Zb));
Console.WriteLine(result);