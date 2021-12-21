


    using System.Xml;

    string[] input = new[] {"dog", "cat", "redivider", "kayak", "tea", "reviver"};

    var palindrome = PalindromeFinder(input);
    foreach (var item in palindrome)
    {
        Console.WriteLine(item.ToString());
    }



static string[] PalindromeFinder(string[] input)
{
    List<string> result = new List<string>();
        for (int i = 0; i < input.Length; i++)
        {
            char[] toChars = input[i].ToCharArray();
            char[] toCharsReversed = input[i].ToCharArray();
            Array.Reverse(toCharsReversed);
            bool isEqual = Enumerable.SequenceEqual(toChars, toCharsReversed);
            if (isEqual)
            {
                result.Add(input[i]);
            }

            


        }

        return result.ToArray();
    }
    

    
