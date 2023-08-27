using System;

namespace StringParser
{
    class Parser
    {
        public static void Main()
        {
            Console.WriteLine("Write the text: \r\n");
            string line = Console.ReadLine();

            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu(line);
            }
            
        }

        private static bool MainMenu(string line)
        {
            Console.WriteLine("\r\n Choose an option:");
            Console.WriteLine("1) To find longest word");
            Console.WriteLine("2) Swap numbers to words");
            Console.WriteLine("3) To display at the begin sentences with '?', after with '!'");
            Console.WriteLine("4) To display sentences without ','");
            Console.WriteLine("5) To find words that start with the same character");
            Console.WriteLine("6) Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    FindLongestWord(line);
                    return true;
                case "2":
                    return true;
                case "3":
                    return true;
                case "4":
                    return true;
                case "5":
                    return true;
                case "6":
                    return false;
                default:
                    return true;
            }
        }

        static void FindLongestWord(string line)
        {
            string[] words = line.Split(" ");

            string longestWord = "";

            for (int i = 0; i < words.Length; i++)
            {
                if (i == 0)
                {
                    longestWord = words[i];
                }
                else
                {
                    longestWord = words[i].Length > words[i - 1].Length ? words[i] : words[i - 1];
                }

            }

            Console.WriteLine($"\r\n Longest word is: {longestWord}");
        }
    }
}