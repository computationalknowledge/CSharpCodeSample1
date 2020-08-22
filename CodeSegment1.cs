using System;

namespace ConsoleApp2
{
    // This code can be used to illustrate a number of interesting applications of OO Code features
    // as well as the use of ASCII data encoding and how it can be manipulated
    class Program
    {
        static void Main(string[] args)
        {
            int sumOfLetterValues = AsciiSymbols.DisplaySumOfAsciiValues("Mary");
            Console.WriteLine(sumOfLetterValues);
        }
    }

    class AsciiSymbols
    {
        // ascii table chart: https://www.screencast.com/t/ssxYu6d3xNgc 
        private static Char[] _asciiSymbols;
        public static int DisplaySumOfAsciiValues(string input1)
        {
            GenerateAsciiValues();
            int sumOfLetterValues = 0;
            foreach (var letter in input1)
            {
                int counter = 0;
                foreach (var asciiCharacter in _asciiSymbols)
                {
                    if (asciiCharacter.Equals(letter))
                    {
                        sumOfLetterValues += counter;
                        
                    }
                    counter++;
                }
            }

            return sumOfLetterValues;
        }

        public static Char[] GenerateAsciiValues()
        {
            _asciiSymbols = new Char[200];

            for (int i = 32; i < 128; i++)
            {
                _asciiSymbols[i] = Convert.ToChar(i);
            }
            return _asciiSymbols;
        }

    }


}

