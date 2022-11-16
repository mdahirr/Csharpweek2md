//int mark = 35;
//var grade = mark >= 65 ? (mark >= 85 ? "Distinction" : "Pass") : "Fail";

string greeting = null;
if (greeting != null & greeting.ToLower().StartsWith('a'))
{
    Console.WriteLine($"{greeting} starts with 'a'");
}

public class GradeMark
    {
        public string GradeMethod(int mark)
        {
            var grade = mark >= 65 ? (mark >= 85 ? "Distinction" : "Pass") : "Fail";
            return grade;
        }
    }

public partial class Program
{
    public static string Grade(int mark)
    {
        var grade = mark >= 65 ? (mark >= 85 ? "Distinction" : "Pass") : "Fail";
        return grade;
    }
}

