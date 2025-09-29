internal class Program
{
    private static void Main(string[] args)
    {
        string text = "И поэтому все так произошло";

        string[] words = text.Split(new char[] { ' ' });

        foreach (string s in words)
        {
            Console.WriteLine(s);
        }

    }
}