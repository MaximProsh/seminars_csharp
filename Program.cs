// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
int fnum = Convert.ToInt32(Console.ReadLine());
int snum = Convert.ToInt32(Console.ReadLine());
if (fnum > snum)
{
    Console.Write("max: ");
    Console.WriteLine(fnum);
}
else
{
    Console.Write("max: ");
    Console.WriteLine(snum);
}

// Задача 4: Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.
int fnum = Convert.ToInt32(Console.ReadLine());
int snum = Convert.ToInt32(Console.ReadLine());
int tnum = Convert.ToInt32(Console.ReadLine());
int max = 0;
if (fnum > snum)
{
    max = fnum;
}
else
{
    max = snum;
}
if (tnum > max)
{
    max = tnum;
}
Console.WriteLine(max);

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).
// int num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 0)
{
    Console.WriteLine("Четное");
}
else
{
    Console.WriteLine("Нечетное");
}

//Задача 8: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.
int num = Convert.ToInt32(Console.ReadLine());
int count = 1;
while (count != num + 1)
{
    Console.Write(count);
    Console.Write(" ");
    count += 1;
}

// int num = Convert.ToInt32(Console.ReadLine());
// int result = num % 10;
// Console.WriteLine(result);


// int num = Convert.ToInt32(Console.ReadLine());
// int count = -num;
// while (count != num + 1)
// {
//     Console.Write(count);
//     Console.Write(" ");
//     count +=1;
// }
// Console.WriteLine();

// int num = Convert.ToInt32(Console.ReadLine());
// if(num == 1)
// {
//     Console.WriteLine("Понедельник");
// }

// if(num == 2)
// {
//     Console.WriteLine("Вторник");
// }

// if(num == 3)
// {
//     Console.WriteLine("Среда");
// }

// if(num == 4)
// {
//     Console.WriteLine("Четверг");
// }

// if(num == 5)
// {
//     Console.WriteLine("Пятница");
// }

// if(num == 6)
// {
//     Console.WriteLine("Суббота");
// }

// if(num == 7)
// {
//     Console.WriteLine("Воскресенье");
// }

// int fnum = Convert.ToInt32(Console.ReadLine());
// int snum = Convert.ToInt32(Console.ReadLine());

// if (snum * snum == fnum)
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }


// int number = Convert.ToInt32(Console.ReadLine());
// int result = number * number;
// Console.WriteLine(result);