namespace A22_Ex01_3
{
    using System;
    using System.Text;
    using A22_Ex01_2;

    public class Program
    {
        public static void Main()
        {
            System.Console.WriteLine("Please enter the number of lines for the sand clock:");
            uint numberOfAsterisk = Convert.ToUInt32(System.Console.ReadLine());
            var clockBuilder = new StringBuilder();
            IsInputEvenNumber(ref numberOfAsterisk);
            A22_Ex01_2.Program.GenerateSandClock(clockBuilder, numberOfAsterisk);
            Console.Write(clockBuilder.ToString());
            Console.ReadKey();
        }

        private static void IsInputEvenNumber(ref uint io_NumberOfAsterisk)
        {
            if (io_NumberOfAsterisk % 2 == 0)
            {
                io_NumberOfAsterisk++;
            }
        }
    }
}