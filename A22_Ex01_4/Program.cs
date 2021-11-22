namespace A22_Ex01_4
{
    using System;

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine(@"Enter a string by the following rules: 
* 6 characters only.
* English only (Upper and lower case).
* Can add numbers aswell.
=====================================
Press Enter to submit:");
            string userInputStr = Console.ReadLine();
            RunConditions(ref userInputStr);
            Console.ReadKey();
        }

        private static void RunConditions(ref string io_userInputStr)
        {
            IsCorrectInput(ref io_userInputStr);
            bool isPalindrom = IsPalindrom(io_userInputStr);
            if (isPalindrom)
            {
                Console.WriteLine("Palindrom: Yes.");
            }
            else
            {
                Console.WriteLine("Palindrom: No.");
            }

            if (IsANumber(io_userInputStr))
            {
                bool canDivide = DivideByFour(io_userInputStr);
                if (canDivide)
                {
                    Console.WriteLine("Divide by 4: Yes.");
                }
                else
                {
                    Console.WriteLine("Divide by 4: No.");
                }
            }
            else
            {
                Console.WriteLine("Divide by 4: *The input is not a number*.");
            }

            if (UpperOrLower(io_userInputStr))
            {
                int numOfUpperCases = NumOfUpper(io_userInputStr);
                Console.WriteLine("UpperCase Count: " + numOfUpperCases);
            }
            else
            {
                Console.WriteLine("UpperCase Count: *The input is not a string.*");
            }
        }

        private static bool IsCorrectInput(ref string io_userInputStr)
        {
            while (io_userInputStr.Length != 6)
            {
                Console.WriteLine(@"Wrong Input: *Length should be 6 digits only.*
Type again:");
                io_userInputStr = Console.ReadLine();
            }

            bool isUpperOrLower = UpperOrLower(io_userInputStr);
            bool isANumber = IsANumber(io_userInputStr);
            while ((isUpperOrLower && isANumber) || (!isUpperOrLower && !isANumber))
            {
                Console.WriteLine(@"Wrong Input: *Numbers only, or strings only.*
Type again:");

                io_userInputStr = Console.ReadLine();
                isUpperOrLower = UpperOrLower(io_userInputStr);
                isANumber = IsANumber(io_userInputStr);
            }

            // Console.WriteLine("The input is correct");
            bool correctInput = true;
            return correctInput;
        }

        private static bool UpperOrLower(string i_userInputStr)
        {
            bool correctChar = false;
            for (int i = 0; i < i_userInputStr.Length; i++)
            {
                char charInput = i_userInputStr[i];

                if (!((charInput >= 'A' && charInput <= 'Z') || (charInput >= 'a' && charInput <= 'z')))
                {
                    continue;
                }
                else
                {
                    correctChar = true;
                }
            }

            return correctChar;
        }

        private static bool IsANumber(string i_userInputStr)
        {
            bool isANumber = false;
            for (int i = 0; i < i_userInputStr.Length; i++)
            {
                char charInput = i_userInputStr[i];

                if (!(charInput >= '0') || !(charInput <= '9'))
                {
                    continue;
                }
                else
                {
                    isANumber = true;
                }
            }

            return isANumber;
        }

        private static bool IsPalindromRecursive(string i_userInputStr, int i_firstChar, int i_secondChar)
        {
            if (i_firstChar == i_secondChar)
            {
                return true;
            }

            if (i_userInputStr[i_firstChar] != i_userInputStr[i_secondChar])
            {
                return false;
            }

            if (i_firstChar < i_secondChar + 1)
            {
                return IsPalindromRecursive(i_userInputStr, i_firstChar + 1, i_secondChar - 1);
            }

            return true;
        }

        private static bool IsPalindrom(string i_userInputStr)
        {
            int strLength = i_userInputStr.Length;

            if (strLength == 0)
            {
                return true;
            }

            return IsPalindromRecursive(i_userInputStr, 0, strLength - 1);
        }

        private static bool DivideByFour(string i_userInputStr)
        {
            bool canDevide = false;
            int userInputInt = Convert.ToInt32(i_userInputStr);
            if (userInputInt % 4 == 0)
            {
                canDevide = true;
            }

            return canDevide;
        }

        private static int NumOfUpper(string i_userInputStr)
        {
            int numOfUpper = 0;
            if (UpperOrLower(i_userInputStr))
            {
                for (int i = 0; i < i_userInputStr.Length; i++)
                {
                    char charInput = i_userInputStr[i];
                    if (charInput >= 'A' && charInput <= 'Z')
                    {
                        numOfUpper++;
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            return numOfUpper;
        }
    }
}