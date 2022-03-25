using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.BitwiseOperands
{
    internal class BitwiseWithChars
    {
        //public static void Main(string[] args)
        public static void Run()
        {
            string str = "wayz";
            Console.WriteLine(str);

            int[] fromstr = new int[4];
            for (int i = 0; i < str.Length; i++)
            {
                fromstr[i] = Convert.ToInt32(str[i]);
            }
            for (int i = 0; i < fromstr.Length; i++)
            {
                if (i == fromstr.Length - 1)
                {
                    Console.WriteLine((char)(fromstr[i - 1] & fromstr[i]));
                    break;
                }
                Console.WriteLine((char)(fromstr[i] & fromstr[i]));
            }
        }
    }
}
