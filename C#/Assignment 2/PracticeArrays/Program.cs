// See https://aka.ms/new-console-template for more information
using System.Collections;

namespace PracticeArrays
{
    class program
    {
        static void Main(String[] args)
        {

            //int[] primes = FindPrimesInRange(1, 10);
            //int[] rs = new int[4] {3,2,4,-1};
            //int[] rr = rotateArray(rs, 2);

            //int[] kk = new int[10] { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };
            //int[] k2 = new int[8] {1,1,1,2,3,1,3,3 };
            //int[] k3 = new int[9] {0,1,1,5,2,2,6,3,3};
            //LongestSequence(k2);

            int[] array = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3, 7, 7, 7, 0, 2, 2, 2, 0, 10, 10, 10 };
            FrqeuntNum(array);
        }
        /*1.Copying an Array*/

        static void cArray()
        {
            char[] fArray = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J' };
            char[] sArray = new char[fArray.Length];

            Console.Write("The First Array: ");
            for (int i = 0; i < fArray.Length; i++)
            {
                sArray[i] = fArray[i];
                Console.Write($"{fArray[i]} ");
            }
            Console.WriteLine();
            Console.Write("The Second Array: ");
            for (int i = 0; i < sArray.Length; i++)
            {

                Console.Write($"{sArray[i]} ");
            }
        }






        /*2.Write a simple program that lets the user manage a list of elements. */

        static void mList()
        {
            ArrayList arr = new ArrayList();

            while (true)
            {
                Console.WriteLine("Enter command (+ item, - item, -- to clear)):");
                String item = Console.ReadLine();

                if (item == "--")
                {
                    arr.Clear();
                    Console.WriteLine(String.Join(", ", arr.ToArray(typeof(String)) as String[]));
                    continue;
                }

                if (item.StartsWith("+"))
                {
                    arr.Add(item.Split(" ")[1]);
                    Console.WriteLine(String.Join(", ", arr.ToArray(typeof(String)) as String[]));
                    continue;
                }
                if (item.StartsWith("-"))
                {
                    arr.Remove(item.Split(" ")[1]);
                    Console.WriteLine(String.Join(", ", arr.ToArray(typeof(String)) as String[]));
                    continue;
                }

            }
        }



        /*3.Write a method that calculates all prime numbers in given range and returns them as array of integers*/
        static int[] FindPrimesInRange(int startNum, int endNum)
        {
            int[] primeArray = new int[100];
            int idex = 0;
            for (int i = startNum; i < endNum; i++)
            {
                int count = 0;
                for (int j = 2; j < i / 2; j++)
                {
                    if (i % 2 == 0)
                    {
                        count++;
                    }
                }
                if (count == 0 && i != 1)
                {
                    primeArray[idex] = i;
                    idex++;
                    Console.Write($"{i} ");
                }
            }

            return primeArray;
        }

        /*4.Write a program to read an array of nintegers (space separated on a single line) and an integer k, 
         * rotate the array right ktimes and sum the obtained arrays after each rotation*/

        static int[] rotateArray(int[] arr, int num)
        {
            int[] sum = new int[arr.Length];
            int[] before = arr;
            int[] after;
            for (int i = 0; i < num; i++)
            {
                after = rotateRight(before);
                for (int j = 0; j < after.Length; j++)
                {
                    sum[j] += after[j];
                }
                before = after;
            }

            Console.Write(String.Join(" ", sum));
            return sum;
        }

        static int[] rotateRight(int[] arr)
        {
            int[] result = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0)
                {
                    result[i] = arr[arr.Length - 1];
                }
                else
                {
                    result[i] = arr[i - 1];
                }

            }
            return result;
        }


        /*5.Write a program that finds the longest sequence of equal elements in an array of integers. 
         * If several longest sequences exist, print the leftmost one.*/

        static void LongestSequence(int[] arr)
        {
            int num = -1;
            int count = 0;
            int mNum = -1;
            int mCount = 0;
            foreach (int i in arr)
            {
                if (i != num)
                {
                    num = i;
                    count = 1;
                }
                else
                {
                    count += 1;
                    if (count > mCount)
                    {
                        mCount = count;
                        mNum = num;
                    }
                }
            }
            for (int i = 0; i < mCount; i++)
            {
                Console.Write($"{mNum} ");
            }
        }


        /*7.Write a program that finds the most frequent number in a given sequence of numbers.  
         * In case of multiple numbers with the same maximal frequency, print the leftmost of them*/
        static void FrqeuntNum(int[] array)
        {
            
            Dictionary<int, int> dic = new Dictionary<int, int>();
            int repeatNum = 1;
            int nn = 1;

            //this loop make is to find out the most frequent and the number
            foreach (int item in array)
            {
                if (dic.ContainsKey(item))
                {

                    dic[item] += 1;
                }
                else
                {
                    dic.Add(item, nn);
                }
            }


            //most frquent occurs times
            int mCount = dic.Values.Max();
            //number of the most frquent
            int maxFre = dic.OrderByDescending(x => x.Value).First().Key;

            Dictionary<int, int> di = new Dictionary<int, int>();
            int num = -1;
            int count = 0;
            int mNum = -1;
            int mmCount = 0;
            int mmmCount = 0;

            //this loop is to find out the maximal frequence 
            foreach (int i in array)
            {
                if (i != num)
                {
                    num = i;
                    count = 1;
                }
                else
                {

                    count++;
                    if (count > mmCount)
                    {
                        mmCount = count;
                        mNum = num;
                    }
                }
            

            }
            //add the maximal frquence into the di
            di.Add(mNum, mmCount);



            // this loop is to find out the number have the same maximal
            int snum = -1;
            int smnum = -1;
            foreach (int j in array)
            {
                if (j != snum)
                {
                    snum = j;
                    mmmCount = 1;
                }
                else
                {

                    mmmCount++;

                }
                if (mmmCount == mmCount )
                {
                    smnum = snum;
                    if (di.ContainsKey(smnum))
                    {
                        continue;

                    }
                    else
                    {
                        di.Add(smnum, mmCount);
                    }
                    
                   

                }

            }

            //dic to array only for the key
            int[] dicToArray = di.Keys.ToArray();

            //array to string
            string arrToString = string.Join(" ", dicToArray);
          

            Console.Write($" The number {maxFre} is the most frequent (occurs {mCount} times). The numbers {arrToString} have the same maximal frequence (each occurs {mmCount} times). The leftmost of them is {arrToString[0]}.");
        }
    }
}
