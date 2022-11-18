using System.Text;

static string StringExercise(string myString)
{
    string newString = myString.Trim().ToUpper().Replace('L', '*').Replace('T', '*').Remove(myString.IndexOf('n'));
    return newString;

}


//Console.WriteLine(StringExercise(myString));

static string StringBuilderExercise(string myString)
{
    var trimmedUpper = myString.Trim().ToUpper();

    StringBuilder sb = new StringBuilder(trimmedUpper);
    sb.Replace("L", "*").Replace("T", "*");



    var nPos = sb.ToString().IndexOf("N");



    return sb.Remove(nPos + 1, sb.Length - nPos - 1).ToString();
}


static void StringInterpolation(string name)
{
    Console.WriteLine("Hello, " + name + " - concatenation operator");
    Console.WriteLine(String.Concat("Hello, ", name, " - static String.Concat method"));
    Console.WriteLine($"Hello, {name} - string interpolation");

    var cashPrize = 10000.00;
    var numberOfWinners = 6000;
    var cashEach = $"You will receive {cashPrize / numberOfWinners:C}!";
}


static void ParsingStrings()
{
    Console.Write("How many apples? ");
    var input = Console.ReadLine() ?? "0";

    int numApples;
    bool success = Int32.TryParse(input, out numApples); // Parse or TryParse
}

static void OneDArrays()
{
    int[] myIntArray = { 12, 23, 34, 45, 56 };

    Array.Reverse<int>(myIntArray);

    foreach (var element in myIntArray)
    {
        Console.WriteLine(element);
    }
}


static void MultiDArrays()
{
    int[,] twoDArray = {
        { 1, 2, 3, 4, 5 }, 
        { 10, 20, 30, 40, 50 },
        { 20, 21, 22, 23, 24 }
    };

    Console.WriteLine("twoDArray row by row");
    for (int i = 0; i < twoDArray.GetLength(0); i++)
    {
        for (int j = 0; j < twoDArray.GetLength(1); j++)
        {
            Console.Write($"({i}, {j}) {twoDArray[i, j]}\t");
        }
        Console.WriteLine();
    }
}


static void JaggedArrays()
{
    int[][] jaggedArray = {
        new int[] { 1, 2, 3, 4, 5 },
        new int[] { 10, 20, 30, 40, 50 },
        new int[] { 20, 21, 22, 23, 24 }
    };

    foreach (var row in jaggedArray)
    {
        foreach (var item in row)
        {
            Console.Write($"{item} ");
        }

        Console.WriteLine();
    }
}

int[] arr = new int[5];



int[,] multiArr = new int[3, 5];



int[][] jaggedArr = new int[3][];
jaggedArr[0] = new int[5];
jaggedArr[1] = new int[4];
jaggedArr[2] = new int[5];



//JaggedArrays();


//MultiDArrays();


//OneDArrays();


//ParsingStrings();


//StringInterpolation("Phil");

//var myString = " c# List fundamentals";

//Console.WriteLine(StringBuilderExercise(myString));
