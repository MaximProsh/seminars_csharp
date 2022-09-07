





// double Fibonacci(int n)
// {
//     if (n == 1 || n == 2) return 1;
//     else return Fibonacci(n - 1) + Fibonacci(n - 2);
// }

// for (int i = 1; i < 100; i++)
// {
//    Console.WriteLine($"{i} = {Fibonacci(i)}"); 
// }



// double Factorial(int n)
// {
//     if (n == 1) return 1;
//     else return n * Factorial(n - 1);
    
// }
// // Console.WriteLine(Factorial(10));

// for (int i = 1; i < 40; i++)
// {
//     Console.WriteLine($"{i}! = {Factorial(i)}");
// }


// int[,] pic = new int[,]
// {
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 },
// {0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// };
// void PrintImage(int[,] image)
// {
//     for (int i = 0; i < image.GetLength(0); i++)
//     {
//         for (int j = 0; j < image.GetLength(1); j++)
//         {
//             // Console.Write($"{image[i, j]} ");
//             if (image[i, j] == 0)
//             {
//                 Console.Write($" ");
//             }
//             else Console.Write($"+");
//         }
//         Console.WriteLine();
//     }    
// }
// PrintImage(pic);

// void FillImage(int row, int col)
// {
//     if (pic[row, col] == 0)
//     {
//         pic[row, col] = 1;
//         FillImage(row-1, col);
//         FillImage(row, col-1);
//         FillImage(row+1, col);
//         FillImage(row, col+1);
//     }
// }
// FillImage(11, 4);
// PrintImage(pic);



// void PrintAr(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();
//     }    
// }


// void FillArr(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(-100, 100);
//         }
//     }
// }

// int[,] matr = new int[3, 5];
// FillArr(matr);
// PrintAr(matr);


// int[,] matrix = new int[3, 5];
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         Console.Write($"{j + i} ");
//     }
//     Console.WriteLine();
// }



// string[,] table = new string[2, 5];
// table[1, 2] = "слово";

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.Write($"{table[rows, columns]}-");
//     }
//     Console.WriteLine();
// }



// 38: Задайте массив вещественных чисел. Найдите разницу 
// между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
// bool IsNumber = int.TryParse(Console.ReadLine(), out int length);
// if (!IsNumber || length == 0)
// {
//     Console.WriteLine("Invalid input");
//     return;
// }

// Random rnd = new Random();
// int[] array = new int[length];

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = rnd.Next(1, 99);
// }

// int GetMaxinArr(int[] array)
// {
//     int max = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] > max)
//         {
//             max = array[i];
//         }
//     }
//     return max;
// }

// int GetMininArr(int[] array)
// {
//     int min = array[0];
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] < min)
//         {
//             min = array[i];
//         }
//     }
//     return min;
// }

// int result = GetMaxinArr(array) - GetMininArr(array);

// Console.WriteLine(string.Join(", ", array));
// Console.WriteLine(GetMaxinArr(array));
// Console.WriteLine(GetMininArr(array));
// Console.WriteLine(result);


// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
// bool IsNumber = int.TryParse(Console.ReadLine(), out int length);
// if (!IsNumber || length == 0)
// {
//     Console.WriteLine("Invalid input");
//     return;
// }

// int[] array = new int[length];
// Random rand = new Random();
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = rand.Next(-99, 99);
// }

// int GetSumOddNums(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(i % 2 == 0)
//         {
//             count += array[i];
//         }
//     }
//     return count;
// }

// Console.WriteLine(string.Join(",", array));
// Console.WriteLine(GetSumOddNums(array));








// // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// // Напишите программу, которая покажет количество чётных чисел в массиве.
// // [345, 897, 568, 234] -> 2
// bool IsNumber = int.TryParse(Console.ReadLine(), out int length);
// if (!IsNumber)
// {
//     Console.WriteLine("Invalid input");
//     return;
// }

// int[] array = new int[length];
// Random rand = new Random();
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = rand.Next(100, 999);
// }

// int GetSumEvenNums(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] % 2 == 0)
//         {
//             count++;
//         }
//     }
//     return count;
// }

// Console.WriteLine(string.Join(",", array));
// Console.WriteLine(GetSumEvenNums(array));




// bool IsNumber = int.TryParse(Console.ReadLine(), out int length);
// if (!IsNumber)
// {
//     Console.WriteLine("Invalid input");
//     return;
// }

// int[] array = new int[length];
// Random rand = new Random();
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = rand.Next(-9, 9);
// }

