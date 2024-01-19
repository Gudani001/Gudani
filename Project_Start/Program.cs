// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static string collectionName = "";
    static string[] questions = new string[0];
    static bool[] isCorrect = new bool[0];

    static void Main()
    {
        string c;
        do
        {
            Console.WriteLine("\nOptions:\n1. Add a name for the collection\n2. Add a question to the collection\n3. Display collection\n4. Exit");
            Console.Write("Enter your choice (1-3 or done): ");
            c = Console.ReadLine();
            
            if (c == "1") { 
                Console.Write("Enter the name for the collection: "); 
                collectionName = Console.ReadLine(); }
            else if (c == "2") {
                AddQuestion();
            }
            else if (c == "3"){ 
            DisplayCollection();
            }
            else if (c != "done"){
            }
        } while (c != "done");
    }

    static void AddQuestion()
    {
        Console.Write("Enter a question: ");
        string qt = Console.ReadLine();
        Console.Write("Enter the question image path:");
        string ip = Console.ReadLine();
        Console.Write("Is this the correct answer?:");
        bool ic = bool.Parse(Console.ReadLine());
        
        Array.Resize(ref questions, questions.Length + 1);
        Array.Resize(ref isCorrect, isCorrect.Length + 1);
    
        questions[questions.Length - 1] = $"{qt} (Image: {ip})";
        isCorrect[isCorrect.Length - 1] = ic;
    }

    static void DisplayCollection()
    {
    Console.WriteLine($"\nCollection Name: {collectionName}\n|  Question|  Is Correct  |\n");
  for (int i = 0; i < questions.Length; i++) 
  Console.WriteLine($"|  {questions[i]}  |  {isCorrect[i]}  |");
    }
}
