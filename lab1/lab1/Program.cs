
List<string> scanner = Scanner("29535123p48723487597645723645");

Coloring("29535123p48723487597645723645", scanner);

Console.WriteLine("Sum: " + Sum(scanner));


/*
 * Find the sequence of numbers which starts and ends with same digit.
 *
 * Return a List
 */
static List<string> Scanner(string input)
{
    string result = "";
    List<string> results = new List<string>();

    for (int i = 0; i < input.Length; i++)
    {
        if (char.IsDigit(input[i]))
        {
            result += input[i];
            for (int j = i + 1; j < input.Length; j++)
            {
                if (!char.IsDigit(input[j]))
                {
                    break;
                }
                else if (!(input[j] == input[i]))
                {
                    result += input[j];
                }
                else
                {
                    result += input[i];
                    results.Add(result);
                    break;
                }
            }
        }
        else
        {
            continue;
        }
        result = "";
    }
    return results;
}


/*
 * If the string contains the list the change the color of the list items.
 *
 * Return nothing.
 */
static void Coloring(string theString, List<string> input)
{
    for (int i = 0; i < input.Count; i++)
    {
        string[] temp = theString.Split(input[i]);
        if (temp[0] == "")
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(input[i]);
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write(temp[1]);

        }
        else if (temp[0] != "")
        {
            Console.Write(temp[0]);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(input[i]);
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write(temp[1]);
        }
        Console.WriteLine();
    }
}


/*
 * Adding the items in the list.
 *
 * Return sum as int.
 */
static long Sum(List<string> input)
{
    long result = 0;
    for (int i = 0; i < input.Count; i++)
    {
        long temp = long.Parse(input[i]);
        result += temp;
    }
    return result;
}