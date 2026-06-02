namespace Lesson07;

public static class StringExtenstion
{
    public static bool IsFirstLetterUpperCase(this string str)
    {
        if (str.Length == 0) return false;
        
        return char.IsUpper(str[0]);
    }
    
    public static string SpaceString(this string str)
    {
        string newStr = "";
        
        foreach (var c in str)
        {
            if (char.IsUpper(c))
                newStr += " ";
            
            newStr += c;
        }
        newStr = newStr.Trim();
        return newStr;
    }
}