namespace Ch05Ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myString = "This is a test";
            char[] seperator = { ' ' };
            string[] myWords;
            myWords = myString.Split(seperator);

            foreach(string word in myWords)
            {
                Console.WriteLine($"{word}");
            }
            Console.ReadKey();
        }
    }
}