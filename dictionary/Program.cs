using System;
using System.Collections.Generic;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
    Create a dictionary with key value pairs to
    represent words (key) and its definition (value)
*/
            Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>();

            // Add several more words and their definitions
            wordsAndDefinitions.Add("Awesome", "The feeling of students when they are learning C#");
            wordsAndDefinitions.Add("Tired", "The feeling that I could sleep right now");
            wordsAndDefinitions.Add("Sick", "What happens in spring when I don't have time for it");
            wordsAndDefinitions.Add("Cat", "Vicious floof.");

            /*
                Use square bracket lookup to get the definition two
                words and output them to the console
            */

            Console.WriteLine(wordsAndDefinitions["Tired"]);
            Console.WriteLine(wordsAndDefinitions["Cat"]);

            /*
                Loop over dictionary to get the following output:
                    The definition of [WORD] is [DEFINITION]
                    The definition of [WORD] is [DEFINITION]
                    The definition of [WORD] is [DEFINITION]
            */
            foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
            {
                Console.WriteLine($"The definition of {word.Key} is {word.Value}");
            }
            Console.WriteLine("Hello World!");

            // Make a new list
            List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>>();

            /*
                You want to track the following about each word:
                    word, definition, part of speech, example sentence

                Example of one dictionary in the list:
                {
                    "word": "excited",
                    "definition": "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness",
                    "part of speech": "adjective",
                    "example sentence": "I am excited to learn C#!"
                }
            */

            // Create dictionary to represent a few word
            Dictionary<string, string> excitedWord = new Dictionary<string, string>();

            // Add each of the 4 bits of data about the word to the Dictionary
            excitedWord.Add("word", "excited");
            excitedWord.Add("definition", "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness");
            excitedWord.Add("part of speech", "adjective");
            excitedWord.Add("example sentence", "I am excited to learn C#!");

            // Add Dictionary to your `dictionaryOfWords` list
            dictionaryOfWords.Add(excitedWord);
            // create another Dictionary and add that to the list
            Dictionary<string, string> tiredWord = new Dictionary<string, string>();
            tiredWord.Add("word", "tired");
            tiredWord.Add("definition", "sleepiness from lack of sleep");
            tiredWord.Add("part of speech", "adjective");
            tiredWord.Add("example sentence", "I am so tired");

            dictionaryOfWords.Add(tiredWord);

            /*
                Iterate your list of dictionaries and output the data

                Example output for one word in the list of dictionaries:
                    word: excited
                    definition: having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness
                    part of speech: adjective
                    example sentence: I am excited to learn C#!
            */

            // Iterate the List of Dictionaries
            dictionaryOfWords.ForEach(word =>
            {
    // Iterate the KeyValuePairs of the Dictionary

    foreach (KeyValuePair<string, string> wordData in word)
                {

                    Console.WriteLine($"{wordData.Key}: {wordData.Value}");
                }
            });

            Dictionary<string, List<string>> idioms = new Dictionary<string, List<string>>();
            idioms.Add("Penny", new List<string> { "A", "penny", "for", "your", "thoughts" });
            idioms.Add("Injury", new List<string> { "Add", "insult", "to", "injury" });
            idioms.Add("Moon", new List<string> { "Once", "in", "a", "blue", "moon" });
            idioms.Add("Grape", new List<string> { "I", "heard", "it", "through", "the", "grapevine" });
            idioms.Add("Murder", new List<string> { "Kill", "two", "birds", "with", "one", "stone" });
            idioms.Add("Limbs", new List<string> { "It", "costs", "an", "arm", "and", "a", "leg" });
            idioms.Add("Grain", new List<string> { "Take", "what", "someone", "says", "with", "a", "grain", "of", "salt" });
            idioms.Add("Fences", new List<string> { "I'm", "on", "the", "fence", "about", "it" });
            idioms.Add("Sheep", new List<string> { "Pulled", "the", "wool", "over", "his", "eyes" });
            idioms.Add("Lucifer", new List<string> { "Speak", "of", "the", "devil" });

            foreach (KeyValuePair<string, List<string>> idiom in idioms)
            {
                string idiomPhrase = "";

                foreach (string singleWord in idiom.Value)
                {
                    idiomPhrase = idiomPhrase + " " + singleWord;
                }
                Console.WriteLine($"{idiom.Key}: {idiomPhrase}");
            }

            Dictionary<string, string> vehicle = new Dictionary<string, string>();
            vehicle.Add("year", "2008");
            vehicle.Add("model", "Damfresh");
            vehicle.Add("make", "Biotraxquote");
            vehicle.Add("color", "sky magenta");

            Dictionary<string, string> salesId = new Dictionary<string, string>();
            salesId.Add("sales ID", "ecb1c841-1a43-4a7c-896e-712d2ec39c71");

            Dictionary<string, string> salesAgent = new Dictionary<string, string>();
            salesAgent.Add("mobile", "(896) 478-6975");
            salesAgent.Add("last name", "Botsford");
            salesAgent.Add("first name", "Shaina");
            salesAgent.Add("emails", "beatae_sonny@hotmail.com and shaina@aol.com");

            Dictionary<string, string> purchaseDate = new Dictionary<string, string>();
            purchaseDate.Add("purchase date", "2017-11-15");

            Dictionary<string, double> grossProfit = new Dictionary<string, double>();
            grossProfit.Add("gross profit", 871.26);

            Dictionary<string, string> credit = new Dictionary<string, string>();
            credit.Add("credit providor", "J.P.Morgan Chase & Co");
            credit.Add("account", "601109582720302");
        }
    }
}