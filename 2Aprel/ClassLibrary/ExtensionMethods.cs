using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public static class ExtensionMethods
    {
        // Tek ededolup olmamasi
        // Cut eded olup olmamasi
        // Stringin icinde digit olup olmamasi
        // Gelen stringin baw herfini boyuk elesin
        // Charin stringin necenci indeksinde oldugunu tapip arraye daxil etsin indekleride array olaraq qaytarsin

        public static bool IsOdd(this int Number) 
        {
            if (Number % 2 != 0)
            {
                return true;
            }
            return false;
        }

        public static bool IsEven(this int Number) 
        {
            if (Number % 2 == 0)
            {
                return true;
            }
            return false;
        }

        public static bool IsContainsDigit(this string Word) 
        {
            bool check = false;
            bool checkOne = false;
            if (Word != null)
            {
                foreach (var item in Word)
                {
                    if (char.IsDigit(item))
                    {
                        check=true;
                    }
                }
                foreach (var item in Word)
                {
                    if (char.IsLetter(item))
                    {
                        checkOne = true;
                    }
                }
                if (check == true && checkOne == true )
                {
                    return true;
                }
            }
            return false;


        }
        public static void ToCapitalize(this string Word) 
        {
            if (char.IsUpper(Word[0]) != true)
            {
                Word = Word.Replace(Word[0], char.ToUpper(Word[0]));
                
            }
            Console.WriteLine(Word);
        }

        public static int[] GetValueIndexes(this string Word, char FindChar)
        {

            int[] arrayForNumber = new int[0];
            for (int i = 0; i < Word.Length; i++)
            {

                if (Word[i].ToString().Contains(FindChar) == true)
                {
                    Array.Resize(ref arrayForNumber, arrayForNumber.Length + 1);
                    arrayForNumber[arrayForNumber.Length - 1] = i;
                }

            } return arrayForNumber;
        }
    }
}
