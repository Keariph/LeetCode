namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "0101";
            MaximumOddBinaryNumber maximumOddBinaryNumber = new MaximumOddBinaryNumber();
            string result = maximumOddBinaryNumber.Solution(s);
            Console.WriteLine(result);
        }    
    }
}

