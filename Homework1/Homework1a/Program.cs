using System.ComponentModel;
using System.ComponentModel.Design;

string[] input = new[] { "dog", "cat", "redivider", "kayak", "tea", "reviver" };
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
        char[] toCharsReversed = new char[toChars.Length];
        for (int j = toChars.Length - 1; j >= 0; j--)
        {
            toCharsReversed[toChars.Length - j - 1] = toChars[j];
        }

        bool isEqual = true;
        for (int j = 0; j < toChars.Length; j++)
        {
            if (toChars[j] == toCharsReversed[j])
                isEqual = true;
            else
            {
                isEqual = false;
                break;
            }
        }
        if (isEqual)
        {
            result.Add(input[i]);
        }
    }
    return result.ToArray();
}







    

    

