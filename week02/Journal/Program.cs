using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Journal journal = new Journal();
        while(true){
            Console.WriteLine("Please select one of the following option:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            Console.Write("What would you like to do? ");
            int response = int.Parse(Console.ReadLine());
            if(response == 1)
            {
                Entry entry = new Entry();
                PromptGenerator pg = new PromptGenerator();

                entry._date = DateTime.Now.ToShortDateString();
    
                entry._promptText = pg.GetRandomPrompt();

                Console.WriteLine(entry._promptText);
                entry._entryText = System.Console.ReadLine();
                
                journal.AddEntry(entry);
            }
            else if(response == 2)
            {
                System.Console.WriteLine("Here are all the journal entries:\n\n");
                journal.DisplayAll();
            }
            else if(response == 3)
            {
                Console.WriteLine("What is the filename? (Include the file extension)");
                journal.LoadFromFile(Console.ReadLine());
            }
            else if(response == 4)
            {
                Console.WriteLine("What is the filename? (Include the file extention)");
                journal.SaveToFile(Console.ReadLine());
            }
            else if(response == 5)
            {
                System.Console.WriteLine("Thank you for journaling today! Have a great day!");
                break;
            }
        }
        
    }
}