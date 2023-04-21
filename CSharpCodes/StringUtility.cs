using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCodes
{
    public class StringUtility
    {
        private static readonly Random random = new Random();

        public static string SummarizeText(string longText, int maxWords = 20)
        {
            if (longText.Length > maxWords)
            {
                var words = longText.Split(' ');
                var result = new List<string>();
                var wordCount = 0;
                foreach (var word in words)
                {
                    if (wordCount <= maxWords)
                    {
                        result.Add(word);
                        wordCount += word.Length + 1;
                    }
                    else
                    {
                        break;
                    }
                }
                return String.Join(" ", result) + "...";
            }


            return (longText);

        }

        public static string RandomTextGeneration(int length) // Input text generation
        {
            Console.WriteLine("Random text generation: ");
            var random = new Random();
            var passLength = length;
            //var buffer = new char[passLength];
            var password = new StringBuilder(passLength);
            for (int i = 0; i < passLength; i++)
            {
                var rndNum = random.Next(65, 122);
                if (rndNum >= 91 && rndNum <= 96)
                {
                    i--;
                    continue;
                }
                password.Append((char)rndNum);
            }
            var final = password.ToString();
            return final;
        }

        public static string PasswordGenerator(int length)
        {
            //var random = new Random();
            const string A = "ASDFGHJKLQWERTYUIOPZXCVBNM";
            const string a = "asdfghjklqwertyuiopzxcvbnm";
            const string nums = "1234567890";
            const string specialChar = "£$&()*+[]@#^-_!?";

            var password = new StringBuilder(length);

            for (int i = 0; i < length; i++)
            {
                var which = random.Next(0, 4);
                int add;
                switch (which)
                {
                    case 0:
                        add = random.Next(0, A.Length - 1);
                        password.Append(A[add]);
                        break;
                    case 1:
                        add = random.Next(0, a.Length - 1);
                        password.Append(a[add]);
                        break;
                    case 2:
                        add = random.Next(0, 9);
                        password.Append(nums[add]);
                        break;
                    case 3:
                        add = random.Next(0, specialChar.Length - 1);
                        password.Append(specialChar[add]);
                        break;
                }
            }

            return password.ToString();
        }

        public static string TypingPracticeText(int length)
        {
            var characters = new char[] {'d', 'k', ' ' };
            var outPut = new StringBuilder(length);
            int j = 0 ;
            for (int i = 0; i < length; i++)
            {
                if (outPut.Length > 2){
                    if (outPut[i - 1] != ' ' && outPut[i - 2] != ' ' && outPut[i - 3] != ' ')
                    {
                        j = characters.Length - 1;
                    }
                    else
                    {
                        j = random.Next(0, characters.Length);
                    }
                }
                outPut.Append(characters[j]);
            }
            return outPut.ToString();
        }
    }
}
