﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Codeforces.com
{
    class TastLib
    {
        /*
        // Арбуз
В один из жарких летних дней Петя и его друг Вася решили купить арбуз. Они выбрали самый большой и самый спелый, на их взгляд. 
После недолгой процедуры взвешивания весы показали w килограмм. Поспешно прибежав домой, изнемогая от жажды, ребята начали делить 
приобретенную ягоду, однако перед ними встала нелегкая задача. Петя и Вася являются большими поклонниками четных чисел, поэтому хотят 
поделить арбуз так, чтобы доля каждого весила именно четное число килограмм, при этом не обязательно, чтобы доли были равными по 
величине. Ребята очень сильно устали и хотят скорее приступить к трапезе, поэтому Вы должны подсказать им, удастся ли поделить арбуз, 
учитывая их пожелание. Разумеется, каждому должен достаться кусок положительного веса.

Входные данные
В первой и единственной строке входных данных записано целое число w (1 ≤ w ≤ 100) — вес купленного ребятами арбуза.

Выходные данные
Выведите YES, если ребята смогут поделить арбуз на две части, каждая из которых весит четное число килограмм, и NO в противном случае.

Примеры
входные данныеСкопировать
8
выходные данныеСкопировать
YES
Примечание
Например, ребята могут поделить арбуз на две части размерами 2 и 6 килограммов соответственно (другой вариант — две части 4 и 4 килограмма).


        string name = Console.ReadLine();
        int w = Convert.ToInt32(name);

        if (w % 2 == 0 && w >= 4)
        {
            Console.WriteLine("YES");
        }
        else 
        { 
            Console.WriteLine("NO"); 
        }



||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||



        // A. Слишком длинные слова
Иногда некоторые слова вроде «localization» или «internationalization» настолько длинны, что их весьма утомительно писать много раз в каком либо 
тексте.
Будем считать слово слишком длинным, если его длина строго больше 10 символов. Все слишком длинные слова можно заменить специальной аббревиатурой.
Эта аббревиатура строится следующим образом: записывается первая и последняя буква слова, а между ними — количество букв между первой и последней 
буквой (в десятичной системе счисления и без ведущих нулей).
Таком образом, «localization» запишется как «l10n», а «internationalization» как «i18n».
Вам предлагается автоматизировать процесс замены слов на аббревиатуры. При этом все слишком длинные слова должны быть заменены аббревиатурой, 
а слова, не являющиеся слишком длинными, должны остаться без изменений.

Входные данные
В первой строке содержится целое число n (1 ≤ n ≤ 100). В каждой из последующих n строк содержится по одному слову. Все слова состоят из малых 
латинских букв и имеют длину от 1 до 100 символов.

Выходные данные
Выведите n строк. В i строке должен находиться результат замены i-го слова из входных данных.

Примеры
входные данныеСкопировать
4
word
localization
internationalization
pneumonoultramicroscopicsilicovolcanoconiosis
выходные данныеСкопировать
word
l10n
i18n
p43s


        //Console.WriteLine("Сколько слов вы хотите ввести?");
        int elCount = int.Parse(Console.ReadLine());
        string[] wordArr = new string[elCount];
        for (int i = 0; i < wordArr.Length; i++)
        {
            wordArr[i] = Console.ReadLine();
        }
        for (int i = 0; i < elCount; i++)
        {
            string dlina = wordArr[i];
            int dlina2 = dlina.Length;

            if (dlina2 > 10)
            {
                Console.WriteLine(dlina[0] + $"{dlina2 - 2}" + dlina[dlina2 - 1]);
            } else
            {
                Console.WriteLine(wordArr[i]);
            }
        }



||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||



        //A. Команда
Однажды трое лучших друзей Петя, Вася и Тоня решили создать команду и участвовать в соревновании по программированию. Обычно на соревнованиях 
по программированию участникам предлагается несколько задач. Еще перед началом друзья договорились, что они будут реализовывать задачу, 
если как минимум двое из них придумали и уверены в решении, в противном случае ребята не будут писать решение этой задачи.
На этом соревновании организаторы предложили n задач. Для каждой задачи известно, кто из друзей придумал и уверен в ее решении. Помогите друзьям 
найти количество задач, по которым они будут писать решение.

Входные данные
В первой строке входных данных записано единственное целое число n (1 ≤ n ≤ 1000) — количество задач на соревновании. Далее в n строках записано 
по три целых числа, каждое из которых равно 0 или 1. Если первое число в строке равно 1, то Петя уверен в решении этой задачи, в противном
случае он не уверен в решении. Второе число обозначает мнение Васи, а третье — мнение Тони. Числа в строках разделены пробелами.

Выходные данные
Выведите единственное целое число — количество задач, которые друзья будут реализовывать на соревновании.

Примеры
входные данныеСкопировать
3
1 1 0
1 1 1
1 0 0
выходные данныеСкопировать
2
входные данныеСкопировать
2
1 0 0
0 1 1
выходные данныеСкопировать
1

Примечание
В первом примере решение первой задачи знают Петя и Вася, а решение второй знают все трое. Значит, они будут писать решения по этим задачам. 
Решение третьей задачи знает только Петя, но этого недостаточно, и друзья не будут ее писать.
Во втором примере друзья будут реализовывать только вторую задачу, так как ее решение знают Вася и Тоня.

        int n = int.Parse(Console.ReadLine());
        string[] tasks = new string[n];
        int count = 0;
        for (int i = 0; i < tasks.Length; i++)
        {
            tasks[i] = Console.ReadLine();
        }

        for (int i = 0; i < tasks.Length; i++)
        {
            if (tasks[i] == "110" || tasks[i] == "101" || tasks[i] == "011" || tasks[i] == "111")
            {
                count++;
            }
        }
        Console.WriteLine(count);


||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||


        //A. Команда
«Участник выходит в следующий раунд соревнований, если он набрал не меньше баллов, чем участник, занявший k-е место, при условии, что 
набранное им число баллов строго положительно...» — выдержка из правил соревнований.
Всего в соревновании было n участников (n ≥ k), и вам уже известны их баллы. Определите, сколько участников выйдет в следующий раунд.

Входные данные
В первой строке входных данных записаны два целых числа n и k (1 ≤ k ≤ n ≤ 50), разделенных единичным пробелом.

Во второй строке записаны n целых чисел, разделенных единичными пробелами, a1, a2, ..., an (0 ≤ ai ≤ 100), где ai — количество баллов, 
набранных участником на i-ом месте. Числа в заданной последовательности не возрастают (то есть для всех i от 1 до n - 1 
выполняется ai ≥ ai + 1).

Выходные данные
Выведите одно целое число — искомое количество участников, в соответствии с правилами.

Примеры
входные данныеСкопировать
8 5
10 9 8 7 7 7 5 5
выходные данныеСкопировать
6
входные данныеСкопировать
4 2
0 0 0 0
выходные данныеСкопировать
0

Примечание
В первом примере участник на 5ом месте набрал 7 баллов. Так как участник на 6ом месте тоже набрал 7 баллов, то в следующий раунд выходят 6 участников.
Во втором примере никто не набрал положительного количества баллов.



        //input
        int n = int.Parse(Console.ReadLine());
        string[] tasks = new string[n];
        int count = 0;
        int sum = 0;
        for (int i = 0; i < tasks.Length; i++)
        {
            tasks[i] = Console.ReadLine();
        }

        //solution
        for (int i = 0; i < tasks.Length; i++)
        {
            char[] s = tasks[i].ToCharArray();
            for (int j = 0; j < s.Length; j++)
            {
                if (s[j] == ' ')
                {
                    continue;
                }
                sum += (int)char.GetNumericValue(s[j]);
            }
            if (sum >= 2)
            {
                count++;
            }
            sum = 0;
        }
        Console.WriteLine(count);




||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||


        
            // A.Следующий раунд
«Участник выходит в следующий раунд соревнований, если он набрал не меньше баллов, чем участник, занявший k-е место, при условии, что набранное 
им число баллов строго положительно...» — выдержка из правил соревнований.
Всего в соревновании было n участников (n ≥ k), и вам уже известны их баллы. Определите, сколько участников выйдет в следующий раунд.

Входные данные
В первой строке входных данных записаны два целых числа n и k (1 ≤ k ≤ n ≤ 50), разделенных единичным пробелом.

Во второй строке записаны n целых чисел, разделенных единичными пробелами, a1, a2, ..., an (0 ≤ ai ≤ 100), где ai — количество баллов, набранных участником на i-ом месте. Числа в заданной последовательности не возрастают (то есть для всех i от 1 до n - 1 выполняется ai ≥ ai + 1).

Выходные данные
Выведите одно целое число — искомое количество участников, в соответствии с правилами.

Примеры
входные данныеСкопировать
8 5
10 9 8 7 7 7 5 5
выходные данныеСкопировать
6
входные данныеСкопировать
4 2
0 0 0 0
выходные данныеСкопировать
0

Примечание
В первом примере участник на 5ом месте набрал 7 баллов. Так как участник на 6ом месте тоже набрал 7 баллов, то в следующий раунд выходят 6 
участников. Во втором примере никто не набрал положительного количества баллов.



            //инпут строка 1
            string a = Console.ReadLine();
            string[] nk = a.Split(); // разбивает строки от пробела до пробела
            int[] aa = new int[nk.Length]; // создали пустой интовый массив
            for (int i = 0; i < nk.Length; i++)
            {
                aa[i] = Convert.ToInt32(nk[i]); //конвертнули стринг массив в другой инт массив
            }

            //инпут строка 2
            string b = Console.ReadLine();
            string[] pp = b.Split(); // разбивает строки от пробела до пробела
            int[] strPoints = new int[pp.Length]; // создали пустой интовый массив
            for (int i = 0; i < pp.Length; i++)
            {
                strPoints[i] = Convert.ToInt32(pp[i]); //конвертнули стринг массив в другой инт массив
            }

            // логика
            int sum = 0;
            int index = aa[1] - 1;
            int count = 0;
            for (int i = 0; i < strPoints.Length; i++)
            {
                if (strPoints[index] <= strPoints[i])
                {
                    sum += strPoints[i];
                    if (strPoints[i] == 0)
                    {
                        continue;
                    } else
                    {
                        count++;
                    }
                }
                if (sum == 0)
                {
                    count = 0;
                }
            }
            Console.WriteLine(count);




||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||



            //A. Укладка доминошками
Дана прямоугольная клеточная доска размера M × N клеток. Также дано неограниченное количество стандартных доминошек размера 2 × 1 клетку. 
Доминошки можно поворачивать. Требуется уложить как можно больше доминошек на доску так, чтобы соблюдались следующие условия:
1. Каждая доминошка полностью покрывает две клетки доски.
2. Никакие две доминошки не перекрываются.
3. Каждая доминошка полностью лежит внутри доски. Касание краев доски допускается.
Найдите максимальное количество доминошек, которое можно уложить с данными ограничениями.

Входные данные
В единственной строке записано два целых числа M и N — размеры доски в клетках (1 ≤ M ≤ N ≤ 16).

Выходные данные
Выведите одно число — максимальное количество доминошек, которое можно уложить.

Примеры
входные данныеСкопировать
2 4
выходные данныеСкопировать
4
входные данныеСкопировать
3 3
выходные данныеСкопировать
4




            string input = Console.ReadLine();
            string[] temp = input.Split();
            int[] mn = new int[temp.Length]; // создали пустой интовый массив
            for (int i = 0; i < temp.Length; i++)
            {
                mn[i] = Convert.ToInt32(temp[i]);
            }

            int result = (mn[0] * mn[1]) / 2;
            Console.WriteLine(result);



            int x = 0;
            string nn = Console.ReadLine(); // съели цифру
            int n = int.Parse(nn); // перевели цифру в int
            string[] lines = new string[n]; //положили цифру в объем массива
            //инициализируем строки в массив
            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = Console.ReadLine();  //съели строки и положили в массив
            }
                   
            //логика1
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i] == "X++" || lines[i] == "++X")
                {
                    x++;
                }
                else
                {
                    x--;
                }
            }
            Console.WriteLine(x);
        
            //логика2 - не решено без тупого подхода как в логике 1
            for (int i = 0; i < lines.Length; i++)
            {

            }
            string x1 = lines[0];
            string x2 = lines[1];
            int i1 = Convert.ToInt32(x1);
            x = i1;
            Console.WriteLine(x);




||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||



            //A.Петя и строки
Маленький Петя очень любит подарки. Его мама подарила ему на день рождения две строки равной длины, состоящие из больших и маленьких букв 
латинского алфавита. Теперь Петя хочет сравнить эти строки лексикографически. При этом регистр букв значения не имеет, то есть большая 
буква считается эквивалентной соответствующей маленькой букве. Помогите Пете выполнить сравнение.

Входные данные
В каждой из первых двух строк записано по одной подаренной строке. Длина строк находится в пределах от 1 до 100 включительно. Гарантируется, что строки имеют одинаковую длину, а также состоят из больших и маленьких букв латинского алфавита.

Выходные данные
Если первая строка меньше второй, выведите «-1». Если вторая строка меньше первой, выведите «1». Если строки равны, выведите «0». Учтите, что регистр букв не учитывается при сравнении.

Примеры
входные данныеСкопировать
aaaa
aaaA
выходные данныеСкопировать
0
входные данныеСкопировать
abs
Abz
выходные данныеСкопировать
-1
входные данныеСкопировать
abcdefg
AbCdEfF
выходные данныеСкопировать
1



            //string[] alf = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            string[] input = new string[2];
            //инпут 2 строк
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = Console.ReadLine().ToUpper();
            }

            //разбил строки в массивы
            char[] line1 = input[0].ToCharArray();
            char[] line2 = input[1].ToCharArray();
            int[] sum = new int[2];

            //посчитали
            for (int i = 0; i < sum.Length; i++)
            {
                for (int j = 0; j < line1.Length; j++)
                {
                    for (int k = 0; k < alf.Length; k++)
                    {
                        if (line1[j].ToString() == alf[k])
                        {
                            sum[i] += k + 1;
                            break;
                        }
                    }
                }
                line1 = line2;
            }

            //вывели
            if (sum[0] == sum[1])
            {
                Console.WriteLine("0");
            }
            else if (sum[0] > sum[1])
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("-1");
            }



            Console.WriteLine(String.Compare(input[0], input[1]));

            int Compare(object x, object y)
            {
                string s1 = x as string;
                string s2 = y as string;
                //negate the return value to get the reverse order
                return -String.Compare(s1, s2);
            }
            













    */

    }
}