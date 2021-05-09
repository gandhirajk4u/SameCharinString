using System;

namespace SameCharinString
{    public static class Program
    {
        private static string GetChar(string str)
        {
            int i, j;
            string strOutput = "";
            for (i = 0; i < str.Length; i++)
            {
                for (j = i + 1; j < str.Length; j++)
                {
                    if(str[i] == str[j])
                    {
                        strOutput += str[i].ToString() + "\n";
                    }
                }
            }
            return strOutput;
        }
        static void Main(string[] args)
        {
            string op = GetChar("Vainav-Vennila");
            Console.WriteLine(op);
            Console.ReadLine();
        }
    }
}
