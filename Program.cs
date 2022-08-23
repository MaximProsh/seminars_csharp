
// int randnum = new Random().Next(100, 1000);
// int fnum = randnum / 100;
// int lnum = randnum % 10;

// Console.WriteLine(randnum);
// Console.WriteLine(fnum);
// Console.WriteLine(lnum);

// int result = fnum * 10 + lnum;
// Console.WriteLine(result);

// void FillArray(int[] collection)
// {
//     int lenght = collection.Length;
//     int index = 0;
//     while (index < lenght)
//     {
//         collection[index] = new Random().Next(1, 100);
//         index++;
//     }
// }

// void PrintArray(int[] col)
// {
//     int count = col.Length;
//     int position = 0;
//     while (position < count)
//     {
//         Console.Write(col[position]);
//         Console.Write(" ");
//         position++;
//     }
//     Console.WriteLine();
// }

// int IndexOf(int[] collection, int find)
// {
//     int count = collection.Length;
//     int index = 0;
//     int position = -402;
//     while (index < count)
//     {
//         if (collection[index] == find)
//         {
//             position = index;
//             break;                        
//         }
//         index++;
//     }
    
//     return position;
// }

// int find = 40;

// int[] array = new int[10];
// FillArray(array);
// PrintArray(array);
// Console.WriteLine(IndexOf(array, find));



// int[] array = { 4, 6, 9, 7, 14, 88, 21, 33 };
// int n = array.Length;
// int find = 144;
// int index = 0;

// while(n > index)
// {
//     if(array[index] == find)
//     {
//         Console.Write("Число найдено на позиции ");
//         Console.WriteLine(index + 1);
//         break;
//     }
//     index++;
// }
// Console.WriteLine("Искомое число не найдено");


// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if(arg2 > result) result = arg2;
//     if(arg3 > result) result = arg3;
//     return result;
// }

// int[] array = { 16, 25, 13, 14, 556, 66, 17, 83, 19 };

// int resmax = Max(
//     Max(array[0], array[1], array[2]),
//     Max(array[3], array[4], array[5]),
//     Max(array[6], array[7], array[8]) 
//     );

// Console.WriteLine(resmax);





// int a1 = 10;
// int b1 = 2;
// int c1 = 3;
// int max1 = Max(a1, b1, c1);
// int a2 = 9;
// int b2 = 1000;
// int c2 = 18;
// int max2 = Max(a2, b2, c2);
// int a3 = 13;
// int b3 = 20;
// int c3 = 133;
// int max3 = Max(a3, b3, c3);
// int maxfull = Max(max1, max2, max3);
// int maxfull2 = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));

// Console.WriteLine(max1);
// Console.WriteLine(max2);
// Console.WriteLine(max3);
// Console.WriteLine(maxfull);
// Console.WriteLine(maxfull2);

// int max = 0;
// if(a1 > max) max = a1;
// if(b1 > max) max = b1;
// if(c1 > max) max = c1;
// if(a2 > max) max = a2;
// if(b2 > max) max = b2;
// if(c2 > max) max = c2;
// if(a3 > max) max = a3;
// if(b3 > max) max = b3;
// if(c3 > max) max = c3;

// Console.WriteLine(max);


// int num = Convert.ToInt32(Console.ReadLine());
// int count = 1;
// while (count != num + 1)
// {
//    if (count % 2 == 0) 
//     {
//         Console.Write(count);
//         Console.WriteLine(" ");
//     }

// count = count + 1;
// }



// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
// int fnum = Convert.ToInt32(Console.ReadLine());
// int snum = Convert.ToInt32(Console.ReadLine());
// if (fnum > snum)
// {
//     Console.Write("max: ");
//     Console.WriteLine(fnum);
// }
// else
// {
//     Console.Write("max: ");
//     Console.WriteLine(snum);
// }

// Задача 4: Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.
// int fnum = Convert.ToInt32(Console.ReadLine());
// int snum = Convert.ToInt32(Console.ReadLine());
// int tnum = Convert.ToInt32(Console.ReadLine());
// int max = 0;
// if (fnum > snum)
// {
//     max = fnum;
// }
// else
// {
//     max = snum;
// }
// if (tnum > max)
// {
//     max = tnum;
// }
// Console.WriteLine(max);

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).
// int num = Convert.ToInt32(Console.ReadLine());
// if (num % 2 == 0)
// {
//     Console.WriteLine("Четное");
// }
// else
// {
//     Console.WriteLine("Нечетное");
// }

//Задача 8: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.
// int num = Convert.ToInt32(Console.ReadLine());
// int count = 1;
// while (count != num + 1)
// {
//     Console.Write(count);
//     Console.Write(" ");
//     count += 1;
// }

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