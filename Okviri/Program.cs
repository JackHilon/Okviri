using System;
using System.Collections.Generic;

namespace Okviri
{
    class Program
    {
        static void Main(string[] args)
        {
            // Okviri problem
            // https://open.kattis.com/problems/okviri
            // change print pattern every third char

            // not solved !!!
            // result(submit) --> wrong answer: -R-R-R-R-X-E-E-E-E-E-E-E-E-

            var charArr = Console.ReadLine().ToCharArray();

            string firstLine = "";
            string secondLine = "";
            string thirdLine = "";

            var firstPeterPan = "..#..";
            var secondPeterPan = ".#.#.";

            var firstSpecial = ".#.";
            var secondSpecial = "#.#";

            var firstWendy = "..*..";
            var secondWendy = ".*.*.";
            int k;
            for (int i = 0; i < charArr.Length; i++)
            {
                k = i + 1;
                if (k % 3 == 0)
                {
                    firstLine = firstLine + firstWendy;
                    secondLine = secondLine + secondWendy;
                    thirdLine = thirdLine + ThirdWendy(charArr[i]);
                }
                else if (k % 2 == 0)
                {
                    firstLine = firstLine + firstSpecial;
                    secondLine = secondLine + secondSpecial;
                    thirdLine = thirdLine + ThirdSpecial(charArr[i]);
                }
                else
                {
                    firstLine = firstLine + firstPeterPan;
                    secondLine = secondLine + secondPeterPan;
                    thirdLine = thirdLine + ThirdPeterPan(charArr[i]);
                }
            } // end for loop

            if((charArr.Length > 2) && (charArr.Length % 2 == 0))
            {
                firstLine = firstLine + ".";
                secondLine = secondLine + ".";
                thirdLine = thirdLine + "#";
            }

            PrintAll(firstLine, secondLine, thirdLine);
        } // end main

        private static void PrintAll(string s1, string s2, string s3)
        {
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s2);
            Console.WriteLine(s1);
        }
        private static string ThirdPeterPan(char a)
        {
            return $"#.{a.ToString()}.#";
        }
        private static string ThirdSpecial(char a)
        {
            return $".{a.ToString()}.";
        }
        private static string ThirdWendy(char a)
        {
            return $"*.{a.ToString()}.*";
        }
    }
}
