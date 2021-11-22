namespace A22_Ex01_1
{
    using System;
    using System.Linq;

    public class Program 
    {
        public static void Main()
        {
            string[] binaryStr = new string[4];
            int[] binaryStrToInt = new int[4];

            Console.WriteLine("Please enter 4 binary number 8 digits each: (Press Enter to continue)");
            int arrayLength = binaryStr.Length;
            for (int i = 0; i < arrayLength; i++)
            {
                binaryStr[i] = Console.ReadLine();
                bool isBinaryAfterChecks = BinaryStrChecks(binaryStr[i]);
                while (!isBinaryAfterChecks)
                {
                    binaryStr[i] = Console.ReadLine();
                    isBinaryAfterChecks = BinaryStrChecks(binaryStr[i]);
                }

                binaryStrToInt[i] = BinaryConvertToDecimal(binaryStr[i]);
            }

            PrintDecimal(binaryStrToInt);
            AvarageInBinary(binaryStr);
            NumberOfPowerBy2(binaryStrToInt);
            IsAscending(binaryStrToInt);
            MaxAndMinNumber(binaryStrToInt);
            Console.ReadKey();
        }

        public static bool BinaryStrChecks(string i_binaryStr)
        {
            bool binaryChecksBool = true;
            for (int i = 0; i <= 3; i++)
            {
                if (i_binaryStr.Length != 8)
                {
                    Console.WriteLine("Only 8 digit binary number, type again.");
                    binaryChecksBool = false;
                    break;
                }

                bool notBinaryBool = IsBinary(i_binaryStr);
                if (!notBinaryBool)
                {
                    Console.WriteLine("Not a binary number '0's and '1's only, type again.");
                    binaryChecksBool = false;
                    break;
                }
            }

            return binaryChecksBool;
        }

        public static bool IsBinary(string i_binaryStr)
        {
            bool isBinary = false;
            for (int j = 0; j <= 7; j++)
            {
                if ((i_binaryStr[j] == '0') || (i_binaryStr[j] == '1'))
                {
                    isBinary = true;
                }
                else
                {
                    isBinary = false;
                    break;
                }
            }

            return isBinary;
        }

        public static int BinaryConvertToDecimal(string i_binaryStr) // Converts binary to decimal
        {
            int decimalNumber = 0;
            for (int i = 0; i < i_binaryStr.Length; i++)
            {
                if (i_binaryStr[i_binaryStr.Length - i - 1] == '0')
                {
                    continue;
                }

                decimalNumber += (int)Math.Pow(2, i);
            }

            return decimalNumber;
        }

        public static void PrintDecimal(int[] i_binaryStrToInt) // Printing decimal
        {
            string msg = string.Format(@"The Decimal numbers are: {0}, {1}, {2}, {3}", i_binaryStrToInt[0], i_binaryStrToInt[1], i_binaryStrToInt[2], i_binaryStrToInt[3]);
            Console.WriteLine(msg);
        }

        public static void AvarageInBinary(string[] i_binaryStr)
        {
            char zeroNumber = '0';
            int numberOfZeros = 0;
            int numberOfOnes = 0;
            for (int i = 0; i <= 3; i++)
            {
                numberOfZeros += i_binaryStr[i].Count(f => (f == zeroNumber));
            }

            numberOfOnes += 32 - numberOfZeros;
            float avarageOnes = numberOfOnes / 4f;
            float avarageZeros = numberOfZeros / 4f;
            Console.WriteLine("The avarage 1's is: " + avarageOnes);
            Console.WriteLine("The avarage 0's is: " + avarageZeros);
        }

        public static void NumberOfPowerBy2(int[] i_binaryStrToInt)
        {
            int numberOfDecimalPowerOf2 = 0;
            for (int i = 0; i <= 3; i++)
            {
                if ((i_binaryStrToInt[i] != 0) && ((i_binaryStrToInt[i] & (i_binaryStrToInt[i] - 1)) == 0))
                {
                    numberOfDecimalPowerOf2++;
                }
            }

            Console.WriteLine("The number of decimal number that are power of 2 is: " + numberOfDecimalPowerOf2);
        }

        public static void IsAscending(int[] i_binaryStrToInt)
        {
            int numberOfAscendingInt = 0;
            for (int i = 0; i <= 3; i++)
            {
                string intToString = i_binaryStrToInt[i].ToString();
                if (intToString.Length == 2)
                {
                    if (intToString[0] < intToString[1])
                    {
                        numberOfAscendingInt++;
                    }
                }
                else if (intToString.Length == 3)
                {
                    if (intToString[0] < intToString[1] && intToString[1] < intToString[2])
                    {
                        numberOfAscendingInt++;
                    }
                }
            }

            Console.WriteLine("There is " + numberOfAscendingInt + " ascending numbers");
        }

        public static void MaxAndMinNumber(int[] i_binaryStrToInt)
        {
            int maxNumber = i_binaryStrToInt.Max();
            int minNumber = i_binaryStrToInt.Min();
            Console.WriteLine("The maximum number is: " + maxNumber);
            Console.WriteLine("The minimum number is: " + minNumber);
        }
    }
}