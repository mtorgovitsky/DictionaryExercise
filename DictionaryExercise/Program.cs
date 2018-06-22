using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "734325428374583475";

            Dictionary<int, int> dict = new Dictionary<int, int>();

            int temp1;

            for (int i = str.Length - 1; i >= 0; i--)
            {
                int.TryParse(str[i].ToString(), out temp1);
                if (dict.ContainsKey(temp1))
                {
                    dict[temp1]++;
                }
                else
                {
                    dict.Add(temp1, 1);
                }
            }

            foreach (var member in dict)
            {
                Console.WriteLine($"Key: {member.Key}\tValue: {member.Value}");
            }

            long l = 3274737547674527;
            int counter = 0;
            long temp2 = l % 10;
            for (; l > 0; temp2 = l % 10)
            {
                if (temp2 == 7)
                {
                    counter++;
                }
                l -= temp2;
                l /= 10;
            }

            Console.Write($"The 7 Number appears {counter} times\n");
        }
    }
}
