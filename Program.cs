using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ryba10
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = File.ReadAllText("input.txt");
            string temp = string.Empty;
            string result = string.Empty;
            int count = 0;
            for (int i = text.Length - 1; i >= 0; i--)
            {
                char currentChar = text[i];

                if (currentChar == '5')
                {
                    count++;
                }

                if (count == 0)
                {
                    temp += currentChar;
                }
            }

            for (int i = temp.Length - 1; i >= 0; i--)
            {
                result += temp[i];
            }

            Console.WriteLine(count);
            Console.WriteLine(result);

        }
    }
}
