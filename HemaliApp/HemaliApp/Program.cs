using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HemaliApp
{
    class Program
    {
        static LinkedList<int> FindIntersection(LinkedList<int> list1, LinkedList<int> list2)
        {
            LinkedList<int> intersection = new LinkedList<int>();

            HashSet<int> set = new HashSet<int>();

            foreach (int node in list1)
            {
                set.Add(node);
            }

            foreach (int node in list2)
            {
                if (set.Contains(node))
                {
                    intersection.AddLast(node);
                }
            }

            return intersection;
        }

        static void ExecuteFindIntersection()
        {
            LinkedList<int> list1 = new LinkedList<int>();
            LinkedList<int> list2 = new LinkedList<int>();

            list1.AddLast(12);
            list1.AddLast(7);
            list1.AddLast(8);
            list1.AddLast(13);
            list1.AddLast(2);
            list1.AddLast(18);

            list2.AddLast(1);
            list2.AddLast(7);
            list2.AddLast(13);
            list2.AddLast(4);
            list2.AddLast(18);

            LinkedList<int> intersection = FindIntersection(list1, list2);

            Console.Write("List 1: ");
            foreach (int node in list1)
            {
                Console.Write(node + " ");
            }
            Console.WriteLine();

            Console.Write("List 2: ");
            foreach (int node in list2)
            {
                Console.Write(node + " ");
            }
            Console.WriteLine();

            Console.Write("Intersection: ");
            foreach (int node in intersection)
            {
                Console.Write(node + " ");
            }
            Console.WriteLine();
        }

        static int GetCharacterCount(string str, char targetChar)
        {
            int count = 0;

            foreach (char c in str)
            {
                if (c == targetChar)
                {
                    count++;
                }
            }

            return count;
        }

        static void ExecuteGetCharacterCount(string str, char c)
        {
            Console.WriteLine(str + " " + c + " " + GetCharacterCount(str, c));
        }
        static void ExecuteGetCharacterCount()
        {
            ExecuteGetCharacterCount("madam", 'm');
            ExecuteGetCharacterCount("madaM", 'm');
            ExecuteGetCharacterCount("madaM", 'a');
        }

        static void TempFunction()
        {
            int[] arr = new int[] { 0, 1, 2, 3, 4, 5 };
            Console.WriteLine(arr);
        }

        static char GetMostFreqCount(string str)
        {
            Dictionary<char, int> charCountMap = new Dictionary<char, int>();

            char mostFreqChar = ' ';
            int mostFreqCharCount = 0;

            foreach (char c in str)
            {
                if (charCountMap.ContainsKey(c))
                {
                    charCountMap[c] = charCountMap[c] + 1;
                }
                else
                {
                    charCountMap[c] = 1;
                }

                if (charCountMap[c] > mostFreqCharCount)
                {
                    mostFreqChar = c;
                    mostFreqCharCount = charCountMap[mostFreqChar];
                }
            }

            return mostFreqChar;
        }

        static Dictionary<char, int> GetCharacterCounts(string str)
        {
            Dictionary<char, int> charCountMap = new Dictionary<char, int>();

            foreach (char c in str)
            {
                if (charCountMap.ContainsKey(c))
                {
                    charCountMap[c] = charCountMap[c] + 1;
                }
                else
                {
                    charCountMap[c] = 1;
                }
            }

            return charCountMap;
        }

        static void Main(string[] args)
        {
            //ExecuteFindIntersection();
            //ExecuteGetCharacterCount();
            //TempFunction();

            //char output = GetMostFreqCount("madam");
            //Console.WriteLine(output);

            var charCountMap = GetCharacterCounts("madam");
            foreach (var pair in charCountMap)
            {
                Console.WriteLine(pair.Key + " " + pair.Value);
            }
        }
    }
}
