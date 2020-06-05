using System;
using System.IO;
using System.Linq;

namespace OOP_Lab3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string");
            string text = Console.ReadLine();
            //text = text.Replace(" ", "");
            string[] buff = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            int np = 0;
            for (int i = 0; i < buff.Length; i++)
            {
                int check = 0;
                for (int k = 0; k < buff[i].Length; k++)
                {
                    check++;
                }
                if ((check % 2) !=0)
                {
                    np++;
                }
            }

            Console.WriteLine($"Odd words : {np}");

        }
    }
}
