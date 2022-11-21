//// Reference types
//using System.Text;

//StringBuilder sb = new StringBuilder(); // mutable
//sb.Append("Hello");
//string st = "Hello";                    // immutable



//// Value types
//int number = 10;                        // mutable



//StringBuilder sbCopy = sb;
//sbCopy.Append(", World!");



//string stCopy = st;
//stCopy += ", World!";
//int numberCopy = number;
//numberCopy += 5;



//Console.WriteLine($"Original sb: {sb.ToString()}");
//Console.WriteLine($"Original st: {st}");
//Console.WriteLine($"Original number: {number}");

//AddMessageToSb(sb);
//Console.WriteLine($"Original sb after AddMessageToSb: {sb.ToString()}");



//static void AddMessageToSb(StringBuilder sb)
//{
//    sb.Append(" - and anyone else I may have forgotten.");
//}

static void swapNumbers(ref int x, ref int y)
{
    int swap = x;
    x = y;
    y = swap;
    Console.WriteLine($"y is now equal to {y}");
    Console.WriteLine($"x is not equal to {x}");
}

int x = 2;
int y = 5;
swapNumbers(ref x, ref y);