public static string CollapseSpaces(string value)
{
    return System.Text.RegularExpressions.Regex.Replace(value, @"\s+", " ");
}
