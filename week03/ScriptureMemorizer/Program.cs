class Program
{
    static void Main(string[] args)
    {
        Reference reference = new("John", 3, 16);
        Scripture scripture = new(reference, "For God so loved the world, that he gave his only begotten Son, that whoever believeth in him should not perish, but have everlasting life.");
        
        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide a word or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input == "quit")
            {
                break;
            }
            scripture.HideRandomWords(3);
            Console.Clear();
        }
        
    }
}