// int SumPositive(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] > 0)
//         {
//             count += array[i];
//         }
//     }
//     return count;
// }

// int SumNegative(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] < 0)
//         {
//             count += array[i];
//         }
//     }
//     return count;
// }

// Console.WriteLine(string.Join(",", array));
// Console.WriteLine(SumPositive(array));
// Console.WriteLine(SumNegative(array));


// Задача 29: Напишите программу, которая задаёт 
// массив из 8 элементов и выводит их на экран.
// Console.Write("How many elements will in the array: ");
// int dimension = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[dimension];

// int[] BuildArr(int[] arr, int dimension)
// {
//     int count = 1;    
//     while(count < dimension + 1)
//     {
//         Console.Write($"Input {count} element of the array: ");
//         arr[count - 1] = Convert.ToInt32(Console.ReadLine());
//         count ++;
//     }
//     return arr;
// }

// void PrintArr(int[] arr)
// {
//     Console.Write('[');
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i == arr.Length - 1)
//         {
//             Console.Write($"{arr[i]}");
//         }
//         else
//         {
//             Console.Write($"{arr[i]},");
//         }
//     }
//     Console.WriteLine(']');
// }

// BuildArr(arr, dimension);
// PrintArr(arr);


// int[] array = new int[8];
// Random rand = new Random();

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = rand.Next(1, 100);
// }

// Console.WriteLine(string.Join(",", array));


// Задача 27: Напишите программу, которая принимает на вход 
// число и выдаёт сумму цифр в числе.
// using static System.Console;
// #nullable disable

// Write("Input a number: ");
// string number = ReadLine();

// bool CheckIfNum(string num)
// {
//     bool Xnum = int.TryParse(num, out int x);
//     if (Xnum != true)
//     {
//         return false;
//     }
//     return true;
// }

// int SumInNum(string number)
// {
//     int result = 0;
//     for (int i = 0; i < number.Length; i++)
//     {
//         int tonum;
//         char everyn = number[i];
//         tonum = everyn - '0';
//         result += tonum;
//     }
//     return result;
// }

// if (CheckIfNum(number))
// {
//     WriteLine($"The sum of digits in the number: {SumInNum(number)}");
// }
// else
// {
//     WriteLine("Wrong input");
// }






// Задача 25: Напишите цикл, который принимает на вход 
// два числа (A и B) и возводит число A в натуральную степень B.
// using static System.Console;
// #nullable disable

// Write("Input number а: ");
// int a = int.Parse(ReadLine());
// Write("Input number b: ");
// int b = int.Parse(ReadLine());

// int GetPower(int a, int b)
// {
//     int result = 1;
//     for (int i = 0; i < b; i++)
//     {
//         result *= a;
//     }
//     return result;
// }

// int numineq = GetPower(a, b);
// WriteLine($"{a} to the {b} power equals {numineq}");


// int[] arr = {2, 5, 5, 9, 1, 8, 8, 4, 3, 7, 6};

// void PrintArray(int [] array)
// {
//     int count = array.Length;
//     for (int i = 0;  i < count; i++)
//     {
//         Console.Write($"{arr[i]} ");
//     }
//     Console.WriteLine();
// }

// void SelectionSort(int[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int minPosition = i;

//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if (array[j] < array[minPosition]) minPosition = j;
//         }
        
//         int temporary = array[i];
//         array[i] = array[minPosition];
//         array[minPosition] = temporary;
//     }
// }


// PrintArray(arr);
// SelectionSort(arr);
// PrintArray(arr);


// string text = "- Я думаю, - сказал князь, улыбаясь, - что "
//             + "ежели бы вас послали вместо нашего милого Винценгероде,"
//             + "вы бы взяли приступом согласие прусского короля."
//             + "- Вы так красноречивы. Вы дадите мне чаю?";

// string Replace (string text, char oldValue, char newValue)
// {
//     string result = String.Empty;
//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if(text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }

//     return result;
// }

// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);


// Задача 23
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

// int num = Convert.ToInt32(Console.ReadLine());

// int[] CubeTable(int num)
// {
//     if (num > 0)
//     {
//         int count = 0;
//         int[] table = new int[num];
//         while (count != num)
//         {
//             table[count] = Convert.ToInt32(Math.Pow(count + 1, 3));
//             count ++;
//         }
//         return table;
//     }
//     if (num <= 0)
//     {
//         int count = 1;
//         int[] table = new int[num];
//         while (count != num)
//         {
//             table[count] = Convert.ToInt32(Math.Pow(count, 3));
//             count --;
//         }
//         return table;
//     }
//     int[] mist = {0};
//     return mist;
// }

