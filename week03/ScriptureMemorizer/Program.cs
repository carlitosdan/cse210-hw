using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        //Reference re1 = new Reference("Nefi", 3, 7);
        //Scripture scripture = new Scripture(re1, "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");

        // Instantiate and pass the file path. 

        string path1 = Path.Combine(AppContext.BaseDirectory, "scriptures.json");

        TakeJson LoadScripture = new TakeJson(path1);
        
        Scripture randomScripture = LoadScripture.GetRandomScripture();
        
       
        bool continueLoop = true;

        while (continueLoop)
        {
            Console.Clear();
            Console.WriteLine(randomScripture.GetReferenceText());
            randomScripture.DisplayScripture();
            Console.WriteLine("\nPress Enter to hide more words, or type 'quit' to exit.");

            string v = Console.ReadLine();

            if (v.ToLower() == "quit")
            {
                continueLoop = false;  // Quit
            }
            else
            {
                bool moreToHide = randomScripture.HideRandomWords();
                if (!moreToHide)
                {
                    Console.WriteLine("\nAll words are now hidden!");
                    continueLoop = false; 
                }
            }
        }

        



    }

}