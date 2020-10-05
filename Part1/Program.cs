/// Homework No. 5		Exercise Part 1
/// File Name: ReverseArray
/// @author: Evan Sinclair
/// Date:  Oct 5, 2020
///
/// Problem Statement: Copy an Array
/// 
/// Overall Plan:
/// 1)Declare and initialize an array
/// 2)Declare a second array that will copy the first
/// 3)Create a for loop to copy each item in the first array to the second array
/// 4)Use foreach loop to print out all the elements of both arrays to check for correct copy
///
///







using System;
using System.Data;

namespace Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //first array
            int[] firstArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            
            //second array
            int[] copyArray = new int[10];
            
            //for loop to copy
            for (int j = firstArray.Length; j > 0; j--)
            {
                copyArray[j - 1] = firstArray[j - 1];
            }
            
            //loops to output to console
            foreach (int printMe in firstArray)
            {
                Console.WriteLine(printMe.ToString());
            }
            foreach (int printMe in copyArray)
            {
                Console.WriteLine(printMe.ToString());
            }
        }
    }
}
