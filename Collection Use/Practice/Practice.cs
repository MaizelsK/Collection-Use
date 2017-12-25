using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Use
{
    public class Practice
    {
        static public void PracticeTask1()
        {
            Random random = new Random();
            ArrayList list = new ArrayList();

            for (int i = 0; i < 10; i++)
                list.Add(random.Next(-20, 20));

            foreach (var number in list)
                Console.Write(number + " ");

            Console.WriteLine("\n");

            for (int i = list.Count - 1; i >= 0; i--)
                if ((int)list[i] % 2 != 0) list.Remove(list[i]);

            foreach (var number in list)
                Console.Write(number + " ");

            Console.WriteLine();
            Console.ReadLine();
        }

        static public void PracticeTask2()
        {
            Random random = new Random();
            ArrayList list = new ArrayList();

            int sum = 0;
            double average;

            for (int i = 0; i < 10; i++)
            {
                list.Add(random.Next(-20, 20));
                sum += (int)list[i];
            }

            foreach (var number in list)
                Console.Write(number + " ");

            Console.WriteLine("\n");

            average = (double)sum / list.Count;

            Console.WriteLine("Среднее арифметическое коллекции: {0}\n", average);

            foreach (var number in list)
                if ((int)number > average) Console.Write(number + " ");

            Console.WriteLine(); Console.ReadLine();
        }
    }
}
