using System;
using System.Collections.Generic;
using System.Text;

namespace Codeforces.com
{
    class TastLib
    {
        /*
        // Арбуз
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



        // A. Слишком длинные слова
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



        //A. Команда
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


        //A. Команда
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




            //A. Следующий раунд
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




            //A. Укладка доминошками
            string input = Console.ReadLine();
            string[] temp = input.Split();
            int[] mn = new int[temp.Length]; // создали пустой интовый массив
            for (int i = 0; i < temp.Length; i++)
            {
                mn[i] = Convert.ToInt32(temp[i]);
            }
 
            int result = (mn[0] * mn[1]) / 2;
            Console.WriteLine(result);
 


            //A. Bit++
            int x = 0;
            string nn = Console.ReadLine(); // съели цифру
            int n = int.Parse(nn); // перевели цифру в int
            string[] lines = new string[n]; //положили цифру в объем массива
            //инициализируем строки в массив
            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = Console.ReadLine();  //съели строки и положили в массив
            }
 
            //логика
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





            //A.Петя и строки
            //string[] alf = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            string[] input = new string[2];
            //инпут 2 строк
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = Console.ReadLine().ToUpper();
            }
 
            Console.WriteLine(String.Compare(input[0], input[1]));
 
            int Compare(object x, object y)
            {
                string s1 = x as string;
                string s2 = y as string;
                //negate the return value to get the reverse order
                return -String.Compare(s1, s2);
            }
 
 
            /*
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
            */
 






    */

    }
}
