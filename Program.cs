// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// int m = 3;
// int n = 4;
// double[,] array = new double[m, n];
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i, j] = new Random().Next(-10, 10) + new Random().NextDouble();
//         array[i, j] = Math.Round(array[i, j], 1);
//         System.Console.Write(array[i, j] + "\t");
//     }
//     System.Console.WriteLine();
// }
// Решение с помощью метода 
// void ArrayDouble(int rows, int columns)
// {
//     double[,] array = new double[rows, columns];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(-10, 10) + new Random().NextDouble();
//             array[i, j] = Math.Round(array[i, j], 1);
//             System.Console.Write(array[i, j] + "\t");
//         }
//         System.Console.WriteLine();
//     }
// }
// ArrayDouble(10,10);




// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или 
// же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// System.Console.Write("Введите строку и строчку числа через запятую :");
// string indecesEntered = Console.ReadLine();
// int[] indeces = Array.ConvertAll(indecesEntered.Split(","), int.Parse);
// int indecesEnteredRow = indeces[0];
// int indecesEnteredColumns = indeces[1];
// int row = 5;
// int columns = 5;

// int[,] array = new int[row, columns];
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i, j] = new Random().Next(-5, 10);

//         System.Console.Write(array[i, j] + "\t");
//     }
//     System.Console.WriteLine();
// }

// if (indecesEnteredRow < row && indecesEnteredColumns < columns)
// {
//     string resultMessage = Convert.ToString(array[indecesEnteredRow, indecesEnteredColumns]);
//     System.Console.WriteLine("На позиции [{0}] находится {1}", indecesEntered, resultMessage);

// }
// else
//     System.Console.WriteLine("[{0}] такого елемента нет",indecesEntered);



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// int row = new Random().Next(3, 6);
// int columns = new Random().Next(3, 6);

// int[,] array = new int[row, columns];
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i, j] = new Random().Next(1, 10);

//         System.Console.Write(array[i, j] + "\t");
//     }
//     System.Console.WriteLine();
// }
// System.Console.WriteLine("среднее арифметическое :");
// for (int i = 0; i < array.GetLength(1); i++)
// {
//     double Average = 0;
//     int count = 0;
//     for (int j = 0; j < array.GetLength(0); j++)
//     {
//         Average = Average + array[j, i];
//         count++;

//     }
//     System.Console.Write($"{Math.Round(Average / count, 1)} \t");
// }

// 4 друга должны посетить 12 пабов, в котором выпить по британской пинте пенного напитка. 
// До каждого бара идти 15-20 минут, каждый пьет пинту за 15 минут. У первого друга лимит выпитого 1.1 литра, 
// у второго 1.5, у третьего 2.2 литра, у 4 - 3.3 литра, это их максимум. Необходимо выяснить, до скольки баров 
// смогут дойти каждый из друзей(Пройденное расстояние (в барах)), пока не упадет. И сколько всего времени будет потрачено на выпивку.



double[] drinkFriends = new double[4]; //кто сколько выпили
int[] pessedBars = new int[4];//кто сколько баров прошел
double[] drinkingTime = new double[4];//кто сколько потратил время на выпивку

int[] friendLimitit = { 1100, 1500, 2200, 3300 };//лимит друзей

double millilitersPinta = 568;
double timeforOnePint = 15;
int count = 0;

double millilitersBeerPerMinute = millilitersPinta / timeforOnePint;//количество выпитого пива за 1 минуту
millilitersBeerPerMinute=Math.Round(millilitersBeerPerMinute,2);
while (count < 12)
{
    for (int j = 0; j < 4; j++)
    {
        if (drinkFriends[j] != friendLimitit[j])
        {
            if (drinkFriends[j] + millilitersPinta < friendLimitit[j])
            {
                drinkFriends[j] = drinkFriends[j] + millilitersPinta;
                pessedBars[j]++;
                
            }
            else
            {
                drinkFriends[j]=friendLimitit[j];
                pessedBars[j]++;
            }

        }


    }
    count++;
}
for (int i = 0; i < 4; i++)
{
    drinkingTime[i]=friendLimitit[i]/millilitersBeerPerMinute;
    drinkingTime[i]=Math.Round(drinkingTime[i],2);
}

System.Console.WriteLine("       Прошли баров");
System.Console.WriteLine("Друг1 Друг2 Друг3 Друг4");
System.Console.WriteLine($"{string.Join(";     ", pessedBars)}");
System.Console.WriteLine();
System.Console.WriteLine("Потратили время на выпивку");
System.Console.WriteLine("Друг1  Друг2  Друг3  Друг4");
System.Console.WriteLine($"{string.Join("; ", drinkingTime)}");