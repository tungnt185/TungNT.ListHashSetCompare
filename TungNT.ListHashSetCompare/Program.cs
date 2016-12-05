using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TungNT.ListHashSetCompare
{
    class Program
    {
        static void Main(string[] args)
        {
            ListOperation();

            HashSetOperation();

            ListHashSetPerformanceBenchmark();

            Console.Read();
        }

        private static void ListOperation()
        {
            var intList = new List<int>(100);

            intList.Add(5);
            intList.RemoveAt(0);

            //Add item at index
            intList.Insert(0, 10);
            intList.Insert(1, 7);

            var first = intList[0];

            // Index of an item
            var index = intList.IndexOf(4);

            // Check List contains item
            bool contain = intList.Contains(4);

            // Iterate over all objects
            foreach (var item in intList)
                Console.WriteLine(item);
        }

        private static void HashSetOperation()
        {
            var intHashSet = new HashSet<int>() { 1, 2, 3, 4, 5 };

            intHashSet.Add(10);
            intHashSet.Remove(5);

            //Check Set contains item
            bool contain = intHashSet.Contains(1);

            // Iterate over all objects
            foreach (var item in intHashSet)
                Console.WriteLine(item);

            //Delete all items
            intHashSet.Clear();
        }

        private static void ListHashSetPerformanceBenchmark()
        {
            //const int COUNT = 50; 
            const int COUNT = 50000;

            HashSet<int> intHashSet = new HashSet<int>();
            Stopwatch stopWatch = new Stopwatch();
            for (int i = 0; i < COUNT; i++)
            {
                intHashSet.Add(i);
            }

            stopWatch.Start();
            for (int i = 0; i < COUNT; i++)
            {
                intHashSet.Contains(i);
            }
            stopWatch.Stop();

            Console.WriteLine(stopWatch.Elapsed);

            stopWatch.Reset();
            List<int> intList = new List<int>();
            for (int i = 0; i < COUNT; i++)
            {
                intList.Add(i);
            }

            stopWatch.Start();
            for (int i = 0; i < COUNT; i++)
            {
                intList.Contains(i);
            }
            stopWatch.Stop();

            Console.WriteLine(stopWatch.Elapsed);
        }
    }
}
