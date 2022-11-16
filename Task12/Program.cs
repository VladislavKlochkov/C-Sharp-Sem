// 12. Напишите программу, которая 
// 1. будет принимать на вход два числа и 
// 2. выводить, является ли первое число кратным второму. 
// 3. Если число 1 не кратно числу 2, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите два целых числа");

int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());

int Multiplicity(int number1, int number2)
{
    return number1 % number2;
}
int res = Multiplicity(num1, num2);
if (res == 0)
{
    Console.WriteLine($"{num1} кратно {num2}");
}
else Console.WriteLine($"{num1} некратно {num2}, остаток {res}");