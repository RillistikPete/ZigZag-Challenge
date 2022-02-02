using System;
using System.Text;

namespace ZigzagChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test cases
            string [] testCase1 = new string [] { "cat", "9" };
            string [] testCase2 = new string [] { "dumplings", "3" };
            string [] testCase3 = new string [] { "cryptocurrency", "4" };
            Console.WriteLine(ZigZag(testCase1));
            Console.WriteLine(ZigZag(testCase2));
            Console.WriteLine(ZigZag(testCase3));
        }

        public static string ZigZag(string [] strArr)
        {
            // Start row at 0 and count up until 1 less than number of rows,
            // then change direction to zigzag.
            int row = 0;
            // Number of rows - convert string to int
            int num = Convert.ToInt32(strArr[1]);
            // String array to hold each row's string
            string [] rows = new string [num];
            bool up = true;
            for (var i = 0; i < strArr[0].Length; i++)
            {
                // Each row is given a character according to direction
                rows[row] += strArr[0][i];
                if (row == num - 1)
                {
                    up = false;
                }
                else if (row == 0)
                {
                    up = true;
                }
                if (up)
                {
                    row++;
                }
                else
                {
                    row--;
                }
            }
            // Put all rows together to form new string
            StringBuilder answer = new StringBuilder();
            for (var j = 0; j < num; j++)
            {
                answer.Append(rows[j]);
            }
            return answer.ToString();
        }
    }
}   
