//int mark = 35;
//var grade = mark >= 65 ? (mark >= 85 ? "Distinction" : "Pass") : "Fail";

namespace grades
{
    public class GradeMark
    {
        public string GradeMethod(int mark)
        {
            var grade = mark >= 65 ? (mark >= 85 ? "Distinction" : "Pass") : "Fail";
            return grade;
        }
    }
}