
Console.Clear();
string[] array = { "hello", "2", "world", ";-)", "H" };
System.Console.WriteLine($"[{String.Join(" ; ", new_array(array))}]");



string[] new_array (string[] array)
{
    string[] res = { };
    foreach (var item in array)
    {
        if (item.Length > 0 && item.Length <= 3)
        {
            res = res.Append(item).ToArray();
        }
    }
    return res;
}