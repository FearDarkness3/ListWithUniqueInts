using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListWithUniqueInts
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> test = CreateList();

            for (int i = 0; i < test.Count; i++)
            {
                Console.Write(test[i] + " ");
            }

            Console.ReadLine();
        }

        // We need a list of 10 000 ints within [1, 10 000] range. Basicly we need to fill the list with 10 000 ints and then shuffle it.
        // If we needed a list with only 5 000 ints we could take first 5 000 shuffled elements
         
        public static List<int> CreateList()
        {
            List<int> result = new List<int>(10000);

            // fill the list

            for (int i = 1; i <= result.Capacity; i++)
            {
                result.Add(i);
            }

            Shuffle(result);
            
            return result;
        }

        public static void Shuffle(List<int> data)
        {
            Random rand = new Random();
            int k = data.Count;

            while (k > 1)
            {
                int l = rand.Next(k--);

                int temp = data[k];
                data[k] = data[l];
                data[l] = temp;
            }
        }
    }
}
