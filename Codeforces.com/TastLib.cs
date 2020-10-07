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










    */

    }
}
