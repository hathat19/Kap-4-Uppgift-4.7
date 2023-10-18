using System;
namespace upg4_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett meddelande som ska skrivas ut vertikalt:");
            string userSent = Console.ReadLine();

            Console.WriteLine("Hur många mellanslag ifrån kanten vill du ha det skrivet?");
            int spaces = int.Parse(Console.ReadLine());

            for (int i = 0; i < userSent.Length; i++)
            {
                if (spaces > 0)
                {
                    for (int j = 1; j <= spaces; j++)
                    {
                        Console.Write(" ");
                    }
                }
                
                Console.WriteLine(userSent[i]);
            }
        }
    }
}