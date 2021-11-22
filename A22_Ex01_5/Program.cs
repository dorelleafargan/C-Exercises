namespace A22_Ex01_05
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int userNumber = 0;
            Console.WriteLine("Enter a number with 7 digits:");
            var userNumberAsString = Console.ReadLine();
            userNumber = InputValidation(userNumberAsString);
            FindTheLargestDigitOfNumber(userNumber);
            FindTheAvereageOfTheNumberDigits(userNumber);
            FindHowManyDigitsDividedByThree(userNumber);
            FindHowManyDigitsAreSmallerFromTheFirstDigit(userNumberAsString);
            Console.ReadKey();
        }

        public static int InputValidation(string i_UserNumberAsString)
        {
            int userNumber = 0;
            while ((i_UserNumberAsString.Length != 7) || (!int.TryParse(i_UserNumberAsString, out userNumber)))
            {
                Console.WriteLine("Wrong Input. Try again");
                i_UserNumberAsString = Console.ReadLine();
            }

            return userNumber;
        }

        public static void FindTheLargestDigitOfNumber(int i_userNumber)
        {
            int rightDigit = 0;
            int largestDigit = 0;
            while (i_userNumber > 0)
            {
                rightDigit = i_userNumber % 10;
                if (largestDigit < rightDigit)
                {
                    largestDigit = rightDigit;
                }

                i_userNumber = i_userNumber / 10;
            }

            Console.WriteLine("The largest digit is:" + largestDigit);
        }

        public static void FindTheAvereageOfTheNumberDigits(int i_userNumber)
        {
            int rightDigit = 0;
            float avarage = 0;
            int sumOfDigits = 0;
            string inputNumberToStr = i_userNumber.ToString();
            int inputLength = inputNumberToStr.Length;
            for (int i = 0; i < inputLength; i++)
            {
                sumOfDigits += (int)char.GetNumericValue(inputNumberToStr[i]);
            }

            avarage = (float)sumOfDigits / 7f;
            Console.WriteLine("Avarage of sum of numbers by digits is: " + avarage);
        }

        public static void FindHowManyDigitsDividedByThree(int i_userNumber)
        {
            int dividedByThreeCounter = 0;
            int rightDigit = 0;
            while (i_userNumber > 0)
            {
                rightDigit = i_userNumber % 10;
                if (rightDigit != 0)
                {
                    if (rightDigit % 3 == 0)
                    {
                        dividedByThreeCounter++;
                    }
                }

                i_userNumber = i_userNumber / 10;
            }

            Console.WriteLine("Number of digits that can be divided by 3 is: " + dividedByThreeCounter);
        }

        public static void FindHowManyDigitsAreSmallerFromTheFirstDigit(string i_userNumberStr)
        {
            int inputLength = i_userNumberStr.Length;
            int firstDigit = (int)char.GetNumericValue(i_userNumberStr[inputLength - 1]);
            int firstDigitSmallerCounter = 0;
            for (int i = 0; i < inputLength - 1; i++)
            {
                if (firstDigit > (int)char.GetNumericValue(i_userNumberStr[i]))
                {
                    firstDigitSmallerCounter++;
                }
            }

            Console.WriteLine("Number of digits that are smaller from the first digit: " + firstDigitSmallerCounter);
        }
    }

}