// Console.WriteLine(string.Join(",", CubeTable(num)));


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

// int x1 = Convert.ToInt32(Console.ReadLine());
// int y1 = Convert.ToInt32(Console.ReadLine());
// int z1 = Convert.ToInt32(Console.ReadLine());

// int x2 = Convert.ToInt32(Console.ReadLine());
// int y2 = Convert.ToInt32(Console.ReadLine());
// int z2 = Convert.ToInt32(Console.ReadLine());

// double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
// {
//     double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
//     return result;
// }

// Console.WriteLine(Math.Round(Distance(x1, y1, z1, x2, y2, z2), 2));


//Задача 19. Напишите программу, которая принимает на вход пятизначное число
//и проверяет, является ли оно палиндромом.
// string? num = Console.ReadLine();

// bool IsPalindromeOddNum(string num)
// {
//     int count = 0;
//     int thesamenums = 0;
//     while (count != ((num.Length - 1) / 2))
//     {
//         if (num[count] == num[(num.Length - 1) - count])
//         {
//              thesamenums ++;
//         }
//        count ++;
//     }
//     if (thesamenums == (num.Length - 1) / 2)
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
// }

// if (IsPalindromeOddNum(num))
// {
//     Console.WriteLine("The number IS a palindrome");
// }

// if (!IsPalindromeOddNum(num))
// {
//     Console.WriteLine("The number is NOT a palindrome");
// }





// string? num = Console.ReadLine();

// int CheckIfNum(string num)
// {
//     bool Xnum = int.TryParse(num, out int x);
//     if (Xnum != true)
//     {
//         Console.WriteLine("This is not a number");
//     }
//     return x;
// }

// CheckIfNum(num);

// Console.WriteLine("Введите x:");
// bool Xnum = int.TryParse(Console.ReadLine(), out int x);
// Console.WriteLine("Введите y:");
// bool Ynum = int.TryParse(Console.ReadLine(), out int y);

// if (Xnum != true || Ynum != true)
// {
//     Console.WriteLine("Числа введены не верно");
//     return;
// }


// int GetPosition(int x, int y)
// {
//     if (x > 0 && y > 0)
//     {
//         return 1;
//     }

//     if (x < 0 && y > 0)
//     {
//         return 2;
//     }

//     if (x < 0 && y < 0)
//     {
//         return 3;
//     }

//     if (x > 0 && y < 0)
//     {
//         return 4;
//     }
    
//     return -1;
// }

// Console.WriteLine(GetPosition(x, y));


// // Задача 15: Напишите программу, которая принимает на вход цифру, 
// // обозначающую день недели, и проверяет, является ли этот день выходным.
// int num = Convert.ToInt32(Console.ReadLine());

// if (num >= 1 & num <= 7)
// {
//     if (num == 6 ^ num == 7)
//     {
//         Console.WriteLine("Выходной день");
//     }
//     else
//     {
//         Console.WriteLine("Будний день");
//     }
// }
// else
// {
//     Console.WriteLine("Неверный ввод. Наберите цифру с 1 до 7");
// }





// Задача 13: Напишите программу, которая выводит 
// третью цифру заданного числа или сообщает, что третьей цифры нет.

// void ThirdNum(int num)
// {
//     int count = 0;
//     int sumnum = num;
// while(sumnum > 1) // выясняем, сколько цифр в числе
//     {
//         sumnum = sumnum / 10;
//         count++;
//     }

//     int rightminus = count - 3; // определяем, скольк цифр справа до третьей цифры числа слева

//     if (rightminus < 0)
//     {
//         Console.WriteLine("Третьей цифры нет");
//     }
//     else
//     {
//         while(rightminus != 0) // уменьшаем изначальное число до трёхзначного
//         {
//             num = num / 10;
//             rightminus--;
//         }
//         int result = num % 10; // вычисляем результат - третью цифру, если она тут есть
//         Console.WriteLine($"Третья цифра числа: {result}");
//     }
// }

// int num = Convert.ToInt32(Console.ReadLine());
// ThirdNum(num);



// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
// int SecondNum(int x)
// {
//     int twodigit = x / 10;
//     int result = twodigit % 10;
//     return result;
// }

// int randnum = new Random().Next(100, 1000);
// Console.WriteLine($"Входящее число: {randnum}");
// Console.WriteLine($"Вторая цифра числа: {SecondNum(randnum)}");


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