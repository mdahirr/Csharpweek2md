//int mark = 35;
//var grade = mark >= 65 ? (mark >= 85 ? "Distinction" : "Pass") : "Fail";

string greeting = null;
if (greeting != null & greeting.ToLower().StartsWith('a'))
{
    Console.WriteLine($"{greeting} starts with 'a'");
}

//public class GradeMark
//    {
//        public string GradeMethod(int mark)
//        {
//            var grade = mark >= 65 ? (mark >= 85 ? "Distinction" : "Pass") : "Fail";
//            return grade;
//        }
//    }

public partial class Program
{
    public static string Grade(int mark)
    {
        var grade = mark >= 65 ? (mark >= 85 ? "Distinction" : "Pass") : "Fail";
        return grade;
    }

    public static string Priority(int level)
    {
        string priority = "Code ";

        switch (level) 
        {
            case 3:
                priority = priority + "Red";
                break;
            case 2:
                priority = priority + "Amber";
                break;
            case 1:
                priority = priority + "Amber";
                break;
            case 0:
                priority = priority + "Green";
                break;
            default:
                priority = "Error";
                break;
        }   
    }

    public static string DrivingLaw(int age)
    {
        string law = "";
        switch (age)
        {
            case < 18:
                law = "Cannot legally drive";
                break;
            case < 23:
                law = "Can legally drive, but cannot hire a car";
                break;
            default:
                law = "Can legally drive and rent a car";
                break;
        }
        return law;
    }
}

