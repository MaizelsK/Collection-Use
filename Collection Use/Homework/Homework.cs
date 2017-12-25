using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Use
{
    public class Homework
    {
        static public void HomeWork()
        {
            Random random = new Random();
            List<int> list = new List<int>();

            int evenNumberSum = 0;
            int maxValuePos = 0;

            for (int i = 0; i < 10; i++)
            {
                var randomNumber = random.Next(0, 100);

                list.Add(randomNumber);

                if (i % 2 == 0) evenNumberSum += randomNumber;

                if (randomNumber > list[maxValuePos]) maxValuePos = i;
            }

            List<int> tempList = new List<int>(list);

            tempList.Remove(list[maxValuePos]);

            int secondMaxValue = tempList[0];
            int secondMaxValuePos = 0;

            tempList.Sort();
            secondMaxValue = tempList[tempList.Count - 1];

            for (int i = 0; i < list.Count; i++)
                if (secondMaxValue == list[i])
                {
                    secondMaxValuePos = i;
                    break;
                }

            foreach (var number in list)
                Console.Write(number + " ");

            Console.WriteLine("\n\nСумма элементов на четных позициях: {0}", evenNumberSum);

            Console.WriteLine("\nВторое максимальное чилсо: {0} ({1} позиция)", secondMaxValue, secondMaxValuePos);

            Console.ReadLine();
        }
    }
}
