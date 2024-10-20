using System;
using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ArrayHomework
{
    internal class FirstArray
    {
        //ДЗ: Работа с конкретными строками/столбцами
        //Дан двумерный массив.
        //Вычислить сумму второй строки и произведение первого столбца.
        //Вывести исходную матрицу и результаты вычислений.

        //static void Main(string[] args)
        //{
        //    int resultLine = 0;
        //    int resultColumn = 1;

        //    int[,] arrayDimensional = new int[3, 5]
        //    {
        //        { 2, 4, 5, 6, 7 },
        //        { 3, 7, 8, 9, 1 },
        //        { 1, 3, 4, 5, 6 }
        //    };

        //    for (int i = 0; i < arrayDimensional.GetLength(0); i++)
        //    {
        //        resultColumn *= arrayDimensional[i, 0];

        //    }

        //    for (int j = 0; j < arrayDimensional.GetLength(1); j++)
        //    {
        //        resultLine += arrayDimensional[1, j];
        //    }

        //    Console.WriteLine(resultColumn + " " + " Произведение столбца.");
        //    Console.WriteLine();
        //    Console.WriteLine(resultLine + " " + " Сумма строки.");
        //    Console.WriteLine();
        //    Console.WriteLine("Исходная матрица");

        //    for (int g = 0; g < arrayDimensional.GetLength(0); g++)
        //    {
        //        for (int k = 0; k < arrayDimensional.GetLength(1); k++)
        //        {
        //            Console.Write(arrayDimensional[g, k] + " ");
        //        }
        //        Console.WriteLine();
        //    }
        //}
    }

    internal class SecondArray
    {
        //ДЗ: Наибольший элемент
        //Найти наибольший элемент матрицы A(10,10)
        //и записать ноль в те ячейки, где он находятся.
        //Вывести наибольший элемент, исходную и полученную матрицу. 
        //Массив под измененную версию не нужен.

        //static void Main(string[] args)
        //{
        //    int maxValue = int.MinValue;
        //    int maxValueNull = 0;
        //    int[,] arrayGreatest = new int[10, 10];
        //    Random random = new Random();
        //    Console.WriteLine("Old Array");
        //    cicleArray(ref maxValue, arrayGreatest, random);
        //    Console.WriteLine("New Array");
        //    newCicle(ref maxValue, arrayGreatest, ref maxValueNull, random);
        //}

        //static void cicleArray(ref int maxValue, int[,] arrayGreatest, Random random)
        //{
        //    cicleСountableOldArray(ref maxValue, arrayGreatest, random);
        //    Console.WriteLine(maxValue + " MaxValue");
        //    Console.WriteLine();
        //}

        //static void cicleСountableOldArray(ref int maxValue, int[,] arrayGreatest, Random random)
        //{
        //    for (int i = 0; i < arrayGreatest.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < arrayGreatest.GetLength(1); j++)
        //        {
        //            arrayGreatest[i, j] = random.Next(100);
        //            Console.Write(arrayGreatest[i, j] + " ");
        //            if (arrayGreatest[i, j] > maxValue)
        //            {
        //                maxValue = arrayGreatest[i, j];
        //            }
        //        }
        //        Console.WriteLine();
        //    }
        //}

        //static void newCicle(ref int maxValue, int[,] arrayGreatest, ref int maxValueNull, Random random)
        //{
        //    cicleСountableOldArray(ref maxValue, arrayGreatest, random);
        //    int temp = maxValue;
        //    maxValue = maxValueNull;
        //    Console.WriteLine(maxValueNull + " MaxValue");
        //}
    }

    internal class Thiried
    {
        //    ДЗ: Локальные максимумы
        //Дан одномерный массив целых чисел из 30 элементов.
        //Найдите все локальные максимумы и вывести их.
        //(Элемент является локальным максимумом, если он больше своих соседей)
        //Крайний элемент является локальным максимумом, если он больше своего соседа.
        //Программа должна работать с массивом любого размера.
        //Массив всех локальных максимумов не нужен.

        //static void Main(string[] args)
        //{
        //    int[] arrayTwenty = new int[30];
        //    Random random = new Random();

        //    for (int i = 0; i < arrayTwenty.Length; i++)
        //    {
        //        arrayTwenty[i] = random.Next(100);
        //        int maxElement = int.MinValue;

        //        for (int j = 0; j < arrayTwenty.Length - 1; j++)
        //        {

        //            if (arrayTwenty[i] > arrayTwenty[j])
        //            {
        //                maxElement = arrayTwenty[i];
        //                arrayTwenty[arrayTwenty.Length - 1]--;
        //            }

        //            else if (arrayTwenty[i] < arrayTwenty[j])
        //            {
        //                maxElement = arrayTwenty[j];
        //                arrayTwenty[arrayTwenty.Length - 1]--;
        //            }

        //            else
        //            {
        //                Console.WriteLine("Числа ровны");
        //                break;
        //            }

        //            Console.WriteLine();
        //            Console.WriteLine($"{arrayTwenty[i]} {arrayTwenty[j]}  Массив");
        //            Console.WriteLine();
        //            Console.WriteLine(maxElement + " Локальный максимум");

        //        }
        //        Console.WriteLine();
        //    }
        //}
    }

    internal class FortyExercise
    {
        //ДЗ: Динамический массив

        //Пользователь вводит числа, и программа их запоминает.
        //Как только пользователь введёт команду sum, программа выведет сумму всех веденных чисел. 
        //Выход из программы должен происходить только в том случае, если пользователь введет команду exit.
        //Если введено не sum и не exit, значит это число и его надо добавить в массив.
        //В начале цикла надо выводить в консоль все числа, которые содержатся в массиве, а значит их ввел пользователь ранее. 
        //Программа должна работать на основе расширения массива.
        //Внимание, нельзя использовать List<T> и Array.Resize

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Команда 1 - 'exit' выход из программы.");
        //    Console.WriteLine("Команда 2 - 'sum' сложит массив чисел.");
        //    Console.WriteLine("Команда 3 - 'number' Введите число.");
        //    string comandArray = Console.ReadLine().ToLower();
        //    string exitComand = "exit";
        //    string sumComand = "sum";
        //    string numberComand = "number";
        //    int tempValue = 0;
        //    int newIndex = 0;

        //    while (true)
        //    {
        //        if (comandArray == numberComand)
        //        {
        //            int[] inputUserArray = new int[1];
        //            string numberArray = Console.ReadLine().ToLower();

        //            if (int.TryParse(numberArray, out int tryNumberArray))
        //            {
        //                Resize(ref inputUserArray, newIndex, inputUserArray.Length);

        //                tempValue += tryNumberArray;

        //                Console.WriteLine($"Вы вели число {numberArray}");

        //            }
        //            if (numberArray == sumComand)
        //            {
        //                Console.WriteLine($"Сумма цикла. {tempValue}");
        //                Console.ReadLine();
        //                break;
        //            }
        //            else if (numberArray == exitComand)
        //            {
        //                Console.WriteLine($"Цикл завершен! ");
        //                Console.Clear();
        //                break;
        //            }
        //        }
        //        else
        //        {
        //            Console.WriteLine("Бездействие. Самое утомительное занятие. ");
        //            Console.ReadLine();
        //            break;
        //        }
        //    }
        //}

        //static void Resize(ref int[] arrayUser, int newSize, int indexOld)
        //{
        //    int[] newArray = new int[arrayUser.Length + 1];
        //    newArray[indexOld] = newSize;

        //    for (int g = 0; g < indexOld; g++)
        //    {
        //        newArray[g] = arrayUser[g];
        //    }

        //    for (int k = indexOld; k < arrayUser.Length; k++)
        //    {
        //        newArray[k + 1] = arrayUser[k];
        //    }
        //    arrayUser = newArray;
        //}
    }

    internal class fiveExercise
    {
        // ДЗ: Подмассив повторений чисел

        //В массиве чисел найдите самый длинный подмассив из одинаковых чисел.
        //Дано 30 чисел.Вывести в консоль сам массив, число, которое само больше раз повторяется подряд и количество повторений.
        //Дополнительный массив не надо создавать.
        //Пример 1: {5, 5, 9, 9, 9, 5, 5} - число 9 повторяется 3 раза подряд.
        //Пример 2: { 5, 5, 5, 3, 3, 3, 3} - число 3 повторяется 4 раза подряд.

        //static void Main(string[] args)
        //{
        //    int[] arrayNumbers = new int[30];
        //    Random random = new Random();

        //    for (int i = 0; i < arrayNumbers.Length; i++)
        //    {
        //        arrayNumbers[i] = random.Next(1, 20);

        //        for (int j = 0; j <= arrayNumbers[i]; j++)
        //        {
        //            int repeat = j;
        //            for (int g = i; g <= arrayNumbers[j]; g++)
        //            {
        //                if (arrayNumbers[j] == arrayNumbers[i])
        //                {
        //                    ++j;
        //                    Console.Write(arrayNumbers[j] + " ");
        //                    Console.WriteLine($"число повторилось {repeat} раз.");
        //                }
        //            }
        //        }
        //    }
        //}

    }

    internal class sixExercise
    {
        //ДЗ: Сортировка чисел
        //Дан массив чисел(минимум 10 чисел).
        //Надо вывести в консоль числа отсортированы, от меньшего до большего.
        //Нельзя использовать Array.Sort.
        //Используйте пузырьковую сортировку.

        //static void Main(string[] args)
        //{
        //    int[] arrayTen = new int[10];
        //    Random random = new Random();
        //    int tempValue = 0;

        //    for (int i = 0; i < arrayTen.Length; i++)
        //    {
        //        arrayTen[i] = random.Next(1, 20);
        //        Console.Write(arrayTen[i] + " ");
        //    }
        //    Console.WriteLine();

        //    for (int g = 0; g < arrayTen.Length; g++)
        //    {
        //        for (int h = 0; h < arrayTen.Length - 1; h++)
        //        {
        //            if (arrayTen[h] > arrayTen[h + 1])
        //            {
        //                tempValue = arrayTen[h];
        //                arrayTen[h] = arrayTen[h + 1];
        //                arrayTen[h + 1] = tempValue;
        //            }
        //        }

        //    }

        //    for (int c = 0; c < arrayTen.Length; c++)
        //    {
        //        Console.Write(arrayTen[c] + " ");
        //    }
        //}
    }

    internal class sevenExercise
    {
        //ДЗ: Split

        //Дана строка с текстом, используя метод строки String.Split()
        //получить массив слов, которые разделены пробелом в тексте
        //и вывести массив, каждое слово с новой строки.

        //static void Main(string[] args)
        //{
        //    string words = "I'm really tired.";

        //    char[] charChar = new char[] {'.', ' '};

        //    foreach (var point in words.Split(charChar, StringSplitOptions.RemoveEmptyEntries))
        //    {
        //        Console.WriteLine(point);
        //    }

        //    Console.Read();
        //}
    }

    internal class eightExercise
    {
        //ДЗ: Сдвиг значений массива
        //Дан массив чисел.
        //Нужно его сдвинуть циклически
        //на указанное пользователем значение позиций влево,
        //не используя других массивов.
        //Пример для сдвига один раз:
        //{ 1, 2, 3, 4} => {2, 3, 4, 1}

        //static void Main(string[] args)
        //{
        //    int[] arrayAgain = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        //    int numberClient;
        //    int temp;

        //    for (int i = 0; i < arrayAgain.Length; i++)
        //    {
        //        Console.Write(arrayAgain[i] + " ");
        //    }

        //    Console.WriteLine();
        //    Console.WriteLine("Введите значение на которое нужно сдвинуть крайнее левое число, вправо.");
        //    int index = Convert.ToInt32(Console.ReadLine());

        //    for (int i = 0; i < arrayAgain.Length; i++)
        //    {
        //        numberClient = arrayAgain[0]; 
        //        temp = arrayAgain[index]; 
        //        arrayAgain[index] = numberClient;
        //        arrayAgain[0] = temp;

        //        Console.WriteLine();
        //        Console.Write(arrayAgain[i] + " ");
        //    }
        //}
    }

    internal class nineExercise
    {
        //    //ДЗ: Скобочное выражение
        //    //Дана строка из символов '(' и ')'. Определить, является ли она корректным скобочным выражением.
        //    //Определить максимальную глубину вложенности скобок.
        //    //Текущая глубина равняется разности открывающихся и закрывающихся скобок в момент подсчета каждого символа.
        //    //К символу в строке можно обратиться по индексу
        //    //Пример “(()(()))” - строка корректная и максимум глубины равняется 3.
        //    //Пример некорректных строк: "(()", "())", ")(", "(()))(()"

        //static void Main(string[] args)
        //{
        //    char[] args2 = { '(', ')', '(', ')', '(', ')', '(', ')', '(', ')', ')', '(' };
        //    int maxInside = 0;
        //    int depth = 0;

        //    for (int i = 0; i < args2.Length - 1; i++)
        //    {
        //        if (i != '(' + ')')
        //        {
        //            ++maxInside;
        //        }
        //        Console.Write(args2[i] + " ");
        //        depth = maxInside / 2;
        //    }
        //    Console.WriteLine();
        //    Console.WriteLine(depth);

        //}

    }
}