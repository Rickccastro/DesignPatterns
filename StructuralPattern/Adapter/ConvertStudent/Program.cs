using ConvertStudent.Adapter;

namespace ConvertStudent;

internal class Program
{
    static void Main(string[] args)
    {
        string[,] students =
            {
                { "1", "Alice", "Mathematics", "1200.50" },
                { "2", "Bob", "Physics", "1300.75" },
                { "3", "Charlie", "Computer Science", "1400.00" }
            };

        var studentadapter = new StudentAdapter();
        studentadapter.ProcessTuitionCalculator(students);
    }
}
