namespace LengthLastWord;
public class Class1
{
    public int LengthOfLastWord(string s)
    {
        string[] strings = s.Split(" ");
        int index = strings.Length - 1;

        while (index > 0)
        {
            if (strings[index] != " " && strings[index] != "")
            {
                return strings[index].Length;
            }
            index--;
        }
        return strings[index].Length;
    }
}
