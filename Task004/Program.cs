// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите три числа: ");
int numberA = int.Parse (Console.ReadLine());
int numberB = int.Parse (Console.ReadLine());
int numberC = int.Parse (Console.ReadLine());

int maxNumber = numberA;
if (numberA < numberB) maxNumber = numberB;
if (numberA > numberB) maxNumber = numberA;
if (numberC > maxNumber) maxNumber = numberC;

Console.Write ("Максимальное число: ");
Console.WriteLine (maxNumber);