//Задача 1. Программа, которая выдает квадрат числа
System.Console.Write("Введите число > ");
String stringValue = Console.ReadLine();
int value = Convert.ToInt32(stringValue);
int result = value * value;
System.Console.WriteLine($"Квадрат числа {value} равен {result}");