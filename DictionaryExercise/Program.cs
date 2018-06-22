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

            int tempInt;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                int.TryParse(str[i].ToString(), out tempInt);
                if (dict.ContainsKey(tempInt))
                {
                    dict[tempInt]++;
                }
                else
                {
                    dict.Add(tempInt, 1);
                }
            }

            foreach (var member in dict)
            {
                Console.WriteLine($"Key: {member.Key}\tValue: {member.Value}");
            }
        }
    }
}
