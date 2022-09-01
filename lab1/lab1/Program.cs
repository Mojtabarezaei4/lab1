
List<string> scanner = Scanner("29535123p48723487597645723645");
Console.WriteLine(Sum(scanner));
//29535123p48723487597645723645

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
                    //Console.WriteLine(result);
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

    //foreach (string s in results)
    //{
    //    Console.WriteLine(s);
    //}

    return results;
}

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