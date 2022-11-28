//Задача 2: Напишите программу,которая принимает на вход два числа
//и выдает, какое большее, а какое меньшее
//a = 5   b = 7 -> max = 7
//a = 2   b = 10 -> max =10
//a = -9  b = -3 -> max = -3
/*
Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());


if(number1 > number2)
{
    Console.WriteLine($"Число {number1} является большим, а число {number2} меньшим");
}

if(number2 > number1)
{
    Console.WriteLine($"Число {number2} является большим, а число {number1} меньшим");
}

*/

//Задача 4: Напишите программу, которая принимает на вход три числа и
//выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
/*
Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2 && num1 > num3)
{
    Console.Write($"Максимальное из этих чисел {num1}");
}

if (num2 > num1 && num2 > num3)
{
    Console.Write($"Максимальное из этих чисел {num2}");
}

if (num3 > num1 && num3 > num2)
{
    Console.Write($"Максимальное из этих чисел {num3}");
}
*/

//Задача 6: Напишите программу, которая на вход принимает число
//и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = num % 2;
if (result == 0)
{
    Console.Write("Число четное");
}
if (result == 1)
{
    Console.Write("Число нечетное");
}
*/

//Задача 8: Напишите программу, которая на вход принимает число 
//(N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите N: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = num / num;
while(current >= 1 && current <= num)
{
    if (current % 2 == 0)
    {
        Console.Write(current + " ");
        current ++ ;
    }
}