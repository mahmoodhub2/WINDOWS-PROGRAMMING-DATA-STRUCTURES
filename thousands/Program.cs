/*
  FILE : Program.cs
* PROJECT :  Assignment 3#
* PROGRAMMER : Mahmood Al-Zubaidi
* FIRST VERSION : October 6/2021
* DESCRIPTION : The purpose of this function is to show how long it takes to add, retrive to/from a list, hash table, and dictionary.
* by adding sven thousand words from a file and then sotring a list then retrieving a specific word from that list and compare it wiht 
* the unsorted list as well as comparing it to the dictionary and the hashtable, to detrimaine which one is faster when it comes to adding
* and retriving.
*/
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Timers;
using System.Collections;
using System.IO;

namespace Compareator
{
    class Program
    {
        static void Main(string[] args)
        {

            Stopwatch stopWatch = new Stopwatch();


            List<string> list = new List<string>();

            string[] readText = File.ReadAllLines(@"C:\Users\ma hmood\Downloads\sevenThosand.txt");

            stopWatch.Start();
            foreach (string s in readText)
            {
                list.Add(s);
            }

            stopWatch.Stop();
            Console.WriteLine(" adding to LIST took:    " + stopWatch.ElapsedMilliseconds.ToString() + "ms");


            stopWatch.Reset();
            stopWatch.Start();
            foreach (string s in list)
            {
                if (s == "kxgwz")
                {
                    Console.WriteLine(" The word I'm looking for in unsorted LIST:   " + s);
                }
            }
            stopWatch.Stop();
            Console.WriteLine(" time it took to retrieve that word from unsorted LIST:   " + stopWatch.ElapsedMilliseconds.ToString() + "ms");





            list.Sort();
            stopWatch.Reset();
            stopWatch.Start();
            foreach (string s in list)
            {
                if (s == "kxgwz")
                {
                    Console.WriteLine(" The word I'm looking for in a sorted list:   " + s);
                }
            }
            stopWatch.Stop();
            Console.WriteLine(" time it took to retrieve that word from Sorted LIST took:   " + stopWatch.ElapsedMilliseconds.ToString() + "ms");







            Hashtable hashTable = new Hashtable();
            stopWatch.Reset();
            stopWatch.Start();
            int hashCounter = 0;
            foreach (string s in readText)
            {
                hashCounter++;
                hashTable.Add(hashCounter.ToString(), s);
            }



            stopWatch.Stop();
            Console.WriteLine(" adding to HashTable took:   " + stopWatch.ElapsedMilliseconds.ToString() + "ms");



            ICollection hasHkeys = hashTable.Keys;
            stopWatch.Reset();
            stopWatch.Start();
            foreach (String s in hasHkeys)
            {
                string container = hashTable[s].ToString();

                if (container == "kxgwz")
                {
                    Console.WriteLine("The word I'm looking for in HashTable is:   " + container);
                }
            }

            stopWatch.Stop();
            Console.WriteLine(" time it took to retrieve that word from HashTable took:   " + stopWatch.ElapsedMilliseconds.ToString() + "ms");









            Dictionary<string, string> diction = new Dictionary<string, string>();
            stopWatch.Reset();
            stopWatch.Start();
            int counterDictionary = 0;
            foreach (string s in readText)
            {
                counterDictionary++;
                diction.Add(counterDictionary.ToString(), s);
            }
            stopWatch.Stop();
            Console.WriteLine(" adding to Dictionary took:    " + stopWatch.ElapsedMilliseconds.ToString() + "ms");


            ICollection dictioNkeys = diction.Keys;
            stopWatch.Reset();
            stopWatch.Start();
            foreach (KeyValuePair<string, string> kvp in diction)
            {
                string container = kvp.Value;
                if (container == "kxgwz")
                {
                    Console.WriteLine("The word I'm looking for in dictionary is:   " + container);
                }
            }
            stopWatch.Stop();
            Console.WriteLine(" time it took to retrieve that word from Dictionary:  " + stopWatch.ElapsedMilliseconds.ToString() + "ms");

        }
    }
}
