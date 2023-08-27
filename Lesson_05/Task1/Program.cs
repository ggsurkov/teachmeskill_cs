using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace StringParser
{

    class WordsTheSameFirstChar
    {
        public List<string> words { get; set; }
        public char letter { get; set; }
    }
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
            Console.WriteLine("2) Swap numbers to spanish words");
            Console.WriteLine("3) To display at the begin sentences with '?', after with '!'");
            Console.WriteLine("4) To display sentences without ','");
            Console.WriteLine("5) To find words that start with the same character");
            Console.WriteLine("6) Display words that begining and ending by the same char");
            Console.WriteLine("7) Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    FindLongestWord(line);
                    return true;
                case "2":
                    SwapNumbersToSpanishWords(line);
                    return true;
                case "3":
                    DisplayQuestionsFirst(line);
                    return true;
                case "4":
                    DisplaySentencesWithoutComma(line);
                    return true;
                case "5":
                    DisplayWordsWithSameCharacterStarted(line);
                    return true;
                case "6":
                    DisplayWordsWithSameCharacterOfStartedAndEnding(line);
                    return true;
                case "7":
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

        static void SwapNumbersToSpanishWords(string line)
        {
            line = line.Replace("0", "cero")
                .Replace("1", "uno")
                .Replace("2", "dos")
                .Replace("3", "tres")
                .Replace("4", "cuatro")
                .Replace("5", "cinco")
                .Replace("6", "seis")
                .Replace("7", "siete")
                .Replace("8", "ocho")
                .Replace("9", "nueve");
            Console.WriteLine($"\r\n Result: {line}");
        }

        static void DisplayQuestionsFirst(string line)
        {
            List<string> sentences = Regex.Split(line, @"(?<=[\.!\?])\s+").ToList();

            List<string> questionsSentences = new List<string> { };
            List<string> exclamatorySentences = new List<string> { }; ;
            List<string> othersSentences = new List<string> { }; ;

            foreach (string sentence in sentences)
            {
                if (sentence.Contains("?"))
                {
                    questionsSentences.Add(sentence);
                }
                else if (sentence.Contains("!"))
                {
                    exclamatorySentences.Add(sentence);
                }
                else
                {
                    othersSentences.Add(sentence);
                }
            }

            Console.WriteLine("Result: \r\n");

            foreach (var s in questionsSentences)
            {
                Console.WriteLine(s);
            }
            foreach (var s in exclamatorySentences)
            {
                Console.WriteLine(s);
            }
            foreach (var s in othersSentences)
            {
                Console.WriteLine(s);
            }

        }

        static void DisplaySentencesWithoutComma(string line)
        {
            string[] sentences = Regex.Split(line, @"(?<=[\.!\?])\s+");

            sentences = Array.FindAll(sentences, s => !s.Contains(","));

            Console.WriteLine("Result: \r\n");

            foreach (var sentence in sentences) { 
                Console.WriteLine(sentence);
            }
        }

        static void DisplayWordsWithSameCharacterStarted(string line)
        {
            string[] words = line.Split(" ");
            List<char> firstLetters = new List<char> { };
            List<WordsTheSameFirstChar> sameWords = new List<WordsTheSameFirstChar> { };

            foreach (var word in words) 
            {
                if (!firstLetters.Contains(Char.ToLower(word[0])))
                {
                    firstLetters.Add(Char.ToLower(word[0]));
                }
                
            }

            for (int i = 0; i < firstLetters.Count; i++)
            {
                for (int j = 0; j < words.Count(); j++)
                {
                    if (words[j].ToCharArray()[0] == firstLetters[i])
                    {
                        var currentSameWord = sameWords.Find(w => w.letter == firstLetters[i]) ?? null;
                        if (currentSameWord != null)
                        {
                            currentSameWord.words.Add(words[j]);
                        }
                        else
                        {
                            WordsTheSameFirstChar newSameWord = new WordsTheSameFirstChar() {letter = firstLetters[i], words = new List<string>{ words[j] } };
                            sameWords.Add(newSameWord);
                        }
                    }
                }
            }

            foreach (var sM in sameWords)
            {
                var wordsResult = String.Join(", ", sM.words.ToArray());
                
                Console.WriteLine($"\r\n['{sM.letter}']: {wordsResult}");
            }
        }

        static void DisplayWordsWithSameCharacterOfStartedAndEnding(string line)
        {
            string[] words = line.Split(" ");
            List<string> specificWords = new List<string>();

            foreach (var word in words)
            {
                if (word[0] == word[word.Length - 1])
                {
                    specificWords.Add(word);
                }
            }

            var resultedWords = String.Join(", ", specificWords.ToArray());
            Console.WriteLine($"\r\n Result: {resultedWords}");
 
        }
    }
}