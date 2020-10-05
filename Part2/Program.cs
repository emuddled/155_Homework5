/// Homework No. 5		Exercise Part 2
/// File Name: ReverseArray
/// @author: Evan Sinclair
/// Date:  Oct 5, 2020
///
/// Problem Statement:Reverse an array. Create three methods: one to create the array,
/// one to reverse the array, and one to print the array at the end.
/// 
/// Overall Plan:
/// 1)Create a method to produce an array of a given length filled with random integers
/// 2)Create a method to reverse the array
/// 3)Create a method to print the contents of the array
/// 4)Call all 3 methods in the Main method to execute
///
///


using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = GenerateNumbers(7);
            PrintNumbers(arr);
            Reverse(arr);
            PrintNumbers(arr);
        }
        
        
        //generate int[] filled with random numbers
        static int[] GenerateNumbers(int size)
        {
            Random rand = new Random();
            int[] a = new int[size];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rand.Next(11);
            }
            return a;

        }

        //reverse and array
        static int[] Reverse(int[] arr)
        {
            int tempInt;

            for (int i = 0; i < arr.Length / 2; i++)
            {
                tempInt = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = tempInt;
            }

            return arr;
        }

        //print an array of ints
        static void PrintNumbers(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }
    }
}
