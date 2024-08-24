namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write Operation");

            char O = Convert.ToChar(Console.ReadLine() ?? "");

            Console.WriteLine("Enter First Num");
            string FirstNum = Console.ReadLine() ?? "";


            Console.WriteLine("Enter Second Num");
            string SecondNum = Console.ReadLine() ?? "";

            int FN = Convert.ToInt32(FirstNum);
            int SN = Convert.ToInt32(SecondNum);
            int Answer = 0;

            if (O == '+') Answer = FN + SN;
            else if (O == '-') Answer = FN - SN;
            else if (O == '/') Answer = FN / SN;
            else if (O == '*') Answer = FN * SN;
            else Answer = 0;

            Console.WriteLine("{0} {1} {2} is equals to {3}", FirstNum, Convert.ToString(O), SecondNum, Convert.ToString(Answer));
        }
    }
}
