namespace YeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string index = Console.ReadLine();
                ReverseSimbols(index);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public static void ReverseSimbols(string input)
        {
            char[] symbols = input.ToCharArray();

            foreach (char i in symbols)
            {
                if (i == ' ') throw new ArgumentException("Invalid input");
            }

            for (int i = symbols.Length - 1; i >= 0; i--)
            {
                Console.Write(symbols[i]);
            }
        }
    }
}