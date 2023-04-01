//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// int a = 0;
// while(true){
//     Console.WriteLine($"\nВведите пятизначное число: ");
//     a = Convert.ToInt32(Console.ReadLine());
//     if(a < 10000 || a > 99999) Console.WriteLine("Это не пятизначное число");
//     else break;
// }
// int ch5 = a % 10;
// int ch4 = a / 10 % 10;
// int ch3 = a / 100 % 10;
// int ch2 = a / 1000 % 10;
// int ch1 = a / 10000;
// if (ch1 == ch5 && ch2 == ch4) Console.WriteLine("Это палиндром");
// else Console.WriteLine("Это не палиндром");

//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// Console.Write("x1 = ");
// double x1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("y1 = ");
// double y1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("z1 = ");
// double z1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("x2 = ");
// double x2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("y2 = ");
// double y2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("z2 = ");
// double z2 = Convert.ToDouble(Console.ReadLine());
// Console.Write($"Расстояние между точками равно {Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1))}");

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число n = ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++){
    Console.WriteLine(i*i*i);
}