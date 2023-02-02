using System;
using System.Runtime.InteropServices;

namespace recursive_and_extension
{
    internal class Program
    {
        public static void Main(string[] args)
        {

           // Recursive function
           //3^4 = 3*3*3*3

           int result = 1;
           for (int i = 1; i < 6; i++)
               result = result * 3;

           Console.WriteLine(result);


           Islemler instance = new Islemler();

           Console.WriteLine(instance.Expo(3,4));

           //Extension Methods

           string myName = "Ömer Faruk Kaya";
           bool sonuc = myName.CheckSpaces();
           Console.WriteLine("sonuc: "+sonuc);
           if (sonuc)
               Console.WriteLine(myName.RemoveWhiteSpaces());
           Console.WriteLine(myName.MakeUpperCase());
           Console.WriteLine(myName.MakeLowerCase());

           int[] dizi = { 9, 3, 6, 2, 1, 5, 0 };

           dizi.SortArray();
           dizi.PrintToScreen();

           int sayı = 5;
           Console.WriteLine("çift mi:"+ sayı.IsEvenNumber());

           Console.WriteLine("MyNameFirstChar:"+myName.GetFirstChar());





        }
    }

    public class Islemler
    {
        public int Expo(int sayi, int üs)
        {
            if (üs < 2)
                return sayi;
            return Expo(sayi, üs - 1) * sayi;
        }

        //Expo(3,4)
        //Expo(3,3)*3
        //Expo(3,2)*3*3
        //Expo(3,1)*3*3*3;
        //3*3*3*3= 3^4

    }
    public static class Extension
    {
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }

        public static string RemoveWhiteSpaces(this string param)
        {
            string[] dizi = param.Split(" ");
            return string.Join("", dizi);
        }

        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }
        public static string MakeLowerCase(this string param)
        {
            return param.ToUpper();
        }

        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }

        public static void PrintToScreen(this int[] param)
        {
            foreach (int item in param)
                Console.WriteLine("item:"+item);
        }

        public static bool IsEvenNumber(this int param)
        {
            return param%2 == 0;
        }

        public static string GetFirstChar(this string param)
        {
            return param.Substring(0, 1);
        }

    }
}