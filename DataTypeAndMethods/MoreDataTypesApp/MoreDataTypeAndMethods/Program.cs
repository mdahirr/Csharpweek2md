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

var myString = " c# List fundamentals";

Console.WriteLine(StringBuilderExercise(myString));
