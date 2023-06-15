namespace RandomSentenceGeneratorVer1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, this is your first random-generated sentence:");

            string[] names = { "Kristiyan", "Slavi", "Valyo", "Ivan", "Bobcho", "Djena", "Liam", "Noah", "Oliver", "Emma", "Charrolettë", "Sophia", "Isabella" };
            string[] cities = { "Sofia", "Plovdiv", "Varna", "Burgas", "London", "Berlin", "Munich", "Wiesbaden", "Madrid", "Barcelona" };
            string[] adverbs = { "slowly", "diligently", "warmly", "sadly", "rapidly", "impatiently", "seriously" };
            string[] verbs = { "eats", "holds", "sees", "plays with", "brings" };
            string[] nouns = { "stones", "a cake", "an apple", "a laptop" };
            string[] details = { "near the river", "at home", "at the park", "in school", "in his grandmother's house" };

            while (true)
            {
                string randomName = GetRandomWord(names);
                string randomCity = GetRandomWord(cities);
                string randomAdverb = GetRandomWord(adverbs);
                string randomVerb = GetRandomWord(verbs);
                string randomNoun = GetRandomWord(nouns);
                string randomDetail = GetRandomWord(details);

                string whoFromWhere = $"{randomName} from {randomCity}";
                string action = $"{randomAdverb} {randomVerb} {randomNoun}";
                string detail = $"{randomDetail}";

                PrintSentence(whoFromWhere, action, detail);

                GenerateNewOne();
            }
        }

        static string GetRandomWord(string[] arr)
        {
            Random randomWord = new Random();
            int randomIndex = randomWord.Next(arr.Length);
            string word = arr[randomIndex];

            return word;
        }

        static void GenerateNewOne()
        {
            Console.WriteLine("Click [Enter] to generate a new one.");
            Console.ReadLine();
        }

        static void PrintSentence(string whoFromWhere, string action, string detail)
        {
            string finalSentence = $"{whoFromWhere} {action} {detail}.";
            Console.WriteLine(finalSentence);
        }
    }
}