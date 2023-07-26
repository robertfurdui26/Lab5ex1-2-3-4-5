using System;

class Program
{
    static void Main()
    {
        // Exercitiul 1
        Console.WriteLine("Exercitiul 1: Verificarea pozitiei unui substring in string.");
        Console.Write("Introduceti string-ul: ");
        string inputString = Console.ReadLine();
        Console.Write("Introduceti substring-ul: ");
        string substring = Console.ReadLine();

        int position = inputString.IndexOf(substring);
        if (position != -1)
            Console.WriteLine($"Substringul se gaseste la pozitia {position} in string.");
        else
            Console.WriteLine("Substringul nu exista in string.");

        // Exercitiul 2
        Console.WriteLine("\nExercitiul 2: Verificarea palindromului.");
        Console.Write("Introduceti un sir de caractere: ");
        string inputString2 = Console.ReadLine();

        bool isPalindrom = true;
        for (int i = 0; i < inputString2.Length / 2; i++)
        {
            if (inputString2[i] != inputString2[inputString2.Length - 1 - i])
            {
                isPalindrom = false;
                break;
            }
        }

        if (isPalindrom)
            Console.WriteLine("Sirul introdus este un palindrom.");
        else
            Console.WriteLine("Sirul introdus NU este un palindrom.");

        // Exercitiul 3
        Console.WriteLine("\nExercitiul 3: Numararea aparitiilor unui caracter intr-un sir.");
        Console.Write("Introduceti un sir de caractere: ");
        string inputString3 = Console.ReadLine();
        Console.Write("Introduceti caracterul cautat: ");
        char charToSearch = Console.ReadKey().KeyChar;

        int count = 0;
        foreach (char c in inputString3)
        {
            if (char.ToLower(c) == char.ToLower(charToSearch))
                count++;
        }
        Console.WriteLine($"\nCaracterul '{charToSearch}' apare de {count} ori in sir.");

        // Exercitiul 4
        Console.WriteLine("\nExercitiul 4: Caracterul cu cele mai multe aparitii.");
        Console.Write("Introduceti un sir de caractere: ");
        string inputString4 = Console.ReadLine();

        int[] charCounts = new int[26]; // Pentru literele de la 'a' la 'z'

        foreach (char c in inputString4.ToLower())
        {
            if (char.IsLetter(c))
                charCounts[c - 'a']++;
        }

        int maxCount = charCounts.Max();
        char mostFrequentChar = (char)(Array.IndexOf(charCounts, maxCount) + 'a');

        Console.WriteLine($"Caracterul '{mostFrequentChar}' apare de {maxCount} ori in sir.");

        // Exercitiul 5
        Console.WriteLine("\nExercitiul 5: Normalizarea sirului de caractere.");
        Console.Write("Introduceti un sir de caractere: ");
        string inputString5 = Console.ReadLine();

        string[] words = inputString5.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            if (!string.IsNullOrWhiteSpace(words[i]))
            {
                char firstLetter = char.ToUpper(words[i][0]);
                string restOfWord = words[i].Substring(1).ToLower();
                words[i] = firstLetter + restOfWord;
            }
        }

        string normalizedString = string.Join(" ", words);
        Console.WriteLine($"Rezultat: {normalizedString}");
    }
}
