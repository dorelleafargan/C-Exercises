 namespace A22_Ex01_2
{
    using System;
    using System.Text;

    public class Program
    {
        public static void Main()
        {
            uint numberOfAsterisk = 5;
            var clockBuilder = new StringBuilder();
            GenerateSandClock(clockBuilder, numberOfAsterisk);
            Console.Write(clockBuilder.ToString());
            Console.ReadKey();
        }

        public static void GenerateSandClock(StringBuilder stringBuilder, uint i_NumOfAsterisk, uint i_IndentionLevel = 0)
        {
            var line = NumberToSpaces(i_IndentionLevel++) + NumberToAestrics(i_NumOfAsterisk);
            stringBuilder.AppendLine(line);

            if (i_NumOfAsterisk == 1)
            {
                return;
            }

            GenerateSandClock(stringBuilder, i_NumOfAsterisk - 2, i_IndentionLevel);
            stringBuilder.AppendLine(line);
        }

        private static string NumberToSpaces(uint indentionLevel)
        {
            return new string(' ', (int)indentionLevel);
        }

        private static string NumberToAestrics(uint numberOfAestrics)
        {
            return new string('*', (int)numberOfAestrics);
        }
    }
}