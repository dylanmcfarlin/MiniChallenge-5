using System;

// Dylan McFarlin
// Date Revised: 9-4-20
// MiniChallenge#5
// Program that asks the user to input 10 fields to generate a story. The fields could be whatever we wanted them to be.
// Code Reviewed by: Hayley Ambs
// Comments: The only thing I'd say is the story has a weird flow in it once you put words in, but i mean it works.

namespace MiniChallenge_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Mad Lib :)");
            Console.WriteLine();
            Console.WriteLine("Type a plural noun:"); // 1
            string pluralNoun1 = Console.ReadLine();

            Console.WriteLine("Type an adjective:");  // 2
            string adjective1 = Console.ReadLine();

            Console.WriteLine("Type a plural noun:"); // 3
            string pluralNoun2 = Console.ReadLine();

            Console.WriteLine("Type an adjective:"); // 4
            string adjective2 = Console.ReadLine();

            Console.WriteLine("Type an adjective:"); // 5
            string adjective3 = Console.ReadLine();

            Console.WriteLine("Type a plural noun:"); // 6
            string pluralNoun3 = Console.ReadLine();

            Console.WriteLine("Type a plural noun:"); // 7
            string pluralNoun4 = Console.ReadLine();

            Console.WriteLine("Type an adjective:"); // 8
            string adjective4 = Console.ReadLine();

            Console.WriteLine("Type a verb:"); // 9
            string verb1 = Console.ReadLine();

            Console.WriteLine("Type a noun:"); // 10
            string noun1 = Console.ReadLine();

            Console.Clear();
            Console.WriteLine(pluralNoun1 + " are " + adjective1 + " " + pluralNoun2 + " are "
             + adjective2 + " life is " + adjective3 + " and so are " + pluralNoun3 + " and "
             + pluralNoun4 + " are really " + adjective4 + " and they love to " + verb1 +
              " to where ever their " + noun1 + " desires.");
        }
    }
}
