using System.Text;
namespace Strings;
public static class StringsAlgo
{
  public static bool IsPalindrome(string str) {
    // Write your code here.
    var left = 0;
    var right = str.Length - 1;

  while (left <= right)
  {
    if (str[left] != str[right]) return false;
    left++;
    right--;
  }
    return true;
  }

   public static string CaesarCypherEncryptor(string str, int key) {
    // Write your code here.
    var builder = new StringBuilder();
    foreach (var character in str)
    {
      var asciiValue = character + (key % 26); 
      var shiftedCharacter = (char)asciiValue;
      if (shiftedCharacter > 'z')
      {
        shiftedCharacter = (char)('a' - 1 + (shiftedCharacter % 'z'));
      }
      builder.Append(shiftedCharacter);
    }
    return builder.ToString();
  }

  public static string RunLengthEncoding(string str) {
    // Write your code here.
    var currChar = str[0];
    var count = 0;
    var builder = new StringBuilder();

    foreach (var character in str)
    {
       if (currChar != character || count == 9)
       {
          builder.Append(count);
          builder.Append(currChar);
          currChar = character;
          count = 0;
       }
       count++;
    }
    builder.Append(count);
    builder.Append(currChar);
    return builder.ToString();
  }

  public static string[] CommonCharacters(string[] strings) {
    // Write your code here.
    var has = new HashSet<string>();
    var dict = new Dictionary<char, int>();
    var list = new List<string>();
    for (int i = 0; i < strings.Length; i++)
    {
      var currStr = strings[i];
      var set = currStr.ToHashSet();
      foreach (var character in set)
      {
        if (dict.ContainsKey(character))
        {
          dict[character] += 1;
          if (dict[character] == strings.Length)
          {
            list.Add(character.ToString());
          }
        }
        else
        {
          dict.Add(character, 1);
        }
      }
    }
    return list.ToArray();
  }
}
